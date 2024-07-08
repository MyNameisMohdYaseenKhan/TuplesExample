namespace TuplesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a+b);
            Console.WriteLine("Tuples Example!");
            //crate a Tuple object
            int[] ar = { 1, 2, 3, 4, 5 };
            Tuple<int[], int, String> t1 = new Tuple<int[], int, String>(ar, 6, "My Name is yaseen");


            foreach (var i in t1.Item1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(t1.Item2);

            String[] str=t1.Item3.Split(' ');

            foreach (var i in str) {
                Console.WriteLine(i);
            }
            //using tuple create method
            var myTuple = Tuple.Create("String");

            var tt = Tuple.Create(1, "hello", ar);

            var tt1 = Tuple.Create(1, "hello", ar, 1, "hello", ar, 1, "hello");

            Console.WriteLine(tt1.Rest);
            // var tt2 = Tuple.Create(1, "hello", ar, 1, "hello", ar, 1, "hello",78);

            //Nesting Tuple

            var nestig = Tuple.Create(1, 2, "yaseen khan", tt,new Tuple<int>(1));

            for(int i = 0; i < nestig.Item4.Item3.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello Sir");
            print();
        }

        //tuple as a return type
        public static Tuple<String,String,String> print()
        {

            return Tuple.Create("Mohd", "Yaseen", "Khan");
        }
    }
}