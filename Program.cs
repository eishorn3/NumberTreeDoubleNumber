namespace NumberTreeDoubleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for my double tree: ");
            int userLine = Convert.ToInt32(Console.ReadLine());


            for (int counter = 0; counter <= userLine; counter++)
            {
                Console.WriteLine();


                for (int position = 0; position < counter; position++)
                {

                    Console.Write(counter);


                }
            }
        }
    }
}
