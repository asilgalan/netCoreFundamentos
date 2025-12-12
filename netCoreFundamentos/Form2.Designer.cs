namespace netCoreFundamentos
{
    partial class Form2
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
            btnSumar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            resultado = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(313, 300);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 89);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 199);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero 2";
            label2.Click += label2_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(323, 124);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(323, 226);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(537, 154);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 5;
            resultado.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "Form2";
            Text = "Form2";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label resultado;
    }
}