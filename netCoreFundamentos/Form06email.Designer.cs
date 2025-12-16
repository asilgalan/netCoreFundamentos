namespace netCoreFundamentos
{
    partial class Form06email
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
            txtEmail = new TextBox();
            btnComprobar = new Button();
            mensaje = new Label();
            error = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 65);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(197, 176);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(75, 23);
            btnComprobar.TabIndex = 2;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.ForeColor = Color.Brown;
            mensaje.Location = new Point(446, 83);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(0, 15);
            mensaje.TabIndex = 3;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.IndianRed;
            error.Location = new Point(210, 146);
            error.Name = "error";
            error.Size = new Size(0, 15);
            error.TabIndex = 4;
            // 
            // Form06email
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(error);
            Controls.Add(mensaje);
            Controls.Add(btnComprobar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form06email";
            Text = "Form06email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnComprobar;
        private Label mensaje;
        private Label error;
    }
}