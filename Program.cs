using Delegates;

internal class Program
{
    private static void Main(string[] args)
    {
        string dirExample = Directory.GetCurrentDirectory(); 

        List<CollectionIntValueClass> IntValuesList = new List<CollectionIntValueClass>
        {
            new CollectionIntValueClass { Name = "Item1", Value = (new Random()).Next() },
            new CollectionIntValueClass { Name = "Item2", Value = (new Random()).Next() },
            new CollectionIntValueClass { Name = "Item3", Value = (new Random()).Next() },
            new CollectionIntValueClass { Name = "Item4", Value = (new Random()).Next() }
        };

        IntValuesList.CollectionWrite();
                
        var maxIntItem = IntValuesList.GetMax(x => x.Value);

        Console.WriteLine($"Максимальный элемент IntValuesList: {maxIntItem.Name}, Value: {maxIntItem.Value}");

        List<CollectionDoubleValueClass> DoubleValuesList = new List<CollectionDoubleValueClass>
        {
            new CollectionDoubleValueClass { Name = "Item1", Value = (new Random()).NextDouble() },
            new CollectionDoubleValueClass { Name = "Item2", Value = (new Random()).NextDouble() },
            new CollectionDoubleValueClass { Name = "Item3", Value = (new Random()).NextDouble() },
            new CollectionDoubleValueClass { Name = "Item4", Value = (new Random()).NextDouble() }
        };

        DoubleValuesList.CollectionWrite();

        var maxDoubleItem = DoubleValuesList.GetMax(x => (float)x.Value);
         
        Console.WriteLine($"Максимальный элемент DoubleValuesList: {maxDoubleItem.Name}, Value: {maxDoubleItem.Value:N2}");

        var dirChecker = new CheckDirectory();        
        dirChecker.FindFiles(dirExample);


        Console.ReadLine();
    }

}