using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para CrearCliente.xaml
    /// </summary>
    public partial class CrearCliente : Window
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE=xe; user id = system; password= adriano12");
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void btnIrModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarCliente m = new ModificarCliente();
            this.Close();
            m.ShowDialog();

        }

        private void btnVentanaPorfesional_Click(object sender, RoutedEventArgs e)
        {
            CrearProfesional p = new CrearProfesional();
            this.Close();
            p.ShowDialog();

        }

        private void btnVentanaCliente_Click(object sender, RoutedEventArgs e)
        {
            CrearCliente c = new CrearCliente();
            this.Close();
            c.ShowDialog();
        }

        private void btnVentanaReportes_Click(object sender, RoutedEventArgs e)
        {
            AdministracionReportes r = new AdministracionReportes();
            this.Close();
            r.ShowDialog();
        }

        private void btnIrAgregarC_Click(object sender, RoutedEventArgs e)
        {
            CrearCliente Cl = new CrearCliente();
            this.Close();
            Cl.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand cmd = new OracleCommand("AgregarCliente", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("IdRutCl", OracleType.Int32).Value = Convert.ToInt32(txtRutCliente.Text);
                cmd.Parameters.Add("NombreCl", OracleType.VarChar).Value = txtNomCliente.Text;
                cmd.Parameters.Add("RubroCl", OracleType.VarChar).Value = txtRubroCliente.Text;
                cmd.Parameters.Add("UserId", OracleType.Int32).Value = 3;
                cmd.Parameters.Add("DescCl", OracleType.VarChar).Value = txtDescCliente.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Agregado");
            }
            catch(Exception)
            {
                MessageBox.Show("Error al Agregar");
            }
            conexion.Close();

        }
    }
}


