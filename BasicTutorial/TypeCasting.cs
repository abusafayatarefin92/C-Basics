// Converting data it has been assigned at compilation
// Implicit & Explicit

public class TypeCasting
{
    public int TypeCastingMethod()
    {
        double x = 1234.5;
        int a;
        // Cast double to int explicit conversion
        a = (int)x;
        return a;
    }

    public int TypeCastingMethod2() {
        string value = "687496748";
        int result = 0;

        if (int.TryParse(value, out result))
        {
            Console.WriteLine("Success: " + result);
        }
        else {
            Console.WriteLine("Failure.");
        }
        return result;
    }
}