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
    public partial class ConsultarMenu : Form
    {
        List<Menu> menus = new List<Menu>();
        List<Menu> carta = new List<Menu>();
        public ConsultarMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu seleccionado = comboBox1.SelectedItem as Menu;
            if (seleccionado != null)
            {
                carta = menus.Where(c => c.NombreMenu == seleccionado.NombreMenu).ToList();
                dataGridView1.DataSource = carta;
            }
        }

        private void ConsultarMenu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            string file = "menus.json";
            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                menus = JsonSerializer.Deserialize<List<Menu>>(datos) ?? new List<Menu>();
                comboBox1.DataSource = menus;
                comboBox1.DisplayMember = "NombreMenu";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente f1 = new MenuCliente();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
