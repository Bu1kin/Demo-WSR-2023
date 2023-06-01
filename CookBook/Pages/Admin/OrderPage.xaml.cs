using CookBook.Utility;
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
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CookBook.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        KniggaShopEntities _context = KniggaShopEntities.GetContext();
        Order orderSelected = new Order();

        public OrderPage()
        {
            InitializeComponent();
            ReloadOrders();
            CbProduct.ItemsSource = _context.Book.ToList();
        }

        private void ReloadOrders()
        {
            var list = _context.Order.ToList();
            DgOrders.ItemsSource = list;
        }

        private void DgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgOrders.SelectedItem != null)
            {
                orderSelected = (Order)DgOrders.SelectedItem;
            }

            DgOrderProducts.ItemsSource = _context.OrderBook.Include(x => x.Book).Where(x => x.OrderID == orderSelected.ID).AsNoTracking().ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Book bookTemp = (Book)CbProduct.SelectedItem;
            Book book = _context.Book.Where(x => x.ID == bookTemp.ID).First();

            Order order = _context.Order.Where(x => x.ID == orderSelected.ID).First();

            OrderBook orderBook = new OrderBook();
            orderBook.Amount = Convert.ToInt32(TbAmount.Text);
            orderBook.Book = book;
            orderBook.Order = order;
            orderBook.Price = book.Price * orderBook.Amount;
            orderBook.SalePrice = book.SalePrice * orderBook.Amount;

            _context.OrderBook.Add(orderBook);
            _context.SaveChanges();

            ReloadOrders();
            DgOrderProducts.ItemsSource = _context.OrderBook.Include(x => x.Book).Where(x => x.OrderID == orderSelected.ID).AsNoTracking().ToList();
        }
    }
}
