namespace FizzBuzzKata
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1,"1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzTests(int input, string expected)
        {
            var number = new FizzBuzz().Check(input);
            Assert.Equal(expected, number);
        }
    } 
}

