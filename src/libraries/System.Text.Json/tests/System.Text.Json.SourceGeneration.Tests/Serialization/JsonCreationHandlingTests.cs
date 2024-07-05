﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Tests;
using static System.Text.Json.Serialization.Tests.JsonCreationHandlingTests;

namespace System.Text.Json.SourceGeneration.Tests
{
    public sealed class JsonCreationHandlingTests_String()
        : JsonCreationHandlingTests(new StringSerializerWrapper(CreationHandlingTestContext.Default))
    {
    }

    public sealed class JsonCreationHandlingTests_AsyncStreamWithSmallBuffer()
        : JsonCreationHandlingTests(new AsyncStreamSerializerWrapper(CreationHandlingTestContext.Default))
    {
    }

    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyListOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_ListOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIListOfInt_BackedBy_StructListOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_ListOfJsonElement))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_ListOfJsonElementWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_ListOfJsonElementWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_StructListOfJsonElement))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_StructListOfJsonElementWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIList_BackedBy_StructListOfJsonElementWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfInt))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfIntWithNumberHandling))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructListOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructListOfInt))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueue))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyQueueWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentQueueOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStack))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyStackWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentStackOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_ListOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyICollectionOfInt_BackedBy_StructCollectionOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructCollectionOfInt))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructCollectionOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructCollectionOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritableFieldStructCollectionOfIntWithNumberHandling))]
    [JsonSerializable(typeof(StructWithWritableFieldStructCollectionOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritableFieldStructCollectionOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructCollectionOfInt))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructCollectionOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructCollectionOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_HashSetOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyISetOfInt_BackedBy_StructSetOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfInt))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfIntWithNumberHandling))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructSetOfIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructSetOfInt))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructSetOfIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructSetOfIntWithoutPopulateAttribute))]

    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyDictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_DictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionaryOfStringToInt_BackedBy_StructDictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_DictionaryOfStringToJsonElement))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_DictionaryOfStringToJsonElementWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_DictionaryOfStringToJsonElementWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_StructDictionaryOfStringToJsonElement))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_StructDictionaryOfStringToJsonElementWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyIDictionary_BackedBy_StructDictionaryOfStringToJsonElementWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToInt))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritablePropertyStructDictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructDictionaryOfStringToInt))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(StructWithWritableFieldNullableStructDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertyConcurrentDictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToInt))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToIntWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToIntWithoutPopulateAttribute))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToIntWithNumberHandling))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToIntWithNumberHandlingWithAttributeOnType))]
    [JsonSerializable(typeof(ClassWithReadOnlyPropertySortedDictionaryOfStringToIntWithNumberHandlingWithoutPopulateAttribute))]

    [JsonSerializable(typeof(ClassWithReadOnlyProperty_SimpleClass))]
    [JsonSerializable(typeof(ClassWithWritableProperty_SimpleClass))]
    [JsonSerializable(typeof(StructWithReadOnlyProperty_SimpleStruct))]
    [JsonSerializable(typeof(StructWithWritableProperty_SimpleStruct))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty_SimpleClassWithSmallParametrizedCtor))]
    [JsonSerializable(typeof(ClassWithWritableProperty_SimpleClassWithSmallParametrizedCtor))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty_SimpleClassWithLargeParametrizedCtor))]
    [JsonSerializable(typeof(ClassWithWritableProperty_SimpleClassWithLargeParametrizedCtor))]
    [JsonSerializable(typeof(ClassWithProperty_BaseClassWithPolymorphism))]
    [JsonSerializable(typeof(ClassWithProperty_BaseClassWithPolymorphismOnSerializationOnly))]
    [JsonSerializable(typeof(BaseClassRecursive))]
    [JsonSerializable(typeof(ClassWithClassProperty))]

    // TODO: Consider support for following syntax [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<int>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<int?>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<int[]>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<List<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<IEnumerable<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<IEnumerable>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<ImmutableArray<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<ImmutableHashSet<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<ImmutableList<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<ImmutableQueue<int>>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<ImmutableStack<int>>))]

    // TODO: Consider support for following syntax [JsonSerializable(typeof(ClassWithWritableProperty<>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<int>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<int?>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<int[]>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IEnumerable<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IEnumerable>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ImmutableArray<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ImmutableHashSet<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ImmutableList<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ImmutableQueue<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ImmutableStack<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<List<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IList<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IList>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Queue<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Queue>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ConcurrentQueue<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Stack<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Stack>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ConcurrentStack<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ICollection<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ISet<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Dictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<IDictionary>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<ConcurrentDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<SortedDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<StructList<int>?>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<StructCollection<int>?>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<StructSet<int>?>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<StructDictionary<string, int>?>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Stack<int>>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<Stack>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<SimpleClassWithSmallParametrizedCtor>))]
    [JsonSerializable(typeof(ClassWithWritableProperty<SimpleClassWithLargeParametrizedCtor>))]

    [JsonSerializable(typeof(ClassWithReadOnlyProperty<List<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<IList<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<IList>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<Queue<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<Queue>), TypeInfoPropertyName = "NonGenericClassWithReadOnlyPropertyOfQueue")]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<ConcurrentQueue<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<Stack<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<Stack>), TypeInfoPropertyName = "NonGenericClassWithReadOnlyPropertyOfStack")]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<ConcurrentStack<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<ICollection<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<ISet<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<Dictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<IDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<IDictionary>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<ConcurrentDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<SortedDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructList<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructList<int>?>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructCollection<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructCollection<int>?>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructSet<int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructSet<int>?>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructDictionary<string, int>>))]
    [JsonSerializable(typeof(ClassWithReadOnlyProperty<StructDictionary<string, int>?>))]

    [JsonSerializable(typeof(ClassWithReadOnlyInitializedField<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithInitializedField<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithReadOnlyInitializedProperty<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithInitializedProperty<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithWritablePropertyWithoutPopulate<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithDefaultPopulateAndProperty<SimpleClass>))]
    [JsonSerializable(typeof(ClassWithInitializedProperty<ClassWithRequiredProperty>))]
    [JsonSerializable(typeof(ClassWithRecursiveRequiredProperty))]
    [JsonSerializable(typeof(ClassImplementingInterfaceWithPopulateOnTypeWithInterfaceProperty))]
    [JsonSerializable(typeof(ClassImplementingInterfaceWithInterfaceProperty))]
    [JsonSerializable(typeof(IInterfaceWithInterfacePropertyWithPopulateOnType))]
    [JsonSerializable(typeof(IInterfaceWithInterfaceProperty))]
    [JsonSerializable(typeof(ClassWithReplaceOnTypeAndWritableProperty_SimpleClass))]
    [JsonSerializable(typeof(SimpleClassWitNonPopulatableProperty))]
    [JsonSerializable(typeof(ClassWithInvalidTypeAnnotation))]
    [JsonSerializable(typeof(ClassWithInvalidPropertyAnnotation))]
    [JsonSerializable(typeof(ClassWithParameterizedConstructorWithPopulateProperty))]
    [JsonSerializable(typeof(ClassWithParameterizedConstructorWithPopulateType))]
    [JsonSerializable(typeof(ClassWithParameterizedConstructorNoPopulate))]
    internal partial class CreationHandlingTestContext : JsonSerializerContext
    {
    }
}
