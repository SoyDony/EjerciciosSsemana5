using System;
using System.Runtime.ConstrainedExecution;

namespace EjerciciosSsemana5
{
    internal class Program
    {
   
        /*Ejercicio 1: 

        Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

        Inicializar una clase Persona con atributos nombre, edad y dni.
        Crear un constructor sin parámetros que inicialice con valores por defecto.
        Inicializar la clase Persona con solo el nombre.
        Crear un constructor que reciba todos los atributos.
        Crear un método mostrarDatos() que imprima los atributos.

        Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).*/

        public class Persona
        {
            public string nombre { get; set; }
            private int edad;
            public int dni { get; set; }


            public Persona()
            {
                nombre = "Daniel";
                edad = 41;
                dni = 30201998;
            }

            public Persona(string nombre)
            {
                this.nombre = nombre;
                this.edad = 0;
                this.dni = 0;
            }



            public Persona(string nombre, int edad, int dni)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.dni = dni;
            }

            public void mostrarDatos()
            {
                Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Dni: {dni}");
            }

            public int getEdad()
            {
                return edad;
            }

            public void setEdad(int nuevaEdad)
            {
                edad = nuevaEdad;
            }
        }


        /*Ejercicio 2: 

        Crear una clase Calculadora.

        Crear un método sumar(int a, int b) que devuelva una suma.
        Crear un método sumar(double a, double b, double c) para sumar tres números.
        Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
        Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).
        Saludos! Buen martes*/


        public class Calculadora
        {
            public int sumar(int a, int b)
            {
                return a + b;
            }

            public double sumar(double a, double b, double c)
            {
                return a + b + c;
            }

            public void sumar(string mensaje, int a, int b)
            {

                Console.WriteLine(mensaje + (a + b));
            }

            public bool esPar(int a)
            {
                return a % 2 == 0;
            }

        }

        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();

            Console.WriteLine(c1.esPar(8));
        }
        

    }


}


      