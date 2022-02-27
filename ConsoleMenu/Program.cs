using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userCommand;
            string userName = "";
            string changeColorTextCommand;
            string userPassword = "";
            string confirmationPassword;
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Введите команду: " +
                                  "\n-----------------" +
                                  "\nSetName" +
                                  "\n-----------------" +
                                  "\nChangeConsoleColor" +
                                  "\n-----------------" +
                                  "\nSetPassword" +
                                  "\n-----------------" +
                                  "\nWriteName" +
                                  "\n-----------------" +
                                  "\nEsc" +
                                  "\n-----------------");
                Console.SetCursorPosition(17, 0);
                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case "SetName":
                        Console.Clear();
                        if (userPassword.Equals(String.Empty))
                        {
                            Console.Write("Введите новое имя: ");
                            userName = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Введите пароль: ");
                            confirmationPassword = Console.ReadLine();
                            if (confirmationPassword.Equals(userPassword))
                            {
                                Console.Write("Введите новое имя: ");
                                userName = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Пароль введен неверно!");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "ChangeConsoleColor":
                        Console.Clear();
                        Console.WriteLine("Выберите цвет: " +
                                          "\n-------" +
                                          "\nЗеленый" +
                                          "\n-------" +
                                          "\nКрасный" +
                                          "\n-------" +
                                          "\nСиний" +
                                          "\n-------" +
                                          "\nЖелтый" +
                                          "\n-------" +
                                          "\nБелый" +
                                          "\n-------");
                        Console.SetCursorPosition(15, 0);
                        changeColorTextCommand = Console.ReadLine();
                        switch (changeColorTextCommand)
                        {
                            case "Зелёный":
                            case "Зеленый":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Красный":
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            case "Синий":
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            case "Жёлтый":
                            case "Желтый":
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            case "Белый":
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            default:
                                Console.ResetColor();
                                break;
                        }
                        break;
                    case "SetPassword":
                        Console.Clear();
                        if(userPassword.Equals(String.Empty))
                        {
                            Console.Write("Введите новый пароль: ");
                            userPassword = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Введите старый пароль: ");
                            confirmationPassword = Console.ReadLine();
                            if (confirmationPassword.Equals(userPassword))
                            {
                                Console.Write("Введите новый пароль: ");
                                userPassword = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Пароль введен неверно!");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "WriteName":
                        Console.Clear();
                        if (userPassword.Equals(String.Empty))
                        {
                            Console.Write(userName);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Введите пароль: ");
                            confirmationPassword = Console.ReadLine();
                            if (confirmationPassword.Equals(userPassword))
                            {
                                Console.WriteLine(userName);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Пароль введен неверно!");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "Esc":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой команды :/");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Выход...");
        }
    }
}