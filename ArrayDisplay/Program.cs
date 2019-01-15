using System;
using ArrayLoopLibrary; //Notice that I have declared that I am using my ArrayLoop Library

namespace ArrayDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayLoop arrayLoops = new ArrayLoop(); //Remember to Instaniate

            //Now I'll use those methods I made

            arrayLoops.AddNumbers();

            arrayLoops.ShowNumbers();

            Console.WriteLine(arrayLoops.NumberString());
            Console.ReadLine();
        }
    }
}
