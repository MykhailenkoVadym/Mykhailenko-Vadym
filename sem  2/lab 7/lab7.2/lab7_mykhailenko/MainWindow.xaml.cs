using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using WinForms = System.Windows.Forms;

namespace lab7_mykhailenko
{
    public partial class MainWindow : Window
    {
        private List<string> pathToFiles = new List<string>();
        private bool isChanged = false;

        private readonly FileWindow fileWindow = new FileWindow();

        WinForms.FolderBrowserDialog fbd = new WinForms.FolderBrowserDialog();

        private readonly string Error_message = "Виникла помилка";

        public MainWindow()
        {
            InitializeComponent();
            mainPath.Text = Path.GetFullPath(".");
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            if (isChanged) return;

            if (mainPath.Text == "" || fileName.Text == "")
            {
                MessageBox.Show("Перевірте правильність заповнення всіх полів", Error_message);
                return;
            }

            try
            {
                pathToFiles = Directory.GetFiles(mainPath.Text, fileName.Text, SearchOption.AllDirectories).ToList();
            }
            catch
            {
                MessageBox.Show("Виникла помилка в заповнені директорії, або файл занадто віддалений", Error_message);
                return;
            }

            if (pathToFiles.Count != 0)
            {
                logTextBlock.Foreground = Brushes.Green;
                logTextBlock.Text = "Файл знайдено";
                openButton.IsEnabled = true;
            }
            else
            {
                logTextBlock.Foreground = Brushes.Red;
                logTextBlock.Text = "файл не знайдено";
                openButton.IsEnabled = false;
            }

            isChanged = true;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fileWindow.fillWindow(pathToFiles.First());
                fileWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Error_message);
            }
        }

        private void textChanged(object sender, TextChangedEventArgs e)
        {
            if (isChanged)
            {
                openButton.IsEnabled = false;
                logTextBlock.Text = "";
                pathToFiles.Clear();
                isChanged = false;
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
                mainPath.Text = fbd.SelectedPath;
            isChanged = false;
        }
    }
}
