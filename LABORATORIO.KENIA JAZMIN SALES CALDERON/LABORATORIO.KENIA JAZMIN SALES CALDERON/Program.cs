// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//


using LABORATORIO.KENIA_JAZMIN_SALES_CALDERON.ENTIDADES.NEGOCIOS;
using LABORATORIO.KENIA_JAZMIN_SALES_CALDERON.ENTIDADES;


Console.WriteLine("******************************");
Console.WriteLine("BIENVENIDO");
Console.WriteLine("******************************");


ClsPersona Clspersona = new ClsPersona();
Persona persona = new Persona();


Console.WriteLine("Favor  ingresar su Nombre: ");
persona.nombre = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Favor ingrese su edad: ");
persona.edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Favor ingresar su Sexo: ");
persona.sexo = (Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Favor ingresar su Peso: ");
persona.peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");

Console.WriteLine("Favor ingresar  su Altura: ");
persona.altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ");


Clspersona.PesodePersonas(persona);


Console.WriteLine(" ");

Clspersona.MayordeEdad(persona);


Console.ReadKey();
