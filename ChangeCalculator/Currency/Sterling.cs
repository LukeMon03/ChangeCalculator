namespace ChangeCalulator.Currency
{
    public class Sterling
    {
        public static Dictionary<double, string> changeInCirculation = new()
        {
            { 0.01, "1p Coin" },
            { 0.02, "2p Coin" },
            { 0.05, "5p Coin" },
            { 0.1,  "10p Coin" },
            { 0.2,  "20p Coin" },
            { 0.5,  "50p Coin" },
            { 1,    "1 Pound Coin" },
            { 2,    "2 Pound Coin" },
            { 5,    "5 Pound Note" },
            { 10,   "10 Pound Note" },
            { 20,   "20 Pound Note" },
            { 50,   "50 Pound Note" },
        };
    }
}
