using EmpleadoModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoDal
{
    public class PersonasDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select from * persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }


        public void InsertarPersonasDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," +
                                                         "'" + persona.Estado + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        
    }
}
