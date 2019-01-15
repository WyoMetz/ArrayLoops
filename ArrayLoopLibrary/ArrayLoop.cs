using System;
using System.Text;

namespace ArrayLoopLibrary
{
    public class ArrayLoop
    {
        //Programmers are Lazy people (NOT true but they pretend) so loops are the preferred method of working with Arrays

        //Lets Create a new Array called WorkingValues of Type int[].

        public int[] WorkingValues = new int[10];

        //Now say I want to add 1-10 into this Array. A For Loop works wonderfully.

        public void AddNumbers() //remember void means that this method returns nothing. Maybe it just moves data or anything else.
        {
            for (int i = 0; i < 10; i++) //What this says is; Let int i = 0, While i is less than 10 do this, then increase i by 1.
            {
                WorkingValues[i] = i + 1; //Remember Arrays start at 0.
            }
        }

        //Now lets get the values of the array so we can display it on a User Interface (such as a Console App).
        //We'll use a foreach loop to make our lives Easy (lazy remember).

        public void ShowNumbers()
        {
            foreach (var Number in WorkingValues) //What this says is; for each value in this collection of values, do this.
            {
                Console.WriteLine(Number.ToString()); 
            }
        }

        //Say we want a single string of values that we will use for some other application. Lets put all the Values in a string.

        public string NumberString()
        {
            StringBuilder builder = new StringBuilder(); //If you read about Concatenation you know string builder is the preferred method of building strings.

            foreach (var Number in WorkingValues) //Same foreach as above
            {
                builder.Append(Number.ToString()); //this will add all the numbers together as a string.
            }

            return builder.ToString(); //This gives us that string of numbers.
        }

    }
}
