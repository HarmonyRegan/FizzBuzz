namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        [Fact]
        public void NotFizzBuzz()
        {
            var number = new FizzBuzz().Check(1);
            Assert.Equal("1", number);
        }

        [Fact]
        public void DivisibleBy3Fizz()
        {
            var number = new FizzBuzz().Check(3);
            Assert.Equal("Fizz", number);
        }

        [Fact]
        public void DivisibleBy5Buzz()
        {
            var number = new FizzBuzz().Check(5);
            Assert.Equal("Buzz", number);
        }

        [Theory]
        [InlineData(1,"1")]
        [InlineData(5, "Buzz")]
        [InlineData(3, "Fizz")]
        public void FizzBuzzTests(int input, string expected)
        {
            var number = new FizzBuzz().Check(input);
            Assert.Equal(expected, number);
        }
    } 
}

