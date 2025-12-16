namespace netCoreFundamentos
{
    partial class Form03ColoresPosicion
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtVerde = new TextBox();
            txtPosicionx = new TextBox();
            txtPosiciony = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnMover = new Button();
            label3 = new Label();
            label4 = new Label();
            Rojo = new Label();
            Verde = new Label();
            Azul = new Label();
            btnColor = new Button();
            cambiando = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(396, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(396, 81);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 2;
            // 
            // txtPosicionx
            // 
            txtPosicionx.Location = new Point(102, 137);
            txtPosicionx.Name = "txtPosicionx";
            txtPosicionx.Size = new Size(100, 23);
            txtPosicionx.TabIndex = 3;
            // 
            // txtPosiciony
            // 
            txtPosiciony.Location = new Point(102, 81);
            txtPosiciony.Name = "txtPosiciony";
            txtPosiciony.Size = new Size(91, 23);
            txtPosiciony.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 48);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 5;
            label1.Text = "Cambiar color de fondo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 36);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Mover boton";
            // 
            // btnMover
            // 
            btnMover.Location = new Point(93, 207);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(75, 23);
            btnMover.TabIndex = 7;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 63);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 119);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // Rojo
            // 
            Rojo.AutoSize = true;
            Rojo.Location = new Point(329, 169);
            Rojo.Name = "Rojo";
            Rojo.Size = new Size(31, 15);
            Rojo.TabIndex = 10;
            Rojo.Text = "Rojo";
            // 
            // Verde
            // 
            Verde.AutoSize = true;
            Verde.Location = new Point(331, 127);
            Verde.Name = "Verde";
            Verde.Size = new Size(36, 15);
            Verde.TabIndex = 11;
            Verde.Text = "Verde";
            // 
            // Azul
            // 
            Azul.AutoSize = true;
            Azul.Location = new Point(331, 84);
            Azul.Name = "Azul";
            Azul.Size = new Size(30, 15);
            Azul.TabIndex = 12;
            Azul.Text = "Azul";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(396, 227);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 13;
            btnColor.Text = "Cambiar fondo";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // cambiando
            // 
            cambiando.AutoSize = true;
            cambiando.Location = new Point(223, 48);
            cambiando.Name = "cambiando";
            cambiando.Size = new Size(69, 15);
            cambiando.TabIndex = 14;
            cambiando.Text = "Cambiando";
            // 
            // Form03ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(cambiando);
            Controls.Add(btnColor);
            Controls.Add(Azul);
            Controls.Add(Verde);
            Controls.Add(Rojo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnMover);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosiciony);
            Controls.Add(txtPosicionx);
            Controls.Add(txtVerde);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form03ColoresPosicion";
            Text = "Form03ColoresPosicion";
            Load += Form03ColoresPosicion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtPosicionx;
        private TextBox txtPosiciony;
        private Label label1;
        private Label label2;
        private Button btnMover;
        private Label label3;
        private Label label4;
        private Label Rojo;
        private Label Verde;
        private Label Azul;
        private Button btnColor;
        private Label cambiando;
        private TextBox txtAzul;
        private TextBox txtVerde;
    }
}