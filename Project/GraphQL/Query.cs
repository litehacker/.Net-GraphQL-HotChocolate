using System.Linq;
using Project.Data;
using Project.Models;
using HotChocolate;
using HotChocolate.Data;

namespace Project.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}