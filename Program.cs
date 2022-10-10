namespace PRAKTICHESKAYA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Octava();
        }
        static void Pervaya()
        {
            int[] octavaone = new int[11] { 261, 277, 293, 311, 329, 349, 369, 391, 415, 466, 493 };
            Console.WriteLine("Для выбора другой октавы вам нужно выйти в меню, чтобы выйти в меню выбора нажмите Escape");
            Console.WriteLine("Рабочие клавиши: z,x,c,v,b,n,m,a,s,d,f. ");
            do
            {
                ConsoleKeyInfo One = Console.ReadKey();
                if (One.Key == ConsoleKey.Z)
                {
                    Console.Beep(octavaone[0], 100);
                }
                if (One.Key == ConsoleKey.X)
                {
                    Console.Beep(octavaone[1], 100);
                }
                if (One.Key == ConsoleKey.C)
                {
                    Console.Beep(octavaone[2], 100);
                }
                if (One.Key == ConsoleKey.V)
                {
                    Console.Beep(octavaone[3], 100);
                }
                if (One.Key == ConsoleKey.B)
                {
                    Console.Beep(octavaone[4], 100);
                }
                if (One.Key == ConsoleKey.N)
                {
                    Console.Beep(octavaone[5], 100);
                }
                if (One.Key == ConsoleKey.M)
                {
                    Console.Beep(octavaone[6], 100);
                }
                if (One.Key == ConsoleKey.A)
                {
                    Console.Beep(octavaone[7], 100);
                }
                if (One.Key == ConsoleKey.S)
                {
                    Console.Beep(octavaone[8], 100);
                }
                if (One.Key == ConsoleKey.D)
                {
                    Console.Beep(octavaone[9], 100);
                }
                if (One.Key == ConsoleKey.F)
                {
                    Console.Beep(octavaone[10], 100);
                }
                if (One.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (true);
            Octava();
        }
        static void Vtoraya()
        {
            int[] octavatwo = new int[11] { 523, 554, 587, 622, 659, 698, 739, 783, 830, 932, 987 };          
            Console.WriteLine("Для выбора другой октавы вам нужно выйти в меню, чтобы выйти в меню выбора нажмите Escape");
            Console.WriteLine("Рабочие клавиши: z,x,c,v,b,n,m,a,s,d,f. ");
            do
            {
                ConsoleKeyInfo Two = Console.ReadKey();
                if (Two.Key == ConsoleKey.Z)
                {
                    Console.Beep(octavatwo[0], 100);
                }
                if (Two.Key == ConsoleKey.X)
                {
                    Console.Beep(octavatwo[1], 100);
                }
                if (Two.Key == ConsoleKey.C)
                {
                    Console.Beep(octavatwo[2], 100);
                }
                if (Two.Key == ConsoleKey.V)
                {
                    Console.Beep(octavatwo[3], 100);
                }
                if (Two.Key == ConsoleKey.B)
                {
                    Console.Beep(octavatwo[4], 100);
                }
                if (Two.Key == ConsoleKey.N)
                {
                    Console.Beep(octavatwo[5], 100);
                }
                if (Two.Key == ConsoleKey.M)
                {
                    Console.Beep(octavatwo[6], 100);
                }
                if (Two.Key == ConsoleKey.A)
                {
                    Console.Beep(octavatwo[7], 100);
                }
                if (Two.Key == ConsoleKey.S)
                {
                    Console.Beep(octavatwo[8], 100);
                }
                if (Two.Key == ConsoleKey.D)
                {
                    Console.Beep(octavatwo[9], 100);
                }
                if (Two.Key == ConsoleKey.F)
                {
                    Console.Beep(octavatwo[10], 100);
                }
                if (Two.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (true);
            Octava();
        }
        static void Octava()
        {
            Console.WriteLine("\n Вы в меню выбора октав, выберите действие: \n F1 - для первой актавы \n F2 - для второй актавы \n Если вы хотите закрыть программу нажмите: F3");
            ConsoleKeyInfo Octava1 = Console.ReadKey();
            if (Octava1.Key == ConsoleKey.F1)
            {
                Console.WriteLine("Вы переключились на 1 октаву.");
                Pervaya();
            }
            if (Octava1.Key == ConsoleKey.F2)
            {
                Console.WriteLine("Вы переключились на 2 октаву.");
                Vtoraya();
            }
            if (Octava1.Key == ConsoleKey.F3)
            {
                return;
            }
        }
    }
}