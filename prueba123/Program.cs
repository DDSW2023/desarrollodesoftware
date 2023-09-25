using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba123
{

    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AgendaContext())
            {
                var Persona = new Persona 
                { 
                    Nombre = "Santiago", 
                    Apellido = "Ciaponi", 
                    Telefonos = { 
                        new Telefono { numero = "3329477465", Tipo = "celular" },
                        new Telefono { numero = "3329480772", Tipo = "fijo" }
                    }
                };

                context.Personas.Add(Persona);  
                context.SaveChanges();



            }


        }
    }
}