namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入年收入：");

            decimal income = decimal.Parse(Console.ReadLine());

            decimal tax = 0;

            if (income <= 540000m)
            {
                tax = income * 0.05m;
            }
            else if (income <= 1210000m)
            {
                tax = 540000m * 0.05m
                    + (income - 540000m) * 0.12m;
            }
            else if (income <= 2420000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (income - 1210000m) * 0.20m;
            }
            else if (income <= 4530000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (income - 2420000m) * 0.30m;
            }
            else if (income <= 10310000m)
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (4530000m - 2420000m) * 0.30m
                    + (income - 4530000m) * 0.40m;
            }
            else
            {
                tax = 540000m * 0.05m
                    + (1210000m - 540000m) * 0.12m
                    + (2420000m - 1210000m) * 0.20m
                    + (4530000m - 2420000m) * 0.30m
                    + (10310000m - 4530000m) * 0.40m
                    + (income - 10310000m) * 0.50m;
            }

            Console.WriteLine($"應繳稅額：{tax}");
        }
    }
}
