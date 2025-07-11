// See https://aka.ms/new-console-template for more information
using HolaMandril.Entidades;

Console.WriteLine("03. Hola Real Mandril!");

Console.WriteLine("01. Hola Real Mandril!");

Console.WriteLine("02. Hola Real Mandril!");

Console.WriteLine("Probando el uso de GIT");

// Instancia de la clase Persona
Persona persona = new Persona
{
    Id = 1,
    Nombre = "Juan",
    Apellido = "Pérez",
    Edad = 30
};

Console.WriteLine($"Id: {persona.Id}, Nombre: {persona.Nombre}, Apellido: {persona.Apellido}, Edad: {persona.Edad}");