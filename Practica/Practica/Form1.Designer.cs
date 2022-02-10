namespace Practica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarSubitem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitarSubitem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.textBoxFacultad = new System.Windows.Forms.TextBox();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCarrerras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDOS";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(133, 52);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(133, 108);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(133, 161);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdad.TabIndex = 5;
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.ContextMenuStrip = this.Menu;
            this.dataGridViewLista.Location = new System.Drawing.Point(298, 41);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(490, 234);
            this.dataGridViewLista.TabIndex = 6;
            this.dataGridViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentClick);
            this.dataGridViewLista.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentDoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEditar,
            this.itemBorrar});
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(107, 48);
            // 
            // itemEditar
            // 
            this.itemEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarSubitem,
            this.deshabilitarSubitem});
            this.itemEditar.Name = "itemEditar";
            this.itemEditar.Size = new System.Drawing.Size(106, 22);
            this.itemEditar.Text = "Editar";
            // 
            // habilitarSubitem
            // 
            this.habilitarSubitem.Name = "habilitarSubitem";
            this.habilitarSubitem.Size = new System.Drawing.Size(136, 22);
            this.habilitarSubitem.Text = "Habilitar";
            this.habilitarSubitem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // deshabilitarSubitem
            // 
            this.deshabilitarSubitem.Name = "deshabilitarSubitem";
            this.deshabilitarSubitem.Size = new System.Drawing.Size(136, 22);
            this.deshabilitarSubitem.Text = "Deshabilitar";
            this.deshabilitarSubitem.Click += new System.EventHandler(this.deshabilitarToolStripMenuItem_Click);
            // 
            // itemBorrar
            // 
            this.itemBorrar.Name = "itemBorrar";
            this.itemBorrar.Size = new System.Drawing.Size(106, 22);
            this.itemBorrar.Text = "Borrar";
            this.itemBorrar.Click += new System.EventHandler(this.itemBorrar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(498, 299);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 7;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRegistro.Location = new System.Drawing.Point(326, 299);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistro.TabIndex = 8;
            this.buttonRegistro.Text = "REGISTRAR";
            this.buttonRegistro.UseVisualStyleBackColor = false;
            this.buttonRegistro.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxFacultad
            // 
            this.textBoxFacultad.Location = new System.Drawing.Point(133, 301);
            this.textBoxFacultad.Name = "textBoxFacultad";
            this.textBoxFacultad.Size = new System.Drawing.Size(100, 20);
            this.textBoxFacultad.TabIndex = 10;
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(133, 211);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarnet.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CARNET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CARRERA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "FACULTAD";
            // 
            // comboBoxCarrerras
            // 
            this.comboBoxCarrerras.FormattingEnabled = true;
            this.comboBoxCarrerras.Items.AddRange(new object[] {
            "ING. Sistemas",
            "ING. Agricola",
            "ING. Civil"});
            this.comboBoxCarrerras.Location = new System.Drawing.Point(133, 254);
            this.comboBoxCarrerras.Name = "comboBoxCarrerras";
            this.comboBoxCarrerras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarrerras.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.comboBoxCarrerras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.textBoxFacultad);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Practica.Properties.Resources.icon;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de estudiantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.TextBox textBoxFacultad;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCarrerras;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem itemEditar;
        private System.Windows.Forms.ToolStripMenuItem itemBorrar;
        private System.Windows.Forms.ToolStripMenuItem habilitarSubitem;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarSubitem;
    }
}

