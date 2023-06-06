using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
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
using static System.Net.Mime.MediaTypeNames;

namespace FileOperation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            string[] lines = File.ReadAllLines(pathone);
            foreach (var item in lines)
            {

            }
            using (StreamReader reader = new StreamReader(pathone))
            {
                string text = await reader.ReadToEndAsync();
                ListBox.Items.Add(text);
            }
        }

        private async void ResultButton2_Click(object sender, RoutedEventArgs e)
        {
            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            using (StreamReader reader2 = new StreamReader(pathtwo))
            {
                string text2 = await reader2.ReadToEndAsync();
                ListBox2.Items.Add(text2);
            }
        }

        private async void ResultButton3_Click(object sender, RoutedEventArgs e)
        {
            string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            using (StreamReader reader3 = new StreamReader(paththree))
            {
                string text3 = await reader3.ReadToEndAsync();
                ListBox3.Items.Add(text3);
            }
        }

        private async void ResultButton4_Click(object sender, RoutedEventArgs e)
        {
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            string pathfour = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileFour.txt";

            using (StreamReader reader = new StreamReader(pathone))
            {
                string text = await reader.ReadToEndAsync();
                ListBox4.Items.Add(text);
            }
            using (StreamReader reader2 = new StreamReader(pathtwo))
            {
                string text2 = await reader2.ReadToEndAsync();
                ListBox4.Items.Add(text2);
            }
            using (StreamReader reader3 = new StreamReader(paththree))
            {
                string text3 = await reader3.ReadToEndAsync();
                ListBox4.Items.Add(text3);
            }
            using (StreamReader reader4 = new StreamReader(pathfour))
            {
                string text4 = await reader4.ReadToEndAsync();
                ListBox4.Items.Add(text4);
            }
        }

        private async void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно додана");
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            string textToAdd = TextBox.Text;
            using (StreamWriter writer = File.AppendText(pathone))
            {
                await writer.WriteLineAsync(textToAdd);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно видалена");
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";

            // Очистити зміст файлу
            File.WriteAllText(pathone, "");

            // Очистити ListBox
            ListBox.Items.Clear();
        }

        private async void GenerateButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно додана");
            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            string textToAdd2 = TextBox2.Text;
            using (StreamWriter writer2 = File.AppendText(pathtwo))
            {
                await writer2.WriteLineAsync(textToAdd2);
            }
        }

        private async void GenerateButton3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно додана");
            string pathtree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            string textToAdd3 = TextBox3.Text;
            using (StreamWriter writer3 = File.AppendText(pathtree))
            {
                await writer3.WriteLineAsync(textToAdd3);
            }
        }

        private async void GenerateButton4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно додана");
            string pathfour = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileFour.txt";
            string textToAdd4 = TextBox4.Text;
            using (StreamWriter writer4 = File.AppendText(pathfour))
            {
                await writer4.WriteLineAsync(textToAdd4);
            }
        }

        private void DeleteButton2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно видалена");
            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";

            // Очистити зміст файлу
            File.WriteAllText(pathtwo, "");

            // Очистити ListBox
            ListBox2.Items.Clear();
        }

        private void DeleteButton3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно видалена");
            string pathtree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";

            // Очистити зміст файлу
            File.WriteAllText(pathtree, "");

            // Очистити ListBox
            ListBox3.Items.Clear();
        }

        private void DeleteButton4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Інформація успішно видалена");
            string pathfour = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileFour.txt";

            // Очистити зміст файлу
            File.WriteAllText(pathfour, "");

            // Очистити ListBox
            ListBox4.Items.Clear();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //int x = Convert.ToString(x);
            //int y = e.Y;
            TomTom.Content = e.GetPosition(this);
        }
    }
}
