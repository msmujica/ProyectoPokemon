namespace ProyectoPokemon;

public interface ICombate
{
    void atacar(Pokemon oponente, Ataque ataque);
    void recibirDaño(int daño);
}