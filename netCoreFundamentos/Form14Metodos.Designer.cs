using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form14Metodos
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
        label1 = new Label();
        resultado = new Label();
        btnDoble = new Button();
        btnObjecRef = new Button();
        txtNumero = new TextBox();
        btnDobleRef = new Button();
        lblRaton = new Label();
        lblNumeros = new Label();
        lblLetras = new Label();
        txtSoloNumero = new TextBox();
        txtSoloLetras = new TextBox();
        monthCalendar1 = new MonthCalendar();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(29, 8);
        label1.Name = "label1";
        label1.Size = new Size(106, 47);
        label1.TabIndex = 0;
        label1.Text = "Numero";
        // 
        // resultado
        // 
        resultado.Location = new Point(28, 109);
        resultado.Name = "resultado";
        resultado.Size = new Size(182, 54);
        resultado.TabIndex = 1;
        // 
        // btnDoble
        // 
        btnDoble.Location = new Point(211, 33);
        btnDoble.Name = "btnDoble";
        btnDoble.Size = new Size(148, 76);
        btnDoble.TabIndex = 2;
        btnDoble.Text = "Doble Valor";
        btnDoble.UseVisualStyleBackColor = true;
        btnDoble.Click += btnDoble_Click;
        // 
        // btnObjecRef
        // 
        btnObjecRef.Location = new Point(197, 127);
        btnObjecRef.Name = "btnObjecRef";
        btnObjecRef.Size = new Size(162, 91);
        btnObjecRef.TabIndex = 3;
        btnObjecRef.Text = "Doble Oject Referencia";
        btnObjecRef.UseVisualStyleBackColor = true;
        btnObjecRef.Click += btnObjecRef_Click;
        // 
        // txtNumero
        // 
        txtNumero.Location = new Point(28, 33);
        txtNumero.Name = "txtNumero";
        txtNumero.Size = new Size(100, 23);
        txtNumero.TabIndex = 4;
        // 
        // btnDobleRef
        // 
        btnDobleRef.Location = new Point(211, 246);
        btnDobleRef.Name = "btnDobleRef";
        btnDobleRef.Size = new Size(176, 75);
        btnDobleRef.TabIndex = 5;
        btnDobleRef.Text = "Doble por Referencia";
        btnDobleRef.UseVisualStyleBackColor = true;
        btnDobleRef.Click += btnDobleRef_Click;
        // 
        // lblRaton
        // 
        lblRaton.BackColor = Color.IndianRed;
        lblRaton.ForeColor = SystemColors.ActiveCaptionText;
        lblRaton.Location = new Point(432, 142);
        lblRaton.Name = "lblRaton";
        lblRaton.Size = new Size(232, 154);
        lblRaton.TabIndex = 6;
        lblRaton.Text = "lblRaton";
        lblRaton.MouseMove += lblRaton_MouseMove;
        // 
        // lblNumeros
        // 
        lblNumeros.Location = new Point(417, 21);
        lblNumeros.Name = "lblNumeros";
        lblNumeros.Size = new Size(91, 22);
        lblNumeros.TabIndex = 7;
        lblNumeros.Text = "Solo  Numeros";
        // 
        // lblLetras
        // 
        lblLetras.Location = new Point(414, 91);
        lblLetras.Name = "lblLetras";
        lblLetras.Size = new Size(123, 18);
        lblLetras.TabIndex = 8;
        lblLetras.Text = "Solo Letras";
        // 
        // txtSoloNumero
        // 
        txtSoloNumero.Location = new Point(505, 21);
        txtSoloNumero.Name = "txtSoloNumero";
        txtSoloNumero.Size = new Size(176, 23);
        txtSoloNumero.TabIndex = 9;
        txtSoloNumero.KeyPress += txtSoloNumero_KeyPress;
        // 
        // txtSoloLetras
        // 
        txtSoloLetras.Location = new Point(487, 88);
        txtSoloLetras.Name = "txtSoloLetras";
        txtSoloLetras.Size = new Size(161, 23);
        txtSoloLetras.TabIndex = 10;
        txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
        // 
        // monthCalendar1
        // 
        monthCalendar1.Location = new Point(575, 111);
        monthCalendar1.Name = "monthCalendar1";
        monthCalendar1.TabIndex = 11;
        // 
        // Form14Metodos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(monthCalendar1);
        Controls.Add(txtSoloNumero);
        Controls.Add(txtSoloLetras);
        Controls.Add(lblLetras);
        Controls.Add(lblNumeros);
        Controls.Add(lblRaton);
        Controls.Add(btnDobleRef);
        Controls.Add(txtNumero);
        Controls.Add(btnObjecRef);
        Controls.Add(btnDoble);
        Controls.Add(resultado);
        Controls.Add(label1);
        Name = "Form14Metodos";
        Text = "Form14Metodos";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtSoloNumero;
    private System.Windows.Forms.TextBox txtSoloLetras;

    private System.Windows.Forms.Label lblNumeros;
    private System.Windows.Forms.Label lblLetras;

    private System.Windows.Forms.Label lblRaton;

    private System.Windows.Forms.Button btnDobleRef;

    private System.Windows.Forms.Button btnDoble;
    private System.Windows.Forms.Button btnObjecRef;
    private System.Windows.Forms.TextBox txtNumero;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label resultado;

    #endregion

    private MonthCalendar monthCalendar1;
    // Reiniciar el contador antes de empezar la validación
}