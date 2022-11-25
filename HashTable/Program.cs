namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************ Welcome To Hash Tables *********************\n");

            MyMapNode<int, string> table = new MyMapNode<int, string>(19);
            table.Add(0, "Paranoids");
            table.Add(1, "are");
            table.Add(2, "not");
            table.Add(3, "paranoid");
            table.Add(4, "because");
            table.Add(5, "they");
            table.Add(6, "are");
            table.Add(7, "paranoid");
            table.Add(8, "but");
            table.Add(9, "because");
            table.Add(10, "they");
            table.Add(11, "keep");
            table.Add(12, "putting");
            table.Add(13, "themselves");
            table.Add(14, "deliberately");
            table.Add(15, "into");
            table.Add(16, "paranoid");
            table.Add(17, "avoidable");
            table.Add(18, "situations");

            for (int i = 0; i < table.size; i++)
            {
                table.Get(i);
            }

            Console.WriteLine("The Added Paragraph is :: ");
            for (int i = 0; i < table.array.Length; i++)
            {
                Console.Write($"{table.array[i]} ");
            }
            Console.WriteLine("\n\n************** Frequency of Words **************");
            table.FrequencyOfWords(table.array, table.array.Length);

            table.Remove(17);
            table.Get(17);
            table.array = table.array.Where(val => val != "avoidable").ToArray();
            Console.WriteLine("\nThe Updated Paragraph is :: ");
            for (int i = 0; i < table.array.Length; i++)
            {
                Console.Write($"{table.array[i]} ");
            }
            Console.WriteLine();


        }
    }
}