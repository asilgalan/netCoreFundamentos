using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form17SumarBotones
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
        button2 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        txtSuma = new System.Windows.Forms.TextBox();
        btnIniciar = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        button1 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(262, 28);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(180, 85);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(57, 47);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(138, 33);
        label1.TabIndex = 2;
        label1.Text = "Suma";
        // 
        // txtSuma
        // 
        txtSuma.Location = new System.Drawing.Point(156, 44);
        txtSuma.Name = "txtSuma";
        txtSuma.Size = new System.Drawing.Size(255, 23);
        txtSuma.TabIndex = 3;
        // 
        // btnIniciar
        // 
        btnIniciar.Location = new System.Drawing.Point(455, 44);
        btnIniciar.Name = "btnIniciar";
        btnIniciar.Size = new System.Drawing.Size(135, 27);
        btnIniciar.TabIndex = 4;
        btnIniciar.Text = "iniciar app";
        btnIniciar.UseVisualStyleBackColor = true;
        btnIniciar.Click += btnIniciar_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(button2);
        panel1.Location = new System.Drawing.Point(66, 147);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(567, 272);
        panel1.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(31, 28);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(180, 85);
        button1.TabIndex = 2;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(31, 130);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(180, 85);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // Form17SumarBotones
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        Controls.Add(btnIniciar);
        Controls.Add(txtSuma);
        Controls.Add(label1);
        Text = "Form17SumarBotones";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSuma;
    private System.Windows.Forms.Button btnIniciar;

    private System.Windows.Forms.Button button2;

    #endregion
}