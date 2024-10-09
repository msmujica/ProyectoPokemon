namespace ProyectoPokemon;

public class Batalla
{
    private Entrenador jugador;
    private Entrenador jugadorOponente;
 Fachada
    

    private bool turno;
 master

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

    public bool Turno
    {
        get { return turno; }
        set { turno = value; }
    }

    public Batalla(Entrenador jugador, Entrenador oponente)
    {
        this.Jugador = jugador;
        this.JugadorOponente = oponente;
        this.Turno = true;
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
        if (turno)
        {
            if (!this.Jugador.Activo.EstaDerrotado)
            {
                this.Jugador.Activo.mostrarAtaques();
                int ataqueIndex = int.Parse(Console.ReadLine());
                this.Jugador.elegirAtaque(ataqueIndex, this.JugadorOponente.Activo);
            }   
        }
        else
        {
            
            if (!this.JugadorOponente.Activo.EstaDerrotado)
            {
                this.JugadorOponente.Activo.mostrarAtaques();
                int ataqueIndex = int.Parse(Console.ReadLine());
                this.JugadorOponente.elegirAtaque(ataqueIndex, this.Jugador.Activo);
            }
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