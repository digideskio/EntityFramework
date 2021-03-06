// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal
{
    public class NotMappedEntityTypeAttributeConvention : EntityTypeAttributeConvention<NotMappedAttribute>
    {
        public override InternalEntityTypeBuilder Apply(InternalEntityTypeBuilder entityTypeBuilder, NotMappedAttribute attribute)
        {
            Check.NotNull(entityTypeBuilder, nameof(entityTypeBuilder));
            Check.NotNull(attribute, nameof(attribute));

            return entityTypeBuilder.ModelBuilder.Ignore(entityTypeBuilder.Metadata.Name, ConfigurationSource.DataAnnotation)
                ? null
                : entityTypeBuilder;
        }
    }
}
