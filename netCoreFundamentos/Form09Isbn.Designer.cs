namespace netCoreFundamentos
{
    partial class Form09Isbn
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
            txtISBN = new System.Windows.Forms.TextBox();
            isbn = new System.Windows.Forms.Label();
            btnComprobar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Location = new System.Drawing.Point(62, 79);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new System.Drawing.Size(222, 23);
            txtISBN.TabIndex = 0;
       
            // 
            // isbn
            // 
            isbn.Location = new System.Drawing.Point(62, 47);
            isbn.Name = "isbn";
            isbn.Size = new System.Drawing.Size(222, 14);
            isbn.TabIndex = 1;
            isbn.Text = "isbn";
          
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new System.Drawing.Point(75, 158);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new System.Drawing.Size(176, 50);
            btnComprobar.TabIndex = 2;
            btnComprobar.Text = "Comprobar ISBN";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(62, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(214, 30);
            label1.TabIndex = 3;
    
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnComprobar);
            Controls.Add(isbn);
            Controls.Add(txtISBN);
            Text = "Form09Isbn";
            Load += Form09Isbn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label isbn;

        private System.Windows.Forms.Button btnComprobar;

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}