using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OracleClient;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
        }

        OracleConnection conexion = new OracleConnection("DATA SOURCE=xe; user id = system; password= adriano12");

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            
            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE EMAIL= :email AND PASSWORD = :contra", conexion);

            comando.Parameters.AddWithValue(":email", txtEmail.Text);
            comando.Parameters.AddWithValue(":contra", txtPassword.Text);


            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read()) 
            {
                CrearCliente c = new CrearCliente();
                this.Close();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }

        }


        
    }
}
