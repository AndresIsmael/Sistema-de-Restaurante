using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Restaurante
{
    public partial class MenuMesero : Form
    {
        public MenuMesero()
        {
            InitializeComponent();
        }

        private void MenuMesero_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoMenus.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatePedido f2 = new CreatePedido();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GestionarPedidos f2 = new GestionarPedidos();
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }
    }
}
