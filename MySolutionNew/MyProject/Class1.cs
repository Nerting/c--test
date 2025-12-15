public static class MathOperations
{
    public static double Add(double a, double b) => a + b;
    
    
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо.");
        }
        return a / b;
    }
}
