namespace ProyectoPokemon;

public class Entrenador : IPorTurnos
{
    private string nombre;
    private List<Pokemon> equipo;
    private Pokemon activo;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public List<Pokemon> Equipo
    {
        get { return equipo; }
        set { equipo = value; }
    }

    public Pokemon Activo
    {
        get { return activo; }
        set { activo = value; }
    }

    public Entrenador(string nombre, List<Pokemon> listaPokemon)
    {
        this.Nombre = nombre;
        this.Equipo = listaPokemon;
        this.Activo = listaPokemon[0];
    }

    public void elegirEquipo(Pokemon pokemon)
    {
        if (pokemon is Pokemon)
        {
            this.Equipo.Add(pokemon);   
        }
    }

    public void cambiarActivo(int indexPokemonList)
    {
        this.Activo = this.Equipo[indexPokemonList];
    }

    public void elegirAtaque(int indexAtaque, Pokemon oponente)
    {
        Ataque ataqueElegido = this.activo.Ataques[indexAtaque];
        this.activo.atacar(oponente, ataqueElegido);
    }
    
    public void comenzarTurno()
    {
            Console.WriteLine($"{this.Nombre} comienza su turno.");
    }
    
    public void finalizarTurno()
    {
            Console.WriteLine($"{this.Nombre} finaliza su turno.");
    }
}