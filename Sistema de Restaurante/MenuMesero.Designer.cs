namespace Sistema_de_Restaurante
{
    partial class MenuMesero
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
            label1 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(316, 216);
            button4.Name = "button4";
            button4.Size = new Size(150, 40);
            button4.TabIndex = 19;
            button4.Text = "Gestion de pedidos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(316, 141);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 18;
            button2.Text = "Realizar pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 45);
            label1.Name = "label1";
            label1.Size = new Size(245, 65);
            label1.TabIndex = 16;
            label1.Text = "Bienvenido mesero";
            // 
            // button7
            // 
            button7.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(626, 388);
            button7.Name = "button7";
            button7.Size = new Size(150, 40);
            button7.TabIndex = 20;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // MenuMesero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "MenuMesero";
            Text = "MenuMesero";
            Load += MenuMesero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        private Label label1;
        private Button button7;
    }
}