
using System;

class Program
{
    static void Main()
    {
        Console.Write("Eingabe: ");
        string eingabe = Console.ReadLine() ?? ""; 

        if (int.TryParse(eingabe, out int zahl))
        {
            Console.WriteLine("Sie haben eine ganze Zahl eingegeben.");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultät");
            Console.WriteLine("5) Wurzelziehen");

            string auswahl = Console.ReadLine() ?? "";

            if (auswahl == "1" || auswahl == "2" || auswahl == "3")
            {
                Console.Write("Zweite Zahl: ");

                if (int.TryParse(Console.ReadLine(), out int zahl2))
                {
                    if (auswahl == "1")
                        Console.WriteLine("Ergebnis: " + ((long)zahl + zahl2));

                    else if (auswahl == "2")
                        Console.WriteLine("Ergebnis: " + ((long)zahl * zahl2));

                    else if (zahl2 != 0)
                        Console.WriteLine("Ergebnis: " + ((double)zahl / zahl2));

                    else
                        Console.WriteLine("Division durch 0 ist nicht möglich.");
                }
                else
                    Console.WriteLine("Ungültige Zahl.");
            }
            else if (auswahl == "4")
            {
                if (zahl < 0 || zahl > 20)
                    Console.WriteLine("Zahl muss zwischen 0 und 20 liegen.");
                else
                {
                    long ergebnis = 1;

                    for (int i = 1; i <= zahl; i++)
                        ergebnis *= i;

                    Console.WriteLine("Ergebnis: " + ergebnis);
                }
            }
            else if (auswahl == "5")
            {
                if (zahl < 0)
                    Console.WriteLine("Keine reelle Wurzel möglich.");
                else
                    Console.WriteLine("Ergebnis: " + Math.Sqrt(zahl));
            }
            else
                Console.WriteLine("Ungültige Auswahl.");
        }
        else
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingegeben.");
            Console.WriteLine("1) Selbstlaute entfernen");
            Console.WriteLine("2) Zeichenkette umdrehen");
            Console.WriteLine("3) Anzahl der Zeichen");

            string auswahl = Console.ReadLine() ?? "";

            if (auswahl == "1")
            {
                foreach (char c in "aeiouAEIOU")
                    eingabe = eingabe.Replace(c.ToString(), "");

                Console.WriteLine(eingabe);
            }
            else if (auswahl == "2")
            {
                char[] zeichen = eingabe.ToCharArray();
                Array.Reverse(zeichen);

                Console.WriteLine(new string(zeichen));
            }
            else if (auswahl == "3")
                Console.WriteLine("Anzahl: " + eingabe.Length);
            else
                Console.WriteLine("Ungültige Auswahl.");
        }
    }
}

