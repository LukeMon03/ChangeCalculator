namespace ChangeCalulatorApp.ChangeCalculator
{
    public interface IChangeCalculator
    {
        public List<string> CalculateChange(double price, double paymentAmount);
    }
}
