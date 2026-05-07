using Xunit;
using ChangeCalulatorApp.ChangeCalculator;

namespace ChangeCalculatorApp.Tests
{
    public class ChangeCalulatorTests
    {
        private readonly ChangeCalculator _calculator = new ChangeCalculator();

        [Fact]
        public void ChangeCalulator_ReturnsCorrectAmountOfChangeWhenGivenValidInput()
        {
            // Arrange
            var currencyForExchange = ChangeCalulatorApp.Currency.Sterling.changeInCirculation;

            var expectedResponse1 = $"2 {currencyForExchange[5000]}s";
            var expectedResponse2 = $"1 {currencyForExchange[500]}";
            var expectedResponse3 = $"1 {currencyForExchange[200]}";
            var expectedResponse4 = $"1 {currencyForExchange[20]}";
            var expectedResponse5 = $"1 {currencyForExchange[2]}";

            // Act
            var result = _calculator.CalculateChange(242.78, 350);

            // Assert
            Assert.Contains(expectedResponse1, result);
            Assert.Contains(expectedResponse2, result);
            Assert.Contains(expectedResponse3, result);
            Assert.Contains(expectedResponse4, result);
            Assert.Contains(expectedResponse5, result);
        }

        [Fact]
        public void ChangeCalulator_ReturnsNoChangeWhenPaymentAmountIsExact()
        {
            // Act
            var result = _calculator.CalculateChange(250, 250);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ChangeCalulator_ReturnsInsufficentFundsWhenPaymentAmountIsLessThanPrice()
        {
            // Assert
            var insuficentFundsMessage = "Insufficent funds have been entered";

            // Act
            var result = _calculator.CalculateChange(250, 100);

            // Assert
            Assert.Contains(insuficentFundsMessage, result);
        }
    }
}
