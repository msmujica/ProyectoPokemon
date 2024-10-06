namespace ProyectoPokemon;

public class Ataque
{
    private string nombre;
    private int daño;
    private List<Tipo> tipo;
    private bool especial;
    
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Daño
    {
        get { return daño; }
        set { daño = value; }
    }

    public List<Tipo> Tipos
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public bool Especial
    {
        get { return especial; }
        set { especial = value; }
    }

    public Ataque(string nombre, int daño, List<Tipo> tipo, bool especial)
    {
        this.Nombre = nombre;
        this.Daño = daño;
        this.Tipos = tipo;
        this.Especial = especial;
    }

    public void agregarTipo(Tipo tipo)
    {
        this.Tipos.Add(tipo);
    }
}