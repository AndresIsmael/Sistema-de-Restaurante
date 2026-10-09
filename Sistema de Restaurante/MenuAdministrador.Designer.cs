namespace Sistema_de_Restaurante
{
    partial class MenuAdministrador
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 25);
            label1.Name = "label1";
            label1.Size = new Size(333, 65);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido administrador";
            // 
            // button1
            // 
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(209, 138);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 6;
            button1.Text = "Crear Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(407, 138);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 7;
            button2.Text = "Gestionar Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(407, 208);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 9;
            button3.Text = "Gestionar Empleado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(209, 208);
            button4.Name = "button4";
            button4.Size = new Size(150, 40);
            button4.TabIndex = 8;
            button4.Text = "Crear Empleado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(407, 284);
            button5.Name = "button5";
            button5.Size = new Size(150, 40);
            button5.TabIndex = 11;
            button5.Text = "Gestionar pedidos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(209, 284);
            button6.Name = "button6";
            button6.Size = new Size(150, 40);
            button6.TabIndex = 10;
            button6.Text = "Reporte de ventas";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // MenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuAdministrador";
            Text = "MenuAdministrador";
            Load += MenuAdministrador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}