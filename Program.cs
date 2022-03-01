using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace tallerProgramacion
          //juan manuel torres alvarez
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                // juan manuel torres alvarez
                //15-02-2022
                //solucion punto 20 taller
                int tituloU;//titulo universitario
                double bono_alimentacion, bonoProfesionalizacion, bono_transporte,
               deduccion_caja_de_compensacion, deduccion_paro_forzoso;
                double deduccion_seguro_colectivo, EPS, dias_laborados, sueldo,
               sueldo_quincenal;
                Console.Write("Ingresa el valor de dias laborados: ");
                dias_laborados = double.Parse(Console.ReadLine());
                Console.WriteLine("Selecciona el valor que tiene titulo universitario.");

                Console.WriteLine("\t1.- Si");
                Console.WriteLine("\t2.- No");
                Console.Write("\t: ");
                sueldo = 1050000;
                tituloU = int.Parse(Console.ReadLine());
                if (tituloU == 1)
                    bonoProfesionalizacion = sueldo * 0.1;
                else
                    bonoProfesionalizacion = 0;
                bono_transporte = 120000;
                bono_alimentacion = dias_laborados * 25000;
                deduccion_seguro_colectivo = sueldo * 0.02;
                deduccion_paro_forzoso = sueldo * 0.01;
                EPS = sueldo * 0.02;
                deduccion_caja_de_compensacion = sueldo * 0.02;
                sueldo_quincenal = sueldo + bonoProfesionalizacion +
               bono_transporte + bono_alimentacion - deduccion_seguro_colectivo -
               deduccion_paro_forzoso - EPS - deduccion_caja_de_compensacion;
                Console.WriteLine("Valor de bono alimentacion: " +
               bono_alimentacion);
                Console.WriteLine("Valor de bono profesionalizacion: " +
               bonoProfesionalizacion);
                Console.WriteLine("Valor de bono transporte: " + bono_transporte);
                Console.WriteLine("Valor de deduccion caja de ahorro: " +
               deduccion_caja_de_compensacion);
                Console.WriteLine("Valor de deduccion paro forzoso: " +
               deduccion_paro_forzoso);
                Console.WriteLine("Valor de deduccion seguro colectivo: " +
               deduccion_seguro_colectivo);
                Console.WriteLine("Valor de deduccion seguro social: " + EPS);
                Console.WriteLine("Valor de sueldo base: " + sueldo);
                Console.WriteLine("Valor de sueldo quincenal: " +
               sueldo_quincenal);
                Console.WriteLine();

                Console.ReadKey();
            }
        }
    }
