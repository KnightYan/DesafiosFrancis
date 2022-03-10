using Xunit;

namespace TestesFrancis.Exercicio2.Tests
{
    public class HappyNumberDetectorTests
    {
        private readonly HappyNumberDetector detector;
        //ARRANGE
        public HappyNumberDetectorTests()
        {
            detector = new HappyNumberDetector();
        }

        //ACT + ASSERT
        [Fact]
        public void IsTheNumberHappy_Happy_Number_True()
        {
            var result = detector.IsTheNumberHappy(7);

            Assert.True(result);
        }

        //ACT + ASSERT
        [Fact]
        public void IsTheNumberHappy_Happy_Number_False()
        {
            var result = detector.IsTheNumberHappy(2);

            Assert.False(result);
        }

        /*[Fact]
        public void IsTheNumberHappy_Happy_Number_True()
        {
            //ARRANGE
            var happyNumberDetector = new HappyNumberDetector();

            //ACT
            var result = happyNumberDetector.IsTheNumberHappy(7);

            //ASSERT
            Assert.True(result);
        }*/
    }
}
