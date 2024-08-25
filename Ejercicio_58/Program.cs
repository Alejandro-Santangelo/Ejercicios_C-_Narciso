using System;

class Program
{
    static void Main()
    {
        Console.Write("  Ingrese una letra o carácter: ");
        char valor = Console.ReadKey().KeyChar;

        switch (valor)
        {
            case '.':
            case ',':
            case ';':
            case ':':
                Console.WriteLine("  Es un signo de puntuación");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("  Es una cifra numérica");
                break;
            default:
                Console.WriteLine("  Es algún otro caracter");
                break;
        }
    }
}