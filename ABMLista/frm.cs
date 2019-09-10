﻿using System;
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

            if (Alumnos.Agregar(s.Text))
            {
                lbl.Text = Alumnos.MostrarLista();
                
            }
            else
            {
                MessageBox.Show("error");
            }


            s.SelectAll();
            s.Focus();

        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            int Pos = Alumnos.BuscarPosicion(s.Text);
            if (Pos == -1)
            {
                lblRepues.Text = "El alumno " + s.Text + " no se encontró";
            }
            else
            {
                lblRepues.Text = "la posición del alumno es " + (Pos + 1).ToString();
            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            string Resp = Alumnos.Borrar(s.Text);
            if (string.IsNullOrEmpty(Resp))
            {
                Resp = "el alumno " + s.Text + " ha sido borrado";
            }
            lblRepues.Text = Resp;
        }

       
        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (rbAlfab.Checked == true)
            {
                lblPorden.Text = Alumnos.OrdenAlfabetico();

            }
            else if (rbCarga.Checked == true)
            {
                lblPorden.Text = Alumnos.MostrarLista();
            }
        }

        #endregion
    }
}
