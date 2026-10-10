using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CreatePedido : Form
    {
        List<Pedido> orders = new List<Pedido>();
        List<Menu> menus = new List<Menu>();
        List<Empleado> empleados = new List<Empleado>();
        Menu coincidencia;
        public CreatePedido()
        {
            InitializeComponent();
        }

        private void CreatePedido_Load(object sender, EventArgs e)
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
                comboBox3.DataSource = empleados;
                comboBox3.DisplayMember = "NombreEmpleado";
            }

            comboBox2.Items.Add("Tarjeta");
            comboBox2.Items.Add("Efectivo");
            comboBox2.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu seleccionado = comboBox1.SelectedItem as Menu;
            coincidencia = menus.FirstOrDefault(c => c.NombreMenu == seleccionado.NombreMenu);
            label5.Text = "Monto a pagar: " + coincidencia.Precio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file3 = "pedidos.json";
            Random random = new Random();
            int id = random.Next(100000, 999999);

            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre."); return;
            }
            Menu MenuSelect = comboBox1.SelectedItem as Menu;
            Empleado EmpleadoSelect = comboBox3.SelectedItem as Empleado;
            if (File.Exists(file3))
            {
                string datos = File.ReadAllText(file3);
                orders = JsonSerializer.Deserialize<List<Pedido>>(datos) ?? new List<Pedido>();
                do
                {
                    id = random.Next(100000, 999999);
                }
                while (orders.Any(c => c.NumeroPedido == id));
                coincidencia = menus.FirstOrDefault(c => c.NombreMenu == MenuSelect.NombreMenu);
            }

            Pedido pd = new Pedido
            {
                NumeroPedido = id,
                Nombre = textBox1.Text,
                Menu = MenuSelect.NombreMenu,
                TipoPago = comboBox2.SelectedItem?.ToString() ?? "Tarjeta",
                Empleado = EmpleadoSelect.NombreEmpleado,
                Monto = coincidencia.Precio,
                Estado = "En cocina"
            };
            label8.Text = "Numero de pedido: " + id;
            orders.Add(pd);
            string json = JsonSerializer.Serialize(orders, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("pedidos.json", json);
            MessageBox.Show("Pedido creado correctamente, su numero de orden es" + id + ".");
            MenuCliente f5 = new MenuCliente();
            f5.Show();
            this.Hide();
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
    }
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public string Nombre { get; set; }
        public string Menu { get; set; }
        public string TipoPago { get; set; }
        public string Empleado { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
    }
}
