using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using LinqToDB;
using Logica.Libreria;

namespace Logica
{
    public class Estudiantes : Library
    {
        Conexion conexionDB;
        private List<TextBox> listTxtBox;
        private List<Label> listLbl;
        private Paginador<Estudiante> Paginador;

        //Object Array
        private PictureBox cajaFoto; 
        private DataGridView datagrid;
        private NumericUpDown cantRegistros;
        private Label lblPagina;
        private string accion;

        public Estudiantes(List<TextBox> listTxtBox, List<Label> listLbl, Object[] objetos)
        {
            this.listTxtBox = listTxtBox;
            this.listLbl = listLbl;
            accion = "insert";

            //Asignacion de los objetos en el array 
            cajaFoto = (PictureBox)objetos[0];
            datagrid = (DataGridView)objetos[1];
            cantRegistros = (NumericUpDown)objetos[2];
            lblPagina = (Label)objetos[3]; 
            //Recordatorio: No puse lblPagina en el List de Label por la estructura de los ciclos en AgregarFailed(Linea:99)

            conexionDB = new Conexion();
            
            Reset();
            
            
        }

        public void Reset()
        {
            accion = "insert";
            num_pagina = 1;
            numEstudiante = 0;

            foreach (var txt in listTxtBox)
            {
                txt.Clear();
            }
            listaEstudiantes = tablaEstudiante.ToList();
            if (listaEstudiantes.Count > 0) 
                Paginador = new Paginador<Estudiante>(listaEstudiantes, lblPagina, registro_porPagina);

            buscarEstudiante(""); //Realiza un filtro automatico de todos los registros en la tabla.
        }

