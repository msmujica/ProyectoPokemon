using ProyectoPokemon;

Tipos fuego = new Tipos("Fuego");
Tipos agua = new Tipos("Agua");

fuego.agregarDebilidades(agua);
agua.agregarFortalezas(fuego);
        
Ataque lanzallamas = new Ataque("Lanzallamas", 40, new List<Tipos> { fuego }, false);
Ataque pistolaAgua = new Ataque("Pistola de Agua", 30, new List<Tipos> { agua }, false);

new Pokemon("Charmander", 100, pistolaAgua, new List<Ataque>{ lanzallamas }, new List<Tipos>{ fuego });
new Pokemon("Squirtle", 100, lanzallamas, new List<Ataque>{ pistolaAgua }, new List<Tipos>{ agua });
new Pokemon("Bulbasaur", 100, null, new List<Ataque>(), new List<Tipos>());

// Crear Entrenadores
Entrenador ash = new Entrenador("Ash");
Entrenador misty = new Entrenador("Misty");

// Ash elige su equipo
Console.WriteLine("Ash selecciona su equipo:");
ash.elegirEquipo();

// Misty elige su equipo
Console.WriteLine("Misty selecciona su equipo:");
misty.elegirEquipo();

// Crear una batalla y comenzar
Batalla batalla = new Batalla(ash, misty);
batalla.iniciarBatalla();
batalla.procesarTurno();