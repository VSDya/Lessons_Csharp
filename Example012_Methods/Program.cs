// Вид 1 (Ничего не принимают и ничего не возвращают)
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();











// Вид2 (ничего не возвращает, но в то же время могут применять какие то аргументы)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// или если не одно сообщение, то:
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст, count: 4");
Method21(count: 4, msg: "новый текст");



// Вид3 (если метод что то возвращает но ничего не принимает
// то нужно указать тип данных что мы будем возвращать)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);




// Вид4 (что то принимают и что то возвращают)
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "new method ");
Console.WriteLine(res);





