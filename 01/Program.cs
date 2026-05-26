namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個大於 90 的整數 : ");
            int max = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= max; i++ )
            {
                if ( i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("Dann");
                }
                else if ( i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if ( i % 5 == 0)
                {
                    Console.WriteLine("School");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
