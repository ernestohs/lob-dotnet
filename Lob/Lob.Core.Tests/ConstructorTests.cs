using System;
using Xunit;

namespace Lob.Core.Tests
{
    public class Tests
    {
        [Fact]
        public void CreateInstance()
        {
            var test_key = "test_67b6072a56edf42fa03ed3c7f396f4e1ded";
            var target = new Client(test_key);
            Assert.Equal(target.ApiKey, test_key);
        }
    }
}