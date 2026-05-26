namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請以英文輸入一句話：");
            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if(wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach(var item in wordCount)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }

            Console.ReadLine();
        }
    }
}
