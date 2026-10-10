namespace Sistema_de_Restaurante
{
    partial class MenuCliente
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(314, 292);
            button4.Name = "button4";
            button4.Size = new Size(150, 40);
            button4.TabIndex = 15;
            button4.Text = "Consultar pedido";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(314, 217);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 14;
            button2.Text = "Realizar pedido";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(314, 140);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 13;
            button1.Text = "Consultar menu";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 48);
            label1.Name = "label1";
            label1.Size = new Size(240, 65);
            label1.TabIndex = 12;
            label1.Text = "Bienvenido cliente";
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuCliente";
            Text = "MenuCliente";
            Load += MenuCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}