double Calculateformula(int a, int b, int c, int d)
{
    double numenator = a * b;
    double denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

double result = Calculateformula(1, 2, 3, 4);
Console.WriteLine(result);