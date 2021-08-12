using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array :");
            //taking the array size from user
            string X = Console.ReadLine();
            int sizeOfArray = Int32.Parse(X);
            int[] array = new int[sizeOfArray];

            //taking the array from user
            Console.WriteLine("Enter the elements of array :");
            for (int traverser = 0; traverser < sizeOfArray; traverser++)
            {
                string elementsOfArray = Console.ReadLine();
                array[traverser] = Int32.Parse(elementsOfArray);
             }

            Console.WriteLine("Enter an element to be searched in array :");
            string arrayElementFromUser = Console.ReadLine();
            int elementFromUser = Int32.Parse(arrayElementFromUser);

            //Linear search in Array
            for(int searchElementInArray=0; searchElementInArray < array.Length; searchElementInArray++)
            {
                if(array[searchElementInArray] == elementFromUser)
                {
                    Console.WriteLine($"The given element is {elementFromUser} and is in {searchElementInArray + 1} position");
                }
            }
         Console.ReadLine();
         }
    }
}
