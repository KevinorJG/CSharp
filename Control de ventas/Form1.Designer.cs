
namespace Control_de_ventas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AreaVenta = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.comboBoxPago = new System.Windows.Forms.ComboBox();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.labelPago = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelActualFecha = new System.Windows.Forms.Label();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnProductos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBoleta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.AreaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaVenta
            // 
            this.AreaVenta.Controls.Add(this.labelPrice);
            this.AreaVenta.Controls.Add(this.labelDescripcion);
            this.AreaVenta.Controls.Add(this.textBoxCantidad);
            this.AreaVenta.Controls.Add(this.labelCantidad);
            this.AreaVenta.Controls.Add(this.comboBoxPago);
            this.AreaVenta.Controls.Add(this.comboBoxProductos);
            this.AreaVenta.Controls.Add(this.labelPago);
            this.AreaVenta.Controls.Add(this.labelProductos);
            this.AreaVenta.Location = new System.Drawing.Point(12, 70);
            this.AreaVenta.Name = "AreaVenta";
            this.AreaVenta.Size = new System.Drawing.Size(776, 163);
            this.AreaVenta.TabIndex = 0;
            this.AreaVenta.TabStop = false;
            this.AreaVenta.Text = "Area de venta";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(618, 66);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 27);
            this.labelPrice.TabIndex = 7;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(611, 50);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(99, 13);
            this.labelDescripcion.TabIndex = 6;
            this.labelDescripcion.Text = "Precio del producto";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(329, 67);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(333, 50);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad";
            // 
            // comboBoxPago
            // 
            this.comboBoxPago.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPago.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPago.FormattingEnabled = true;
            this.comboBoxPago.Items.AddRange(new object[] {
            "Contado",
            "Tarjeta"});
            this.comboBoxPago.Location = new System.Drawing.Point(26, 121);
            this.comboBoxPago.Name = "comboBoxPago";
            this.comboBoxPago.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPago.TabIndex = 3;
            this.comboBoxPago.Text = "(Seleccione un pago)";
            this.comboBoxPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxPago_SelectedIndexChanged);
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Items.AddRange(new object[] {
            "Coleccion Escolar",
            "Coleccion PreUniversitaria",
            "Coleccion Profesional"});
            this.comboBoxProductos.Location = new System.Drawing.Point(26, 66);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(146, 21);
            this.comboBoxProductos.TabIndex = 2;
            this.comboBoxProductos.Text = "(Seleccione un tarjeta)";
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Location = new System.Drawing.Point(23, 105);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(122, 13);
            this.labelPago.TabIndex = 1;
            this.labelPago.Text = "Seleccione tipo de pago";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(23, 50);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(114, 13);
            this.labelProductos.TabIndex = 0;
            this.labelProductos.Text = "Seleccion un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTROL DE REGISTRO DE VENTAS";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(615, 60);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(73, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha Actual:";
            // 
            // labelActualFecha
            // 
            this.labelActualFecha.AutoSize = true;
            this.labelActualFecha.Location = new System.Drawing.Point(703, 60);
            this.labelActualFecha.Name = "labelActualFecha";
            this.labelActualFecha.Size = new System.Drawing.Size(0, 13);
            this.labelActualFecha.TabIndex = 3;
            this.labelActualFecha.Click += new System.EventHandler(this.labelActualFecha_Click);
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(119, 239);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(93, 23);
            this.buttonRegistro.TabIndex = 4;
            this.buttonRegistro.Text = "REGISTRAR";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "CANCELAR";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 485);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "SALIR";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProductos,
            this.columnCantidad,
            this.columnPrecio,
            this.columnPago,
            this.columnDescuento,
            this.columnRecargo,
            this.columnPrecioFinal,
            this.columnRegistro,
            this.columnBoleta});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(942, 211);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnProductos
            // 
            this.columnProductos.Text = "PRODUCTOS";
            this.columnProductos.Width = 150;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "CANT.";
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "PRECIO";
            this.columnPrecio.Width = 80;
            // 
            // columnPago
            // 
            this.columnPago.Text = "TIPO PAGO";
            this.columnPago.Width = 100;
            // 
            // columnDescuento
            // 
            this.columnDescuento.Text = "DESCUENTO";
            this.columnDescuento.Width = 100;
            // 
            // columnRecargo
            // 
            this.columnRecargo.Text = "RECARGO";
            this.columnRecargo.Width = 100;
            // 
            // columnPrecioFinal
            // 
            this.columnPrecioFinal.Text = "PRECIO FINAL";
            this.columnPrecioFinal.Width = 100;
            // 
            // columnRegistro
            // 
            this.columnRegistro.Text = "REGISTRO";
            this.columnRegistro.Width = 150;
            // 
            // columnBoleta
            // 
            this.columnBoleta.Text = "REFERENCIA";
            this.columnBoleta.Width = 140;
            // 
            // checkImg
            // 
            this.checkImg.Image = global::Control_de_ventas.Properties.Resources.check;
            this.checkImg.Location = new System.Drawing.Point(795, 33);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(200, 200);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkImg.TabIndex = 9;
            this.checkImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 520);
            this.Controls.Add(this.checkImg);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.labelActualFecha);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreaVenta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control de registro de ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AreaVenta.ResumeLayout(false);
            this.AreaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AreaVenta;
        private System.Windows.Forms.ComboBox comboBoxPago;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelActualFecha;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnProductos;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.ColumnHeader columnPago;
        private System.Windows.Forms.ColumnHeader columnDescuento;
        private System.Windows.Forms.ColumnHeader columnRecargo;
        private System.Windows.Forms.ColumnHeader columnPrecioFinal;
        private System.Windows.Forms.ColumnHeader columnRegistro;
        private System.Windows.Forms.ColumnHeader columnBoleta;
        private System.Windows.Forms.PictureBox checkImg;
    }
}

