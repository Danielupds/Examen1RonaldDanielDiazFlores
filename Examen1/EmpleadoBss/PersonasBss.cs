﻿using EmpleadoDal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoBss
{
    public class PersonasBss
    {
        PersonasDal dal = new PersonasDal();
        public DataTable ListarPersonasBss()
        {
            return dal.ListarPersonasDal();
        }
    }
}
