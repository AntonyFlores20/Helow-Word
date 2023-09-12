// See https://aka.ms/new-console-template for more information
using Helow_Word;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de aplicaciones web";
int edad = 20;
double salario = 2000;

var alumno = "Luis Chang";
var mundial = 2026;

var player = new Persona();
player.name = "Paolo Guerrero";
player.dni =12165456;
player.phone = "051-1465145614";
player.active =  true;

var player2 = new Persona()
{
    dni = 121235415,
    name = "Claudio Pizarro",
    phone = "084-54545454",
    active = false,
};

var player3 = new Persona(22546546, "Gianluca Lapadula", "878-545454654", true);
var player4 = new Persona(45641654, "Pedro Galesse", "051-54564614", true);
var personas = new List<Persona>();
personas.Add(player);
personas.Add(player2);
personas.Add(player3);
personas.Add(player4);

//buscar a la persona Lapadula con DNI 22546546
//Linq Query Expresions

var busqueda = (from p in personas
                where p.dni == 22546546
                select p).FirstOrDefault();
Console.WriteLine("La persona encontrada es: "
                    + busqueda.name);
//Buscar por lambda expressions
var otraBusqueda = personas
                    .Where(a => a.dni == 22546546
                    ).FirstOrDefault();