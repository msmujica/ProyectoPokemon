namespace ProyectoPokemon;

public class Batalla
{
    private Entrenador jugador;
    private Entrenador jugadorOponente;
    

    public Entrenador Jugador
    {
        get { return jugador; }
        set { jugador = value; }
    }

    public Entrenador JugadorOponente
    {
        get { return jugadorOponente; }
        set { jugadorOponente = value; }
    }

    public Batalla(Entrenador jugador, Entrenador oponente)
    {
        this.Jugador = jugador;
        this.JugadorOponente = oponente;
    }
    
    public void iniciarBatalla() 
    { 
        Console.WriteLine("¡Comienza la batalla!"); 
        this.Jugador.comenzarTurno(); 
        this.JugadorOponente.comenzarTurno();
    } 
    
    public void terminarBatalla() 
    { 
        Console.WriteLine("¡La batalla ha terminado!"); 
    }

    public void procesarTurno()
    {
        if (!this.Jugador.Activo.EstaDerrotado)
        {
            this.Jugador.Activo.mostrarAtaques();
            int ataqueIndex = int.Parse(Console.ReadLine());
            this.Jugador.elegirAtaque(ataqueIndex, this.JugadorOponente.Activo);
        }
    }
    public void procesarTurnoOponente(int ataqueIndex)
    {
        if (!this.JugadorOponente.Activo.EstaDerrotado)
        {
            this.JugadorOponente.elegirAtaque(ataqueIndex, this.Jugador.Activo);
        }
    }

}