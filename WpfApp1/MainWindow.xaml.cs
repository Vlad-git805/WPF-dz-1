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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 6;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 6;
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
            textbox2.Text = "";
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }

        private void ButtonClearOnesymbol_Click(object sender, RoutedEventArgs e)
        {
            string str = null;
            for (int i = 0; i < textbox.Text.Length - 1; i++)
            {
                str += textbox.Text[i];
            }
            textbox.Text = str;
        }

        private void ButtonSlesh_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                return;
            if (textbox.Text[textbox.Text.Length - 1] != '*' && textbox.Text[textbox.Text.Length - 1] != '/' && textbox.Text[textbox.Text.Length - 1] != '+' && textbox.Text[textbox.Text.Length - 1] != '-' && textbox.Text[textbox.Text.Length - 1] != '.')
                textbox.Text += '/';
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 7;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 7;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 8;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 8;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 9;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 9;
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                return;
            if (textbox.Text[textbox.Text.Length - 1] != '*' && textbox.Text[textbox.Text.Length - 1] != '/' && textbox.Text[textbox.Text.Length - 1] != '+' && textbox.Text[textbox.Text.Length - 1] != '-' && textbox.Text[textbox.Text.Length - 1] != '.')
                textbox.Text += '*';
        }

        private void ButtonMinys_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                return;
            if (textbox.Text[textbox.Text.Length - 1] != '*' && textbox.Text[textbox.Text.Length - 1] != '/' && textbox.Text[textbox.Text.Length - 1] != '+' && textbox.Text[textbox.Text.Length - 1] != '-' && textbox.Text[textbox.Text.Length - 1] != '.')
                textbox.Text +='-';
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                return;
            if (textbox.Text[textbox.Text.Length - 1] != '*' && textbox.Text[textbox.Text.Length - 1] != '/' && textbox.Text[textbox.Text.Length - 1] != '+' && textbox.Text[textbox.Text.Length - 1] != '-' && textbox.Text[textbox.Text.Length - 1] != '.')
                textbox.Text += '+';
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text[textbox.Text.Length - 1] == '+' || textbox.Text[textbox.Text.Length - 1] == '-' || textbox.Text[textbox.Text.Length - 1] == '*' || textbox.Text[textbox.Text.Length - 1] == '/' || textbox.Text[textbox.Text.Length - 1] == '.')
                return;
            bool ok = false;
            for (int i = 0; i < textbox.Text.Length; i++)
            {
                if(textbox.Text[i] == '+' || textbox.Text[i] == '-' || textbox.Text[i] == '*' || textbox.Text[i] == '/')
                {
                    ok = true;
                    break;
                }
            }
            if(ok == false)
            {
                return;
            }
            else if(ok == true)
            {
                string str = textbox.Text;
                textbox2.Text = str;
                double result = 0;
                string first_numb = null;
                string second_numb = null;
                bool mult = false;
                bool dil = false;
                bool plus = false;
                bool minys = false;

                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if(textbox.Text[i] == '*' || textbox.Text[i] == '/' || textbox.Text[i] == '+' || textbox.Text[i] == '-')
                    {
                        if (textbox.Text[i] == '*')
                            mult = true;
                        else if (textbox.Text[i] == '/')
                            dil = true;
                        else if (textbox.Text[i] == '+')
                            plus = true;
                        else if (textbox.Text[i] == '-')
                            minys = true;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (textbox.Text[j] == '*' || textbox.Text[j] == '/' || textbox.Text[j] == '+' || textbox.Text[j] == '-')
                                break;
                            if (textbox.Text[j] == '.')
                                first_numb += ',';
                            else
                                first_numb += textbox.Text[j];
                        }

                        for (int j = i + 1; j < textbox.Text.Length; j++)
                        {
                            if (textbox.Text[j] == '*' || textbox.Text[j] == '/' || textbox.Text[j] == '+' || textbox.Text[j] == '-')
                                break;
                            if (textbox.Text[j] == '.')
                                second_numb += ',';
                            else
                                second_numb += textbox.Text[j];
                        }
                    }
                }
                char[] chararr = first_numb.ToCharArray();
                Array.Reverse(chararr);
                first_numb = new string(chararr);
                textbox.Text = "";
                if (mult == true)
                {
                    result = double.Parse(first_numb) * double.Parse(second_numb);
                    textbox.Text += result;
                }
                else if (dil == true)
                {
                    if(double.Parse(second_numb) == 0)
                    {
                        textbox.Text += "error, dilenna na 0";
                        textbox2.Text = "";
                        return;
                    }
                    result = double.Parse(first_numb) / double.Parse(second_numb);
                    textbox.Text += result;
                }
                else if (plus == true)
                {
                    result = double.Parse(first_numb) + double.Parse(second_numb);
                    textbox.Text += result;
                }
                else if (minys == true)
                {
                    result = double.Parse(first_numb) - double.Parse(second_numb);
                    textbox.Text += result;
                }


                //string[] numbers = textbox2.Text.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
                //foreach (var item in numbers)
                //{
                //    textbox.Text += item + ' ';
                //}
            }

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 4;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 4;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 5;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 5;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 1;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 1;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 2;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 2;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if(textbox.Text.Length == 0)
                textbox.Text += 3;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 3;
        }

        private void ButtonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                return;
            if (textbox.Text[textbox.Text.Length - 1] != '*' && textbox.Text[textbox.Text.Length - 1] != '/' && textbox.Text[textbox.Text.Length - 1] != '+' && textbox.Text[textbox.Text.Length - 1] != '-' && textbox.Text[textbox.Text.Length - 1] != '.')
                textbox.Text += '.';
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text.Length == 0)
                textbox.Text += 0;
            else if ((textbox.Text.Length > 1 && textbox.Text[textbox.Text.Length - 1] == '0') && (textbox.Text[textbox.Text.Length - 2] == '+' || textbox.Text[textbox.Text.Length - 2] == '-' || textbox.Text[textbox.Text.Length - 2] == '*' || textbox.Text[textbox.Text.Length - 2] == '/'))
            {
                return;
            }
            else
                textbox.Text += 0;
        }
    }
}
