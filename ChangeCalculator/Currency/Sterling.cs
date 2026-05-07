namespace ChangeCalulatorApp.Currency
{
    public class Sterling
    {
        public static Dictionary<double, string> changeInCirculation = new()
        {
            // Valued in Pence to avoid issues with dividing doubles
            { 1, "1p Coin" },
            { 2, "2p Coin" },
            { 5, "5p Coin" },
            { 10,  "10p Coin" },
            { 20,  "20p Coin" },
            { 50,  "50p Coin" },
            { 100,    "1 Pound Coin" },
            { 200,    "2 Pound Coin" },
            { 500,    "5 Pound Note" },
            { 1000,   "10 Pound Note" },
            { 2000,   "20 Pound Note" },
            { 5000,   "50 Pound Note" },
        };
    }
}
