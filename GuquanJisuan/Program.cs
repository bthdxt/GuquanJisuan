namespace GuquanJisuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            GufenChuli gufenChuli = new GufenChuli();
            gufenChuli.CsvAddToItem(@"D:\Yuki\VS\guquan.csv");


            //for (int i = 0; i < gufenChuli.items.Count; i++)
            //{
            //    Console.WriteLine(gufenChuli.items[i].name);
            //}

            //Console.WriteLine(gufenChuli.GetGuFenBi("B", "A"));
            //Console.WriteLine(gufenChuli.GetGuFenBiAllZiranren("华闽南配集团股份有限公司",12));
            Console.WriteLine(gufenChuli.GetGuFenBiAll("华闽南配集团股份有限公司",12));
        }

    }
}