using System;

class MainClass {
  public static void Main (string[] args) 
  {
    //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero)

    int numero = 0;
    int suma = 0;

    do 
    {
      Console.WriteLine ("Introduce un numero.");
      numero = int.Parse(Console.ReadLine());

      if (numero != 0 && numero >=0)
      {         
        suma = suma + numero;  
      }              

    }while (numero != 0 && numero >= 0); 

    Console.WriteLine ("La suma total de los numeros ingresado es igual: "+suma);
  }
}