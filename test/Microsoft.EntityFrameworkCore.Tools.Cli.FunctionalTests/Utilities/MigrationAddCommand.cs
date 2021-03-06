﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit.Abstractions;

namespace Microsoft.EntityFrameworkCore.Tools.Cli.FunctionalTests
{
    public class MigrationAddCommand : EfCommand
    {
        private readonly string _migrationName;

        public MigrationAddCommand(string projectPath, string migrationName, ITestOutputHelper output)
            : base(projectPath, output)
        {
            _migrationName = migrationName;
        }

        protected override string BuildArgs()
            => $"migrations add {_migrationName}";
    }
}