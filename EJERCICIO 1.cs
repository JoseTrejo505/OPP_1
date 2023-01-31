using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    private string nombre, raza;
    private int edad;

    public Animal(string nombre, string raza, int edad)
    {
        setNombre(nombre);
        setRaza(raza);
        setEdad(edad);
    }

    public void setNombre(string n) { nombre = n; }
    public void setRaza(string a) { raza = a; }
    public void setEdad(int w) { edad = w; }

    public string getNombre() { return nombre; }
    public string getRaza() { return raza; }
    public int getEdad() { return edad; }

    public void mostrarAnimal()
    {
        Console.Write("\nNombre: " + getNombre() + "\nRaza: " + getRaza() + "\nEdad: " + getEdad());

    }
}
public class Principal
{
    public static void Main()
    {
        string nombre, raza;
        int edad;
        Console.Write("FAvor ingresar tipo de animal: ");
        nombre = Console.ReadLine();
        Console.Write("Favor ingresar la raza: ");
        raza = Console.ReadLine();
        Console.Write("Favor ingresar edad: ");
        edad = int.Parse(Console.ReadLine());

        Animal e;
        e = new Animal(nombre, raza, edad);
        e.mostrarAnimal();
    }
}
