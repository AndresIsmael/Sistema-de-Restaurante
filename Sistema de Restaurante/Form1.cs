namespace Sistema_de_Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Image.FromFile(@"images\logo.png");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;

            switch (textBox1.Text)
            {
                case "admin":
                    conteo += 1;
                    break;

                case "mesero":
                    conteo += 2;
                    break;

                case "cliente":
                    conteo += 3;
                    break;
            }

            switch (textBox2.Text)
            {
                case "123":
                    conteo += 1;
                    break;

                case "456":
                    conteo += 2;
                    break;

                case "789":
                    conteo += 3;
                    break;
            }

            switch (conteo)
            {
                case 2:
                    Program.usuario = "admin";
                    MenuAdministrador f1 = new MenuAdministrador();
                    f1.Show();
                    this.Hide();
                    break;

                case 4:
                    MessageBox.Show("Ingreso a mesero");
                    break;

                case 6:
                    MessageBox.Show("Ingreso a cliente");
                    break;

                default:
                    MessageBox.Show("Credenciales incorrectas.");
                    break;
            }
        }
    }
}
