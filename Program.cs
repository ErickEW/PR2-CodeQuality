using System;

namespace PR2PR2_Code_Quality
{
    class Program
    {
        static void Main(string[] args)
        {
             data alumno = new data();

                System.Console.WriteLine("Alumno registrado");
                System.Console.ReadLine();

                Console.WriteLine("Inserta el nombre del alumno: ");
                alumno.name = Console.ReadLine();

                Console.WriteLine("Inserta el nombre de la materia que deseas evaluar");
                alumno.materia = Console.ReadLine();

                Console.WriteLine("Inserta la calificación del 1er parcial"); 
                alumno.parcial1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserta la calificación del 2do parcial"); 
                alumno.parcial2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserta la calificación la calificación final"); 
                alumno.cFinal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("La suma de las calificaciones es {0}", parcial1 + parcial2 + cFinal);
                alumno.suma = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El promedio es {0}", suma/3);
                alumno.promedio = Convert.ToInt32(Console.ReadLine());

        }
    }
}
//No se me ocurrió otra forma de hacerlo y pa colmo no me salió