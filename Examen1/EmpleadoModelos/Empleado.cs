﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoModelos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int idPersona { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion {  get; set; }
    }
}
