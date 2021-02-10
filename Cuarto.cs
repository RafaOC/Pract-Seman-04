using System;

class MainClass {
  public static void Main (string[] args) 
  {
    //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).

    char letra;

    for (letra = 'Z'; letra >= 'A'; letra--) 
    {
      Console.WriteLine (letra);
    }

  }
}