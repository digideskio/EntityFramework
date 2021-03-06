// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.ValueGeneration.Internal
{
    public abstract class TemporaryNumberValueGenerator<TValue> : ValueGenerator<TValue>
    {
        public override bool GeneratesTemporaryValues => true;
    }
}
