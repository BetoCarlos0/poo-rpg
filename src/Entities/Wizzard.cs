namespace poo_rpg.src.Entities
{
    public class Wizzard : Hero
    {
        public Wizzard(string name, int level, string herotype) : base(name, level, herotype)
        {
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int bonus)
        {
            return this.Name+ $" Lançou magia com bonus de {bonus} de dano";
        }
    }
}