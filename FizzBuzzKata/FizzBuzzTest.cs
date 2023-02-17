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
        [Fact]
        public void FizzBuzzArray()
        {
            var numbers = Enumerable.Range(1,20).ToArray();
            var answers = new FizzBuzz().Check(numbers);
            Assert.Equal(new String[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz","16","17","Fizz","19","Buzz" },answers);
            
        }
    } 
}

