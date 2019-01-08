using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LearnWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person Male { get; set; }
        public Person Female { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //this.contentControl.Content = new Person
            //{
            //    FirstName = "Ben",
            //    LastName = "Frank",
            //    Age = 82
            //};

            /*
            Male = new Person()
            {
                FirstName = "Joe",
                LastName = "Smith",
                Age = 52,
                Gender = Gender.Male
            };

            Female = new Person()
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 40,
                Gender = Gender.Female
            };
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
            richTextBox.Selection.ApplyPropertyValue(TextElement.BackgroundProperty,
                Brushes.Green);

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            if (richTextBox.Selection.IsEmpty)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }
    }
}
