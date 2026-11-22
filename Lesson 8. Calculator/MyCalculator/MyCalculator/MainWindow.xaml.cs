using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currOperation = string.Empty;

        private string currValue = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Digital_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender; // ДАна операція зветься unboxing
            var textBlock = (TextBlock)button.Content;
            string value = textBlock.Text;
            if (txtResult.Text == "0")
                txtResult.Text = value;
            else
                txtResult.Text += value;

        }

        private void Button_Backspace_Click(object sender, RoutedEventArgs e)
        {
            int len = txtResult.Text.Length;
            if (len != 0)
            {
                string str = txtResult.Text.Substring(0, len - 1);
                txtResult.Text = str;
            }

        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void Button_Koma_Click(object sender, RoutedEventArgs e)
        {
            string koma = ",";
            bool isKoma = txtResult.Text.Contains(koma);
            if (isKoma)
                return;
            txtResult.Text += ",";
        }

        private void Button_Operation_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender; //Дана операція зветься unboxing
            var textBlock = (TextBlock)button.Content; //Отримуємо у середині кнопки TextBlock
            string operation = textBlock.Text; //тут буде операція +, -, *, / ...

            if (string.IsNullOrEmpty(currOperation))
            {
                currOperation = operation;
                currValue = txtResult.Text; //Зберіг значення, яке було перед чим і інпут
                txtResult.Text = "0"; //Стираємо попередьнє значення
            }
            else
            {
                //Беремо попередню операцію і її виконуємо
                //Виконую додаванн, віднімання  або множення, ...
                switch (currOperation)
                {
                    case "+":
                        {
                            double a = Double.Parse(currValue);
                            double b = Double.Parse(txtResult.Text);
                            double c = a + b;
                            txtResult.Text = c.ToString();
                            currOperation = string.Empty;
                            break;
                        }
                }
            }
        }

    }
}