using System;
using System.Linq.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;

namespace HotChocolate.Data.Filters.Expressions
{
    public class QueryableListAllOperationHandler : QueryableListOperationHandlerBase
    {
        protected override int Operation => Operations.All;

        protected override Expression HandleListOperation(
            QueryableFilterContext context,
            IFilterInputType declaringType,
            IFilterField field,
            IType fieldType,
            ObjectFieldNode node,
            Type closureType,
            LambdaExpression lambda) =>
            FilterExpressionBuilder.All(closureType, context.GetInstance(), lambda);
    }
}