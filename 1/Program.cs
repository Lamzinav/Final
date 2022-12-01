// Функция подсчета подходящих элементов
int CountElement (string[] array)
{
    int size = 0, temp = 0;
    string box = "";
    for (int i = 0; i < array.Length; i++)
    {
        box = array[i];
        temp = box.Length;
        if (temp < 4)
            size ++;
    }
    return size;
}

// Функция формирования нового массива с заданными элементами по условию задачи
string[] ConvertArray (string[] array, int size)
{
    int j = 0, temp = 0;
    string box = "";
    string[] resultArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        box = array[i];
        temp = box.Length;
        if (temp < 4)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

// Код программы
string[] originalArray = {"print","hello","car","|:(","><"};
int sizeArray = CountElement(originalArray);
string[] finalArray = new string[sizeArray];
finalArray = ConvertArray(originalArray, sizeArray);
Console.Write(string.Join(", ", finalArray));
