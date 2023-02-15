namespace Lab13Main
{
    public static class Program
    {
        public static Random rand = new Random();

        public static int Main()
        {
            var collection1 = new MyNewCollection("Test collection 1");
            var journal1 = new Journal();
            collection1.CollectionCountChanged += journal1.Add;
            collection1.CollectionReferenceChanged += journal1.Add;

            var collection2 = new MyNewCollection("Test collection 2");
            var journal2 = new Journal();
            collection2.CollectionCountChanged += journal2.Add;
            collection2.CollectionReferenceChanged += journal2.Add;
            collection1.CollectionCountChanged += journal2.Add;
            collection1.CollectionReferenceChanged += journal2.Add;

            collection1.Add(new Transport("transport 1", 1));
            collection2.Add(new Transport("transport 1", 1));

            collection1.Add(new Train("train 1", 1, 1));
            collection2.Add(new Train("train 1", 1, 1));

            var list1 = new List<string>();
            list1.Add("s1");
            var list2 = new List<string>();
            list2.Add("s1");
            collection1.Add(new Express("express 1", 1, 1, list1));
            collection2.Add(new Express("express 1", 1, 1, list2));           

            collection1.Remove(0);
            collection2.Remove(1);

            collection2[0] = new Transport("new transport 1", 1);

            journal1.Print();
            journal2.Print();

            return 0;
        }
    }
}