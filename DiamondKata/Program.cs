using Diamond;

internal static class Program
{
    /// <summary>
    /// For the sake of simplicity I didn't use interfaces to respect all SOLID principles 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Depending on your letter choise we will build a diamond for you");
        Console.WriteLine("Please enter a character: ");
        char choosedMiddleChar = Console.ReadLine()[0];
        var diamondKata = new DiamondKata();
        diamondKata.PrintDiamondShape(choosedMiddleChar);
    }
}
