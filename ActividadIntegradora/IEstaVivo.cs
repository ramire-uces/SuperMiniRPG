namespace ActividadIntegradora {
    public interface IEstaVivo {
        int Health { get; }
        void RecibirDamage(int damage);
        bool EstaVivo(); 
    } 
}
