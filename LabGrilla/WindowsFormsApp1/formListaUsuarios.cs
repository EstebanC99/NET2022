using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formListaUsuarios : Form
    {
        private Label label1;
        private DataGridView dgvUsuarios;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fecha_nac;
        private DataGridViewTextBoxColumn direccion;
        private Negocio.Usuarios _usuarios;

        public Negocio.Usuarios oUsuarios
        {
            get { return this._usuarios; }
            set { this._usuarios = value; }
        }

        public formListaUsuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
            this.GenerarColumnas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();
        }

        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }

        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void GenerarColumnas()
        {
            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            colNroDoc.Name = "nro_doc";
            colNroDoc.HeaderText = "Nro. Documento";
            colNroDoc.DataPropertyName = "nro_doc";
            colNroDoc.DisplayIndex = 0;
            this.dgvUsuarios.Columns.Add(colNroDoc);

            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();
            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.DisplayIndex = 0;
            colTipoDoc.DataSource = this.getTiposDocumento();
            colTipoDoc.ValueMember = "cod_tipo_doc";
            colTipoDoc.DisplayMember = "desc_tipo_doc";
            this.dgvUsuarios.Columns.Add(colTipoDoc);

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telefono";
            colTel.HeaderText = "Teléfono";
            colTel.DataPropertyName = "telefono";
            
            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "E-Mail";
            colEmail.DataPropertyName = "email";
            
            DataGridViewTextBoxColumn colCel = new DataGridViewTextBoxColumn();
            colCel.Name = "celular";
            colCel.HeaderText = "Celular";
            colCel.DataPropertyName = "celular";
            
            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";
            
            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";
            
            
            colEmail.Width = 250;
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colClave.Visible = false;
            
            this.dgvUsuarios.Columns["direccion"].Width = 250;
            this.dgvUsuarios.Columns["apellido"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["nombre"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["fecha_nac"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;
            
            this.dgvUsuarios.Columns.Add(colTel);
            this.dgvUsuarios.Columns.Add(colEmail);
            this.dgvUsuarios.Columns.Add(colCel);
            this.dgvUsuarios.Columns.Add(colUsuario);
            this.dgvUsuarios.Columns.Add(colClave);
        }

        private DataTable getTiposDocumento()
        {
            //Creo DataTable
            DataTable dtTiposDoc = new DataTable();

            //Agrego columnas al DataTable
            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));

            //Agrego filas al DataTable
            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cédula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Cívica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta Enrolamiento" });

            return dtTiposDoc;
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 10);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuarios:";
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellido,
            this.nombre,
            this.fecha_nac,
            this.direccion});
            this.dgvUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 25);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(645, 150);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(582, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // fecha_nac
            // 
            this.fecha_nac.DataPropertyName = "fecha_nac";
            this.fecha_nac.HeaderText = "Fecha de Nacimiento";
            this.fecha_nac.Name = "fecha_nac";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // formListaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(669, 213);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "formListaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
