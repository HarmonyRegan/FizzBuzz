namespace FizzBuzzKata
{
    public class UnitTest1
    {
        [Fact]
        public void Divisibleby3returnFizz()
        {
            var number =  FizzBuzz(1);
            Assert.Equal("1", number);

        }
        private string FizzBuzz(int number)
        {
            return number.ToString();
        }
        
    }
}