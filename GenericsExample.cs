 class GenericsExample
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Console.WriteLine("Before: {0} {1}",a,b);
            Swap<int> (ref a,ref b) ;
            Console.WriteLine("After: {0} {1}", a, b);

            string x = "Hello", y = "World";
            Console.WriteLine("Before: {0} {1}", x, y);
            Swap<string> (ref x,ref y);
            Console.WriteLine("After: {0} {1}", x, y);

        }
    }
