using EmpleadoDal;
using EmpleadoModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoBss
{
    public class EmpleadosBss
    {
        EmpleadosDal dal = new EmpleadosDal();
        public DataTable ListarEmpleadosBss()
        {
            return dal.ListarEmpleadosDal();
        }
    }
}
