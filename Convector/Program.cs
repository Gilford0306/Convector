using Convector;

Console.WriteLine("Convector");
do
{
    Console.WriteLine("Currency converter - press 1");
    Console.WriteLine("Distance convector - press 2");
    Console.WriteLine("Weight converter - press 3");
    string key = Console.ReadLine();
    switch (key)
    {

        case "1": 
            Console.WriteLine("Input your money");
            double give = double.Parse(Console.ReadLine());
            Currency currency = new Currency(give);
            currency.exchangeC();
            Console.WriteLine(new string('-', 25));
            break;
        case "2":
            Console.WriteLine("Input distance");
            give = double.Parse(Console.ReadLine());
            Distance distance = new Distance(give);
            distance.exchangeD();
            Console.WriteLine(new string('-', 25));
            break;
        case "3":
            Console.WriteLine("Input weight");
            give = double.Parse(Console.ReadLine());
            Weight weight = new Weight(give);
            weight.exchangeW();
            Console.WriteLine(new string('-', 25));
            break;
        default:
            break;
    }
} while (true);
