using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO.KENIA_JAZMIN_SALES_CALDERON.ENTIDADES.NEGOCIOS
{
    internal class ClsPersona
    {
        List<Persona> Persona = new List<Persona>();
        public void PesodePersonas(Persona per)
        {
            double pro = per.peso / Math.Pow(per.altura, 2);

            if (pro < 24)
            {
                Console.WriteLine("Usted tiene un peso ideal");
            }
            else if (pro > 25)
            {
                Console.WriteLine("Usted tiene Sobrepeso");
            }

        }
        public List<Persona> ListadoDePeso()
        {
            return Persona;
        }

        public void MayordeEdad(Persona perso)
        {

            if (perso.edad >= 18)
            {
                Console.WriteLine("Usted es  Mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted NO es Mayor de edad");
            }
        }

        public List<Persona> ListadoDeEdad()
        {
            return Persona;
        }
    }
}
