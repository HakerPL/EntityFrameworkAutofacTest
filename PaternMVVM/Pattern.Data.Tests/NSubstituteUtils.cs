using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace Pattern.Data.Tests
{
    public static class NSubstituteUtils
    {
        public static DbSet<T> CreateMockDbSet<T>(this IEnumerable<T> data)
            where T : class
        {
            var queryable = data.AsQueryable();
            var mockSet = Substitute.For<DbSet<T>, IQueryable<T>>();

            // Query the set
            ((IQueryable<T>)mockSet).Provider.Returns(queryable.Provider);
            ((IQueryable<T>)mockSet).Expression.Returns(queryable.Expression);
            ((IQueryable<T>)mockSet).ElementType.Returns(queryable.ElementType);
            ((IQueryable<T>)mockSet).GetEnumerator().Returns(queryable.GetEnumerator());

            return mockSet;
        }
    }
}