        public void Registrar()
        {
              string textoAlerta;
              string tituloAlerta;
              int camposVacios = 0;

            //Invoco al metodo que convierte la imagen en un arreglo de bytes y almaceno el return en este var.
            var fotoByte = uploadImage.imageToByte(cajaFoto.Image);

            foreach (var txtbox in listTxtBox)
            {
                if (txtbox.Text.Equals(string.Empty)) camposVacios += 1;
            }

            if (camposVacios == 0) agregarSuccess();
            else  /* -------> */   agregarFailed();

            
            void agregarSuccess()
            {
                string email = listTxtBox[3].Text;

                if (txtEvent.validarEmail(email) == true) 
                { 
                    var registros_con_EmailExistentes = conexionDB.tablaEstudiante.Where(estud => estud.email.Equals(listTxtBox[3].Text)).ToList();
                    
                    if (registros_con_EmailExistentes.Count.Equals(0))
                    {
                        textoAlerta = "Registro completado satisfactoriamente.";
                        tituloAlerta = "Registro agregado";
                        MessageBox.Show(textoAlerta, tituloAlerta,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Save();

                    }
                    else
                    {
                        if (registros_con_EmailExistentes[0].num.Equals(numEstudiante))
                        {
                            Save();
                            
                        }
                        else
                        {
                            textoAlerta = "Este email ya está registrado con otro usuario.";
                            tituloAlerta = "Registro duplicado";
                            MessageBox.Show(textoAlerta, tituloAlerta,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
                    }

                }

                else
                {
                    textoAlerta = "El formato del Email no es valido.";
                    tituloAlerta = "Email invalido.";
                    MessageBox.Show(textoAlerta,tituloAlerta,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            void agregarFailed()
            {
                for (int i = 0; i < listTxtBox.Count; i++)
                {
                    if (listTxtBox[i].Text.Equals(string.Empty))
                    {
                        textoAlerta = $"El campo {listLbl[i].Text} es requerido. No puede estar vacio.";
                        tituloAlerta = $"Campo {listLbl[i].Text} Vacio";
                        //listLbl[0].Text = "El campo ID es requerido.";
                        MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        listLbl[i].ForeColor = Color.Red;
                        listTxtBox[i].Focus();
                        break;
                    }
                }
            }
            
            void Save()
            {
                conexionDB.BeginTransactionAsync();
                try
                {
                    foreach (var txt in listTxtBox)
                    {
                        txt.Text.Trim();
                    }

                    switch (accion)
                    {
                        case "insert":
                            conexionDB.Insert(new Estudiante()
                            {
                                id = Convert.ToInt32(listTxtBox[0].Text),
                                nombre = listTxtBox[1].Text,
                                apellido = listTxtBox[2].Text,
                                email = listTxtBox[3].Text,
                                foto = fotoByte
                            });
                            break;

                        case "update":
                            tablaEstudiante.Where(estudiante => estudiante.num.Equals(numEstudiante))
                                .Set(estudiante => estudiante.id, Convert.ToInt32(listTxtBox[0].Text))
                                .Set(estudiante => estudiante.nombre, listTxtBox[1].Text)
                                .Set(estudiante => estudiante.apellido, listTxtBox[2].Text)
                                .Set(estudiante => estudiante.email, listTxtBox[3].Text)
                                .Set(estudiante => estudiante.foto, fotoByte).Update();
                            break;

                        default:
                            break;
                    }

                    conexionDB.CommitTransaction();
                    Reset();

                    //db.tablaEstudiante.Value(estudiante => estudiante.id, Convert.ToInt32(listTxtBox[0].Text))
                    //                  .Value(estudiante => estudiante.nombre, listTxtBox[1].Text)
                    //                  .Value(estudiante => estudiante.apellido, listTxtBox[2].Text)
                    //                  .Value(estudiante => estudiante.email, listTxtBox[3].Text)
                    //                  .Value(estudiante => estudiante.foto, fotoByte)
                    //                  .Insert();
                }
                catch (Exception)
                {
                    conexionDB.RollbackTransaction();
                }

                buscarEstudiante("");
                
            }

            #region Codigo Inicial Linea 43
            /*
            if (listTxtBox[0].Text.Equals(string.Empty)) //Validando si la propiedad Text del index 0 esta vacia o ""
            {
                textoAlerta = "El campo ID es requerido. No puede estar vacio.";
                tituloAlerta = "Campo ID Vacio";
                //listLbl[0].Text = "El campo ID es requerido.";
                var alertaID = MessageBox.Show(textoAlerta,tituloAlerta,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                listLbl[0].ForeColor = Color.Red;
                listTxtBox[0].Focus();
            }

            else if (listTxtBox[1].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Nombre es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Nombre Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[1].ForeColor = Color.Red;
                listTxtBox[1].Focus();
            }

            else if (listTxtBox[2].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Apellido es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Apellido Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[2].ForeColor = Color.Red;
                listTxtBox[2].Focus();
            }

            else if (listTxtBox[3].Text.Equals(string.Empty))
            {
                textoAlerta = "El campo Correo es requerido. No puede estar vacio.";
                tituloAlerta = "Campo Correo Vacio";
                var alertaID = MessageBox.Show(textoAlerta, tituloAlerta, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                listLbl[3].ForeColor = Color.Red;
                listTxtBox[3].Focus();
            }
            */
            #endregion
        }

        public void Eliminar()
        {
            if (numEstudiante.Equals(0))
            {
                MessageBox.Show("Debe hacer click en el estudiante que se va a eliminar.", "Estudiante no seleccionado"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                var Advertencia = MessageBox.Show($"Estás seguro que deseas eliminar al estudiante {datagrid.CurrentRow.Cells[2].Value.ToString()}?",
                    "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Advertencia == DialogResult.Yes)
                {
                    tablaEstudiante.Where(estudiante => estudiante.num.Equals(numEstudiante)).Delete();
                    Reset();
                }
            }
        }

        private int num_pagina = 1, registro_porPagina = 3;
        List<Estudiante> listaEstudiantes;
        public void buscarEstudiante(string busqueda)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            int inicio = (num_pagina - 1) * registro_porPagina;
            if (busqueda.Equals(string.Empty)) //Esta es la condicion que llama el constructor en la llamada a este metodo.
            {
                listaEstudiantes = conexionDB.tablaEstudiante.ToList();
            }
            else
            {
                //La lista almacena los resultados del query que cumplan con la busqueda (tomando en cuenta id, nombre y apellido)
                listaEstudiantes = conexionDB.tablaEstudiante.Where(estudiante => estudiante.id.ToString().Contains(busqueda)
                    || estudiante.nombre.StartsWith(busqueda) || estudiante.apellido.StartsWith(busqueda)
                    || estudiante.email.StartsWith(busqueda)).ToList();
            }
            
            if (listaEstudiantes.Count > 0)
            {
                datagrid.DataSource = listaEstudiantes.Select(estudiantes => new
                {
                    estudiantes.num,
                    estudiantes.id,
                    estudiantes.nombre,
                    estudiantes.apellido,
                    estudiantes.email,
                    estudiantes.foto
                }).Skip(inicio).Take(registro_porPagina).ToList();

                datagrid.Columns[0].Visible = false; //Ocultar la columna numero de registro (num)
                datagrid.Columns[5].Visible = false; //Ocultar la columna que trae la foto
            }

            
        }

        public void gestorPaginas(int opc)
        {

            switch (opc)
            {
                case 0: num_pagina = Paginador.primeraPagina(); break;
                case 1: num_pagina = Paginador.anteriorPagina(); break;
                case 2: num_pagina = Paginador.siguientePagina(); break;
                case 3: num_pagina = Paginador.ultimaPagina(); break;
            }
            buscarEstudiante("");
        }

        public void cantidadRegistros()
        {
            num_pagina = 1;
            registro_porPagina = (int)cantRegistros.Value;
            var list = tablaEstudiante.ToList();
            if (list.Count > 0)
            {
                Paginador = new Paginador<Estudiante>(listaEstudiantes, lblPagina, registro_porPagina);
                buscarEstudiante("");
            }
        }

        private int numEstudiante = 0;
        public void getEstudiante()
        {
            accion = "update";
            numEstudiante = (int)datagrid.CurrentRow.Cells[0].Value;
            for (int i = 0; i < listTxtBox.Count; i++)
            {
                //Cada texto se llena con la celda correspondiente
                listTxtBox[i].Text = Convert.ToString(datagrid.CurrentRow.Cells[i+1].Value);
            }

            try
            {
                byte[] fotoBytearray = (byte[])datagrid.CurrentRow.Cells[5].Value;
                cajaFoto.Image = uploadImage.byteToImage(fotoBytearray);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error al obtener imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
            

        }
    }
    
}
