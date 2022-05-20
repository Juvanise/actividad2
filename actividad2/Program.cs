


//Generar un número aleatorio

Random numero = new Random(DateTime.Now.Millisecond);
int numeroSecreto = numero.Next(1, 21);
//Console.WriteLine(numeroSecreto);

//el usuario ingresa un numero
Console.WriteLine("Por favor intente adivinar el numero que eligio la computadora:del 1 al 20.");
int numeroIngresado = int.Parse(Console.ReadLine());

var contador = 1;
while (numeroIngresado != numeroSecreto)
 {
    contador++;
    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("El numero elegido es mayor que el numero secreto. Ingrese otro numero");
        numeroIngresado = int.Parse(Console.ReadLine());

    } else if(numeroIngresado < numeroSecreto){
        Console.WriteLine("El numero elegido es menor que el numero secreto. Ingrese otro numero");
        numeroIngresado = int.Parse(Console.ReadLine());
    }

}

    Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
    Console.WriteLine($"Lo has logrado en: {contador} intentos");
  

      

    










