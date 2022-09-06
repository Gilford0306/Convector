
namespace Convector
{
    internal class Distance
    {
        public double give { get; set; }

        public Distance()
        {
            give = 0;
        }

        public Distance(double _give)
        {
            give = _give;
        }

        public void exchangeD()
        {
            Console.WriteLine("meters to feets - press 1");
            Console.WriteLine("meters to inches - press 2");
            Console.WriteLine("feets to meters - press 3");
            Console.WriteLine("inches to meters - press 4");
            Console.WriteLine("inches to feets - press 5");
            Console.WriteLine("feets to inches- press 6");
            string cur = Console.ReadLine();
            switch (cur)
            {
                case "1":
                    MtF();
                    break;
                case "2":
                    MtI();
                    break;
                case "3":
                    FtM();
                    break;
                case "4":
                    ItM();
                    break;
                case "5":
                    ItF();
                    break;
                case "6":
                    FtI();
                    break;
                default:
                    Console.WriteLine("Only 1-6 number");
                    break;
            }
        }
        public void MtF()
        {
            Console.WriteLine(give + " meters is " + Math.Round(give * 3.28084, 4, MidpointRounding.AwayFromZero) + " feets");
        }
        public void MtI()
        {
            Console.WriteLine(give + " meters is " + Math.Round(give * 39.37008, 4, MidpointRounding.AwayFromZero) + " give + \" feets ");
        }
        public void FtM()
        {
            Console.WriteLine(give + " feets is " + Math.Round(give * 0.3048000097536, 4, MidpointRounding.AwayFromZero) + " meters");
        }
        public void ItM()
        {
            Console.WriteLine(give + " inches is " + Math.Round(give * 0.025400000812799999883, 4, MidpointRounding.AwayFromZero) + " meters");
        }
        public void ItF()
        {
            Console.WriteLine(give + " inches is " + Math.Round(give * 0.08333333599999999397, 4, MidpointRounding.AwayFromZero) + " feets");
        }
        public void FtI()
        {
            Console.WriteLine(give + " feets  is " + Math.Round(give * 12.000000383999999798, 4, MidpointRounding.AwayFromZero) + " inches");
        }

    }
}
