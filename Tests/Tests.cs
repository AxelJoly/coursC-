using System;
using Xunit;
using Library;
namespace Tests
{
    public class Tests
    {
        [Fact]
        public void World()
        {
            var result = Hello.World;
            var expected = "Hello World";
            Assert.True(expected == result);
            
        }
    }
}