// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    public class SqliteStringLengthTranslator : IMemberTranslator
    {
        public virtual Expression Translate(MemberExpression memberExpression)
            => memberExpression.Expression != null
               && memberExpression.Expression.Type == typeof(string)
               && memberExpression.Member.Name == "Length"
                ? new SqlFunctionExpression("length", memberExpression.Type, new[] { memberExpression.Expression })
                : null;
    }
}
