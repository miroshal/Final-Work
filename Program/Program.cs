// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


string[] FindTreeLen(string[] arr)
{
    int count = 0;
    string[] resultArray = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
            resultArray = AddSting(resultArray, arr[i], count);
        }
    }
    return resultArray;
}

string[] AddSting(string[] resArr, string str, int cnt)
{
    string[] secondArray = new string[resArr.Length + 1];
    for (int i = 0; i < resArr.Length; i++)
    {
        secondArray[i] = resArr[i];
    }

    secondArray[secondArray.Length - 1] = str;
    return secondArray;
}

void Main(string[] arr)
{
    foreach (var item in FindTreeLen(arr))
    {
        Console.WriteLine(item);
    }
}

string[] inputArr = { "hello", "2", "world", "-)", "34567", "355" };
Main(inputArr);
