namespace BitsConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            long b = 20;
            byte c = 30;
            var bitsInt = new Bits();
            var bitsLong = new Bits();
            var bitsByte = new Bits();
            bitsInt = a;
            Console.WriteLine(bitsInt);
            bitsLong = b;
            Console.WriteLine(bitsLong);
            bitsByte = c;
            Console.WriteLine(bitsByte);
        }
    }
}
