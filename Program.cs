namespace cs7_practice

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] numbers = { 11, 12, 9, 7, 12 };
            Arrayy arr = new Arrayy(numbers);
            arr.Show();
            arr.Show("Students's grades:");

            //2
            arr.Avg();
            arr.Max();
            arr.Min();
            arr.Search(12);
            arr.Search(120);

        }
    }
}
