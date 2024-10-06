using System.Collections;

namespace ProyectoPokemon;

public class Pokemon : ICombate, IPorTurnos
{
    private string nombre;
    private int vida;
    private Ataque ataqueEspecial;
    private List<Ataque> ataques;
    private List<Tipo> tipos;
    private bool estaDerrotado;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public Ataque AtaqueEspecial
    {
        get { return ataqueEspecial; }
        set { ataqueEspecial = value; }
    }

    public List<Ataque> Ataques
    {
        get { return ataques; }
        set { ataques = value; }
    }

    public List<Tipo> Tipos
    {
        get { return tipos; }
        set { tipos = value; }
    }

    public bool EstaDerrotado
    {
        get { return estaDerrotado; }
        set { estaDerrotado = value; }
    }

    public Pokemon(string nombre, int vida, Ataque especial, List<Ataque> ataques, List<Tipos> tipos)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.ataqueEspecial = especial;
        this.Ataques = ataques;
        this.Tipos = tipos;
        this.EstaDerrotado = true;
    }
}