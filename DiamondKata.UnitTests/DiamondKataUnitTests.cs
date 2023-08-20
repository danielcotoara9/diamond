namespace Diamond.UnitTests;

public class DiamondKataUnitTests
{
    private DiamondKata _diamondKata;
    [SetUp]
    public void Setup()
    {
        _diamondKata = new DiamondKata();
    }

    [Test]
    public void Should_Not_Accept_Other_Chars_Than_Letters()
    {
        // Arrange
        string input = "5";
        string expectedOutput = "Please enter a valid alphabet character.";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader(input));
            _diamondKata.PrintDiamondShape(input.ToCharArray()[0]);
            var actualOutput = sw.ToString().Replace(Environment.NewLine, "");

            // Assert
            Assert.That(expectedOutput.Length, Is.EqualTo(actualOutput.Length));
            Assert.That(actualOutput, Is.EqualTo(actualOutput));
        }
    }

    [Test]
    public void Should_Inform_User_When_Small_Letters_Are_Inserted()
    {
        // Arrange
        string input = "b";
        var expectedMessageForSmallLetters = "The inserted char was not upper case so we change it for you";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader(input));
            _diamondKata.PrintDiamondShape(input.ToCharArray()[0]);
            var actualOutput = sw.ToString().Replace(Environment.NewLine, "");

            // Assert
            Assert.IsTrue(actualOutput.Contains(expectedMessageForSmallLetters));
        }
    }

    [Test]
    public void Should_Build_Valid_Diamond_From_First_Aplhabet_Letter()
    {
        // Arrange
        string input = "A";
        string expectedOutput = "A";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader(input));
            _diamondKata.PrintDiamondShape(input.ToCharArray()[0]);
            var actualOutput = sw.ToString().Replace(Environment.NewLine, "");

            // Assert
            Assert.That(expectedOutput.Length, Is.EqualTo(actualOutput.Length));
            Assert.That(actualOutput, Is.EqualTo(actualOutput));
        }
    }

    [Test]
    public void Should_Build_Valid_Diamond_For_Letter_C()
    {
        // Arrange
        string input = "C";
        string expectedOutput = "  A B BC   C B B  A";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Console.SetIn(new StringReader(input));
            _diamondKata.PrintDiamondShape(input.ToCharArray()[0]);
            var actualOutput = sw.ToString().Replace(Environment.NewLine, "");

            // Assert
            Assert.That(expectedOutput.Length, Is.EqualTo(actualOutput.Length));
            Assert.That(actualOutput, Is.EqualTo(actualOutput));
        }
    }
}