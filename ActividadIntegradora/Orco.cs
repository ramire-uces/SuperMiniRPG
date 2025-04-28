namespace ActividadIntegradora {
    public class Orco : Enemigo {
        public Orco() {
            Health = 40;
            AttackDamage = 3; 
        }

        public override void Atacar(IEstaVivo objetivo) {
            objetivo.RecibirDamage(AttackDamage);
        }
    }
}
