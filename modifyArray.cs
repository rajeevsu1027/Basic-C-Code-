//   Write a C# Sharp program to create a list from a given list of integers, removing all values ending in 7.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoding 
{
class modifyArray
{
	static void Main(string[] args)
        {            
           List<int> mylist = test(new List<int>(new int[] { 10, 22, 35 , 47, 53, 67 }));                  
           foreach(var i in mylist)
            {
               Console.Write(i.ToString()+" ");
            }     
        }                  
        public static List<int> test(List<int> nums)
          {
             return nums.Where(n => n % 10 < 7).ToList();
          }    
}
}