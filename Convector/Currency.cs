namespace Convector
{
    internal class Currency
    {
          public double give { get; set; }

        public Currency()
        {
            give = 0;
        }

        public Currency(double _give)
        {
            give = _give;
        }

        public void exchangeC()
        {
            Console.WriteLine("Uah to Usd - press 1");
            Console.WriteLine("Uah to Eur - press 2");
            Console.WriteLine("Usd to Uah - press 3");
            Console.WriteLine("Eur to Uah- press 4");
            string cur = Console.ReadLine();
            switch (cur)
            {
                case "1":
                    UAHtoUSD();
                    break;
                case "2":
                    UAHtoEUR();
                    break;
                case "3":
                    USDtoUAH();
                    break;
                case "4":
                    EURtoUAH();
                    break;
                default:
                    Console.WriteLine("Only 1-4 number");
                    break;
            }
        }
        public void UAHtoUSD()
        {
            Console.WriteLine(give + " uah is "+ Math.Round(give / 40.0864, 2, MidpointRounding.AwayFromZero) + " $");
        }
        public void UAHtoEUR()
        {
            Console.WriteLine(give + " uah  is " + Math.Round(give / 39.9745, 2, MidpointRounding.AwayFromZero)  + " Eur");
        }
        public void USDtoUAH()
        {
            Console.WriteLine(give + " $ is " + Math.Round(give * 39.1657, 2, MidpointRounding.AwayFromZero) + " Uah");
        }
        public void EURtoUAH()
        {
            Console.WriteLine(give + " eur is " +  Math.Round(give * 38.7200, 2, MidpointRounding.AwayFromZero) + " Uah");
        }

    }
}
