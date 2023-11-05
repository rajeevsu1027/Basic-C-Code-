//  Delegate practicing :



using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCoding 
{
	
delegate void myDelegate();	
class DemoDelegate
{
	static void Main(string[] args)
        {            
           myDelegate myd = myMethod1;
		   myd();
        }                  
        public static void myMethod1()
          {
             Console.WriteLine("This is myMethod1");
          }    
}
}