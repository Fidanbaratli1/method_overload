namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 23, 12, 5, 9 };
            Console.WriteLine(Getmin(arr));
        }
    
            public static int Getmin (int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
                return min;
            }
        }
    }
   
