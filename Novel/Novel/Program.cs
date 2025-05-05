using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Novel
{
    class Program
    {
        static void Main()
        {
            ShowCredits();
            StartGame();
        }

        static void ShowCredits()
        {
            Console.WriteLine("Космические Хроники: Наследие Андромеды");
            Console.WriteLine("Автор: Зюмкин Никита | Группа: ИПО-21.23");
            Console.WriteLine("Нажмите любую клавишу для начала...");
            Console.ReadKey();
        }

        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в 2525 год, капитан!");
            Console.WriteLine("Вы командуете исследовательским судном 'Галактик'.");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            BeginStory();
        }

        static void BeginStory()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ваш корабль получает экстренный сигнал из системы TRAPPIST-1.");
                Console.WriteLine("Сканеры показывают:\n1. Искусственный объект земного происхождения\n2. Неизвестные энергетические колебания\n3. Слабые признаки жизни");

                Console.WriteLine("\nВаши действия?");
                Console.WriteLine("1. Отправить разведгруппу");
                Console.WriteLine("2. Просканировать объект");
                Console.WriteLine("3. Войти на орбиту для визуального осмотра");
                Console.WriteLine("4. Отправить сигнал ответа");
                Console.WriteLine("5. Покинуть систему");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SendAwayTeam();
                        break;
                    case 2:
                        ScanObject();
                        break;
                    case 3:
                        EnterOrbit();
                        break;
                    case 4:
                        SendResponseSignal();
                        break;
                    case 5:
                        LeaveSystem();
                        break;
                    default:
                        Console.WriteLine("\nНеизвестная команда. Система перезагружается...");
                        RestartGame();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("\nОшибка ввода! Попробуйте снова.");
                RestartGame();
            }
        }

        static void SendAwayTeam()
        {
            Console.Clear();
            Console.WriteLine("Разведгруппа отправляется к объекту...");
            Console.WriteLine("Они обнаруживают:");
            Console.WriteLine("1. Поврежденный исследовательский модуль");
            Console.WriteLine("2. Странные органические образования");
            Console.WriteLine("3. Вернуться на корабль");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InvestigateModule();
                    break;
                case 2:
                    ExamineOrganicFormations();
                    break;
                case 3:
                    ReturnToShip();
                    break;
                default:
                    ReturnToShip();
                    break;
            }
        }

        static void InvestigateModule()
        {
            Console.Clear();
            Console.WriteLine("В модуле вы находите поврежденные бортовые записи.");
            Console.WriteLine("Последняя запись: 'Они пробудились...'");
            GameState.CurrentEnding = "Концовка: Тревожное открытие";
            ShowEnding(GameState.CurrentEnding);
        }

        static void ExamineOrganicFormations()
        {
            Console.Clear();
            Console.WriteLine("Органические образования начинают двигаться!");
            Console.WriteLine("1. Собрать образец");
            Console.WriteLine("2. Отступить");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                GameState.CurrentEnding = "Концовка: Биологическая угроза";
            }
            else
            {
                GameState.CurrentEnding = "Концовка: Успешное отступление";
            }
            ShowEnding(GameState.CurrentEnding);
        }

        static void ReturnToShip()
        {
            Console.Clear();
            Console.WriteLine("Разведгруппа возвращается на корабль.");
            Console.WriteLine("Но что-то прилипло к скафандру...");
            GameState.CurrentEnding = "Концовка: Нежеланный гость";
            ShowEnding(GameState.CurrentEnding);
        }

        static void ScanObject()
        {
            Console.Clear();
            Console.WriteLine("Результаты сканирования:");
            Console.WriteLine("1. Объект идентифицирован как зонд 'Пионер-Х'");
            Console.WriteLine("2. Неизвестные модификации");
            Console.WriteLine("3. Энергетические импульсы");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DecodeTransmission();
                    break;
                case 2:
                    AnalyzeAlienTech();
                    break;
                case 3:
                    ActivateProbe();
                    break;
                default:
                    ContinueMission();
                    break;
            }
        }

        static void EnterOrbit()
        {
            Console.Clear();
            Console.WriteLine("Вы выходите на орбиту объекта.");
            Console.WriteLine("Сканеры фиксируют аномалии:");
            Console.WriteLine("1. Исследовать ближе");
            Console.WriteLine("2. Держаться на расстоянии");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                GameState.CurrentEnding = "Концовка: Гравитационная ловушка";
            }
            else
            {
                GameState.CurrentEnding = "Концовка: Осторожное наблюдение";
            }
            ShowEnding(GameState.CurrentEnding);
        }

        static void SendResponseSignal()
        {
            Console.Clear();
            Console.WriteLine("Вы отправляете ответный сигнал...");
            Console.WriteLine("1. Стандартный протокол");
            Console.WriteLine("2. Универсальный математический код");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                GameState.CurrentEnding = "Концовка: Ответ из темноты";
            }
            else
            {
                GameState.CurrentEnding = "Концовка: Математический контакт";
            }
            ShowEnding(GameState.CurrentEnding);
        }

        static void LeaveSystem()
        {
            Console.Clear();
            Console.WriteLine("Вы покидаете систему...");
            Console.WriteLine("Но сигнал продолжает преследовать вас.");
            GameState.CurrentEnding = "Концовка: Бегство";
            ShowEnding(GameState.CurrentEnding);
        }

        // Реализации остальных методов (DecodeTransmission, AnalyzeAlienTech и т.д.)
        static void DecodeTransmission()
        {
            Console.Clear();
            Console.WriteLine("Декодирование передачи...");
            Console.WriteLine("Сообщение: 'Бегите, пока не поздно'");
            GameState.CurrentEnding = "Концовка: Тревожное послание";
            ShowEnding(GameState.CurrentEnding);
        }

        static void AnalyzeAlienTech()
        {
            Console.Clear();
            Console.WriteLine("Анализ технологий...");
            Console.WriteLine("1. Попытаться скопировать");
            Console.WriteLine("2. Уничтожить образцы");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                GameState.CurrentEnding = "Концовка: Технологический прорыв";
            }
            else
            {
                GameState.CurrentEnding = "Концовка: Упреждающий удар";
            }
            ShowEnding(GameState.CurrentEnding);
        }

        static void ActivateProbe()
        {
            Console.Clear();
            Console.WriteLine("Активация зонда...");
            Console.WriteLine("Зонд просыпается и сканирует ваш корабль!");
            GameState.CurrentEnding = "Концовка: Пробуждение";
            ShowEnding(GameState.CurrentEnding);
        }

        static void ContinueMission()
        {
            Console.Clear();
            Console.WriteLine("Вы продолжаете миссию...");
            Console.WriteLine("Но странные сигналы не прекращаются.");
            GameState.CurrentEnding = "Концовка: Навязчивые сигналы";
            ShowEnding(GameState.CurrentEnding);
        }

        static void ShowEnding(string ending)
        {
            Console.Clear();
            Console.WriteLine($"=== {ending} ===");
            Console.WriteLine("\n1. Новая игра\n2. Выход");

            if (Console.ReadLine() == "1")
                RestartGame();
            else
                Environment.Exit(0);
        }

        static void RestartGame()
        {
            Console.Clear();
            StartGame();
        }
    }

    static class GameState
    {
        public static string CurrentEnding;
        public static bool AlienTechDiscovered;
        public static int CrewStatus = 5; // 1-5, где 5 - отличное состояние
    }
}