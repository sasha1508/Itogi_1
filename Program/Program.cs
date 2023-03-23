
Console.Clear();

String[] Array = new String[5] {"hello","2","world",":-)","-2"}; // Задаём массив

int count =0;

// Находим количество эмлементов с длиной 3 или меньше:
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        count++;
    }
}

String[] Array1 = new String[count]; //Создаём новый массив нужной длины

// Заполняем массив:
int j = 0;
for(int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        Array1[j] = Array[i];
        j++;
    }
}

// Выводим содержимое массива на экран:
for(int i = 0; i < count; i++)
{
    System.Console.WriteLine(Array1[i]);
}

