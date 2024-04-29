using Xunit;

namespace autoTesting.Tests
{
    public class Test_Utility
    {
        [Fact]
        public void Test_Add(){
            Utility util = new Utility();
            int expected = 4;
            int actual = util.Add(1,3);
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        [InlineData(13)]
        public void Test_IsOdd(int x){
            Utility util = new Utility();
            Assert.True(util.IsOdd(x));
        }
    }
}