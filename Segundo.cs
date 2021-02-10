using System;

class MainClass {
  public static void Main (string[] args) 
  {
//Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".

    int num = 0;

    do
    {
      num++;

      Console.WriteLine(num);

    }while (num != 10);
  }
  
}