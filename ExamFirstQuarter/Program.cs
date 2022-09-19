Console.WriteLine("Введите массив через запятую: ");
string input = Console.ReadLine()!;
string[] array = input.Split(",")
                      .ToArray();

void ThreeCharArray(string[]array)
{
    int count = 1;
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<4)
        {
            for (int j = 0; j < newArray.Length; j++)
            {
                newArray[j]=array[i];
                Console.Write($"{newArray[j]}")
            }
            count++;
        }
    }
}