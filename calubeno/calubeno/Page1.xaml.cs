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

namespace calubeno
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        loginshiEntities db = new loginshiEntities ();
        public Page1()
        {
            InitializeComponent();
        }

        private void pass_button(object sender, RoutedEventArgs e)
        {
            Page2 page = new Page2();
            NavigationService.Navigate(page);
        }

        private void login_button(object sender, RoutedEventArgs e)
        {
            try
            {
                userr user = db.userrs.First(x => x.username == user_t.Text && x.password == pass_t.Text);
                MessageBox.Show("loged in successfully");
            }
            catch
            {
                MessageBox.Show("wrong username or password");
            }
        }
    }
}
