public class Calc
{

    public int DateOfBirthCalc(DateTime date)
    {
        return DateTime.Now.Year - date.Year;
    }

    public int DateOfBirthCalc(int yearOfBirth)
    {
        return DateTime.Now.Year - yearOfBirth;
    }
}
class Program
{

    static void Main(string[] args)
    {
        Calc c = new Calc();
        var result = c.DateOfBirthCalc(DateTime.Now.AddYears(-42));
        var result1 = c.DateOfBirthCalc(42);

        Console.WriteLine("Result Int : {0} - Result Year : {1}", result, result1);

    }
}