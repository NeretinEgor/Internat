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
using System.Globalization;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language;
        int bal = 5000;
        public MainWindow()
        {
            InitializeComponent();
            language = "rus-RU";
            CultureInfo culture = new CultureInfo("ru-RU");
            string currentDate = DateTime.Now.ToString("F", culture);
            Date.Content += currentDate;
        }


        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void Enter_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Obn_Click(object sender, RoutedEventArgs e)
        {
            if (lang_ch.Text == "Русский")
            {
                CultureInfo culture = new CultureInfo("ru-RU");
                string currentDate = DateTime.Now.ToString("F", culture);
                Date.Content = "Текущая дата и время: " + currentDate;
                balance.Content = "Баланс компании: " + bal + " руб.";
            }
            else
            {
                if (lang_ch.Text == "English")
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    string currentDate = DateTime.Now.ToString("F", culture);
                    Date.Content = "Current date and time: " + currentDate;
                    balance.Content = "Company budget: $" + bal / 76;
                }
                else
                {
                    CultureInfo culture = new CultureInfo("de-DE");
                    string currentDate = DateTime.Now.ToString("F", culture);
                    Date.Content = "Aktuelles Datum und Uhrzeit: " + currentDate;
                    balance.Content = "Das Budget des Unternehmens: " + bal / 87 + " €";
                }
            }

        }

        private void Lang_Click(object sender, RoutedEventArgs e)
        {
            if (lang.Visibility == Visibility.Hidden)
                lang.Visibility = Visibility.Visible;
            else
                lang.Visibility = Visibility.Hidden;
        }

        private void Lang_EN_Click(object sender, RoutedEventArgs e)
        {
            lang.Visibility = Visibility.Hidden;
            ComboBox cb = sender as ComboBox;
            language = Lang_EN.Tag.ToString();
            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
            CultureInfo culture = new CultureInfo("en-US");
            string currentDate = DateTime.Now.ToString("F",culture);
            if (lang_ch.Text == "Русский")
            {
                Date.Content = "Текущая дата и время: " + currentDate;
                balance.Content = "Баланс компании: " + bal + " руб.";
            }
            else
            {
                if (lang_ch.Text == "English")
                {
                    Date.Content = "Current date and time: " + currentDate;
                    balance.Content = "Company budget: $" + bal / 76;
                }
                else
                {
                    Date.Content = "Aktuelles Datum und Uhrzeit: " + currentDate;
                    balance.Content = "Das Budget des Unternehmens: " + bal / 87 + " €";
                }
            }
        }
        private void Lang_RU_Click(object sender, RoutedEventArgs e)
        {
            lang.Visibility = Visibility.Hidden;
            ComboBox cb = sender as ComboBox;
            language = Lang_RU.Tag.ToString();
            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
            CultureInfo culture = new CultureInfo("ru-RU");
            string currentDate = DateTime.Now.ToString("F", culture);
            if (lang_ch.Text == "Русский")
            {
                Date.Content = "Текущая дата и время: " + currentDate;
                balance.Content = "Баланс компании: " + bal + " руб.";
            }
            else
            {
                if (lang_ch.Text == "English")
                {
                    Date.Content = "Current date and time: " + currentDate;
                    balance.Content = "Company budget: $" + bal / 76;
                }
                else
                {
                    Date.Content = "Aktuelles Datum und Uhrzeit: " + currentDate;
                    balance.Content = "Das Budget des Unternehmens: " + bal / 87 + " €";
                }
            }
        }
        private void Lang_DE_Click(object sender, RoutedEventArgs e)
        {
            lang.Visibility = Visibility.Hidden;
            ComboBox cb = sender as ComboBox;
            language = Lang_DE.Tag.ToString();
            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
            CultureInfo culture = new CultureInfo("de-DE");
            string currentDate = DateTime.Now.ToString("F", culture);
            if (lang_ch.Text == "Русский")
            {
                Date.Content = "Текущая дата и время: " + currentDate;
                balance.Content = "Баланс компании: "+bal+" руб.";
            }
            else
            {
                if (lang_ch.Text == "English")
                {
                    Date.Content = "Current date and time: " + currentDate;
                    balance.Content = "Company budget: $"+bal/76;
                }
                else
                {
                    Date.Content = "Aktuelles Datum und Uhrzeit: " + currentDate;
                    balance.Content = "Das Budget des Unternehmens: "+bal/87+ " €"; 
                }
            }
        }
    }

}
