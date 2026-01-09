namespace netCoreFundamentos;

public partial class Form13TiendaProducto : Form
{
    public Form13TiendaProducto()
    {
       
        InitializeComponent();
        this.ListProducto.SelectionMode= 
            SelectionMode.MultiExtended;
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }


    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        btnNuevo = new System.Windows.Forms.Button();
        btnEliminar = new System.Windows.Forms.Button();
        btnBorrar = new System.Windows.Forms.Button();
        btnSeleccionar = new System.Windows.Forms.Button();
        btnTodos = new System.Windows.Forms.Button();
        btnSubir = new System.Windows.Forms.Button();
        btnBajar = new System.Windows.Forms.Button();
        ListProducto = new System.Windows.Forms.ListBox();
        listAlmacen = new System.Windows.Forms.ListBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        txtProducto = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 7);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(128, 26);
        label1.TabIndex = 0;
        label1.Text = "Producto";
        // 
        // btnNuevo
        // 
        btnNuevo.Location = new System.Drawing.Point(30, 132);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new System.Drawing.Size(121, 40);
        btnNuevo.TabIndex = 1;
        btnNuevo.Text = "Nuevo";
        btnNuevo.UseVisualStyleBackColor = true;
        btnNuevo.Click += btnNuevo_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new System.Drawing.Point(27, 200);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(123, 37);
        btnEliminar.TabIndex = 2;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnBorrar
        // 
        btnBorrar.Location = new System.Drawing.Point(25, 269);
        btnBorrar.Name = "btnBorrar";
        btnBorrar.Size = new System.Drawing.Size(124, 40);
        btnBorrar.TabIndex = 3;
        btnBorrar.Text = "Borrar Todo";
        btnBorrar.UseVisualStyleBackColor = true;
        btnBorrar.Click += btnBorrar_Click;
        // 
        // btnSeleccionar
        // 
        btnSeleccionar.Location = new System.Drawing.Point(367, 121);
        btnSeleccionar.Name = "btnSeleccionar";
        btnSeleccionar.Size = new System.Drawing.Size(83, 39);
        btnSeleccionar.TabIndex = 4;
        btnSeleccionar.Text = "Seleccionar";
        btnSeleccionar.UseVisualStyleBackColor = true;
        btnSeleccionar.Click += btnSeleccionar_Click;
        // 
        // btnTodos
        // 
        btnTodos.Location = new System.Drawing.Point(366, 187);
        btnTodos.Name = "btnTodos";
        btnTodos.Size = new System.Drawing.Size(83, 49);
        btnTodos.TabIndex = 5;
        btnTodos.Text = "Todos";
        btnTodos.UseVisualStyleBackColor = true;
        btnTodos.Click += btnTodos_Click;
        // 
        // btnSubir
        // 
        btnSubir.Location = new System.Drawing.Point(603, 115);
        btnSubir.Name = "btnSubir";
        btnSubir.Size = new System.Drawing.Size(73, 44);
        btnSubir.TabIndex = 6;
        btnSubir.Text = "Subir";
        btnSubir.UseVisualStyleBackColor = true;
        btnSubir.Click += btnSubir_Click;
        // 
        // btnBajar
        // 
        btnBajar.Location = new System.Drawing.Point(597, 183);
        btnBajar.Name = "btnBajar";
        btnBajar.Size = new System.Drawing.Size(78, 38);
        btnBajar.TabIndex = 7;
        btnBajar.Text = "Bajar";
        btnBajar.UseVisualStyleBackColor = true;
        btnBajar.Click += btnBajar_Click;
        // 
        // ListProducto
        // 
        ListProducto.FormattingEnabled = true;
        ListProducto.Location = new System.Drawing.Point(171, 56);
        ListProducto.Name = "ListProducto";
        ListProducto.Size = new System.Drawing.Size(158, 169);
        ListProducto.TabIndex = 8;
        // 
        // listAlmacen
        // 
        listAlmacen.FormattingEnabled = true;
        listAlmacen.Location = new System.Drawing.Point(462, 57);
        listAlmacen.Name = "listAlmacen";
        listAlmacen.Size = new System.Drawing.Size(135, 199);
        listAlmacen.TabIndex = 9;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(174, 13);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(139, 31);
        label2.TabIndex = 10;
        label2.Text = "Tienda";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(451, 16);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(152, 40);
        label3.TabIndex = 11;
        label3.Text = "Almacen";
        // 
        // txtProducto
        // 
        txtProducto.Location = new System.Drawing.Point(31, 49);
        txtProducto.Name = "txtProducto";
        txtProducto.Size = new System.Drawing.Size(120, 23);
        txtProducto.TabIndex = 12;
        // 
        // Form13TiendaProducto
        // 
        ClientSize = new System.Drawing.Size(687, 374);
        Controls.Add(txtProducto);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(listAlmacen);
        Controls.Add(ListProducto);
        Controls.Add(btnBajar);
        Controls.Add(btnSubir);
        Controls.Add(btnTodos);
        Controls.Add(btnSeleccionar);
        Controls.Add(btnBorrar);
        Controls.Add(btnEliminar);
        Controls.Add(btnNuevo);
        Controls.Add(label1);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnBorrar;
    private System.Windows.Forms.Button btnSeleccionar;
    private System.Windows.Forms.Button btnTodos;
    private System.Windows.Forms.Button btnSubir;
    private System.Windows.Forms.Button btnBajar;
    private System.Windows.Forms.ListBox ListProducto;
    private System.Windows.Forms.ListBox listAlmacen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtProducto;

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        
        
        this.ListProducto.Items.Remove(ListProducto.SelectedItem);
        
    }
    private void btnNuevo_Click(object sender, EventArgs e)
    {
        ListProducto.SelectedItem = null;
      

        if (!ListProducto.Items.Contains(txtProducto.Text))
        {
            this.ListProducto.Items.Add(txtProducto.Text);
        }
        else
        {
            ListProducto.SelectedIndex = ListProducto.Items.Count - 1;
        }
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
     
        this.ListProducto.Items.Clear();
    }

    private void btnSeleccionar_Click(object sender, EventArgs e)
    {
        foreach (string item in ListProducto.Items) {
            if (!this.listAlmacen.Items.Contains(item))
            {
                this.listAlmacen.Items.Add(this.ListProducto.Text);
            }
            
       
        }

        
    
    }

    private void btnTodos_Click(object sender, EventArgs e)
    {


        foreach (string item in ListProducto.Items)
        {
            if (!this.listAlmacen.Items.Contains(item))
            {
                this.listAlmacen.Items.Add(item);
            }
          
        }
        
        
       
    }

    private void btnSubir_Click(object sender, EventArgs e)
    {
        int indiceSeleccionado = this.listAlmacen.SelectedIndex;

      
        if (indiceSeleccionado > 0)
        {
     
            object elementoAMover = this.listAlmacen.SelectedItem;

      
            this.listAlmacen.Items.RemoveAt(indiceSeleccionado);

   
            this.listAlmacen.Items.Insert(indiceSeleccionado - 1, elementoAMover);
            
            this.listAlmacen.SelectedIndex = indiceSeleccionado - 1;
        }
    }

    private void btnBajar_Click(object sender, EventArgs e)
    {
        int indiceSeleccionado = this.listAlmacen.SelectedIndex;
        int ultimoIndice = this.listAlmacen.Items.Count - 1; 
      
        if (indiceSeleccionado >= 0 && indiceSeleccionado < ultimoIndice)
        {
     
            object elementoAMover = this.listAlmacen.SelectedItem;

      
            this.listAlmacen.Items.RemoveAt(indiceSeleccionado);

   
            this.listAlmacen.Items.Insert(indiceSeleccionado +1, elementoAMover);
            
            this.listAlmacen.SelectedIndex = indiceSeleccionado + 1;
        }
    }
}