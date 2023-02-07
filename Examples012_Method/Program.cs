// Вид 1  (ничего не принимает, ничего не возвращает)
void Method1()
{
    Console.WriteLine("Автор ....");
}

// Method1();  // ТАк можно делать 
// Method1;  // ТАк нельзя 

// ____________________________________________________________________________________________________________---\

// Вид 2  (Что то принимает, ничего не возвращают)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Пример приминения : 
// Method2("Здесь будет ваш текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}


// Пример приминения : 
// Method21("Текст", 5);  // текст выводиться указанное справа колличество раз 

// Method21(msg: "Текст", count: 5);  // Так же через данную конструкцию можем явно указывать переменные
// Method21(count: 5, msg: "Фильм");  // и писать их в другом порядке

// _________________________________________________________________________________________

// Вид 3   (Ничего не принимают, что то возвращают)

int Method3()   // ОБязательно указывать значение которое будем возвращать (int, string b тд) и обязательно использовать return
{
    return DateTime.Now.Year;   // возвращаем текущее время и год 
}

// int year = Method3();    // присваиваем дату к переменной
// Console.WriteLine(year); // и выводим на экран 

// ______________________________________________________________________________________________

// Вид 4  (Что то принимают, что то возвращают )


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = "";  // или String.Empty  // Создание пустой строки 

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string Method4(int count, string text)
// {

//     string result = "";  // или String.Empty  // Создание пустой строки 
//     for (int i = 0; i < count; i++)  // 1. инициализация счетчика(int i = 0). 2. Проверка условия (i < count). 3. инкремент(увеличение счетчика)(i++)
//     {
//         result = result + text;
//     }
//     return result;
// }



// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// ___________________________________________________________________________________________________

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// __________________________________________________________________________________________________

// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.


string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
        + "Винценгероде, вы бы взяли приступом согласие"
        + "прусского короля. Вы так красноречивы. Вы "
        + "дадите мне чаю?";

// string s = "qwerty"
//             012345
// s [3]  = "r"



// string Replace(string text, char oldValue, char newVaule)  // 4 вид методов
// {
//     string result = String.Empty;   // инициализация пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newVaule}";
//         else result =result + $"{text[i]}";
//     }

//     return result;

// }

// string newText = Replace(text, '', '|');
// Console.WriteLine(newText);

// почему то не работает

// ____________________________________________________________________________________________

int[] array = { 1, 5, 4, 3, 7, 6, 2, 1, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


// void SelectionSort(int[] array)  // для поиска минимального
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])  minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }

// }


void SelectionSort(int[] array)  // для поиска максимального 
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])  maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}
PrintArray(array);
SelectionSort(array);
PrintArray(array);


