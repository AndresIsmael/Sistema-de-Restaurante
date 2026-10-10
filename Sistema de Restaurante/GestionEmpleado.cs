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
    public partial class GestionEmpleado : Form
    {
        List<Empleado> empleados = new List<Empleado>();
        Empleado trabajador;
        public GestionEmpleado()
        {
            InitializeComponent();
        }

        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            dateTimePicker1.Enabled = false;

            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = "empleados.json";

            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                empleados = JsonSerializer.Deserialize<List<Empleado>>(datos) ?? new List<Empleado>();
                trabajador = empleados.FirstOrDefault(c => c.CodigoEmpleado == textBox7.Text);
                if (trabajador == null)
                {
                    MessageBox.Show("Codigo empleado no existe.");
                }
                else
                {
                    button1.Enabled = true;
                    button3.Enabled = true;

                    textBox1.Text = trabajador.NombreEmpleado.ToString();
                    textBox4.Text = trabajador.Telefono.ToString();
                    textBox6.Text = trabajador.Edad.ToString();
                    dateTimePicker1.Value = trabajador.FechaNacimiento;

                    textBox1.Enabled = true;
                    textBox4.Enabled = true;
                    textBox6.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    textBox7.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("No existen empleados.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre."); return;
            }
            if (textBox4.Text == "" || textBox4.Text == null)
            {
                MessageBox.Show("Ingrese un telefono."); return;
            }
            if (textBox6.Text == "" || textBox6.Text == null)
            {
                MessageBox.Show("Ingrese una edad."); return;
            }
            trabajador.NombreEmpleado = textBox1.Text;
            trabajador.Telefono = textBox4.Text;
            trabajador.Edad = textBox6.Text;
            trabajador.FechaNacimiento = dateTimePicker1.Value;

            string json = JsonSerializer.Serialize(empleados, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("empleados.json", json);
            MessageBox.Show("Empleado modificado correctamente.");
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empleados.Remove(trabajador);
            string json = JsonSerializer.Serialize(empleados, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("empleados.json", json);
            MessageBox.Show("Empleado eliminado correctamente.");
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }
    }
}
