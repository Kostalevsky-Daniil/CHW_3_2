namespace ClassLibrary;

public static class Menu
{
    public static void MainMenu() // Класс - главное меню.
    {
        bool MainMenuFlag = true; // Когда флаг будет переходить в состояние false - пользователь выходит из меню.
        while (MainMenuFlag)
        {
            Console.WriteLine("Добро пожаловать в КДЗ 3_2!\n");
            ReadMenu();
        }
    }

    private static void ReadMenu() // Меню для считывания файла.
    {
        bool ReadMenuFlag = true; // Когда флаг будет переходить в состояние false - пользователь выходит из меню.
        while (ReadMenuFlag)
        {
            Console.Write("Введите абсолютный путь до файла или \"назад\", чтобы выйти из меню: ");
            string path = Console.ReadLine();
            if (path == "назад")
            {
                ReadMenuFlag = false;
            }
            else
            {
                ClassLibrary.ReadClass.Read(path);
            }
        }
    }
}