namespace Diamond;

public class DiamondKataDrawer
{
    public void PrintFirsPartOfTheDiamond(int alphabetLetterPosition)
    {
        for (int i = 0; i <= alphabetLetterPosition; i++)
        {
            for (int j = 0; j < alphabetLetterPosition - i; j++)
                Console.Write(" ");

            int doubleOfi = i * 2;

            for (int j = 0; j < doubleOfi + 1; j++)
            {
                if (j == 0 || j == doubleOfi)
                    Console.Write((char)(Constants.FIRST_LETTER_OF_THE_ALPHABET + i));
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    public void PrintSecondPartOfTheDiamond(int alphabetLetterPosition)
    {
        for (int i = alphabetLetterPosition - 1; i >= 0; i--)
        {
            for (int j = 0; j < alphabetLetterPosition - i; j++)
                Console.Write(" ");

            int doubleOfi = i * 2;

            for (int j = 0; j < doubleOfi + 1; j++)
            {
                if (j == 0 || j == doubleOfi)
                    Console.Write((char)(Constants.FIRST_LETTER_OF_THE_ALPHABET + i));
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
