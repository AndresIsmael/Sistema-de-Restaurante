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
    public partial class GestionMenu : Form
    {
        List<Menu> menus = new List<Menu>();
        Menu carta;
        public GestionMenu()
        {
            InitializeComponent();
        }

        private void GestionMenu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            button1.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = "menus.json";
            button1.Enabled = true;
            button3.Enabled = true;

            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                menus = JsonSerializer.Deserialize<List<Menu>>(datos) ?? new List<Menu>();
                carta = menus.FirstOrDefault(c => c.CodigoMenu == textBox7.Text);
                if (carta == null)
                {
                    MessageBox.Show("Codigo menú no existe.");
                }
                else
                {
                    textBox1.Text = carta.NombreMenu.ToString();
                    textBox4.Text = carta.Almuerzo.ToString();
                    textBox3.Text = carta.Desayuno.ToString();
                    textBox6.Text = carta.Postre.ToString();
                    textBox5.Text = carta.Cena.ToString();

                    textBox1.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("No existen menús.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Ingrese un nombre de menú."); return;
            }
            if (textBox4.Text == "" || textBox4.Text == null)
            {
                MessageBox.Show("Ingrese un almuerzo."); return;
            }
            if (textBox3.Text == "" || textBox3.Text == null)
            {
                MessageBox.Show("Ingrese un desayuno."); return;
            }
            if (textBox6.Text == "" || textBox6.Text == null)
            {
                MessageBox.Show("Ingrese un postre."); return;
            }
            if (textBox5.Text == "" || textBox5.Text == null)
            {
                MessageBox.Show("Ingrese una cena."); return;
            }
            carta.NombreMenu = textBox1.Text;
            carta.Almuerzo = textBox4.Text;
            carta.Desayuno = textBox3.Text;
            carta.Postre = textBox6.Text;
            carta.Cena = textBox5.Text;

            string json = JsonSerializer.Serialize(menus, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("menus.json", json);
            MessageBox.Show("Menú modificado correctamente.");
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menus.Remove(carta);
            string json = JsonSerializer.Serialize(menus, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("menus.json", json);
            MessageBox.Show("Menú eliminado correctamente.");
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdministrador f1 = new MenuAdministrador();
            f1.Show();
            this.Hide();
        }
    }
}
