﻿// See https://aka.ms/new-console-template for more information
using Demo01;

int area = 0;
int perimetro = 0;
Rectangulo rectangulo = new Rectangulo();
rectangulo.Base = 10;
rectangulo.Altura= 20;
area = rectangulo.CalcularArea();
perimetro=rectangulo.CalcularPerimetro();

Console.WriteLine("El area es: ");
Console.WriteLine(area);
Console.WriteLine("El ´perimetro es: ");
Console.WriteLine(perimetro);




Persona persona = new Persona()
{
    Nombres = "Hugo",
    Apellidos = "Torrico"

};
persona.AsignarNombresCompletos();

Console.WriteLine(persona.NombresCompletos);
Console.WriteLine("Hello, World!");
Console.Read();