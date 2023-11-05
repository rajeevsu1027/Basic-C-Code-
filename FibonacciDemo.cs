//  Fibonacci series n:

using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoding 
{
	
	
class FibonacciDemo
{
	static void Main(string[] args)
        {            
           Console.WriteLine("Enter upto the count you want fibonacci sequence");
		   int limit =Convert.ToInt32(Console.ReadLine());
		   int previous = 0;
		   int current = 1;
		   int next = 0;
		   
		   while (next <= limit)
		   {
			   Console.Write(previous + " ");
			   next = previous + current ;
			   previous = current ;
			   current = next ;
			   
			   
		   }
        }                  
        
}
}