using static Lr1.Employee;

namespace Lr1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(17017,"Ukraine", "Lviv", "Franka", 71, 11);
            address.ToString();
            Console.WriteLine();

            int usd = 30;
            int eur = 20;
            int uah = 500;
            Converter convert = new Converter(usd, eur, uah);
            Converter.help();
            Console.WriteLine(convert.Convert(3, usd));
            Console.WriteLine();

            Employee bandera = new Employee("Степан", "Бандера", Positions.Midle);
            bandera.Auto();
            Console.WriteLine();

            User user = new User("User893829139210", "Iван", "Сiрко", 417, "1.02.2022");
            user.Print();

        }
    }
}