namespace SimpleCode_Course_Part_2;

/// <summary>
/// ИНКАПСУЛЯЦИЯ C#
/// | примеры инкапсуляции с объяснением
/// | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ
/// | # 58
/// </summary>
public class Lesson_58
{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            isLoaded = true;
            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }

            Console.WriteLine("Пыщ - Пыщ\n");
            isLoaded = false;
        }
    }
    
    public static void Start()
    {
        Start_1();
    }

    static void Start_1()
    {
        Gun gun = new Gun();
        gun.Shoot();
    }
}