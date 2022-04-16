using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGridView
{

   
    internal class PersonaDataObjects
    {

        private List<Persona> listaPersonas = new List<Persona>();

        public PersonaDataObjects()
        {
            Persona p1 = new Persona
            {
                Nombre = "Javiel",
                Mail = "Javier@email.com"
            ,
                Genero = "Hombre",
                Telefono = "2221115588", ImagenGenero= "hombre.png"
                
            };

            Persona p2 = new Persona { Nombre = "Rebeca", Mail = "Rebek@email.com",
                Genero = "Mujer", Telefono = "2223556668" , ImagenGenero="mujer.png"};

            listaPersonas.Add(p1);
            listaPersonas.Add(p2);

        }

        public List<Persona> listar()
        {
            return listaPersonas;

        }   

    }
}
