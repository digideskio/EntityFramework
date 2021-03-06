// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Microsoft.EntityFrameworkCore.ValueGeneration.Internal
{
    public class TemporaryDateTimeValueGenerator : ValueGenerator<DateTime>
    {
        private long _current;

        public override DateTime Next(EntityEntry entry) => new DateTime(Interlocked.Increment(ref _current));

        public override bool GeneratesTemporaryValues => true;
    }
}
