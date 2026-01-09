using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form12CollecionNumero
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
        listBox1 = new System.Windows.Forms.ListBox();
        Numeros = new System.Windows.Forms.Label();
        btnGenerar = new System.Windows.Forms.Button();
        btnMostrar = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        txtsuma = new System.Windows.Forms.TextBox();
        txtPar = new System.Windows.Forms.TextBox();
        txtImpare = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(38, 41);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(188, 259);
        listBox1.TabIndex = 0;
        // 
        // Numeros
        // 
        Numeros.Location = new System.Drawing.Point(40, 10);
        Numeros.Name = "Numeros";
        Numeros.Size = new System.Drawing.Size(185, 22);
        Numeros.TabIndex = 1;
        Numeros.Text = "Numeros";
        // 
        // btnGenerar
        // 
        btnGenerar.Location = new System.Drawing.Point(300, 46);
        btnGenerar.Name = "btnGenerar";
        btnGenerar.Size = new System.Drawing.Size(288, 43);
        btnGenerar.TabIndex = 2;
        btnGenerar.Text = "Generar Numeros";
        btnGenerar.UseVisualStyleBackColor = true;
        btnGenerar.Click += btnGenerar_Click;
        // 
        // btnMostrar
        // 
        btnMostrar.Location = new System.Drawing.Point(300, 120);
        btnMostrar.Name = "btnMostrar";
        btnMostrar.Size = new System.Drawing.Size(287, 62);
        btnMostrar.TabIndex = 3;
        btnMostrar.Text = "Mostrar Datos";
        btnMostrar.UseVisualStyleBackColor = true;
        btnMostrar.Click += btnMostrar_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(298, 224);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(87, 35);
        label1.TabIndex = 4;
        label1.Text = "Suma:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(300, 287);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(84, 32);
        label2.TabIndex = 5;
        label2.Text = "Pares:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(300, 340);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(84, 49);
        label3.TabIndex = 6;
        label3.Text = "Impares";
        // 
        // txtsuma
        // 
        txtsuma.Location = new System.Drawing.Point(390, 222);
        txtsuma.Name = "txtsuma";
        txtsuma.Size = new System.Drawing.Size(196, 23);
        txtsuma.TabIndex = 7;
        // 
        // txtPar
        // 
        txtPar.Location = new System.Drawing.Point(399, 282);
        txtPar.Name = "txtPar";
        txtPar.Size = new System.Drawing.Size(186, 23);
        txtPar.TabIndex = 8;
        // 
        // txtImpare
        // 
        txtImpare.Location = new System.Drawing.Point(407, 343);
        txtImpare.Name = "txtImpare";
        txtImpare.Size = new System.Drawing.Size(178, 23);
        txtImpare.TabIndex = 9;
        // 
        // Form12CollecionNumero
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(txtImpare);
        Controls.Add(txtPar);
        Controls.Add(txtsuma);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnMostrar);
        Controls.Add(btnGenerar);
        Controls.Add(Numeros);
        Controls.Add(listBox1);
        Text = "Form12CollecionNumero";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label Numeros;
    private System.Windows.Forms.Button btnGenerar;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtsuma;
    private System.Windows.Forms.TextBox txtPar;
    private System.Windows.Forms.TextBox txtImpare;

    #endregion
}