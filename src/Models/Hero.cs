namespace JogoRPG.src.Models
{
    public abstract class Hero
    {
        public Hero(){}

        public Hero (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }
        public string Name {get; set;}
        public int Level{get; set;}
        public string HeroType {get; set;}

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Defence()
        {
               return this.Name + " " + " Polícia do Quintal  "; 
        }
    }
}