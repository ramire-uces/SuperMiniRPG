namespace ActividadIntegradora {
    public class Guerrero : Personaje {
        private Random random = new Random();
        public double ProbabilidadBloqueo { get; private set; }

        public Guerrero(string name) : base(name) {
            Health = 20;
            AttackDamage = 10;
            ProbabilidadBloqueo = 0.5;
        }

        public bool BloquearYContraataque(Enemigo enemigo) {
            if (random.NextDouble() < ProbabilidadBloqueo) {
                int damageContraataque = enemigo.AttackDamage * 2;
                enemigo.RecibirDamage(damageContraataque);
                return true;
            }
            return false;
        }

        public override string ToString() {
            return base.ToString() + $", Probabilidad de Bloqueo: {ProbabilidadBloqueo * 100}%";
        }
    }
}

