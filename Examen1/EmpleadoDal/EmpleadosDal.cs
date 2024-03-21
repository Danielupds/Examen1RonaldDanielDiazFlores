using EmpleadoModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoDal
{
    public class EmpleadosDal
    {
        public DataTable ListarEmpleadosDal()
        {
            string consulta = "select from * empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }


        public void InsertarEmpleadosDal(Empleado empleado)
        {
            string consulta = "insert into persona values('" + empleado.Puesto + "'," +
                                                         "'" + empleado.Salario + "'," +
                                                         "'" + empleado.FechaContratacion + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
