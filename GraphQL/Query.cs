using System.Linq;
using GraphQLDemo.Data;
using GraphQLDemo.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQLDemo.GraphQL
{
  [GraphQLDescription("Represents the queries available.")]
  public class Query
  {
    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    [GraphQLDescription("Gets the queryable platform.")]
    public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
    {
      return context.Platforms;
    }

    [UseDbContext(typeof(AppDbContext))]
    [UseFiltering]
    [UseSorting]
    [GraphQLDescription("Gets the queryable command.")]
    public IQueryable<Command> GetCommand([ScopedService] AppDbContext context)
    {
        return context.Commands;
    }
  }
}