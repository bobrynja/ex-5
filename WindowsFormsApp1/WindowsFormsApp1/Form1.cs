using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            try
            {
                if (x < 1 && x > -1) return 1 / (x + 7) + Math.Log(1 - Math.Abs(x));
                else throw new Exception();
            }
            catch { throw; }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                try
                {
                    textBox4.Text = "";
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double h = Convert.ToDouble(textBox3.Text);
                    if (a > b) MessageBox.Show("Нижняя граница не может быть больше верхней");
                    else if (h == 0) MessageBox.Show("Шаг не может быть равен 0");
                    else
                    {
                        for (double x = a; x <= b; x += h)
                        {
                            try
                            {
                                textBox4.Text+="y("+Math.Round(x,2)+")="+ Math.Round(f(x),4)+Environment.NewLine;
                            }
                            catch { textBox4.Text += "y(" + Math.Round(x, 2) + ")=ошибка"+Environment.NewLine; }
                        }
                    }
                }
                catch (FormatException) { MessageBox.Show("Неверный формат ввода данных"); }
                catch
                {
                    MessageBox.Show("Неизвестная ошибка");
                }
            }
        }

    }
    
