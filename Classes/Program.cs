namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "Chrysler";
            car1.Model = "Concorde";
            car1.Year = 1998;

            car1.PrintTheGoods();
        }
    }
}
