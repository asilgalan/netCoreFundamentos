namespace netCoreFundamentos
{
    partial class form3diasemana
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
            mostrarDia = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtdia = new TextBox();
            txtmes = new TextBox();
            txtanio = new TextBox();
            valordia = new Label();
            SuspendLayout();
            // 
            // mostrarDia
            // 
            mostrarDia.Location = new Point(277, 233);
            mostrarDia.Name = "mostrarDia";
            mostrarDia.Size = new Size(75, 23);
            mostrarDia.TabIndex = 0;
            mostrarDia.Text = "Mostrar dia";
            mostrarDia.UseVisualStyleBackColor = true;
            mostrarDia.Click += mostrarDia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 94);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 1;
            label1.Text = "dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 126);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 161);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "año";
            // 
            // txtdia
            // 
            txtdia.Location = new Point(277, 94);
            txtdia.Name = "txtdia";
            txtdia.Size = new Size(100, 23);
            txtdia.TabIndex = 4;
            // 
            // txtmes
            // 
            txtmes.Location = new Point(277, 126);
            txtmes.Name = "txtmes";
            txtmes.Size = new Size(100, 23);
            txtmes.TabIndex = 5;
            // 
            // txtanio
            // 
            txtanio.Location = new Point(277, 161);
            txtanio.Name = "txtanio";
            txtanio.Size = new Size(100, 23);
            txtanio.TabIndex = 6;
            // 
            // valordia
            // 
            valordia.AutoSize = true;
            valordia.Location = new Point(485, 71);
            valordia.Name = "valordia";
            valordia.Size = new Size(38, 15);
            valordia.TabIndex = 7;
            valordia.Text = "label4";
            // 
            // form3diasemana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(valordia);
            Controls.Add(txtanio);
            Controls.Add(txtmes);
            Controls.Add(txtdia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mostrarDia);
            Name = "form3diasemana";
            Text = "form3diasemana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mostrarDia;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtdia;
        private TextBox txtmes;
        private TextBox txtanio;
        private Label valordia;
    }
}