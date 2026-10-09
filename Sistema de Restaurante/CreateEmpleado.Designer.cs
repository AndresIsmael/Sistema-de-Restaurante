namespace Sistema_de_Restaurante
{
    partial class CreateEmpleado
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(496, 394);
            button2.Name = "button2";
            button2.Size = new Size(126, 40);
            button2.TabIndex = 32;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(655, 394);
            button1.Name = "button1";
            button1.Size = new Size(126, 40);
            button1.TabIndex = 31;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Gabriola", 12F);
            textBox5.Location = new Point(126, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(222, 35);
            textBox5.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Gabriola", 12F);
            textBox3.Location = new Point(126, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 35);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Gabriola", 12F);
            textBox2.Location = new Point(519, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 35);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gabriola", 12F);
            textBox1.Location = new Point(126, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 35);
            textBox1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label6.Location = new Point(43, 192);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 39);
            label6.TabIndex = 23;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label5.Location = new Point(368, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 39);
            label5.TabIndex = 22;
            label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label4.Location = new Point(63, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 39);
            label4.TabIndex = 21;
            label4.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label3.Location = new Point(366, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 39);
            label3.TabIndex = 20;
            label3.Text = "Codigo Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gabriola", 15.75F, FontStyle.Bold);
            label2.Location = new Point(45, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 39);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(218, 65);
            label1.TabIndex = 18;
            label1.Text = "Crear Empleado";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(541, 198);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // CreateEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateEmpleado";
            Text = "CreateEmpleado";
            Load += CreateEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}