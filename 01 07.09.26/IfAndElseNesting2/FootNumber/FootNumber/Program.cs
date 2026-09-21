namespace FootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Teha jalanumbri suurusest üks if ja else harjutus.
            //Esimene tingimus on jalanumbri 30-33 (siin on tekst roheline)
            //teine jalanumbri 34-38 (siin on tagataust valge),
            //kolmas jalanumbri 39-44 (siin on tekst sinine ja taataust kollane
            //neljas jalanumbri 45-48 (siin teeb arvuti häält beep)
            //kindlasti tuleb ära lahendada olukord,
            //kus kasutatakse mõnda teist jalanumbrit
            Console.WriteLine("Hello, World!");

            Console.WriteLine("sisesta jalanumber");
            int jalanumber = int.Parse(Console.ReadLine());

            if (jalanumber >= 30 && jalanumber <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sinu jalanumber on 30-33");
            }
            else if (jalanumber >= 34 && jalanumber <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Sinu jalanumber on 34-38");  
            }
            else if (jalanumber >=39 && jalanumber <=44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sinu jalanumber on 39-44");
            }
            else if (jalanumber >= 45 && jalanumber <= 48)
            {
                Console.Beep();
                Thread.SpinWait(1000);
                Console.Beep();
                Thread.SpinWait(1000);
                Console.Beep();
                Thread.SpinWait(1000);
                Console.Beep();
                Thread.SpinWait(1000);
                Console.WriteLine("Sinu jalanumber on 45-48");

            }
            else
            {
                Console.WriteLine("Mõni muu jalanumber");
            }
        }
    }
}
