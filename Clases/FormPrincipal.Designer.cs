
namespace Sistema_de_Estudiantes
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.logoSistema = new System.Windows.Forms.PictureBox();
            this.lblSistemaEstud = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelInfoEstudiante = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.fotoEstudiante = new System.Windows.Forms.PictureBox();
            this.panelListaEstudiantes = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.btnPag1 = new System.Windows.Forms.Button();
            this.lblListaEstudiantes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoSistema)).BeginInit();
            this.panelInfoEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEstudiante)).BeginInit();
            this.panelListaEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.panelPrincipal.Controls.Add(this.logoSistema);
            this.panelPrincipal.Controls.Add(this.lblSistemaEstud);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1008, 52);
            this.panelPrincipal.TabIndex = 0;
            // 
            // logoSistema
            // 
            this.logoSistema.Image = ((System.Drawing.Image)(resources.GetObject("logoSistema.Image")));
            this.logoSistema.Location = new System.Drawing.Point(12, 3);
            this.logoSistema.Name = "logoSistema";
            this.logoSistema.Size = new System.Drawing.Size(41, 40);
            this.logoSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoSistema.TabIndex = 1;
            this.logoSistema.TabStop = false;
            // 
            // lblSistemaEstud
            // 
            this.lblSistemaEstud.AutoSize = true;
            this.lblSistemaEstud.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEstud.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSistemaEstud.Location = new System.Drawing.Point(59, 9);
            this.lblSistemaEstud.Name = "lblSistemaEstud";
            this.lblSistemaEstud.Size = new System.Drawing.Size(211, 26);
            this.lblSistemaEstud.TabIndex = 0;
            this.lblSistemaEstud.Text = "Sistema de Estudiantes";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(5, 68);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 18);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtBuscar.Location = new System.Drawing.Point(59, 65);
            this.txtBuscar.MaximumSize = new System.Drawing.Size(250, 26);
            this.txtBuscar.MinimumSize = new System.Drawing.Size(250, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panelInfoEstudiante
            // 
            this.panelInfoEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInfoEstudiante.AutoSize = true;
            this.panelInfoEstudiante.BackColor = System.Drawing.Color.SteelBlue;
            this.panelInfoEstudiante.Controls.Add(this.btnCancelar);
            this.panelInfoEstudiante.Controls.Add(this.btnEliminar);
            this.panelInfoEstudiante.Controls.Add(this.btnAgregar);
            this.panelInfoEstudiante.Controls.Add(this.txtCorreo);
            this.panelInfoEstudiante.Controls.Add(this.lblCorreo);
            this.panelInfoEstudiante.Controls.Add(this.txtApellido);
            this.panelInfoEstudiante.Controls.Add(this.lblApellidos);
            this.panelInfoEstudiante.Controls.Add(this.txtNombre);
            this.panelInfoEstudiante.Controls.Add(this.lblNombre);
            this.panelInfoEstudiante.Controls.Add(this.txtID);
            this.panelInfoEstudiante.Controls.Add(this.lblID);
            this.panelInfoEstudiante.Controls.Add(this.fotoEstudiante);
            this.panelInfoEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelInfoEstudiante.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfoEstudiante.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfoEstudiante.Location = new System.Drawing.Point(12, 102);
            this.panelInfoEstudiante.Name = "panelInfoEstudiante";
            this.panelInfoEstudiante.Size = new System.Drawing.Size(338, 613);
            this.panelInfoEstudiante.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(247, 576);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 34);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(13, 576);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(13, 519);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 34);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(15, 454);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(177, 27);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCorreo.Location = new System.Drawing.Point(11, 432);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 19);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(15, 387);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 27);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblApellidos.Location = new System.Drawing.Point(13, 365);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 19);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 324);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Location = new System.Drawing.Point(11, 302);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 19);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(13, 259);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 9;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblID.Location = new System.Drawing.Point(9, 237);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // fotoEstudiante
            // 
            this.fotoEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("fotoEstudiante.Image")));
            this.fotoEstudiante.Location = new System.Drawing.Point(87, 40);
            this.fotoEstudiante.Name = "fotoEstudiante";
            this.fotoEstudiante.Size = new System.Drawing.Size(157, 154);
            this.fotoEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoEstudiante.TabIndex = 0;
            this.fotoEstudiante.TabStop = false;
            this.fotoEstudiante.Click += new System.EventHandler(this.fotoEstudiante_Click);
            // 
            // panelListaEstudiantes
            // 
            this.panelListaEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListaEstudiantes.AutoSize = true;
            this.panelListaEstudiantes.BackColor = System.Drawing.Color.SteelBlue;
            this.panelListaEstudiantes.Controls.Add(this.lblCantidad);
            this.panelListaEstudiantes.Controls.Add(this.lblPagina);
            this.panelListaEstudiantes.Controls.Add(this.numericUpDown1);
            this.panelListaEstudiantes.Controls.Add(this.btnPagAnterior);
            this.panelListaEstudiantes.Controls.Add(this.btnPagSiguiente);
            this.panelListaEstudiantes.Controls.Add(this.btnPagUltima);
            this.panelListaEstudiantes.Controls.Add(this.btnPag1);
            this.panelListaEstudiantes.Controls.Add(this.lblListaEstudiantes);
            this.panelListaEstudiantes.Controls.Add(this.dataGridView1);
            this.panelListaEstudiantes.Location = new System.Drawing.Point(363, 102);
            this.panelListaEstudiantes.Name = "panelListaEstudiantes";
            this.panelListaEstudiantes.Size = new System.Drawing.Size(633, 613);
            this.panelListaEstudiantes.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(468, 505);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(117, 16);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad de datos";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPagina.Location = new System.Drawing.Point(280, 497);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(60, 19);
            this.lblPagina.TabIndex = 18;
            this.lblPagina.Text = "Página";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 524);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagAnterior.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPagAnterior.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPagAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagAnterior.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagAnterior.Location = new System.Drawing.Point(246, 519);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(61, 27);
            this.btnPagAnterior.TabIndex = 16;
            this.btnPagAnterior.Text = "<-Pág.";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagSiguiente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPagSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPagSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagSiguiente.Location = new System.Drawing.Point(313, 519);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(61, 27);
            this.btnPagSiguiente.TabIndex = 15;
            this.btnPagSiguiente.Text = "Pág.->";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // btnPagUltima
            // 
            this.btnPagUltima.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPagUltima.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPagUltima.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPagUltima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnPagUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagUltima.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagUltima.Location = new System.Drawing.Point(380, 519);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(61, 27);
            this.btnPagUltima.TabIndex = 14;
            this.btnPagUltima.Text = ">>";
            this.btnPagUltima.UseVisualStyleBackColor = false;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // btnPag1
            // 
            this.btnPag1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPag1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPag1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPag1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnPag1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPag1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPag1.Location = new System.Drawing.Point(179, 519);
            this.btnPag1.Name = "btnPag1";
            this.btnPag1.Size = new System.Drawing.Size(61, 27);
            this.btnPag1.TabIndex = 13;
            this.btnPag1.Text = "<<";
            this.btnPag1.UseVisualStyleBackColor = false;
            this.btnPag1.Click += new System.EventHandler(this.btnPag1_Click);
            // 
            // lblListaEstudiantes
            // 
            this.lblListaEstudiantes.AutoSize = true;
            this.lblListaEstudiantes.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEstudiantes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListaEstudiantes.Location = new System.Drawing.Point(229, 5);
            this.lblListaEstudiantes.Name = "lblListaEstudiantes";
            this.lblListaEstudiantes.Size = new System.Drawing.Size(159, 19);
            this.lblListaEstudiantes.TabIndex = 2;
            this.lblListaEstudiantes.Text = "Lista de Estudiantes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 454);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(918, 59);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 34);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 727);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelListaEstudiantes);
            this.Controls.Add(this.panelInfoEstudiante);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 766);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Estudiantes";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoSistema)).EndInit();
            this.panelInfoEstudiante.ResumeLayout(false);
            this.panelInfoEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEstudiante)).EndInit();
            this.panelListaEstudiantes.ResumeLayout(false);
            this.panelListaEstudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblSistemaEstud;
        private System.Windows.Forms.PictureBox logoSistema;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelInfoEstudiante;
        private System.Windows.Forms.Panel panelListaEstudiantes;
        private System.Windows.Forms.PictureBox fotoEstudiante;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListaEstudiantes;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Button btnPagUltima;
        private System.Windows.Forms.Button btnPag1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

