namespace ProyectoPokemon;

public class Tipos
{
    private string nombre;
    private List<Tipos> debilidades;
    private List<Tipos> fortalezas;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public List<Tipos> Debilidades
    {
        get { return debilidades; }
        set { debilidades = value; }
    }

    public List<Tipos> Fortalezas
    {
        get { return fortalezas; }
        set { fortalezas = value; }
    }

    public Tipos(string nombre)
    {
        this.Nombre = nombre;
    }

    public void agregarDebilidades(Tipos tipo)
    {
        this.Debilidades.Add(tipo);
    }
    
    public void agregarFortalezas(Tipos tipo)
    {
        this.Fortalezas.Add(tipo);
    }
    
    public void eliminarDebilidades(Tipos tipo)
    {
        this.Debilidades.Remove(tipo);
    }
    
    public void eliminarFortalezas(Tipos tipo)
    {
        this.Fortalezas.Remove(tipo);
    }

    public int multiplicadorDaño(Tipos tipoAtaque)
    {
        if (this.Debilidades.Contains(tipoAtaque))
        {
            return 2;
        }

        if (this.Fortalezas.Contains(tipoAtaque))
        {
            return 1;
        }

        return 0;
    }
}