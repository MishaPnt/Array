using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть чисел: ");
            int countOfNumbs = int.Parse(Console.ReadLine());
            int[] myArray = new int[countOfNumbs];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 100);
            }
            TArray tUnionArray = new TUnionArray(myArray);
            Console.WriteLine($"Sum bitewise of array: { tUnionArray.SumOfArr()}");
            int[] array = tUnionArray.Foreach();
            Console.WriteLine("Replacement by opposite signs: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            TArray xorArray = new XorArray(myArray);
            Console.WriteLine($"Sum bitewise OR: { xorArray.SumOfArr()}");
            int[] array1 = xorArray.Foreach();
            Console.WriteLine("Replacement by normal signs: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            } 
        }
    }
}
