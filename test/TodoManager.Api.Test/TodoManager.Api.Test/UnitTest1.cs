using System.Diagnostics;
using Xunit;

namespace TodoManager.Api.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Debug.WriteLine("Just an empty test so I can add a test step to the CI");
            Assert.True(true);
        }
    }
}
