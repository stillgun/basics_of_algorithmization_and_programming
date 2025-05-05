using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmicAdventure
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
            Console.WriteLine("Автор: Баканин Максим | Группа: ИПО-21.23");
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
                        ScanObject(); // Теперь этот метод реализован
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

        // Реализация метода ScanObject
        static void ScanObject()
        {
            Console.Clear();
            Console.WriteLine("=== Результаты сканирования ===");
            Console.WriteLine("1. Объект идентифицирован как исследовательский зонд 'Пионер-Х'");
            Console.WriteLine("2. Обнаружены следы модификаций неизвестными технологиями");
            Console.WriteLine("3. Зафиксированы слабые энергетические импульсы");

            Console.WriteLine("\nДальнейшие действия:");
            Console.WriteLine("1. Декодировать передачу зонда");
            Console.WriteLine("2. Проанализировать инопланетные модификации");
            Console.WriteLine("3. Отправить сигнал активации");
            Console.WriteLine("4. Игнорировать и продолжить миссию");

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
                case 4:
                    ContinueMission();
                    break;
                default:
                    Console.WriteLine("Неверный ввод! Автоматически выбрано продолжение миссии.");
                    ContinueMission();
                    break;
            }
        }

        // Реализация остальных методов
        static void DecodeTransmission()
        {
            Console.Clear();
            Console.WriteLine("Вы успешно декодировали передачу зонда:");
            Console.WriteLine("=== СООБЩЕНИЕ ===");
            Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ: ОБНАРУЖЕНА КВАНТОВАЯ АНОМАЛИЯ");
            Console.WriteLine("КООРДИНАТЫ: 47.34.12X 128.55.42Y");
            Console.WriteLine("РЕКОМЕНДАЦИЯ: ИЗБЕГАТЬ КОНТАКТА");

            GameState.CurrentEnding = "Концовка: Тайное предупреждение";
            ShowEnding(GameState.CurrentEnding);
        }

        static void AnalyzeAlienTech()
        {
            Console.Clear();
            Console.WriteLine("Анализ показывает:");
            Console.WriteLine("- Технологии превосходят земные на 200 лет");
            Console.WriteLine("- Присутствуют биомеханические компоненты");
            Console.WriteLine("- Обнаружены следы ДНК неизвестного происхождения");

            Console.WriteLine("\n1. Попытаться скопировать технологии");
            Console.WriteLine("2. Уничтожить зонд из соображений безопасности");

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
            Console.WriteLine("При активации зонд начинает трансляцию:");
            Console.WriteLine("=== ПЕРЕДАЧА ===");
            Console.WriteLine("ПРИВЕТСТВИЕ, ЗЕМЛЯНЕ. МЫ - ХРАНИТЕЛИ.");
            Console.WriteLine("ВАША ЦИВИЛИЗАЦИЯ ДОСТИГЛА КРИТИЧЕСКОГО УРОВНЯ.");
            Console.WriteLine("ПОДГОТОВЬТЕСЬ К ИСПЫТАНИЮ.");

            GameState.CurrentEnding = "Концовка: Первый контакт";
            ShowEnding(GameState.CurrentEnding);
        }

        static void ContinueMission()
        {
            Console.Clear();
            Console.WriteLine("Вы решили продолжить свою миссию...");
            Console.WriteLine("Но сигнал зонда продолжает преследовать ваш корабль.");
            Console.WriteLine("Через 3 дня экипаж начинает сообщать о странных видениях.");

            GameState.CurrentEnding = "Концовка: Неизбежный контакт";
            ShowEnding(GameState.CurrentEnding);
        }

        // Остальные обязательные методы
        static void SendAwayTeam() { /* реализация */ }
        static void EnterOrbit() { /* реализация */ }
        static void SendResponseSignal() { /* реализация */ }
        static void LeaveSystem() { /* реализация */ }

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
        public static bool ArtifactActivated;
        public static int CrewMembers = 5;
    }
}