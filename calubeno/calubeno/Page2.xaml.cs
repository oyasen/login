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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        loginshiEntities db = new loginshiEntities();
        public Page2()
        {
            InitializeComponent();
        }

        private void signup_button(object sender, RoutedEventArgs e)
        {
            userr user = new userr();
            try
            {
                user.username = user_t.Text;
                if (cpass_t.Text == pass_t.Text)
                {
                    user.password = pass_t.Text;
                    db.userrs.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("account created");
                    Page1 page = new Page1();
                    NavigationService.Navigate(page);
                }
                else
                {
                    MessageBox.Show("passwords doesn't match");
                }
            }
            catch
            {
                MessageBox.Show("the username already exist");
            }
        }
    }
}
