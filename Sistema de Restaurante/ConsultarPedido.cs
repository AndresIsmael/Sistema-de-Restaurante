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
    public partial class ConsultarPedido : Form
    {
        List<Pedido> orders = new List<Pedido>();
        Pedido pd;
        public ConsultarPedido()
        {
            InitializeComponent();
        }

        private void ConsultarPedido_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"images\fondoOpciones.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "pedidos.json";
            if (!int.TryParse(textBox1.Text, out int idPedido))
            {
                MessageBox.Show("Ingresa un numero de pedido valido.");
                return;
            }
            if (File.Exists(file))
            {
                string datos = File.ReadAllText(file);
                orders = JsonSerializer.Deserialize<List<Pedido>>(datos) ?? new List<Pedido>();
                pd = orders.FirstOrDefault(c => c.NumeroPedido == idPedido);
                if (pd != null)
                {
                    dataGridView1.DataSource = new List<Pedido> { pd }; ;
                }
                else
                {
                    MessageBox.Show("No existe el pedido.");
                    return;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCliente f5 = new MenuCliente();
            f5.Show();
            this.Hide();
        }
    }
}
