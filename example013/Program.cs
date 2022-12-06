// example013 - Дан текст,в котором нужно заменить черточками маленькие буквы "к",
// а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь,- что, "
            + "ежели бы вас послали вместо нашего Винценгероде,"
            + "вы бы взыли приступом согаъласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result; 
}

string newText = Replace(text, ' ' , '|'); 
Console.WriteLine(newText);// все пробелы текста заменились вертикальными черточками

// теперь на основе вышеприведенного метода укажем в аргументах символы,которые
// нужно заменить
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

