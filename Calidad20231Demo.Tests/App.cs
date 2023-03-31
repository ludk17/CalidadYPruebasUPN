using Calidad20231Demo.Services;
using NUnit.Framework;

namespace Calidad20231Demo.Tests;

public class App
{
     // 1 caso de prueba son acciones especificas para verificar la funcionalidad.
     // ejecuta la aplicación -> ejecutar metodo sumar
     // ingresa el  numero 3 -> presiona enter -> pasar como perimer paraemtro el 3 
     // ingresa el numer 4 > presiona enter -> pasar como segundo parametro el 4
     // verifica que el resultado sea 7
     // si el resultado es 7 -> OK
     // si el resultado es != 7 -> FAIL
     [Test]
     public void Caso01()
     {
          // ejecuta la aplicación -> ejecutar metodo sumar
          var service = new NumericService();
          var resultado = service.Sumar(3, 4);
          Assert.AreEqual(7,resultado);
     }
     
     // caso de prueba 2
     // ejecuta la aplicación
     // ingresa el  numero 4 -> presiona enter
     // ingresa el numer 7 > presiona enter
     // verifica que el resultado sea 7
     // si el resultado es 11 -> OK
     // si el resultado es != 11 -> FAIL
     [Test]
     public void Caso02()
     {
          var service = new NumericService();
          var resultado = service.Sumar(4, 7);
          Assert.AreEqual(11,resultado);
     }
     
     [Test]
     public void Caso03()
     {
          var service = new NumericService();
          var resultado = service.Sumar(4, 7);
          Assert.AreEqual(11,resultado);
     }
     
     [Test]
     public void Caso04()
     {
          var service = new NumericService();
          var resultado = service.Sumar(4, 7);
          Assert.AreEqual(11,resultado);
     }
     
     [Test]
     public void Caso05()
     {
          var service = new NumericService();
          var resultado = service.Sumar(4, 7);
          Assert.AreEqual(11,resultado);
     }
}