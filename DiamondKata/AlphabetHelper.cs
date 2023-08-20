namespace Diamond;

public class AlphabetValidator
{
    public int GetAlphabetLetterPosition(char choosenMiddleChar)
    {
        choosenMiddleChar = ChangeToUpperIfNeccesary(choosenMiddleChar);

        return choosenMiddleChar - Constants.FIRST_LETTER_OF_THE_ALPHABET;
    }

    public char ChangeToUpperIfNeccesary(char choosenMiddleChar)
    {
        if (!char.IsUpper(choosenMiddleChar))
        {
            choosenMiddleChar = choosenMiddleChar.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("The inserted char was not upper case so we change it for you \n");
        }

        return choosenMiddleChar;
    }
}
