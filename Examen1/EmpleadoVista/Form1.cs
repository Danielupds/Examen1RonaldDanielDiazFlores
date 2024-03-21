using EmpleadoBss;
using EmpleadoModelos;

namespace EmpleadoVista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PersonasBss bss = new PersonasBss();
        EmpleadosBss bss1 = new EmpleadosBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;

            Empleado em = new Empleado();
            em.Puesto = textBox3.Text;
            em.Salario = Convert.ToDecimal(textBox4.Text);
            em.FechaContratacion = dateTimePicker1.Value;


        }
    }
}