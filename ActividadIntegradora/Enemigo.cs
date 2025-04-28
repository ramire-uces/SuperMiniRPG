namespace ActividadIntegradora {
    public abstract class Enemigo : IAtaca, IEstaVivo {
        private int health;
        private int attackDamage;

        public int Health {
            get { return health; }
            protected set { health = value; }
        }

        public int AttackDamage {
            get { return attackDamage; }
            protected set { attackDamage = value; }
        }

        public Enemigo() {}

        public abstract void Atacar(IEstaVivo objetivo);

        public void RecibirDamage(int damage) {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public bool EstaVivo() {
            return Health > 0;
        }

        public override string ToString() {
            return $"Enemigo - Vida: {Health}, Daño de ataque: {AttackDamage}";
        }
    }
}




