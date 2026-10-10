using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Restaurante
{
    public partial class GestionarPedidos : Form
    {
        List<Pedido> orders = new List<Pedido>();
        List<Menu> menus = new List<Menu>();
        List<Empleado> empleados = new List<Empleado>();
        Pedido orden;
        Menu money;
        public GestionarPedidos()
        {
            InitializeComponent();
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            string file1 = "menus.json";
            if (File.Exists(file1))
            {
                string datos = File.ReadAllText(file1);
                menus = JsonSerializer.Deserialize<List<Menu>>(datos) ?? new List<Menu>();
                comboBox1.DataSource = menus;
                comboBox1.DisplayMember = "NombreMenu";
            }

            string file2 = "empleados.json";
            if (File.Exists(file2))
            {
                string datos2 = File.ReadAllText(file2);
                empleados = JsonSerializer.Deserialize<List<Empleado>>(datos2) ?? new List<Empleado>();
                comboBox4.DataSource = empleados;
                comboBox4.DisplayMember = "NombreEmpleado";
            }

            comboBox3.Items.Add("Tarjeta");
            comboBox3.Items.Add("Efectivo");
            comboBox3.SelectedIndex = 0;

            comboBox2.Items.Add("En cocina");
            comboBox2.Items.Add("Preparando");
            comboBox2.Items.Add("Llevando al cliente");
            comboBox2.Items.Add("Finalizado");
            comboBox2.SelectedIndex = 0;

            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.usuario == "mesero")
            {
                MenuMesero f1 = new MenuMesero();
                f1.Show();
                this.Hide();
            }
            if (Program.usuario == "admin")
            {
                MenuAdministrador f1 = new MenuAdministrador();
                f1.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = "pedidos.json";
            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                orders = JsonSerializer.Deserialize<List<Pedido>>(datos) ?? new List<Pedido>();
                if (!int.TryParse(textBox7.Text, out int idPedido))
                {
                    MessageBox.Show("Ingresa un numero de pedido valido.");
                    return;
                }
                orden = orders.FirstOrDefault(c => c.NumeroPedido == idPedido);
                if (orden == null)
                {
                    MessageBox.Show("Numero de pedido no existe.");
                }
                else
                {
                    button1.Enabled = true;
                    button3.Enabled = true;

                    textBox1.Text = orden.Nombre;
                    comboBox1.SelectedItem = menus.FirstOrDefault(m => m.NombreMenu == orden.Menu); ;
                    comboBox2.SelectedItem = orden.Estado;
                    comboBox3.SelectedItem = orden.TipoPago;
                    comboBox4.SelectedItem = empleados.FirstOrDefault(e => e.NombreEmpleado == orden.Empleado);

                    textBox1.Enabled = true;
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    comboBox4.Enabled = true;
                    textBox7.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("No existen pedidos.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre."); return;
            }
            Menu MenuSelect = comboBox1.SelectedItem as Menu;
            Empleado EmpleadoSelect = comboBox4.SelectedItem as Empleado;

            money = menus.FirstOrDefault(c => c.NombreMenu == MenuSelect.NombreMenu);

            orden.Nombre = textBox1.Text;
            orden.Menu = MenuSelect.NombreMenu;
            orden.Estado = comboBox2.SelectedItem?.ToString() ?? "Sin estado";
            orden.TipoPago = comboBox3.SelectedItem?.ToString() ?? "Sin pago";
            orden.Empleado = EmpleadoSelect.NombreEmpleado;
            orden.Monto = money.Precio;

            string json = JsonSerializer.Serialize(orders, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("pedidos.json", json);
            MessageBox.Show("Pedido modificado correctamente.");
            if (Program.usuario == "mesero")
            {
                MenuMesero f1 = new MenuMesero();
                f1.Show();
                this.Hide();
            }
            if (Program.usuario == "admin")
            {
                MenuAdministrador f1 = new MenuAdministrador();
                f1.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orders.Remove(orden);
            string json = JsonSerializer.Serialize(orders, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("pedidos.json", json);
            MessageBox.Show("Pedido eliminado correctamente.");
            if (Program.usuario == "mesero")
            {
                MenuMesero f1 = new MenuMesero();
                f1.Show();
                this.Hide();
            }
            if (Program.usuario == "admin")
            {
                MenuAdministrador f1 = new MenuAdministrador();
                f1.Show();
                this.Hide();
            }
        }
    }
}
