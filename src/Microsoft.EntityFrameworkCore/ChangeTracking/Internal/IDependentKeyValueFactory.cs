// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microsoft.EntityFrameworkCore.ChangeTracking.Internal
{
    public interface IDependentKeyValueFactory<TKey>
    {
        [ContractAnnotation("=>true, key:notnull; =>false, key:null")]
        bool TryCreateFromBuffer(ValueBuffer valueBuffer, [CanBeNull] out TKey key);

        [ContractAnnotation("=>true, key:notnull; =>false, key:null")]
        bool TryCreateFromCurrentValues([NotNull] InternalEntityEntry entry, [CanBeNull] out TKey key);

        [ContractAnnotation("=>true, key:notnull; =>false, key:null")]
        bool TryCreateFromOriginalValues([NotNull] InternalEntityEntry entry, [CanBeNull] out TKey key);

        [ContractAnnotation("=>true, key:notnull; =>false, key:null")]
        bool TryCreateFromRelationshipSnapshot([NotNull] InternalEntityEntry entry, [CanBeNull] out TKey key);
    }
}
