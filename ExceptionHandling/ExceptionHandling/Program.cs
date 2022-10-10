namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Division d = new Division();
            d[0] = "Hello";
            d[1] = "Bangalore";
            d[2] = "Vinny";
            d.devideTwoNumbers(23, 0);
        }
    }
}