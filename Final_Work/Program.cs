Console.WriteLine("Введите текст");
string? text = Console.ReadLine();
#nullable disable
char[] variants = { ' ', ',', '.' };
string[] array = text.Split(variants);
Console.WriteLine();
Console.WriteLine("Ваш текст");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine("Ваши слова c количеством символов меньше или равно 3");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write("[" + string.Join(", ", array[i]) + "]");
    }
}

