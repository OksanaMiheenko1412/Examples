// методы программирования -  лекция 3 ( четыре основные группы методов)
//Первая группа методов - методы, которые не принимают никаких аргуметов и 
// ничего не возвращают (void методы)
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); // как вызывается метод

// Вторая группа методов - методы, которые могут принимать аргументы, но
// ничего не возвращают ( void методы)
void Method2(string msd) // string msd - это аргументы
{
    Console.WriteLine(msd);
}
//Method2("Текст сообщения");

void Method21(string msd, int count) // string msd, int count - 
//это аргументы именованные
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msd);
        i++;
    }
    
}
Method21("Текст", 4);// Method21(msd:"Текст", count: 4) - явное наименование 
// аргумента string, при явном наименовании не обязательно писать по порядку,
// например: Method21(count: 4, msd:"Текст")


// Третья группа методов - методы, которые могут что-то возвращать,но не принимают
// аргументы, например, чтобы генерировать случайные данные. Если метод что-то
// возвращает, мы обязательно должны указать тип данных

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Четвертая группа методов - методы, которые принимают аргументы и могут
// что-то возвращать (наиболее часто используются)

string Method4(int count, string c) // char - новый тип данных
{
   int i = 0;
   string result = String.Empty;//String.Empty - изначально result будет
//пустой строкой
       while (i < count)
       {
        result = result + c;
        i++;
       }
       return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

// метод 4 через цикл for


string Method4(int count, string c) 
{  
    string result = String.Empty;
       for( int i = 0; i < count; i++)
       {
        result = result + c;
       }
       return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
