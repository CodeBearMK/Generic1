namespace Generic1
{
    class GList<T>
    {
        private T[] ary = new T[5];
        private int index;

        public void SaveToAry(T tData)
        {
            if (index < ary.Length)
            {
                ary[index] = tData;
                index++;
            }
        }

        public void show()
        {
            for (int k = 0; k < ary.Length; k++)
            {
                Console.WriteLine("ary[{0}] = {1}", k, ary[k]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GList<double> mydouble = new GList<double>();
            mydouble.SaveToAry(67.4);
            mydouble.SaveToAry(-89);
            mydouble.SaveToAry(0.0006);
            mydouble.SaveToAry(3.1416);
            mydouble.SaveToAry(-93000);
            mydouble.show();
            Console.WriteLine();

            GList<string> mystr = new GList<string>();
            mystr.SaveToAry("Tom");
            mystr.SaveToAry("Mary");
            mystr.SaveToAry("John");
            mystr.SaveToAry("Kevin");
            mystr.SaveToAry("Helen");
            mystr.show();
            Console.Read();
        }
    }
}