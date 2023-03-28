namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(5);
            Area(3, 6);
            Area(4, 6, 9);
            Area(3,4,6,5);
        }
        public static void Area(int r)
        {
            int p = 3;
            int s = p*(r*r);
            Console.WriteLine(s);    //cevrenin sahesi
        }
        public static void Area(int a,int b)
        {
            int s = a * b;
            Console.WriteLine(s);   //Duzbucaqlinin sahesi
        }
        public static void Area( int a, int b, int c)
        {
            int s = 2 * (a * b + a * c + b * c);
            Console.WriteLine(s);  //duzbucaqli paralelipipedin tam sethinin sahesi
        }
        public static void Area( int a, int b,int c,int r)
        {
           int p = (a + b + c) / 2;
            int s = p * r;
            Console.WriteLine(s);  // ucbucaqlinin daxiline cekilmis cevrenin sahesi
        }

    }
}