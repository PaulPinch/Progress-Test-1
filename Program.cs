string [] GetArray(string message)
{
    Console.WriteLine(message);
	string input = Console.ReadLine() ?? "0";
    string [] array = input.Split(", ");
	return array;
}

string [] ProcessArray (string [] arr)
{
    int counter = 0;
    string [] resultarray = new string [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultarray[counter] = arr[i];
            counter++;

        }
    }
    Array.Resize (ref resultarray, counter);
    return resultarray;
}

void PrintArray (string [] arr)
{
    if (arr.Length == 0)
    {
        Console.WriteLine("В исходном массиве нет элементов, удовлетворяющих условию.");
    }
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i != arr.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}

string [] m = ProcessArray (GetArray ("Введите массив, разделяя элементы запятой с пробелом: "));
PrintArray (m);

