namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if and else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else");

            Console.WriteLine("Kirjuta oma vanus");

            string userinput = Console.ReadLine();
            int userage = int.Parse(userinput);

            if (userage < 18)
            {
                Console.WriteLine("Oled alaealine");
            }
            else if (userage < 20)
            {
                Console.WriteLine("Oled oma kahekümnendates");
            }
            else if (userage < 30)
            {
                Console.WriteLine("Oled oma kolmekümnendates");
            }
            else if (userage < 40)
            {
                Console.WriteLine("Oled oma neljakümnendates");
            }
            else if (userage < 50)
            {
                Console.WriteLine("Oled oma viiekümnendates");
            }
            else if (userage < 60)
            {
                Console.WriteLine("Oled oma kuuekümnendates");
            }
            else if (userage < 70)
            {
                Console.WriteLine("Oled oma seitmsekümnendates");
            }
            else if (userage < 80)
            {
                Console.WriteLine("Oled oma kaheksakümnendates");
            }
            else if (userage < 90)
            {
                Console.WriteLine("Oled oma üheksakümnendates");
            }
            else if (userage > 100)
            {
                Console.WriteLine("Oled sa kindel, et panid oma vanuse õigesti?");
            }
        }
    }
}
