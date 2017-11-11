using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeMueveGt
{
    public partial class Form1 : Form
    {
        int trenes;
        int vagonesPorTren;
        int filasPorVagon;
        int asientosPorFila;
        Tren[] listaTrenes;
        int trenesCreados;
        public Form1()
        {
            InitializeComponent();
            trenes = 0;
            vagonesPorTren = 0;
            filasPorVagon = 0;
            asientosPorFila = 0;
            trenesCreados = 0;
            Control.TrenesCreados = 0;
            Asientos.RowHeadersVisible = false;
            Asientos.ColumnHeadersVisible = false;
        }

        private void txtCantidadTrenes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCantidadTrenes.Text.Equals("") || txtVagones.Text.Equals("") || txtFilas.Text.Equals("") || txtAsientos.Text.Equals(""))
            {
                MessageBox.Show("Ingrese toda la informacion requerida!");
                return;
            }
            if (int.Parse(txtCantidadTrenes.Text) < 1 || int.Parse(txtVagones.Text) < 1 || int.Parse(txtFilas.Text) < 1 || int.Parse(txtAsientos.Text) < 1)
            {
                MessageBox.Show("Asegurese que todas las cantidades sean mayores a 0");
                return;
            }
            grupoCreacionDeTrenes.Enabled = true;
            grupoConfiguracion.Enabled = false;
            trenes = int.Parse(txtCantidadTrenes.Text);
            vagonesPorTren = int.Parse(txtVagones.Text);
            filasPorVagon = int.Parse(txtFilas.Text);
            asientosPorFila = int.Parse(txtAsientos.Text);
            Control.ListaTrenes = new Tren[trenes];
            Control.Filas = filasPorVagon;
            Control.Asientos = asientosPorFila;
            MessageBox.Show("Configuración finalizada!");
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int asientosLujo = 0;
            int asientosAhorro = 0;
            if (txtNombreTren.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre del tren!");
                return;
            }
            bool asientosDeLujo = false;
            if (radioSi.Checked)
            {
                asientosDeLujo = true;
                asientosLujo = (Control.Asientos * Control.Filas) / 2;
                asientosAhorro = asientosLujo;
            }
            Tren nuevoTren = new Tren(vagonesPorTren, txtNombreTren.Text,asientosDeLujo);
            for (int i = 0; i < nuevoTren.ListaVagones.Length; i++)
            {
                nuevoTren.ListaVagones[i] = new Vagon(asientosAhorro,asientosLujo,Control.Filas,Control.Asientos);
            }
            for (int k = 0; k < nuevoTren.ListaVagones.Length; k++)
            {
                for (int i = 0; i < Control.Filas; i++)
                {
                    for (int j = 0; j < Control.Asientos; j++)
                    {
                        nuevoTren.ListaVagones[k].FilasYAsientos[i, j] = (new Asiento((i.ToString()+j.ToString()),new Cliente(),false));
                    }
                }
            }
            Control.ListaTrenes[Control.TrenesCreados] = nuevoTren;
            Control.TrenesCreados = Control.TrenesCreados + 1;
            comboBox1.Items.Add(nuevoTren.Nombre);
            if (trenes == Control.TrenesCreados)
            {
                grupoCreacionDeTrenes.Enabled = false;
            }
            radioNo.Checked = false;
            txtNombreTren.Text = "";
            radioSi.Checked = false;
            MessageBox.Show("Tren creado exitosamente!");
            grupoReservarComprar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                btnDisponiblidad.Enabled = true;
                if (comboVagon.Items.Count == 0)
                {
                    for (int i = 0; i < Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones.Length; i++)
                    {
                        comboVagon.Items.Add("Vagon "+(i+1).ToString());
                    }
                }
            }
            if (comboBox1.SelectedIndex == -1)
            {
                btnDisponiblidad.Enabled = false;
                return;
            }
            if (Control.ListaTrenes[comboBox1.SelectedIndex].AsientosDeLujo)
            {
                tipoDeAsiento.Enabled = true;
                tipoDeAsiento.Items.Add("De Lujo");
                tipoDeAsiento.Items.Add("De Ahorro");
            }
            else
            {
                tipoDeAsiento.Enabled = false;
            }
        }

        private void btnDisponiblidad_Click(object sender, EventArgs e)
        {
            if (comboVagon.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un vagon para ver la informacion!");
                return;
            }
            txtNombreTrenReporte.Text = Control.ListaTrenes[comboBox1.SelectedIndex].Nombre;
            txtAsientosDisponiblesReporte.Text = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].obtenerCantidadDeAsientosDisponibles().ToString();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                btnDisponiblidad.Enabled = false;
                return;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void llenarAsientos()
        {
            for (int i = 0; i < Control.Asientos; i++)
            {
                //Agregar Dinamicamente las columnas
                Asientos.Columns.Add(i.ToString(),i.ToString());
            }
            for (int i = 0; i < Control.Filas; i++)
            {
                Asientos.Rows.Add();
            }
            string[,] asientos = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].listaAsientos();
            for (int i = 0; i < Control.Filas; i++)
            {
                for (int j = 0; j < Control.Asientos; j++)
                {
                    Asientos.Rows[i].Cells[j].Value = asientos[i,j];
                }
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].obtenerCantidadDeAsientosDisponibles() > 0)
            {
                if (txtNombreCliente.Text.Equals("") || txtDPI.Text.Equals("") || txtTelefono.Text.Equals("") || txtCorreo.Text.Equals(""))
                {
                    MessageBox.Show("Llene todos los campos del formulario para continuar!");
                    return;
                }
                if (!radioComprar.Checked && !radioReservar.Checked)
                {
                    MessageBox.Show("Seleccione si desea comprar o reservar!");
                    return;
                }
                if (comboBox1.SelectedIndex == -1 || comboVagon.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tren y un vagon para continuar!");
                    return;
                }
                if (tipoDeAsiento.Enabled)
                {
                    if (tipoDeAsiento.SelectedIndex != -1)
                    {
                        seleccionDeAsiento.Enabled = true;
                        grupoReservarComprar.Enabled = false;
                        btnCancelarCompra.Enabled = true;
                        llenarAsientos();
                        return;
                    }
                    MessageBox.Show("Seleccione un tipo de asiento!");
                }
                else
                {
                    seleccionDeAsiento.Enabled = true;
                    grupoReservarComprar.Enabled = false;
                    llenarAsientos();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Este vagon ya no tiene asientos disponibles!");
            }
        }

        private void Asientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Asientos.SelectedCells[0].Value.ToString().Equals("XX"))
            {
                //MessageBox.Show("Este asiento ya fue reservado!");
                int fila = Asientos.SelectedCells[0].RowIndex;
                int columna = Asientos.SelectedCells[0].ColumnIndex;
                txtNombreReservado.Text = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[fila, columna].Cliente.Nombre;
                txtDPIReservado.Text = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[fila, columna].Cliente.DPI.ToString();
                txtTelefonoReservado.Text = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[fila, columna].Cliente.Telefono.ToString();
                txtCorreoReservado.Text = Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[fila, columna].Cliente.Correo;
                btnConfirmar.Enabled = false;
            }
            else
            {
                btnConfirmar.Enabled = true;
                txtReservado.Text = "";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string tipoDeAsientoSeleccionado = "De Ahorro";
            if (Control.ListaTrenes[comboBox1.SelectedIndex].AsientosDeLujo)
            {
                if (tipoDeAsiento.SelectedIndex == 0)
                {
                    tipoDeAsientoSeleccionado = "De Lujo";
                }
            }
            Cliente cliente = new Cliente(txtNombreCliente.Text,int.Parse(txtDPI.Text),int.Parse(txtTelefono.Text),txtCorreo.Text,tipoDeAsientoSeleccionado);
            string fila = Asientos.SelectedCells[0].Value.ToString()[0].ToString();
            string columna = Asientos.SelectedCells[0].Value.ToString()[1].ToString();
            Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].comprar(int.Parse(fila),int.Parse(columna));
            Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[int.Parse(fila), int.Parse(columna)].Cliente = cliente;
            MessageBox.Show("Asiento reservado correctamente!");
            Asientos.Rows.Clear();
            txtNombreReservado.Text = "";
            txtDPIReservado.Text = "";
            txtTelefonoReservado.Text = "";
            txtCorreoReservado.Text = "";
            Asientos.Columns.Clear();
            btnConfirmar.Enabled = false;
            seleccionDeAsiento.Enabled = false;
            grupoReservarComprar.Enabled = true;
            btnCancelarCompra.Enabled = false;
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            Asientos.Rows.Clear();
            txtNombreReservado.Text = "";
            txtDPIReservado.Text = "";
            txtTelefonoReservado.Text = "";
            txtCorreoReservado.Text = "";
            Asientos.Columns.Clear();
            btnConfirmar.Enabled = false;
            seleccionDeAsiento.Enabled = false;
            grupoReservarComprar.Enabled = true;
            btnCancelarCompra.Enabled = false;
        }
    }
}