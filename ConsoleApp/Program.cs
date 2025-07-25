using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть шлях до вихідного файлу: ");
string sourcePath = Console.ReadLine();

Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
string destinationPath = Console.ReadLine();

try
{
    if (!File.Exists(sourcePath))
    {
        Console.WriteLine("Помилка: вихідний файл не знайдено.");
        return;
    }

    File.Copy(sourcePath, destinationPath, overwrite: true);

    Console.WriteLine("Файл успішно скопійовано!");
}
catch (Exception ex)
{
    Console.WriteLine("Сталася помилка при копіюванні файлу:");
    Console.WriteLine(ex.Message);
}