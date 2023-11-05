// firstlargest element in Array :

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoding 
{
	
	
class FirstLargest
{
	static void Main(string[] args)
        {            
           
		   int[] elementList = {23,2,7,15,18,4};
		   int answer = largestInarray(elementList);
		   Console.WriteLine("The largest element in the list" +answer);
        }  

     public static int largestInarray(int[] elements)
	 {
		 int firstLargest = elements[0];
		 for(int i =1; i < elements.Length ; i++)
		 {
            if(firstLargest < elements[i])
			{
				firstLargest = elements[i];
				Console.WriteLine("The firstLargest  value:" +firstLargest);
			}
           
           
		 }
           return firstLargest;		 
      }		 
        
}
}