
using ProgramacionAvanzada1;

List<int> lista = new List<int>(); 
lista.Add(1);    
lista.Add(99);
lista.Add(27);
lista.Add(3);
lista.Add(6);
lista.Add(32);

PlayingWithLists playing = new PlayingWithLists();
playing.EvenNumbers(lista);
playing.OddNumbers(lista);
playing.Ascending(lista);
playing.Descending(lista);
playing.MultipleThree(lista);
playing.EjemploDelegado();//delegado
playing.EjemploAction();//action
playing.EjemploFunc();//func
playing.EjemploPredicate();//predicate
playing.Minimum(lista);
playing.Maximum(lista);
playing.Average(lista);
playing.RMS(lista);

List<Animal> animal = new List<Animal>();
animal.Add(new Perro());
animal.Add(new Gato());
animal.Add(new MiMascota());
animal.Add(new MiMascota2());

Console.WriteLine($"la cantidad de animales en la lista es: {animal.Count}");

List<Perro> animal2 = new List<Perro>();
animal2.Add(new Perro());

MiMascota dog = new MiMascota();
dog.ImprimirMensajeMascota(animal2);

IEnumerable<Perro> animal3 = new List<MiMascota>();  //Covarianza: se usa un ienumerable de tipo perro pero puedes usar los de abajo como mi mascota
//animal3.Add(new Perro()); esta no funciona por que las covarianzas son inmutables

static void RealizarActionPerro(Action<Perro> perroAction)//contravarianza
{
    Perro dog = new Perro();
    perroAction(dog);
}

var accionPerro = new Action<Perro>(x => Console.WriteLine("ladro"));
RealizarActionPerro(accionPerro);




