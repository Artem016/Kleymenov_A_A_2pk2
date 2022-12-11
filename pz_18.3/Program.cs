namespace pz_18._3
{
    internal class Program
    {
        enum Marks {Dead = 1, NotEnough, Enough, Good, Great, GodLike};
        enum Seasons {Summer, Autumn, Winter, Spring  }

        static void Main(string[] args)
        {
            Console.Write("Введите свою оценку: ");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case (int)Marks.Dead:
                    Console.WriteLine("Значение оценик: очень плохо.");
                    break;

                case (int)Marks.NotEnough:
                    Console.WriteLine("Значение оценик: не удовлетворительно.");
                    break;

                case (int)Marks.Enough:
                    Console.WriteLine("Значение оценик: удовлетворительно.");
                    break;

                case (int)Marks.Good:
                    Console.WriteLine("Значение оценик: хорошо.");
                    break;

                case (int)Marks.Great:
                    Console.WriteLine("Значение оценик: отлично.");
                    break;

                case (int)Marks.GodLike:
                    Console.WriteLine("Не ври.");
                    break;

                default:
                    Console.WriteLine("Неизвестная оценка.");
                    break;
            }

            //Задание 2.
            //Переменные и массивы.
            string[] seasons = new string[] { "summer", "autumt", "winter", "spring" };

            string[] season_holly_summer = new string[]
            {
                "Международный день защиты детей — 01 июня",
                "Пушкинский день | День русского языка — 06 июня",
                "Троица | День Святой Троицы — 12 июня (в 2022 году)"
            };

            string[] season_holly_autumt = new string[]
            {
                "День знаний (Первый звонок) - 01 сентября",
                "День окончания Второй мировой войны - 2 сентября",
                "Международный день мира - 21 сентября"
            };

            string[] season_holly_winter = new string[]
            {
                "Новый год 31 - декабря",
                "Рождество - 7 января",
                "Старый Новый год — 14 января"
            };

            string[] season_holly_spring = new string[]
            {
                "День моряка-подводника — 19 марта",
                "День Балтийского моря — 22 марта",
                "День победы русских воинов князя Александра Невского над немецкими рыцарями на \n" +
                "Чудском озере (Ледовое побоище) (День воинской славы России) — 18 апреля"
            };

            //Реализация.
            Console.WriteLine("Введите название сезона (summer, autumn, winter, spring).");
            Seasons user_season = (Seasons)Array.IndexOf(seasons, Console.ReadLine());

            switch (user_season)
            {
                case Seasons.Summer:
                    Console.WriteLine("Праздники на промежутке данного сезона: ");
                    foreach (string holyday in season_holly_summer)
                    {
                        Console.WriteLine(holyday);
                    }
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Праздники на промежутке данного сезона: ");
                    foreach (string holyday in season_holly_autumt)
                    {
                        Console.WriteLine(holyday);
                    }
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Праздники на промежутке данного сезона: ");
                    foreach (string holyday in season_holly_winter)
                    {
                        Console.WriteLine(holyday);
                    }
                    break;
                case Seasons.Spring:
                    Console.WriteLine("Праздники на промежутке данного сезона: ");
                    foreach (string holyday in season_holly_spring)
                    {
                        Console.WriteLine(holyday);
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}