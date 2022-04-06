namespace JogoRPG.src.Models
{
    public class Enemy : Hero
    {
         public Enemy (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Defence()
        {
            return this.Name + " " + "Criminoso do Quintal ";

        }

        public string Defence(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Fugiu do Gato " + Bonus;
            }
            else 
            {
                return this.Name + " Foi preso pelo Gato " + Bonus;
            }
            
        }
    }
}