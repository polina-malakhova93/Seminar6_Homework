double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = Input("Введите k1: ");
double k2 = Input("Введите k2: ");
double b1 = Input("Введите b1: ");
double b2 = Input("Введите b2: ");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"х={x},y= {y}");


