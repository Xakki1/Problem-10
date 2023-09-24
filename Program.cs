internal class Program
{
    private static void Main(string[] args)
    {
        double a;

        Console.WriteLine("Ввелите какое-нибудь сумму денег что вы имеете  =");
        a = Convert.ToDouble(Console.ReadLine());
        if (a >= 1000 && a > -1)
            switch (a % 10)
            {
                case 1:
                    Console.WriteLine("У нас " + a + " рубль");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("У нас " + a + " рубля");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    Console.WriteLine("У нас " + a + " рублей");
                    break;
            }
        else Console.WriteLine( "Ну надо больше");
        Console.ReadKey();
    }
}