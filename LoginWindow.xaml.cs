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

namespace FileOperation
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginText.Text;
            string password = ParolText.Password;
            
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                // Перевірка коректності облікових даних
                if (IsValidCredentials(login, password))
                {
                    // Відкриття головного вікна
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();

                    // Закриття поточного вікна
                    Close();
                }
                else
                {
                    MessageBox.Show("Некоректні облікові дані. Будь ласка, спробуйте знову.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть обидва поля.");
            }
        }
        private bool IsValidCredentials(string login, string password)
        {
            // Тут ви можете реалізувати логіку перевірки облікових даних
            // Зазвичай це включає перевірку з базою даних, хешування паролю та інші дії

            // Повертаємо тимчасове значення true для прикладу
            return login == "admin" && password == "password";
        }
    }
}
