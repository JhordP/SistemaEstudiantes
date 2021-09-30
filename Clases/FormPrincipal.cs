using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Sistema_de_Estudiantes
{
    public partial class FormPrincipal : Form
    {
        private Estudiantes sistemaEstudiantes;

        public FormPrincipal()
        {
            InitializeComponent();

            var listTxtBox = new List<TextBox>();
            listTxtBox.Add(txtID);
            listTxtBox.Add(txtNombre);
            listTxtBox.Add(txtApellido);
            listTxtBox.Add(txtCorreo);

            var listLbl = new List<Label>();
            listLbl.Add(lblID);
            listLbl.Add(lblNombre);
            listLbl.Add(lblApellidos);
            listLbl.Add(lblCorreo);

            Object[] Objetos = 
                { fotoEstudiante, dataGridView1, numericUpDown1, lblPagina};

            sistemaEstudiantes = new Estudiantes(listTxtBox, listLbl, Objetos);

            //Control cajita e' numero'.
            numericUpDown1.Value = 3;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;
        }

        #region eventosTXTBOX
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                lblID.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                lblID.ForeColor = Color.White;
            }

        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sistemaEstudiantes.txtEvent.txtKeyPressRESTRICCION_NUMEROS(e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                lblNombre.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                lblNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sistemaEstudiantes.txtEvent.txtKeyPressRESTRICCION_LETRAS(e);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text == string.Empty)
            {
                lblApellidos.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                lblApellidos.ForeColor = Color.White;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            sistemaEstudiantes.txtEvent.txtKeyPressRESTRICCION_LETRAS(e);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text == string.Empty)
            {
                lblCorreo.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                lblCorreo.ForeColor = Color.White;
            }
        }

        //private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e) {/*Metodo vacio por el momento*/}

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            sistemaEstudiantes.buscarEstudiante(txtBuscar.Text);
        }

        #endregion

        #region BOTONES
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.Registrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.Eliminar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.Reset();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPag1_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.gestorPaginas(0);
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.gestorPaginas(1);
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.gestorPaginas(2);
        }

        private void btnPagUltima_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.gestorPaginas(3);
        }

        //Cambiar foto del Estudiante
        private void fotoEstudiante_Click(object sender, EventArgs e)
        {
            sistemaEstudiantes.uploadImage.subirFoto(fotoEstudiante);
        }




        #endregion

        #region UI de Datos
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sistemaEstudiantes.cantidadRegistros();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) sistemaEstudiantes.getEstudiante();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) sistemaEstudiantes.getEstudiante();
        }
        #endregion

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) sistemaEstudiantes.getEstudiante();
        }

        
    }
}
