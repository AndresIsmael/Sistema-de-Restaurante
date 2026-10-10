namespace Sistema_de_Restaurante
{
    partial class ConsultarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(35, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 83);
            dataGridView1.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label2.Location = new Point(377, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 39);
            label2.TabIndex = 79;
            label2.Text = "Numero pedido:";
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(519, 396);
            button2.Name = "button2";
            button2.Size = new Size(126, 40);
            button2.TabIndex = 77;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(662, 393);
            button1.Name = "button1";
            button1.Size = new Size(126, 40);
            button1.TabIndex = 76;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(231, 65);
            label1.TabIndex = 75;
            label1.Text = "Consultar pedido";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gabriola", 12F);
            textBox1.Location = new Point(519, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 35);
            textBox1.TabIndex = 81;
            // 
            // ConsultarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ConsultarPedido";
            Text = "ConsultarPedido";
            Load += ConsultarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}