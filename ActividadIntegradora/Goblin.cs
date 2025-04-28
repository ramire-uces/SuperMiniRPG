namespace ActividadIntegradora {
    public class Goblin : Enemigo {
        public Goblin() {
            Health = 15;
            AttackDamage = 2;
        }

        public override void Atacar(IEstaVivo objetivo) {
            objetivo.RecibirDamage(AttackDamage);
        }
    }
}
