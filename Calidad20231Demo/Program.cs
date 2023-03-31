// See https://aka.ms/new-console-template for more information

using Calidad20231Demo.Services;

var aString = Console.ReadLine();
var bString = Console.ReadLine();

var service = new NumericService();
var resultado = service.Sumar(int.Parse(aString), int.Parse(bString));

Console.WriteLine(resultado);