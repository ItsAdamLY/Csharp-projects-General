namespace ArrayMatch
{

    public class ArraySearch
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 1, 6 };
            bool swapsMade = false; //boolean

            while (!swapsMade)
            {
                swapsMade = true;
                int i = 0;

                while (i < 2)
                {
                    if (arr[i+1] < arr[i])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[1] = t;
                        swapsMade = false;
                    }

                    i++;
                }
            }

            //method 1
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //method 2
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //method 3
            foreach (int i in arr) // for i in range (0,arr.Length+1)
            {
                Console.WriteLine(i);
            }
        }
    }

}