using System;

namespace Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array :");

            //taking the array size from user
            
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeOfArray];

            //taking the array from user
            Console.WriteLine("Enter the elements of array :");

            for (int traverser = 0; traverser < sizeOfArray; traverser++)
            {
                string elementsOfArray = Console.ReadLine();
                array[traverser] = int.Parse(elementsOfArray);
             }

            Console.WriteLine("Enter an element to be searched in array :");

            int elementToSearch = int.Parse(Console.ReadLine());

            //Linear search in Array
            for(int i=0; i < sizeOfArray; i++)
            {
                if(array[i] == elementToSearch)
                {
                    Console.WriteLine($"The given element is {elementToSearch} and is in {i + 1} position");
                }
            }

         Console.ReadLine();  //element is not found in given array try another element
         }
    }
}
//write new private method 'linear search' and call it from main method