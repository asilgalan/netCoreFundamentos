using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form21CajeroBancario
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
        btnIngresar = new System.Windows.Forms.Button();
        btnRetirar = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        listadoOperaciones = new System.Windows.Forms.ListBox();
        label2 = new System.Windows.Forms.Label();
        saldo = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnIngresar
        // 
        btnIngresar.Location = new System.Drawing.Point(61, 243);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new System.Drawing.Size(242, 74);
        btnIngresar.TabIndex = 0;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // btnRetirar
        // 
        btnRetirar.Location = new System.Drawing.Point(327, 251);
        btnRetirar.Name = "btnRetirar";
        btnRetirar.Size = new System.Drawing.Size(241, 65);
        btnRetirar.TabIndex = 1;
        btnRetirar.Text = "Retirar";
        btnRetirar.UseVisualStyleBackColor = true;
        btnRetirar.Click += btnRetirar_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(366, 41);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(237, 23);
        textBox1.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(234, 44);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(126, 23);
        label1.TabIndex = 3;
        label1.Text = "ingrese cantidad";
        // 
        // listadoOperaciones
        // 
        listadoOperaciones.FormattingEnabled = true;
        listadoOperaciones.Location = new System.Drawing.Point(64, 91);
        listadoOperaciones.Name = "listadoOperaciones";
        listadoOperaciones.Size = new System.Drawing.Size(503, 124);
        listadoOperaciones.TabIndex = 4;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(47, 38);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(154, 43);
        label2.TabIndex = 5;
        label2.Text = "Saldo:";
        // 
        // saldo
        // 
        saldo.Location = new System.Drawing.Point(111, 38);
        saldo.Name = "saldo";
        saldo.Size = new System.Drawing.Size(89, 28);
        saldo.TabIndex = 6;
        // 
        // Form21CajeroBancario
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(saldo);
        Controls.Add(label2);
        Controls.Add(listadoOperaciones);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(btnRetirar);
        Controls.Add(btnIngresar);
        Text = "Form21CajeroBancario";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label saldo;

    private System.Windows.Forms.Button btnIngresar;
    private System.Windows.Forms.Button btnRetirar;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listadoOperaciones;

    #endregion
}