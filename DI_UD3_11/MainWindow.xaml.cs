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

namespace DI_UD3_11
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
        /*EJERCICIO 1
        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            outputTextBox.Text = "Has seleccionado " + inputTextBox.SelectedText;
        }*/
        /*EJERCICIO 3
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Button Background: Green, Foreground: Red");
        }*/
        /*EJERCICIO 4
         * private void Button_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Hola, " + textBox.Text);
}

         */

        /*EJERCICIO 5
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            module1.IsChecked = true;
            module2.IsChecked = true;
            module3.IsChecked = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            module1.IsChecked = false;
            module2.IsChecked = false;
            module3.IsChecked = false;
        }*/

        /* EJERCICIO 6
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                textBlock.Inlines.Clear();
                textBlock.Inlines.Add(new Run("Texto con formato y ") { FontWeight = FontWeights.Bold });
                textBlock.Inlines.Add(new Run("subrayado") { TextDecorations = TextDecorations.Underline });
            }
            else
            {
                textBlock.Inlines.Clear();
                textBlock.Inlines.Add(new Run("Texto simple"));
            }
        }*/
    }
}
