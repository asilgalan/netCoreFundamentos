using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form18SumarCheckBox
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        checkBox1 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox3 = new System.Windows.Forms.CheckBox();
        checkBox4 = new System.Windows.Forms.CheckBox();
        checkBox5 = new System.Windows.Forms.CheckBox();
        checkBox6 = new System.Windows.Forms.CheckBox();
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        txtSuma = new System.Windows.Forms.TextBox();
        btnIniciar = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(7, 24);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(88, 51);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(420, 35);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(88, 51);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "checkBox2";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox3
        // 
        checkBox3.Location = new System.Drawing.Point(268, 77);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(88, 51);
        checkBox3.TabIndex = 2;
        checkBox3.Text = "checkBox3";
        checkBox3.UseVisualStyleBackColor = true;
        // 
        // checkBox4
        // 
        checkBox4.Location = new System.Drawing.Point(268, 24);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new System.Drawing.Size(88, 51);
        checkBox4.TabIndex = 3;
        checkBox4.Text = "checkBox4";
        checkBox4.UseVisualStyleBackColor = true;
        // 
        // checkBox5
        // 
        checkBox5.Location = new System.Drawing.Point(436, 77);
        checkBox5.Name = "checkBox5";
        checkBox5.Size = new System.Drawing.Size(88, 51);
        checkBox5.TabIndex = 4;
        checkBox5.Text = "checkBox5";
        checkBox5.UseVisualStyleBackColor = true;
        // 
        // checkBox6
        // 
        checkBox6.Location = new System.Drawing.Point(150, 24);
        checkBox6.Name = "checkBox6";
        checkBox6.Size = new System.Drawing.Size(88, 51);
        checkBox6.TabIndex = 5;
        checkBox6.Text = "checkBox6";
        checkBox6.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Controls.Add(checkBox6);
        panel1.Controls.Add(checkBox5);
        panel1.Controls.Add(checkBox4);
        panel1.Controls.Add(checkBox3);
        panel1.Controls.Add(checkBox2);
        panel1.Controls.Add(checkBox1);
        panel1.Location = new System.Drawing.Point(22, 116);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(604, 288);
        panel1.TabIndex = 6;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(25, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(110, 37);
        label1.TabIndex = 7;
        label1.Text = "Sumar";
        // 
        // txtSuma
        // 
        txtSuma.Location = new System.Drawing.Point(172, 19);
        txtSuma.Name = "txtSuma";
        txtSuma.Size = new System.Drawing.Size(205, 23);
        txtSuma.TabIndex = 8;
        // 
        // btnIniciar
        // 
        btnIniciar.Location = new System.Drawing.Point(470, 12);
        btnIniciar.Name = "btnIniciar";
        btnIniciar.Size = new System.Drawing.Size(144, 45);
        btnIniciar.TabIndex = 9;
        btnIniciar.Text = "iniciar";
        btnIniciar.UseVisualStyleBackColor = true;
        btnIniciar.Click += btnIniciar_Click;
        // 
        // Form18SumarCheckBox
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnIniciar);
        Controls.Add(txtSuma);
        Controls.Add(label1);
        Controls.Add(panel1);
        Text = "Form18SumarCheckBox";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtSuma;
    private System.Windows.Forms.Button btnIniciar;

    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;

    #endregion
}