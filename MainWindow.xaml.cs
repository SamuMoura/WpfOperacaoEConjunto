using System.Windows;
using System.Windows.Controls;
using WpfOpEConj.Model;

namespace WpfOpEConj
{
    public partial class MainWindow : Window
    {
        private Conjunto conjuntoA = new Conjunto();
        private Conjunto conjuntoB = new Conjunto();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdicionarA_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtElementoA.Text, out int numero))
            {
                conjuntoA.Adicionar(numero);
                AtualizarListBox(lstA, conjuntoA);
                txtElementoA.Clear();
            }
            else
            {
                MessageBox.Show("Insira um número inteiro válido.");
            }
        }

        private void RemoverA_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtElementoA.Text, out int numero))
            {
                conjuntoA.Remover(numero);
                AtualizarListBox(lstA, conjuntoA);
                txtElementoA.Clear();
            }
            else
            {
                MessageBox.Show("Insira um número inteiro válido.");
            }
        }

        private void AdicionarB_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtElementoB.Text, out int numero))
            {
                conjuntoB.Adicionar(numero);
                AtualizarListBox(lstB, conjuntoB);
                txtElementoB.Clear();
            }
            else
            {
                MessageBox.Show("Insira um número inteiro válido.");
            }
        }

        private void RemoverB_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtElementoB.Text, out int numero))
            {
                conjuntoB.Remover(numero);
                AtualizarListBox(lstB, conjuntoB);
                txtElementoB.Clear();
            }
            else
            {
                MessageBox.Show("Insira um número inteiro válido.");
            }
        }

        private void AtualizarListBox(ListBox listBox, Conjunto conjunto)
        {
            listBox.ItemsSource = null;
            listBox.ItemsSource = conjunto.Elementos;
        }
    }
}
