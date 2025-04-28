namespace ActividadIntegradora {
    public abstract class Personaje : IAtaca, IEscapa, IEstaVivo {
        private int health;
        private int level;
        private int attackDamage;
        private string name;

        public string Name {
            get { return name; }
            protected set { name = value; }
        }

        public int Health {
            get { return health; }
            protected set { health = value; }
        }

        public int Level {
            get { return level; }
            protected set { level = value; }
        }

        public int AttackDamage {
            get { return attackDamage; }
            protected set { attackDamage = value; }
        }

        public Personaje(string name) {
            Name = name;
            Level = 1;
        }

        public void SubirNivel() {
            Level++;
            Health += 10;
            AttackDamage++; 
        }

        public void Atacar(IEstaVivo objetivo) {
            objetivo.RecibirDamage(AttackDamage);
        }

        public void Escapar() {}

        public void RecibirDamage(int damage) {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public bool EstaVivo() {
            return Health > 0;
        }

        public override string ToString() {
            return $"\nHéroe {Name}. Nivel: {Level}, Vida: {Health}, Daño de ataque: {AttackDamage}";
        }
    }
}



