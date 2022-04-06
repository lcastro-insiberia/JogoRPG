namespace JogoRPG.src.Models
{
    public class Owl : Hero
    {
        public Owl (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Defence()
        {
            return this.Name + " " + "Agente Secreta do Quintal ";

        }

        public  string Defence(int Bonus)
        {
            if(Bonus > 5)
            {
                return this.Name + " Monitorar o Rato e informar o Gato " + Bonus;
            }
            else 
            {
                return this.Name + " zzzz... Dormiu no trabalho! " + Bonus;
            }
            
        }
    }
}