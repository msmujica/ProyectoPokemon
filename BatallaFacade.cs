namespace ProyectoPokemon
{
    public class BatallaFacade
    {
        private Batalla batalla;

        public BatallaFacade(Entrenador jugador, Entrenador oponente)
        {
            batalla = new Batalla(jugador, oponente);
        }

        public void iniciarBatalla()
        {
            batalla.iniciarBatalla();
        }

        public void ataqueJugador(int indiceAtaque)
        {
            batalla.procesarTurno();
        }

        public void mostrarEstadoPokemones()
        {
            Console.WriteLine($"{batalla.Jugador.Activo.Nombre} tiene {batalla.Jugador.Activo.Vida} de vida restante.");
            Console.WriteLine($"{batalla.JugadorOponente.Activo.Nombre} tiene {batalla.JugadorOponente.Activo.Vida} de vida restante.");
        }

        public void finalizarBatalla()
        {
            batalla.terminarBatalla();
        }
    }
}