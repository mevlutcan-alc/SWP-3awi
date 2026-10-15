
using System;

class Program 
{
    static void Main() 
    {
        Console.Write("Geben Sie eine natürliche Zahl ein: "); // erfragt eine natürliche Zahl vom Benutzer
        int zahl = Convert.ToInt32(Console.ReadLine()); // int = Speichert eine ganze Zahl.
                                                        // Convert.ToInt32 = Wandelt den Text in eine ganze Zahl um.

        Console.ReadLine() = Liest die Eingabe des Benutzers. 

        Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein,"); // WriteLine = Gibt Text aus und springt danach in die nächste Zeile.
        Console.WriteLine("um eine mathematische Operation auszuwählen:"); // WriteLine = Gibt Text aus und springt danach in die nächste Zeile.
        Console.WriteLine("1) Quadrat"); // WriteLine = Gibt Text aus und springt danach in die nächste Zeile.
        Console.WriteLine("2) Wurzel"); // WriteLine = Gibt Text aus und springt danach in die nächste Zeile.
        Console.WriteLine("3) Fakultät"); // WriteLine = Gibt Text aus und springt danach in die nächste Zeile.

        Console.Write("Ihre Auswahl: "); // Fordert den Benutzer auf, eine Auswahl einzugeben. Write bleibt dabei in derselben Zeile.
        int auswahl = Convert.ToInt32(Console.ReadLine()); // int = Speichert eine ganze Zahl. 
                                                           // Convert.ToInt32 = Wandelt den Text in eine ganze Zahl um. 
                                                           // Console.ReadLine() = Liest die Eingabe des Benutzers.
                                                           // Die Eingabe wird in der Variable "auswahl" gespeichert.


        switch (auswahl) // switch prüft, welche Zahl in auswahl gespeichert ist.
        {
            case 1: //Bedeutet: Wenn die Auswahl 1 ist, wird dieser Abschnitt ausgeführt.
                Console.WriteLine("Quadrat: " + (zahl * zahl)); // Berechnet das Quadrat der eingegebenen Zahl und gibt es aus.
                break; // eendet den aktuellen case-Abschnitt und verlässt das switch.

            case 2: //Bedeutet: Wenn die Auswahl 2 ist, wird dieser Abschnitt ausgeführt.
                Console.WriteLine("Wurzel: " + Math.Sqrt(zahl)); // Berechnet die Wurzel der eingegebenen Zahl und gibt sie aus.
                break;

            case 3:
                long fakultaet = 1;

                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }

                Console.WriteLine("Fakultät: " + fakultaet);
                break;

            default:
                Console.WriteLine("Ungültige Auswahl!"); // Wird ausgeführt, wenn keine der vorherigen Bedingungen erfüllt ist.
                break;
        }
    }
}