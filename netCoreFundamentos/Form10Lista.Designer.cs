using System.ComponentModel;

namespace netCoreFundamentos;

partial class Form10Lista
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
        textList = new System.Windows.Forms.ListBox();
        txtaddLis = new System.Windows.Forms.TextBox();
        btnEliminar = new System.Windows.Forms.Button();
        btnBorrar = new System.Windows.Forms.Button();
        btnInsertar = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textList
        // 
        textList.FormattingEnabled = true;
        textList.Location = new System.Drawing.Point(65, 35);
        textList.Name = "textList";
        textList.Size = new System.Drawing.Size(176, 214);
        textList.TabIndex = 0;
        textList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // txtaddLis
        // 
        txtaddLis.Location = new System.Drawing.Point(323, 33);
        txtaddLis.Name = "txtaddLis";
        txtaddLis.Size = new System.Drawing.Size(228, 23);
        txtaddLis.TabIndex = 1;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new System.Drawing.Point(333, 110);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(217, 37);
        btnEliminar.TabIndex = 2;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnBorrar
        // 
        btnBorrar.Location = new System.Drawing.Point(338, 187);
        btnBorrar.Name = "btnBorrar";
        btnBorrar.Size = new System.Drawing.Size(212, 37);
        btnBorrar.TabIndex = 3;
        btnBorrar.Text = "Borrar";
        btnBorrar.UseVisualStyleBackColor = true;
        btnBorrar.Click += btnBorrar_Click;
        // 
        // btnInsertar
        // 
        btnInsertar.Location = new System.Drawing.Point(349, 263);
        btnInsertar.Name = "btnInsertar";
        btnInsertar.Size = new System.Drawing.Size(200, 50);
        btnInsertar.TabIndex = 4;
        btnInsertar.Text = "Add";
        btnInsertar.UseVisualStyleBackColor = true;
        btnInsertar.Click += btnInsertar_Click;
        // 
        // Form10Lista
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnInsertar);
        Controls.Add(btnBorrar);
        Controls.Add(btnEliminar);
        Controls.Add(txtaddLis);
        Controls.Add(textList);
        Text = "Form10Lista";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtaddLis;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Button btnInsertar;

    private System.Windows.Forms.ListBox textList;

    #endregion
}