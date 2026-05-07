using ChangeCalulator.ChangeCalculator;

IChangeCalculator changeCalculator = new ChangeCalculator();

// get input
Console.WriteLine("Please enter the price of the item");
var price = Console.ReadLine();
double.TryParse(price, out double priceAsInt);


Console.WriteLine("Please enter the payment amount");
var paymentAmount = Console.ReadLine();
double.TryParse(paymentAmount, out double paymentAmountAsInt);


// send details to change calculator 
Console.WriteLine(""); // Create space in program terminal for readablility
Console.WriteLine("Calculating Change....");
var change = changeCalculator.CalculateChange(priceAsInt, paymentAmountAsInt);

// output results
foreach (var pieceOfChange in change)
{
    Console.WriteLine(pieceOfChange);
}