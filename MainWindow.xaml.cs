using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
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
    /// 

    public partial class MainWindow : Window
    {
        private Dictionary<string, int> dataDictionary;
        private int step;
        private int limitedStep;
        public MainWindow()
        {
            InitializeComponent();
            dataDictionary = new Dictionary<string, int>();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Зчитування інформації з файлу та запис у словники
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            string[] lines = File.ReadAllLines(pathone);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    int value = int.Parse(parts[1].Trim());
                    dataDictionary[key] = value;
                }
            }

            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            string[] lines2 = File.ReadAllLines(pathtwo);

            foreach (string line in lines2)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    int value = int.Parse(parts[1].Trim());
                    dataDictionary[key] = value;
                }
            }

            // Встановлення значень Step та LimitedStep
            step = dataDictionary["Step"];
            limitedStep = dataDictionary["LimitStep"];
            // Виведення значень Step та LimitedStep на ListBox
            ParseListBox.Items.Add("Step: " + step);
            ParseListBox.Items.Add("LimitedStep: " + limitedStep);
        }
        private async void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
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
            //string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            //string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            //string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            string pathfour = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileFour.txt";

            //using (StreamReader reader = new StreamReader(pathone))
            //{
            //    string text = await reader.ReadToEndAsync();
            //    ListBox4.Items.Add(text);
            //}
            //using (StreamReader reader2 = new StreamReader(pathtwo))
            //{
            //    string text2 = await reader2.ReadToEndAsync();
            //    ListBox4.Items.Add(text2);
            //}
            //using (StreamReader reader3 = new StreamReader(paththree))
            //{
            //    string text3 = await reader3.ReadToEndAsync();
            //    ListBox4.Items.Add(text3);
            //}
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
            string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            string textToAdd3 = TextBox3.Text;
            using (StreamWriter writer3 = File.AppendText(paththree))
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
            string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";

            // Очистити зміст файлу
            File.WriteAllText(paththree, "");

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
            TomTom.Content = e.GetPosition(this);
        }

        private void ParseButton_Click(object sender, RoutedEventArgs e)
        {
            //string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            //string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            //string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";
            //string pathfour = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileFour.txt";
            //string[] lines = File.ReadAllLines(pathone);
            //string[] lines2 = File.ReadAllLines(pathtwo);
            //string[] lines3 = File.ReadAllLines(paththree);
            //string[] lines4 = File.ReadAllLines(pathfour);
            //foreach (string line in lines)
            //{

            //}
        }

        private void IterationButton_Click(object sender, RoutedEventArgs e)
        {
            // Збільшення значення Step та зменшення значення LimitedStep
            step++;
            limitedStep--;

            // Перевірка, чи limitedStep досягло 0 і перезапуск його до 99
            if (limitedStep < 0)
            {
                limitedStep = 99;
            }

            // Оновлення значень в словнику та файлі
            dataDictionary["Step"] = step;
            dataDictionary["LimitStep"] = limitedStep;

            UpdateFile();

            // Виведення значень Step та LimitedStep на ListBox
            ParseListBox.Items.Clear();
            ParseListBox.Items.Add("Step: " + step);
            ParseListBox.Items.Add("LimitedStep: " + limitedStep);
            //string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            //string[] lines = File.ReadAllLines(pathone);
            //Dictionary<string, int> step = new Dictionary<string, int>();
            //Dictionary<string, int> limitedstep = new Dictionary<string, int>();
            /////заполняем словарь информацией из файла
            ///// изменяем шаг и лимит
            ///// обратно ложим в файл
            //string lineToUse5 = lines[5];
            //string lineToUse6 = lines[6];

            //foreach (string line in lines)
            //{
            //    string[] parts = Regex.Split(line, @"\D+");

            //    foreach (string part in parts)
            //    {
            //        if (int.TryParse(part, out int number))
            //        {
            //            // Частина є числом
            //            // Виконайте відповідну обробку числа
            //            // Наприклад, виведення числа у консоль
            //            ParseListBox.Items.Add(number);
            //        }
            //        else
            //        {
            //            // Частина є текстом
            //            // Виконайте відповідну обробку тексту
            //            // Наприклад, виведення тексту у консоль
            //            //ParseListBox.Items.Add(part);
            //            //ParseListBox.Items.Add(part);
            //        }
            //    }
            //}
        }

        private void UpdateFile()
        {
            string pathone = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileOne.txt";
            string pathtwo = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileTwo.txt";
            string paththree = @"C:\Users\nasty\OneDrive\Робочий стіл\Программирование\Project\NET.CORE\LAB_1\FileOperation\FileThree.txt";

            // Читання існуючого вмісту файлу
            List<string> lines = new List<string>(File.ReadAllLines(pathone));
            List<string> lines2 = new List<string>(File.ReadAllLines(pathtwo));
            List<string> lines3 = new List<string>(File.ReadAllLines(paththree));

            // Оновлення значень Step та LimitedStep у списку рядків
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                if (line.StartsWith("Step:"))
                {
                    lines[i] = "Step: " + step;
                }
                else if (line.StartsWith("LimitStep:"))
                {
                    lines[i] = "LimitStep: " + limitedStep;
                }
            }
            
            for (int i = 0; i < lines2.Count; i++)
            {
                string line = lines2[i];
                if (line.StartsWith("Step:"))
                {
                    lines[i] = "Step: " + step;
                }
                else if (line.StartsWith("LimitStep:"))
                {
                    lines2[i] = "LimitStep: " + limitedStep;
                }
            }

            for (int i = 0; i < lines3.Count; i++)
            {
                string line = lines2[i];
                if (line.StartsWith("Step:"))
                {
                    lines3[i] = "Step: " + step;
                }
                else if (line.StartsWith("LimitStep:"))
                {
                    lines3[i] = "LimitStep: " + limitedStep;
                }
            }

            // Запис оновленого вмісту назад у файл
            File.WriteAllLines(pathone, lines);
            File.WriteAllLines(pathtwo, lines2);
            File.WriteAllLines(paththree, lines3);
        }

        private void IterationButton2_Click(object sender, RoutedEventArgs e)
        {
            // Збільшення значення Step та зменшення значення LimitedStep
            step++;
            limitedStep--;

            // Перевірка, чи limitedStep досягло 0 і перезапуск його до 99
            if (limitedStep < 0)
            {
                limitedStep = 99;
            }

            // Оновлення значень в словнику та файлі
            dataDictionary["Step"] = step;
            dataDictionary["LimitStep"] = limitedStep;

            UpdateFile();

            // Виведення значень Step та LimitedStep на ListBox
            ParseListBox.Items.Clear();
            ParseListBox.Items.Add("Step: " + step);
            ParseListBox.Items.Add("LimitedStep: " + limitedStep);
        }

        private void IterationButton3_Click(object sender, RoutedEventArgs e)
        {
            // Збільшення значення Step та зменшення значення LimitedStep
            step++;
            limitedStep--;

            // Перевірка, чи limitedStep досягло 0 і перезапуск його до 99
            if (limitedStep < 0)
            {
                limitedStep = 99;
            }

            // Оновлення значень в словнику та файлі
            dataDictionary["Step"] = step;
            dataDictionary["LimitStep"] = limitedStep;

            UpdateFile();

            // Виведення значень Step та LimitedStep на ListBox
            ParseListBox.Items.Clear();
            ParseListBox.Items.Add("Step: " + step);
            ParseListBox.Items.Add("LimitedStep: " + limitedStep);
        }
    }
}
