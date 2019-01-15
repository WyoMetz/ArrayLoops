using System;
using System.Text;

namespace ArrayLoopLibrary
{
    class CleanArrayLoop
    {
        public int[] WorkingValues = new int[10];

        public void AddNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                WorkingValues[i] = i + 1;
            }
        }
        
        public void ShowNumbers()
        {
            foreach (var Number in WorkingValues) 
            {
                Console.WriteLine(Number.ToString());
            }
        }

        public string NumberString()
        {
            StringBuilder builder = new StringBuilder(); 
            foreach (var Number in WorkingValues) 
            {
                builder.Append(Number.ToString()); 
            }

            return builder.ToString(); 
        }

    }
}
