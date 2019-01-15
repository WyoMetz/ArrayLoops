namespace ArrayLoopLibrary
{
    public class AddingArrayValues
    {
        //When we create an Array we need to add values to it.

        public int[] Numbers = new int[10];

        //To add Items we need to Access the Array via its index. This can only be done inside the Scope of a Method.

        public void AddToArray()
        {
            Numbers[0] = 1; //Arrays will always start at 0.
            Numbers[1] = 2;
            Numbers[2] = 3;
            Numbers[3] = 4;
            Numbers[4] = 5;
            Numbers[5] = 6;
            Numbers[6] = 7;
            Numbers[7] = 8;
            Numbers[8] = 9;
            Numbers[9] = 10;
        }

        // We can also Initialize Arrays with the Values inside.

        public int[] NewNumbers = new int[] { 1, 2, 3, 4, 5 };

        //So the above Array now has 5 int values in it.
        //Note that we dont have to declare the size of the Array in the Square Brackets (e.g. new int[5];).
    }
}
