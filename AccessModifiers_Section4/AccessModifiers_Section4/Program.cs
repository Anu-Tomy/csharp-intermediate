using Amazon;

namespace AccessModifiers_Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
