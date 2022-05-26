﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public UsuarioDesktop(int usuarioID, ModoForm modo) : this()
        {
            this.Modo = modo;

            UsuarioLogic usuarioLogic = new UsuarioLogic();

            this.UsuarioActual = usuarioLogic.GetOne(usuarioID);

            this.MapearADatos();
        }

        public Usuario UsuarioActual { get; set; }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    this.UsuarioActual = new Usuario();
                    this.UsuarioActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Unmodified;
                    break;
                case ModoForm.Baja:
                    this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                    this.UsuarioActual.State = BusinessEntity.States.Deleted;
                    break;
                default:
                    break;
            }

            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();

            UsuarioLogic usuarioLogic = new UsuarioLogic();

            usuarioLogic.Save(this.UsuarioActual);
        }

        public override bool Validar()
        {
            var esValido = true;

            this.ValidarCampos(esValido);

            this.ValidarClaves(esValido);

            this.ValidarEmail(esValido);

            return esValido;

        }

        private void ValidarEmail(bool esValido)
        {
            if (!this.txtEmail.Text.Contains("@") ||
                !this.txtEmail.Text.Contains(".com"))
            {
                esValido = false;
            }
        }

        private void ValidarClaves(bool esValido)
        {
            if (!this.txtClave.Text.Equals(this.txtConfirmarClave.Text))
            {
                esValido = false;
            }

        }

        private void ValidarCampos(bool esValido)
        {
            if (this.Modo != ModoForm.Alta && string.IsNullOrEmpty(this.txtID.Text))
                esValido = false;

            if (string.IsNullOrEmpty(this.txtNombre.Text) ||
                string.IsNullOrEmpty(this.txtApellido.Text) ||
                string.IsNullOrEmpty(this.txtEmail.Text) ||
                string.IsNullOrEmpty(this.txtUsuario.Text) ||
                string.IsNullOrEmpty(this.txtClave.Text))
            {
                esValido = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
