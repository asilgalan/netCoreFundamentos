using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form20TestClases
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
        listapersonaje = new System.Windows.Forms.ListBox();
        btncreate = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        btnEmpleado = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listapersonaje
        // 
        listapersonaje.FormattingEnabled = true;
        listapersonaje.Location = new System.Drawing.Point(59, 117);
        listapersonaje.Name = "listapersonaje";
        listapersonaje.Size = new System.Drawing.Size(477, 199);
        listapersonaje.TabIndex = 0;
        // 
        // btncreate
        // 
        btncreate.Location = new System.Drawing.Point(59, 332);
        btncreate.Name = "btncreate";
        btncreate.Size = new System.Drawing.Size(218, 49);
        btncreate.TabIndex = 1;
        btncreate.Text = "Crear Personajes";
        btncreate.UseVisualStyleBackColor = true;
        btncreate.Click += btncreate_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(59, 73);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(218, 30);
        label1.TabIndex = 2;
        label1.Text = "Datos";
        // 
        // btnEmpleado
        // 
        btnEmpleado.Location = new System.Drawing.Point(325, 332);
        btnEmpleado.Name = "btnEmpleado";
        btnEmpleado.Size = new System.Drawing.Size(211, 51);
        btnEmpleado.TabIndex = 3;
        btnEmpleado.Text = "empleado";
        btnEmpleado.UseVisualStyleBackColor = true;
        btnEmpleado.Click += btnEmpleado_Click;
        // 
        // Form20TestClases
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnEmpleado);
        Controls.Add(label1);
        Controls.Add(btncreate);
        Controls.Add(listapersonaje);
        Text = "Form20TestClases";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnEmpleado;

    private System.Windows.Forms.ListBox listapersonaje;
    private System.Windows.Forms.Button btncreate;
    private System.Windows.Forms.Label label1;

    #endregion
}