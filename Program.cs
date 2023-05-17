namespace Prog_120_S23_L11_LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // - 20 to 20

            //int age = -20; // starting point



            int currentTime = 0;
            int endOfTime = 24;

            int storeClose = 23;
            int storeOpen = 5;
            // And or not
            // &&


            while (currentTime < endOfTime)
            {
                //if(currentTime >= timeToUpdate)
                //{
                //    Console.BackgroundColor = ConsoleColor.Red;

                //}

                // And checks if BOTH conditions are true
                // true && true - This is the only way it is true
                // false && true - This is false
                // true && false - false
                // false && false - false

                // Or will run if ONE of the conditions is true
                // true || true = true
                // true || false = true
                // false || true = true
                // false || false = false

                // Not - ! - Exclmation

                // Is it AFTER the store opens AND before the store closes
                bool isOpen = currentTime >= storeOpen && currentTime < storeClose;
                // Is it AFTER the store closes OR before the store Opens
                bool isClosed = currentTime >= storeClose || currentTime <= storeOpen;

                // isOpen returns if its between opening hours
                // is NOT Open
                bool anotherIsClosed = !isOpen;
                bool anotherIsOpen = !isClosed;

                if (anotherIsOpen)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;

                }

                Console.WriteLine(currentTime + " ");


                currentTime++;

            }

            //Console.BackgroundColor = ConsoleColor.Black;


            //Console.ForegroundColor = ConsoleColor.Black;
            //// is the user older than 10 and younger than 18

            //// age less than 10 && age greater than 18 : THis is wrong you cant be less than 10 and older than 18
            //if(  )
            //{
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;

            //}
        } // main

        public static void BoolReview()
        {
            // Logical Operators
            // 3 types of logical operations
            // And - && - Shift + 7
            // Or - || - Shift - \
            // Not - ! - Shift + 1

            // true or false
            bool result = 5 < 10;
            // And - &&
            int age = 12;

            bool lessThan21 = age < 21;
            bool olderThan65 = age > 65;

            // Is the person a middle aged adult



            if (5 > 10) // Will always turn into ONE true or ONE false
            {

            }
        }

        public static void ChangeCOlorExample()
        {

            // QUick Color SideTrip
            // Change the color of the CONSOLE DISPLAY
            // Change the foreground - Text Color
            // Change the background

            // Changes the color of the text to red, and background to blue
            Console.ForegroundColor = ConsoleColor.Red; // Everything after this line will be red
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("This is some colored text");

            // Changes colors back
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("This is some basic text");
        }

    } // class

} // namespace