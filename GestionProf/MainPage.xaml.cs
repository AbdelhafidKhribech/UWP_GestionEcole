using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GestionProf
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PSHQSR9\SQLEXPRESS01;Initial Catalog=GestionProf;Integrated Security=true;");
        public MainPage()
        {
            
            this.InitializeComponent();
            conn.Open();
            u.Text = conn.State.ToString();

        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            loginProf.Visibility = Visibility.Visible;
            loginAdmin.Visibility = Visibility.Collapsed;
        }

        private void HyperlinkButton_Click2(object sender, RoutedEventArgs e)
        {
            loginProf.Visibility = Visibility.Collapsed;
            loginAdmin.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin));
        }
    }
}
