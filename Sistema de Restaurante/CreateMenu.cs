using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Restaurante
{
    public partial class CreateMenu : Form
    {
        public CreateMenu()
        {
            InitializeComponent();
        }

        private void CreateMenu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
