using System.ComponentModel;

namespace netCoreFundamentos;

partial class Calculadora
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
        btnCero = new System.Windows.Forms.Button();
        btnUno = new System.Windows.Forms.Button();
        btnDos = new System.Windows.Forms.Button();
        btnTres = new System.Windows.Forms.Button();
        btnCuatro = new System.Windows.Forms.Button();
        btnCinco = new System.Windows.Forms.Button();
        btnSeis = new System.Windows.Forms.Button();
        btnSietes = new System.Windows.Forms.Button();
        btnOcho = new System.Windows.Forms.Button();
        btnNueve = new System.Windows.Forms.Button();
        btnCalculo = new System.Windows.Forms.Button();
        btnSuma = new System.Windows.Forms.Button();
        btnCorregir = new System.Windows.Forms.Button();
        btnResta = new System.Windows.Forms.Button();
        btnMultiplicacion = new System.Windows.Forms.Button();
        btnDividir = new System.Windows.Forms.Button();
        txtNumero = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        btnPunto = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // btnCero
        // 
        btnCero.Location = new System.Drawing.Point(49, 9);
        btnCero.Name = "btnCero";
        btnCero.Size = new System.Drawing.Size(65, 48);
        btnCero.TabIndex = 0;
        btnCero.Text = "0";
        btnCero.UseVisualStyleBackColor = true;
        // 
        // btnUno
        // 
        btnUno.Location = new System.Drawing.Point(131, 9);
        btnUno.Name = "btnUno";
        btnUno.Size = new System.Drawing.Size(65, 48);
        btnUno.TabIndex = 1;
        btnUno.Text = "1";
        btnUno.UseVisualStyleBackColor = true;
        // 
        // btnDos
        // 
        btnDos.Location = new System.Drawing.Point(218, 9);
        btnDos.Name = "btnDos";
        btnDos.Size = new System.Drawing.Size(65, 48);
        btnDos.TabIndex = 2;
        btnDos.Text = "2";
        btnDos.UseVisualStyleBackColor = true;
        // 
        // btnTres
        // 
        btnTres.Location = new System.Drawing.Point(49, 76);
        btnTres.Name = "btnTres";
        btnTres.Size = new System.Drawing.Size(65, 48);
        btnTres.TabIndex = 3;
        btnTres.Text = "3";
        btnTres.UseVisualStyleBackColor = true;
        // 
        // btnCuatro
        // 
        btnCuatro.Location = new System.Drawing.Point(131, 76);
        btnCuatro.Name = "btnCuatro";
        btnCuatro.Size = new System.Drawing.Size(65, 48);
        btnCuatro.TabIndex = 4;
        btnCuatro.Text = "4";
        btnCuatro.UseVisualStyleBackColor = true;
        // 
        // btnCinco
        // 
        btnCinco.Location = new System.Drawing.Point(218, 76);
        btnCinco.Name = "btnCinco";
        btnCinco.Size = new System.Drawing.Size(65, 48);
        btnCinco.TabIndex = 5;
        btnCinco.Text = "5";
        btnCinco.UseVisualStyleBackColor = true;
        // 
        // btnSeis
        // 
        btnSeis.Location = new System.Drawing.Point(49, 146);
        btnSeis.Name = "btnSeis";
        btnSeis.Size = new System.Drawing.Size(65, 48);
        btnSeis.TabIndex = 6;
        btnSeis.Text = "6";
        btnSeis.UseVisualStyleBackColor = true;
        // 
        // btnSietes
        // 
        btnSietes.Location = new System.Drawing.Point(131, 146);
        btnSietes.Name = "btnSietes";
        btnSietes.Size = new System.Drawing.Size(65, 48);
        btnSietes.TabIndex = 7;
        btnSietes.Text = "7";
        btnSietes.UseVisualStyleBackColor = true;
        // 
        // btnOcho
        // 
        btnOcho.Location = new System.Drawing.Point(218, 146);
        btnOcho.Name = "btnOcho";
        btnOcho.Size = new System.Drawing.Size(65, 48);
        btnOcho.TabIndex = 8;
        btnOcho.Text = "8";
        btnOcho.UseVisualStyleBackColor = true;
        // 
        // btnNueve
        // 
        btnNueve.Location = new System.Drawing.Point(49, 204);
        btnNueve.Name = "btnNueve";
        btnNueve.Size = new System.Drawing.Size(65, 48);
        btnNueve.TabIndex = 9;
        btnNueve.Text = "9";
        btnNueve.UseVisualStyleBackColor = true;
        // 
        // btnCalculo
        // 
        btnCalculo.Location = new System.Drawing.Point(218, 200);
        btnCalculo.Name = "btnCalculo";
        btnCalculo.Size = new System.Drawing.Size(65, 48);
        btnCalculo.TabIndex = 10;
        btnCalculo.Text = "=";
        btnCalculo.UseVisualStyleBackColor = true;
        btnCalculo.Click += button11_Click;
        // 
        // btnSuma
        // 
        btnSuma.Location = new System.Drawing.Point(299, 200);
        btnSuma.Name = "btnSuma";
        btnSuma.Size = new System.Drawing.Size(65, 48);
        btnSuma.TabIndex = 11;
        btnSuma.Text = "+";
        btnSuma.UseVisualStyleBackColor = true;
        // 
        // btnCorregir
        // 
        btnCorregir.Location = new System.Drawing.Point(380, 9);
        btnCorregir.Name = "btnCorregir";
        btnCorregir.Size = new System.Drawing.Size(65, 248);
        btnCorregir.TabIndex = 12;
        btnCorregir.Text = "C";
        btnCorregir.UseVisualStyleBackColor = true;
        // 
        // btnResta
        // 
        btnResta.Location = new System.Drawing.Point(299, 146);
        btnResta.Name = "btnResta";
        btnResta.Size = new System.Drawing.Size(65, 48);
        btnResta.TabIndex = 13;
        btnResta.Text = "-";
        btnResta.UseVisualStyleBackColor = true;
        // 
        // btnMultiplicacion
        // 
        btnMultiplicacion.Location = new System.Drawing.Point(299, 9);
        btnMultiplicacion.Name = "btnMultiplicacion";
        btnMultiplicacion.Size = new System.Drawing.Size(65, 48);
        btnMultiplicacion.TabIndex = 14;
        btnMultiplicacion.Text = "*";
        btnMultiplicacion.UseVisualStyleBackColor = true;
        // 
        // btnDividir
        // 
        btnDividir.Location = new System.Drawing.Point(299, 92);
        btnDividir.Name = "btnDividir";
        btnDividir.Size = new System.Drawing.Size(65, 48);
        btnDividir.TabIndex = 15;
        btnDividir.Text = "/";
        btnDividir.UseVisualStyleBackColor = true;
        // 
        // txtNumero
        // 
        txtNumero.Location = new System.Drawing.Point(83, 118);
        txtNumero.Name = "txtNumero";
        txtNumero.Size = new System.Drawing.Size(346, 23);
        txtNumero.TabIndex = 16;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnPunto);
        panel1.Controls.Add(btnDividir);
        panel1.Controls.Add(btnMultiplicacion);
        panel1.Controls.Add(btnResta);
        panel1.Controls.Add(btnCorregir);
        panel1.Controls.Add(btnSuma);
        panel1.Controls.Add(btnCalculo);
        panel1.Controls.Add(btnNueve);
        panel1.Controls.Add(btnOcho);
        panel1.Controls.Add(btnSietes);
        panel1.Controls.Add(btnSeis);
        panel1.Controls.Add(btnCinco);
        panel1.Controls.Add(btnCuatro);
        panel1.Controls.Add(btnTres);
        panel1.Controls.Add(btnDos);
        panel1.Controls.Add(btnUno);
        panel1.Controls.Add(btnCero);
        panel1.Location = new System.Drawing.Point(46, 151);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(517, 286);
        panel1.TabIndex = 17;
        // 
        // btnPunto
        // 
        btnPunto.Location = new System.Drawing.Point(131, 200);
        btnPunto.Name = "btnPunto";
        btnPunto.Size = new System.Drawing.Size(65, 48);
        btnPunto.TabIndex = 16;
        btnPunto.Text = ".";
        btnPunto.UseVisualStyleBackColor = true;
        // 
        // Calculadora
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(872, 598);
        Controls.Add(panel1);
        Controls.Add(txtNumero);
        Location = new System.Drawing.Point(15, 15);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnPunto;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button btnTres;
    private System.Windows.Forms.Button btnCuatro;
    private System.Windows.Forms.Button btnCinco;
    private System.Windows.Forms.Button btnSeis;
    private System.Windows.Forms.Button btnSietes;
    private System.Windows.Forms.Button btnOcho;
    private System.Windows.Forms.Button btnNueve;
    private System.Windows.Forms.Button btnCalculo;
    private System.Windows.Forms.Button btnSuma;
    private System.Windows.Forms.Button btnCorregir;
    private System.Windows.Forms.Button btnResta;
    private System.Windows.Forms.Button btnMultiplicacion;
    private System.Windows.Forms.Button btnDividir;
    private System.Windows.Forms.TextBox txtNumero;

    private System.Windows.Forms.Button btnUno;
    private System.Windows.Forms.Button btnDos;

    private System.Windows.Forms.Button btnCero;

    #endregion
}