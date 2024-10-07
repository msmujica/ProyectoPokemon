using System;
using System.Collections.Generic;
using ProyectoPokemon;

// Crear tipos
Tipos fuego = new Tipos("Fuego");
Tipos agua = new Tipos("Agua");

// Definir debilidades y fortalezas
fuego.agregarDebilidades(agua); // Fuego es débil contra Agua
agua.agregarFortalezas(fuego); // Agua es fuerte contra Fuego

// Crear ataques
Ataque lanzallamas = new Ataque("Lanzallamas", 40, new List<Tipos> { fuego }, false);
Ataque pistolaAgua = new Ataque("Pistola de Agua", 30, new List<Tipos> { agua }, false);

// Crear Pokémon
Pokemon charmander = new Pokemon("Charmander", 100, lanzallamas, new List<Ataque> { lanzallamas },
    new List<Tipos> { fuego });
Pokemon squirtle =
    new Pokemon("Squirtle", 100, pistolaAgua, new List<Ataque> { pistolaAgua }, new List<Tipos> { agua });

// Crear entrenadores
Entrenador ash = new Entrenador("Ash", new List<Pokemon> { charmander });
Entrenador misty = new Entrenador("Misty", new List<Pokemon> { squirtle });

// Crear batalla
Batalla batalla = new Batalla(ash, misty);

// Iniciar batalla
batalla.iniciarBatalla();

// Charmander ataca a Squirtle usando lanzallamas
ash.elegirAtaque(0, squirtle); // índice 0 corresponde a "Lanzallamas"

// Squirtle ataca a Charmander usando pistola de agua
misty.elegirAtaque(0, charmander); // índice 0 corresponde a "Pistola de Agua"

// Mostrar el estado de los Pokémon después de los ataques
Console.WriteLine($"{charmander.Nombre} tiene {charmander.Vida} de vida restante.");
Console.WriteLine($"{squirtle.Nombre} tiene {squirtle.Vida} de vida restante.");