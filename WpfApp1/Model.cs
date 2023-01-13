using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static int Count // свойство для отображения числа в TextBlock
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                tb.Text = count.ToString();
            }
        }
        public static int Combo  // свойтсво для отображения фамилии в Combobox
        {
            set
            {
                tbznak.Text = dataZnak[value];
            }
        }
        public static void operations(int i)
        {
            double firstCon = Double.Parse(firstNum.Text);
            double secondCon = Double.Parse(secomdNum.Text);
            double result;
            switch (i)
            {
                case 0:
                    result = firstCon+ secondCon;
                    tbResult.Text = Convert.ToString(result);
                    break;

            }
        }
    }
}
