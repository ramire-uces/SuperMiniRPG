using System;

namespace ActividadIntegradora {
    public class Mago : Personaje {
        public int SpellDamage { get; private set; }

        public Mago(string name) : base(name) {
            Health = 12;
            AttackDamage = 8;
            SpellDamage = 20;
        }

        public void LanzarHechizo(IEstaVivo objetivo) {
            objetivo.RecibirDamage(SpellDamage);
        }

        public override string ToString() {
            return base.ToString() + $", Daño Mágico: {SpellDamage}.";
        }
    }
}
