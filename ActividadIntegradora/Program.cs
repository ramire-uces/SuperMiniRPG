using System;

namespace ActividadIntegradora {
    public delegate void MostrarMensaje(string mensaje);

    class Program {
        static void Main(string[] args) {
            MostrarMensaje mensaje = Console.WriteLine;
            Juego juego = new Juego(mensaje);

            juego.MostrarBienvenida();

            Console.Write("> ");
            string nombreJugador = Console.ReadLine();

            Personaje jugador = null;
            string opcion;

            do {
                juego.MostrarClaseDePersonaje();
                Console.Write("> ");
                opcion = Console.ReadLine();

                if (opcion == "1") {
                    jugador = new Guerrero(nombreJugador);
                } else if (opcion == "2") {
                    jugador = new Mago(nombreJugador);
                } else {
                    juego.MostrarErrorDeAccion();
                    continue;
                }
            } while (jugador == null);

            Enemigo enemigo = new Random().Next(0, 2) == 0 ? new Goblin() : new Orco();

            while (enemigo.EstaVivo() && jugador.EstaVivo()) {
                juego.MostrarAcciones(jugador, enemigo);
                Console.Write("> ");
                string accion = Console.ReadLine();

                switch (accion) {
                    case "1":
                        jugador.Atacar(enemigo);
                        juego.MostrarAtaque(jugador, enemigo);
                        break;

                    case "2":
                        if (jugador is Mago mago) {
                            mago.LanzarHechizo(enemigo);
                            juego.MostrarHechizo(jugador, enemigo);
                        } else if (jugador is Guerrero guerrero) {
                            if (guerrero.BloquearYContraataque(enemigo)) {
                                juego.MostrarBloqueoYContraataque(jugador, enemigo);
                            } else {
                                juego.MostrarFalloDeBloqueo(jugador);
                                enemigo.Atacar(jugador);
                            }
                        }
                        break;

                    case "3":
                        jugador.Escapar();
                        juego.MostrarEscape();
                        return;

                    default:
                        juego.MostrarErrorDeAccion();
                        enemigo.Atacar(jugador);
                        break;
                }
            }

            if (!jugador.EstaVivo()) {
                juego.MostrarDerrota();
                return;
            }
        }
    }
}





