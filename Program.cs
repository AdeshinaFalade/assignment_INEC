using System.Collections;
namespace assignment_INEC

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] voters = { "Mary", "Sean", "James", "Mary", "Jean", "Jean", "Mary", "Olu", "Seun", "Bose", "James", "Mary" };

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var item in voters)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }

            }
            Console.WriteLine("Name and number of times registered");
            foreach (var item in dic)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }



            //INEC should use HashSet next time to avoid duplicates.
            Console.WriteLine("\n\nThe Unique List");
            HashSet<string> unique = voters.ToHashSet();
            foreach (string item in unique)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            //INEC should use HashSet next time to avoid duplicates.




       

        }
    }
}