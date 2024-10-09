using ProyectoPokemon;
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main(string[] args)
    {
        // Crear tipos
        Tipos fuego = new Tipos("Fuego");
        Tipos agua = new Tipos("Agua");

        // Definir debilidades y fortalezas
        fuego.agregarDebilidades(agua);
        agua.agregarFortalezas(fuego);

        // Crear ataques
        Ataque lanzallamas = new Ataque("Lanzallamas", 40, new List<Tipos> { fuego }, false);
        Ataque pistolaAgua = new Ataque("Pistola de Agua", 30, new List<Tipos> { agua }, false);

        // Crear Pokémon y agregarlos a la Pokedex
        Pokemon charmander = new Pokemon("Charmander", 100, lanzallamas, new List<Ataque> { lanzallamas }, new List<Tipos> { fuego });
        Pokemon squirtle = new Pokemon("Squirtle", 100, pistolaAgua, new List<Ataque> { pistolaAgua }, new List<Tipos> { agua });
        Pokemon bulbasaur = new Pokemon("Bulbasaur", 100, null, new List<Ataque>(), new List<Tipos>()); // Ejemplo sin ataques definidos

        Pokedex.agregarPokemon(charmander);
        Pokedex.agregarPokemon(squirtle);
        Pokedex.agregarPokemon(bulbasaur);

        // Crear entrenadores
        Entrenador ash = new Entrenador("Ash");
        Entrenador misty = new Entrenador("Misty");

        // Los entrenadores eligen sus equipos
        Console.WriteLine("Ash elige su equipo:");
        ash.elegirEquipo();

        Console.WriteLine("Misty elige su equipo:");
        misty.elegirEquipo();

        // Crear la fachada para la batalla
        BatallaFacade batallaFacade = new BatallaFacade(ash, misty);

        // Iniciar la batalla
        batallaFacade.iniciarBatalla();

        // Ash ataca con su primer ataque
        batallaFacade.ataqueJugador(0); // Ash elige su ataque

        // Mostrar estado de los Pokémon
        batallaFacade.mostrarEstadoPokemones();

        // Misty ataca con su primer ataque
        batallaFacade.ataqueJugador(0); // Misty elige su ataque

        // Finalizar la batalla
        batallaFacade.finalizarBatalla();
    }
}
