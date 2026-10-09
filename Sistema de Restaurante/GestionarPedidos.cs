using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Restaurante
{
    public partial class GestionarPedidos : Form
    {
        public GestionarPedidos()
        {
            InitializeComponent();
        }

        private void GestionarPedidos_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (Program.usuario)
            {
                case "admin":
                    MenuAdministrador f1 = new MenuAdministrador();
                    f1.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
