using System;

namespace ActividadIntegradora {
    public class Juego {
        private MostrarMensaje _mensaje;

        public Juego(MostrarMensaje mensaje) {
            _mensaje = mensaje;
        }

        public void MostrarBienvenida() {
            _mensaje("Bienvenido a la aventura.");
            _mensaje("Por favor, ingresa el nombre de tu personaje.");
        }

        public void MostrarAcciones(Personaje jugador, Enemigo enemigo) {
            _mensaje($"\n{jugador.Name} ❤︎ {jugador.Health}  |  Enemigo ❤︎ {enemigo.Health}");
            _mensaje("\n¿Qué quieres hacer, héroe?");
            _mensaje("1. Atacar");
            _mensaje("2. Habilidad");
            _mensaje("3. Escapar");
        }

        public void MostrarAtaque(Personaje jugador, Enemigo enemigo) {
            _mensaje("\nHas acertado un buen golpe!");

            if (enemigo.EstaVivo()) {
                enemigo.Atacar(jugador);
                _mensaje("Pero el enemigo ha atacado también, auch!");
            } else {
                _mensaje("Victoria! Has derrotado al enemigo!");
                jugador.SubirNivel();
                _mensaje(jugador.ToString());
            }
        }

        public void MostrarHechizo(Personaje jugador, Enemigo enemigo) {
            _mensaje("\nHas lanzado un hechizo!");

            if (enemigo.EstaVivo()) {
                enemigo.Atacar(jugador);
                _mensaje("Pero el enemigo ha atacado también, auch!");
            } else {
                _mensaje("Victoria! El enemigo ha muerto por tu poderoso hechizo!");
                jugador.SubirNivel();
                _mensaje(jugador.ToString());
            }
        }

        public void MostrarBloqueoYContraataque(Personaje jugador, Enemigo enemigo) {
            _mensaje("\nHas bloqueado el ataque con éxito y contraatacado!");

            if (!enemigo.EstaVivo()) {
                _mensaje("Victoria! El enemigo ha muerto por tu contraataque!");
                jugador.SubirNivel();
                _mensaje(jugador.ToString());
            }
        }

        public void MostrarFalloDeBloqueo(Personaje jugador) {
            _mensaje("\nNo lograste bloquear el ataque, auch!");
        }

        public void MostrarErrorDeAccion() {
            _mensaje("\nOpción no válida ('1', '2', '3'). Pierdes tu turno...");
            _mensaje("El enemigo te ataca por tu error!");
        }

        public void MostrarEscape() {
            _mensaje("\n¡Has escapado exitosamente! Como un debilucho...");
        }

        public void MostrarDerrota() {
            _mensaje("\n¡Has sido derrotado! Tu aventura termina acá...");
        }
    }
}
