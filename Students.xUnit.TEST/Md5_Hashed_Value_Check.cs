using Students.COMMON;
using Xunit;

namespace Students.xUnit.TEST
{
    public class Md5_Hashed_Value_Check
    {
        private Md5Builder md5Builder = new Md5Builder();
        [Fact]
        public void HashResult()
        {
            var expected = "e10adc3949ba59abbe56e057f20f883e";
            var actual =md5Builder.GetHashedValue("123456");
            Assert.Equal(expected, actual);
        }
    }
}
