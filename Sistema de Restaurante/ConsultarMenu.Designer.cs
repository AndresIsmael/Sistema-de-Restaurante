namespace Sistema_de_Restaurante
{
    partial class ConsultarMenu
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(519, 396);
            button2.Name = "button2";
            button2.Size = new Size(126, 40);
            button2.TabIndex = 70;
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
            button1.TabIndex = 69;
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
            label1.Size = new Size(219, 65);
            label1.TabIndex = 67;
            label1.Text = "Consultar Menú";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label2.Location = new Point(453, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 39);
            label2.TabIndex = 73;
            label2.Text = "Menú";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(35, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 83);
            dataGridView1.TabIndex = 74;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(519, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 37);
            comboBox1.TabIndex = 72;
            // 
            // ConsultarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ConsultarMenu";
            Text = "ConsultarMenu";
            Load += ConsultarMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}