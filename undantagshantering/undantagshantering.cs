using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace Undantagshantering_och_Felsökning
{
    internal class Program
    {
        
        static void Main(string[] args)
           
        { 
            //Deklarerar en int "Guess", Den ska räkna antalet gissningar användaren gör.
            int Guess = 0;
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            //Skriver in 1, 21 i parantesen för att jag vill att den ska slumpa ett tal mellan 1-20
            int speltal = slumpat.Next(1, 21); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20.
            
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras
            
            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                 Int32.TryParse(Console.ReadLine(), out int tal);
                //Här väljer jag att antal "Guess" ska plussas på med 1 efter varje försök.
                Guess++;
                //Lägger in en Clear här för att det blir så fruktansvärt jobbigt annars med så mycket text.
                Console.Clear();
                /*Om användarens gissning är lägre än slumpat tal.
                Lägger till här att talet ska vara större än 0 för att kunne göra en else if om användaren skriver in fel*/
                if (tal < speltal && tal > 0)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                   
                }/*Om användarens gissning är högre än slumpat tal.
                Lägger till här att talet ska vara mindre än 21 för att kunne göra en else om personen skriver in fel*/
                if (tal > speltal && tal < 21)
                {                                                 
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                    spela = false;
  
                }
                 
                if (tal == speltal) { //Här lägger jag till "Guess" + försök för att den ska berätta för användaren antal försök.
                    Console.WriteLine("\tGrattis, du gissade rätt! Det tog dig " + Guess +" försök.");
                }
                /*/Vi använder oss av en else if här ifall användaren matar in bokstäver eller siffror som inte är imnellan 1-20.
                 Else if tal är mindre än 1 eller större än 20 så skriver den ut vårat felmedelande.*/
               else if (tal < 1 || tal > 20)
                {
                    Console.WriteLine("Du kan bara mata in ett tal mellan 1-20.");
                }
              
            }
            
        }
        


    } 
}
