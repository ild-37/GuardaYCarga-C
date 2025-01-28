using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace WpfApp1
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
        private void W2_Closing(object sender, CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                MessageBox.Show("Hola, mensaje al capturar ->  X");
                e.Cancel = true;
                
                this.Hide();
            }
        }

        private void BDiag1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(fichero.FileName);
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BDiag2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //fichero.InitialDirectory= @"c:\";
            fichero.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (fichero.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(fichero.FileName);
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BDiag3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fichero.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fichero.Multiselect = true;
            if (fichero.ShowDialog() == true)
            {
                foreach (string ficha in fichero.FileNames)
                {
                    lsFicreros.Items.Add(System.IO.Path.GetFileName(ficha));
                }
            }
            else
            {
                MessageBox.Show(" No se ha selecionado NADA", "Nada de nada", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private void BGuar1_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ficherito = new SaveFileDialog();
            ficherito.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            if (ficherito.ShowDialog() == true)
            {
                File.WriteAllText(ficherito.FileName, txtEditar.Text);
            }
            else
            {
                MessageBox.Show(" Cancelado ", "Na de na", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }


        private void BGuar2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ficherito = new SaveFileDialog();
            ficherito.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs|All files (*.*)|*.*";
            ficherito.InitialDirectory = @"c:\";
            ficherito.AddExtension = true;
            if (ficherito.ShowDialog() == true)
            {
                File.WriteAllText(ficherito.FileName, txtEditar.Text);
            }
            else
            {
                MessageBox.Show(" Cancelado ", "Na de na", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }



        private void W3_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Visibility == Visibility.Visible)
            {
                MessageBox.Show("Hola, mensaje al capturar ->  X");
                e.Cancel = true;
               
                this.Hide();
            }
        }

    }
}
