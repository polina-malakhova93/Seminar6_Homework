Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
int countNum = 1;
for(int i = 0; i < input.Length; i++)
{
    if (input[i] == ',')
    {
        countNum++;
    }
}

int[] numbers = new int[countNum];
int index = 0;
for (int i = 0; i < input.Length; i++)
{
    string temp = "";
    while (input[i] != ',')
    {
        if(i != input.Length - 1)
        {
            temp += input[i].ToString();
            i++;
        }
        else
        {
            temp += input[i].ToString();
            break;
        }
    }
    numbers[index] = Convert.ToInt32(temp);
    index++;
}
PrintArray(numbers);
int countPositive = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        countPositive++;
    }
}
Console.WriteLine($"Количество положительных элементов: {countPositive}");


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
