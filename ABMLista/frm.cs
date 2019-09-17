using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMLista
{
    public partial class frm : Form
    {
        #region Constantes
        const int Incremento = 5;
        #endregion

        #region Propiedades
        ABMLista.Clases.Lista Alumnos = new Clases.Lista();
        ABMLista.Clases.Lista Materias = new Clases.Lista();
        #endregion

        public frm()
        {
            InitializeComponent();
        }

        #region EVENTOS
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            Alumnos.Agregar(txtAlum.Text);
            lbl.Text = Alumnos.MostrarLista();

            Alumnos.AgregarNota(txtNota.Text);
            lblNota.Text = Alumnos.MostrarNotas();

            txtAlum.SelectAll();
            txtAlum.Focus();

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            int Pos = Alumnos.BuscarPosicion(txtAlum.Text);
            if (Pos == -1)
            {
                lblRepues.Text = "El alumno " + txtAlum.Text + " no se encontró";
            }
            else
            {
                lblRepues.Text = "la posición del alumno es " + (Pos + 1).ToString();
            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            string Resp = Alumnos.Borrar(txtAlum.Text);
            if (string.IsNullOrEmpty(Resp))
            {
                Resp = "el alumno " + txtAlum.Text + " ha sido borrado";
            }
            lblRepues.Text = Resp;
        }


        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (rbAlfab.Checked == true)
            {
                lblPorden.Text = Alumnos.OrdenAlfabetico();
                lblON.Text = "";

            }
            else if (rbCarga.Checked == true)
            {
                lblPorden.Text = Alumnos.MostrarLista();
                lblON.Text = Alumnos.MostrarNotas();
                
            }
        }
        #endregion
    }  
}
