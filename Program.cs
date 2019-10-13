using System;

namespace testApp
{
    class Program
    {
    	static void Hello()
    	{
    		Console.WriteLine("Hello World!");
            Console.WriteLine("Here is another line in the test app!!");
            Console.WriteLine("Current time of testing app is: " + DateTime.Now);
    	}

    	static void fizzBuzz()
    	{
    		for (int counter = 1; counter < 101; counter++) 
    		{
    			if ( counter % 15 == 0)
    			{
    				Console.WriteLine("FizzBuzz");
    			}
    			if ( counter % 5 == 0)
    			{
    				Console.WriteLine("Buzz");
    			}
    			if ( counter % 3 == 0 )
    			{
    				Console.WriteLine("Fizz");
    			}
    			else {
    				Console.WriteLine(counter);
    			}
    		}
    	}
        static void Main(string[] args)
        {
            Hello();
            fizzBuzz();
        }
    }
}
