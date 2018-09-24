using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace net_472
{
    public class Tests
    {
        [Fact]
        public void Test()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using(var ctx = new Context(options))
                ctx.Database.EnsureCreated();
        }
    }
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
