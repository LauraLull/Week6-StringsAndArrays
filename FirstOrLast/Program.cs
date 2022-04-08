using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestage oma perekonnanimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine("" + "");

            int firstNameLenght = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLenght} sümbolit ja perekonnanimes {lastNameLength} sümbolit.");

            if (firstNameLenght > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else if (firstNameLenght < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on sama pikkusega.");
            }
        }
    }
}
