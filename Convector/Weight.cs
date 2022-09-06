namespace Convector
{
    internal class Weight
    {
        public double give { get; set; }

        public Weight()
        {
            give = 0;
        }

        public Weight(double _give)
        {
            give = _give;
        }

        public void exchangeW()
        {
            Console.WriteLine("Gram to Ounces - press 1");
            Console.WriteLine("Gram to Pounds - press 2");
            Console.WriteLine("Ounces to Gram - press 3");
            Console.WriteLine("Pounds to Gram - press 4");
            Console.WriteLine("Pounds to Ounces - press 5");
            Console.WriteLine("Ounces to Pounds - press 6");

            string cur = Console.ReadLine();
            switch (cur)
            {
                case "1":
                    GtO();
                    break;
                case "2":
                    GtP();
                    break;
                case "3":
                    OtG();
                    break;
                case "4":
                    PtG();
                    break;
                case "5":
                    PtO();
                    break;
                case "6":
                    OtP();
                    break;
                default:
                    Console.WriteLine("Only 1-6 number");
                    break;
            }
        }
        public void GtO()
        {
            Console.WriteLine( give +" gram is " + Math.Round(give * 0.035274, 4, MidpointRounding.AwayFromZero) + " ounces");
        }
        public void GtP()
        {
            Console.WriteLine(give + " gramis " + Math.Round(give * 0.00220462, 4, MidpointRounding.AwayFromZero) + " pounds");
        }
        public void OtG()
        {
            Console.WriteLine(give + " ounces is " + Math.Round(give * 28.3495, 2, MidpointRounding.AwayFromZero) + " gramm");
        }
        public void PtG()
        {
            Console.WriteLine(give + " pounds is " +  Math.Round(give * 453.592, 2, MidpointRounding.AwayFromZero) + " gramm");
        }
        public void PtO()
        {
            Console.WriteLine(give +  " pounds is " + give * 16 + " ounces");
        }
        public void OtP()
        {
            Console.WriteLine(give + "ounces is  is " + (give * 0.0625, 4, MidpointRounding.AwayFromZero) + " pounds");
        }
    }
}
