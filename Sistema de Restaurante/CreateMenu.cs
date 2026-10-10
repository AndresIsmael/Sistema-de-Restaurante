using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Restaurante
{
    public partial class CreateMenu : Form
    {
        public decimal precioDecimal;
        List<Menu> menus = new List<Menu>();
        List<Menu> mn = new List<Menu>();
        public CreateMenu()
        {
            InitializeComponent();
        }

        private void CreateMenu_Load(object sender, EventArgs e)
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
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox7.Text, out decimal valor))
            {
                precioDecimal = valor;
                textBox7.Text = valor.ToString("C", new CultureInfo("es-GT"));
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (precioDecimal != 0)
            {
                textBox7.Text = precioDecimal.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string file = "menus.json";

            if ( textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre para el menú.");
                return;
            }
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Ingrese un codigo para el menú.");
                return;
            }
            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                menus = JsonSerializer.Deserialize<List<Menu>>(datos) ?? new List<Menu>();
                mn = menus.Where(c => c.CodigoMenu == textBox2.Text).ToList();
            }
            if (mn.Count > 0)
            {
                MessageBox.Show("Codigo de menú ya existe, intente con otro.");
                return;
            }

            Menu carta = new Menu
            {
                CodigoMenu = textBox2.Text,
                NombreMenu = textBox1.Text,
                Desayuno = textBox3.Text,
                Almuerzo = textBox4.Text,
                Cena = textBox5.Text,
                Postre = textBox6.Text,
                Precio = precioDecimal
            };

            menus.Add(carta);
            string json = JsonSerializer.Serialize(menus, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("menus.json", json);
            MessageBox.Show("Menú creado correctamente.");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            precioDecimal = 0;

        }
    }
    public class Menu
    {
        public string CodigoMenu { get; set; }
        public string NombreMenu { get; set; }
        public string Desayuno { get; set; }
        public string Almuerzo { get; set; }
        public string Cena { get; set; }
        public string Postre { get; set; }
        public decimal Precio { get; set; }
    }
}
