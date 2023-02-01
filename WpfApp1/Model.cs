using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class Model
    {// блок с данными
        static int count = 0;
        public static List<string> datalist = new List<string> { "Сложение", "Вычитание","Умножение", "Деление" };
        public static List<string> dataZnak = new List<string> { "+", "-", "*", "/" };
        // блок для обращения к текстовым полям
        public static TextBlock tb;
        public static TextBlock tbCombo;
        public static TextBlock tbznak;
        public static TextBox firstNum;
        public static TextBox secomdNum;
        public static TextBox tbResult;
        // блок с бизнес-логикой
     
        public static int Combo  // свойтсво для отображения знака для текущей операции
        {
            set
            {
                tbznak.Text = dataZnak[value];
            }
        }
        public static void operations(int i)// вычисление
        {
            double firstCon = Double.Parse(firstNum.Text);
            double secondCon = Double.Parse(secomdNum.Text);
            double result;
            switch (i)
            {
                case 0:
                    result = firstCon + secondCon;
                    tbResult.Text = Convert.ToString(result);
                    break;
                case 1:
                    result = firstCon - secondCon;
                    tbResult.Text = Convert.ToString(result);
                    break;
                case 2:
                    result = firstCon * secondCon;
                    tbResult.Text = Convert.ToString(result);
                    break;
                case 3:
                    result = firstCon / secondCon;
                    if (secondCon == 0 || firstCon==0)
                        MessageBox.Show("Делить на ноль нельзя!!!!");
                     else  tbResult.Text = Convert.ToString(result);
                    break;
            }
        }
    }
}
