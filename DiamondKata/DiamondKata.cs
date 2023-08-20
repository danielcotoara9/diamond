namespace Diamond;
public class DiamondKata
{
    private readonly AlphabetValidator _alphabetValidator;
    private readonly DiamondKataDrawer _diamondKataDrawer;

    /// <summary>
    /// For the sake of simplicity I didn't use interfaces to respect all SOLID principles 
    /// </summary>
    /// <param name="args"></param>
    public DiamondKata()
    {
        _alphabetValidator = new AlphabetValidator();
        _diamondKataDrawer = new DiamondKataDrawer();
    }

    /// <summary>
    /// This method takes a alphabwt letter and build a diamond with the letter in the middle of it
    /// If the letter is not in upper case the code will transformit ToUpper()
    /// </summary>
    /// <param name="capitalChar"></param>
    public void PrintDiamondShape(char choosenMiddleChar)
    {
        if (char.IsLetter(choosenMiddleChar))
        {
            int alphabetLetterPosition = _alphabetValidator.GetAlphabetLetterPosition(choosenMiddleChar);
            _diamondKataDrawer.PrintFirsPartOfTheDiamond(alphabetLetterPosition);
            _diamondKataDrawer.PrintSecondPartOfTheDiamond(alphabetLetterPosition);
        }
        else
        {
            Console.WriteLine("Please enter a valid alphabet character.");
        }
    }
}
