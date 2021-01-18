using System;
using System.Collections;
public class SamplesQueue
{

    public static void Main()
    {
        Int64 i = 0;

        // Creates and initializes a new Queue.
        Queue myQ = new Queue();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");
        
        for (i = 0; i <= 1000000; i++)
            myQ.Enqueue(i);


        // Displays the properties and values of the Queue.
        Console.WriteLine("myQ");
        Console.WriteLine("\tCount:    {0}", myQ.Count);
        Console.Write("\tValues:");
        PrintValues(myQ);
        Console.ReadKey();
    }


    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}








/* 
This code produces the following output.

myQ
    Count:    3
    Values:    Hello    World    !
*/
