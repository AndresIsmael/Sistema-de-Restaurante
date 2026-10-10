using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Restaurante
{
    public partial class CreateEmpleado : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Empleado> emp = new List<Empleado>();
        public CreateEmpleado()
        {
            InitializeComponent();
        }

        private void CreateEmpleado_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "empleados.json";

            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Ingrese un codigo de empleado.");
                return;
            }
            if (textBox3.Text == "" || textBox3.Text == null)
            {
                MessageBox.Show("Ingrese una edad.");
                return;
            }
            if (textBox4.Text == "" || textBox4.Text == null)
            {
                MessageBox.Show("Ingrese un telefono.");
                return;
            }
            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                empleados = JsonSerializer.Deserialize<List<Empleado>>(datos) ?? new List<Empleado>();
                emp = empleados.Where(c => c.CodigoEmpleado == textBox2.Text).ToList();
            }
            if (emp.Count > 0)
            {
                MessageBox.Show("Codigo de empleado ya existe, intente con otro.");
                return;
            }
            Empleado empleado = new Empleado
            {
                CodigoEmpleado = textBox2.Text,
                NombreEmpleado = textBox1.Text,
                Telefono = textBox4.Text,
                FechaNacimiento = dateTimePicker1.Value,
                Edad = textBox3.Text,
            };
            empleados.Add(empleado);
            string json = JsonSerializer.Serialize(empleados, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("empleados.json", json);
            MessageBox.Show("Empleado creado correctamente.");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
    public class Empleado
    {
        public string CodigoEmpleado{ get; set; }
        public string NombreEmpleado { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Edad { get; set; }
    }
}
