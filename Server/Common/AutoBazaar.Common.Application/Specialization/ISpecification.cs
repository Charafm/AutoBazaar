using System.Linq.Expressions;

namespace AutoBazaar.Common.Application.Specialization
{
    public interface ISpecification<T>
    {
        List<Expression<Func<T, bool>>> Criterias { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        Expression<Func<T, object>> ThenBy { get; }
        Expression<Func<T, object>> ThenByDescending { get; }
        Expression<Func<T, object>> GroupBy { get; }
    }
}