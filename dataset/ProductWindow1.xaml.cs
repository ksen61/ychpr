using practica1.PetShopDataSetTableAdapters;
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

namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow1.xaml
    /// </summary>
    public partial class ProductWindow1 : Window
    {
        public ProductWindow1()
        {
            InitializeComponent();
            ProductsTableAdapter product = new ProductsTableAdapter();
            gridProducts.ItemsSource = product.GetData();
        }
    }
}
