namespace assig1oop
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Console.WriteLine("Days of the week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion
        }
        static void Main()
        {
            #region Q2
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, true, out Season season))
            {

                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
            }

        }
        #endregion
        #region Q3
        static void Permissions1()
        {


            Permissions userPermissions = Permissions.None;

            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;
            Console.WriteLine("Current Permissions: " + userPermissions);

            if ((userPermissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission is granted.");
            }
            else
            {
                Console.WriteLine("Read permission is not granted.");
            }

            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Permissions after removal: " + userPermissions);

            if ((userPermissions & Permissions.Write) == Permissions.Write)
            {
                Console.WriteLine("Write permission is granted.");
            }
            else
            {
                Console.WriteLine("Write permission is not granted.");
            }


        }
        #endregion
        #region Q4
        static void colors()
        {

            Console.WriteLine("Enter a color (Red, Green, Blue):");
            string userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, true, out Colors color))
            {

                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter one of the following: Red, Green, Blue.");
            }



            #endregion
        }

    }
}
