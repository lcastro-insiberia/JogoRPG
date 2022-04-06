using System; 
using JogoRPG.src.Models;

class Program
    {

        static void Main (string[] args)
        {
            MyCat cat = new MyCat("Gato", 87, "Policial de rua");
            Owl owl = new Owl("Coruja", 88, "Policia secreta");          
            Enemy rat = new Enemy("Rato", 88, "Criminal"); 
            Console.WriteLine(cat.Defence());
            Console.WriteLine(owl.Defence());
            Console.WriteLine(rat.Defence());
        }
    }