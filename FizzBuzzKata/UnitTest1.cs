namespace FizzBuzzKata
{
    public class UnitTest1
    {
        [Fact]
        public void NotFizzBuzz()
        {
            var number = new FizzBuzz().Check(1);
            Assert.Equal("1", number);
        }

        [Fact]
        public void DivisibleBy3Fizz() {
            var number = new FizzBuzz().Check(3);
            Assert.Equal("Fizz", number);
        }
    }




    
}

