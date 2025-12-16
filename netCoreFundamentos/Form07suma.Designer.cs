namespace netCoreFundamentos
{
    partial class Form07suma
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
            txtBox = new RichTextBox();
            btnString = new Button();
            btnStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.Location = new Point(51, 47);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(712, 287);
            txtBox.TabIndex = 0;
            txtBox.Text = "";
            // 
            // btnString
            // 
            btnString.Location = new Point(148, 377);
            btnString.Name = "btnString";
            btnString.Size = new Size(155, 23);
            btnString.TabIndex = 1;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(557, 377);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(170, 23);
            btnStringBuilder.TabIndex = 2;
            btnStringBuilder.Text = "Invertir String Builder";
            btnStringBuilder.UseVisualStyleBackColor = true;
            btnStringBuilder.Click += btnStringBuilder_Click;
            // 
            // Form07suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStringBuilder);
            Controls.Add(btnString);
            Controls.Add(txtBox);
            Name = "Form07suma";
            Text = "Form07suma";
            Load += Form07suma_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtBox;
        private Button btnString;
        private Button btnStringBuilder;
    }
}