class Personaje {
  constructor(nombre, defensa, poder, salud) {
    this.nombre = nombre;
    this.defensa = defensa;
    this.poder = poder;
    this.salud = salud;
  }

  atacar(objetivo) {
    const danio = Math.max(0, this.poder - objetivo.defensa);
    objetivo.salud -= danio;
    console.log(`${this.nombre} ataca a ${objetivo.nombre} y le causa ${danio} de daño.`);
    if (objetivo.salud <= 0) {
      objetivo.salud = 0;
      console.log(`${objetivo.nombre} ha sido derrotado.`);
    } else {
      console.log(`${objetivo.nombre} tiene ${objetivo.salud} de salud restante.`);
    }
  }
}

// Crear los personajes
const superman = new Personaje('Superman', 80, 120, 500);
const omniMan = new Personaje('Omni-Man', 70, 130, 500);

// Ejemplo de ataque
superman.atacar(omniMan);
omniMan.atacar(superman);

// Mostrar estado final
console.log(superman);
console.log(omniMan);
