// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Microsoft.WebAssembly.Build.Tasks;

/// <summary>estimate the total memory needed for the assemblies and AOT data segments.</summary>
public class WasmCalculateInitialHeapSize : Task
{
    [Required]
    public string[] Assemblies { get; set; } = Array.Empty<string>();

    public string[] AOTDataSegmentSizes { get; set; } = Array.Empty<string>();

    [Output]
    public long InitialHeapSize { get; private set; }

    public override bool Execute()
    {
        long totalDllSize = 0;
        long totalDataSize = 0;

        foreach (string asm in Assemblies)
        {
            var info = new FileInfo(asm);
            if (!info.Exists)
            {
                Log.LogError($"Could not find assembly '{asm}'");
                return false;
            }
            totalDllSize += info.Length;
        }

        // during non-AOT builds, AOTDataSegmentSizes is empty
        foreach (string segment in AOTDataSegmentSizes)
        {
            if (!long.TryParse(segment, out long segmentSize))
            {
                Log.LogError($"Could not parse AOT Data segment size '{segment}");
                return false;
            }
            totalDataSize += segmentSize;
        }

        // this is arbitrary guess about memory overhead of the runtime, after the assemblies are loaded
        const double extraMemoryRatio = 1.2;
        // plus size of data segments generated by AOT
        long memorySize = totalDataSize + (long)(totalDllSize * extraMemoryRatio);

        // round it up to 64KB page size for wasm
        InitialHeapSize = (memorySize + 0x10000) & 0xFFFF0000;

        return true;
    }
}
