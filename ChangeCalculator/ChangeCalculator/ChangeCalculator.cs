namespace ChangeCalulator.ChangeCalculator
{
    public class ChangeCalculator: IChangeCalculator
    {
        public List<string> CalculateChange(double price, double paymentAmount)
        {
            var changeList = new List<string>();

            var currencyForExchange = Currency.Sterling.changeInCirculation;

            var sortedCurrency = currencyForExchange
                .OrderByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            double returnChangeAmount = paymentAmount - price;

            foreach (var currency in sortedCurrency) 
            { 
                // Key being the denominations value
                var count = returnChangeAmount / currency.Key;

                count = Math.Floor(count);

                if (count > 0) 
                {
                    // Additional if block to account for multiple of the same denomination
                    if(count > 1)
                    {
                        changeList.Add($"{count} {currency.Value}s");
                    }
                    else
                    {
                        changeList.Add($"{count} {currency.Value}");

                    }

                    returnChangeAmount = returnChangeAmount - (count * currency.Key);

                    if (returnChangeAmount == 0)
                        break;
                }
            }

            return changeList;
        }
    }
}
