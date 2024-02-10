using ClassLibrary;

class Program
{
    static void Main()
    {
        try
        {
            do
            {
                Menu.MainMenu();
                Console.WriteLine("Нажмите ESC, чтобы выйти из программы.\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}