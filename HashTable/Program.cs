namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************** Welcome To Hash Tables *****************************\n");

            MyMapNode<int, string> table = new MyMapNode<int, string>(6);
            table.Add(0, "To");
            table.Add(1, "be");
            table.Add(2, "or");
            table.Add(3, "not");
            table.Add(4, "to");
            table.Add(5, "be");
            table.Get(0);
            table.Get(1);
            table.Get(2);
            table.Get(3);
            table.Get(4);
            table.Get(5);

            Console.WriteLine("The Added Sentence is :: ");
            for (int i = 0; i < table.array.Length; i++)
            {
                Console.Write($"{table.array[i]} ");
            }
            Console.WriteLine("\n\n************** Frequency of Words **************");
            table.FrequencyOfWords(table.array, table.array.Length);


        }
    }
}