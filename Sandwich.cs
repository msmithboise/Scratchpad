namespace CSD
{
    class Sandwich
    {
        private int slices = 5;
        public string bread = "white";

        public void make()
        {
            System.Console.WriteLine("Sandwich made with " + slices + " slices.");
            System.Console.WriteLine("Sandwhich made with " + bread + " bread");
        }

        public void eat()
        {
            System.Console.WriteLine("Eating sandwich with " + slices + " slices.");
        }
        public int addTwoAndTwo()
        {
            int a = 2;
            int b = 2;

            return (a + b);

            // bread will have a red line because bread if it is not static

        }

        public int test(int num)
        {
        num = 50;

        return num + 1;
        }
    }
}

