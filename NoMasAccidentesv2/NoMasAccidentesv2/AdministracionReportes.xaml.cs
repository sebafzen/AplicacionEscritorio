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
using System.Windows.Shapes;

namespace NoMasAccidentesv2
{
    /// <summary>
    /// Lógica de interacción para AdministracionReportes.xaml
    /// </summary>
    public partial class AdministracionReportes : Window
    {
        public AdministracionReportes()
        {
            InitializeComponent();
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

      
    }
}
