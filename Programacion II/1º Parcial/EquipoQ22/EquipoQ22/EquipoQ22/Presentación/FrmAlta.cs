using EquipoQ22.Datos;
using EquipoQ22.Domino;
using EquipoQ22.FactoryConfig;
using EquipoQ22.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//COMPLETAR --> Curso:      Legajo:         Apellido y Nombre:

//CadenaDeConexion: "Data Source=sqlgabineteinformatico.frc.utn.edu.ar;Initial Catalog=Qatar2022;User ID=alumnoprog22;Password=SQL+Alu22"

namespace EquipoQ22
{
    public partial class FrmAlta : Form
    {
        private IEquipoDao equipo;
        private IFormValidatorServices validator;
        private Factory factoryService;
        private Equipo _equipo;
        private Jugador jugadores;
        public FrmAlta(Factory factoryService)
        {
            InitializeComponent();
            this.factoryService = factoryService;
            equipo = factoryService.CreateServices();
            _equipo = new Equipo();
            jugadores = new Jugador();
            validator = factoryService.CreateValidatorServices();
        }
        private void FrmAlta_Load(object sender, EventArgs e)
        {
            equipo.CargarPersonas(cboPersona);

            //ESTE MOCKSITO LO USE PARA NO ESCRIBIR TANTO

            txtPais.Text = "ARGENTINA";
            txtDT.Text = "BILARDO";
            //equipo.ObtenerPersonas(); 
            //SOLO LO USE PARA VERIFICAR QUE SE MAPEE BIEN DESDE LA BD A LA PERSONA




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validator.ValidarCampos(txtPais))
            {
                MessageBox.Show("EL CAMPO PAIS NO PUEDE ESTAR VACIO");
                txtPais.Focus();
                return;

            }


            if (!validator.ValidarCampos(txtDT))
            {
                MessageBox.Show("EL CAMPO DIRECTOR TECNICO NO PUEDE ESTAR VACIO");
                txtDT.Focus();
                return;

            }

            if (validator.ValidatorCombos(cboPersona))
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA PERSONA");
                cboPersona.Focus();
                return;
            }

            if (validator.ValidatorCombos(cboPosicion))
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA POSICION");
                cboPosicion.Focus();
                return;
            }

            if (!validator.ValidarPosiciones(dgvDetalles, cboPosicion,cboPersona))
            {
                _equipo.Pais = txtPais.Text;
                _equipo.DirectorTecnico = txtDT.Text;

                jugadores.Persona.NombreCompleto = cboPersona.Text;
                jugadores.Camiseta = (int)nudCamiseta.Value;
                jugadores.Posicion = cboPosicion.Text;
                jugadores.Persona.IdPersona = 1;
                //LO PODEMOS OBTENER DEL CONSULTAR PERSONAS();
                //PERO YA NO QUEDA TIEMPO LO DEJO ASI HARCODEADO PARA QUE INSERTE...


                _equipo.Jugadores.Add(jugadores);

                dgvDetalles.Rows.Add(new object[]
            {

                10,
                jugadores.Persona.NombreCompleto,
                jugadores.Camiseta,
                jugadores.Posicion

           });


                lblTotal.Text = "Total de Jugadores:  " + (dgvDetalles.Rows.Count).ToString();

            }
            else
            {
                MessageBox.Show("UN JUGADOR NO PUEDE TENER DOS POSICIONES");
            }




        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validator.ValidarCantidadJugadores(dgvDetalles))
            {
                int flagToShow = equipo.GuardarBD(_equipo);

                if (flagToShow > 0)
                {
                    if (MessageBox.Show("LA INSERCION SE REALIZO CORRECTAMENTE") == DialogResult.OK)
                    {
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("OCURRIO UN ERROR AL INSERTAR VERIFICAR...");
                }
            }
            else
            {
                MessageBox.Show("DEBERA INGRESAR AL MENOS 1 JUGADOR");
                dgvDetalles.Focus();
                return;

            }
        }

        private void LimpiarCampos()
        {

            txtPais.Clear();
            txtDT.Clear();
            dgvDetalles.Rows.Clear();
            cboPersona.SelectedIndex = 0;
            cboPosicion.SelectedIndex = 0;
            txtPais.Focus();
            lblTotal.Text = "Total Jugadores: " + 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _equipo.QuitarJugadores(dgvDetalles,lblTotal);


        }
    }
}
