void CalculateNumbers(int var1, int var2)
{
    int sum = var1 + var2;
    int difference = var1 - var2;
    int product = var1 * var2;
    double quotient = (double)var1 / var2;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Quotient: {quotient}");
}