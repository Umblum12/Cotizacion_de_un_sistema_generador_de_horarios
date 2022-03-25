using System;

namespace Cotizacion_de_un_sistema_generador_de_horarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            int horas_de_analisis_y_diseño_de_interfaces = 30;
            int horas_de_el_diseño_de_la_base_de_datos = 15;
            int horas_de_programacion = 120;
            int horas_de_implementacion_del_sistema = 10;

            int costo_por_hora_de_analisis_y_diseño_de_interfaces = 300;
            int costo_por_hora_de_el_diseño_de_la_base_de_datos = 250;
            int costo_por_hora_de_programacion = 450;
            int costo_por_hora_de_implementacion_del_sistema = 200;

            int r1;
            int r2;
            int r3;
            int r4;

            //Colocar el procedimiento
            r1 = (horas_de_analisis_y_diseño_de_interfaces * costo_por_hora_de_analisis_y_diseño_de_interfaces);
            r2 = (horas_de_el_diseño_de_la_base_de_datos * costo_por_hora_de_el_diseño_de_la_base_de_datos);
            r3 = (horas_de_programacion * costo_por_hora_de_programacion);
            r4 = (horas_de_implementacion_del_sistema * costo_por_hora_de_implementacion_del_sistema);

            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Horas de analisis y diseño de interfaces: " + horas_de_analisis_y_diseño_de_interfaces);
            Console.WriteLine("Horas de el diseño de la base de datos: " + horas_de_el_diseño_de_la_base_de_datos);
            Console.WriteLine("Horas de programacion: " + horas_de_programacion);
            Console.WriteLine("Horas de implementacion del sistema: " + horas_de_implementacion_del_sistema);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Costo por Hora de analisis y diseño de interfaces: " + costo_por_hora_de_analisis_y_diseño_de_interfaces);
            Console.WriteLine("Costo por Hora de el diseño de la base de datos: " + costo_por_hora_de_el_diseño_de_la_base_de_datos);
            Console.WriteLine("Costo por Hora de programacion: " + costo_por_hora_de_programacion);
            Console.WriteLine("Costo por Hora de implementacion del sistema: " + costo_por_hora_de_implementacion_del_sistema);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("La cotizacion de analisis y diseño de interfaces: " + r1);
            Console.WriteLine("La cotizacion de el diseño de la base de datos: " + r2);
            Console.WriteLine("La cotizacion de programacion: " + r3);
            Console.WriteLine("La cotizacion de implementacion del sistema: " + r4);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
