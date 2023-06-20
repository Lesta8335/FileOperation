using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FileOperation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Відкриття вікна LoginWindow при запуску програми
            LoginWindow loginWindow = new LoginWindow();
            bool? loginResult = loginWindow.ShowDialog();
           
            // Перевірка результату авторизації
            if (loginResult == true)
            {
                // Якщо авторизація успішна, відкриваємо головне вікно
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                // Якщо авторизація не успішна або було натиснуто "Скасувати", закриваємо програму
                Shutdown();
            }
        }
    }
}
