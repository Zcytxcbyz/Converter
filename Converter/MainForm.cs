using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Converter
{
    public partial class MainForm : Form
    {
        public int[] Index = { 2, 8, 10, 16 };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox_num.SelectedIndex = 0;
            comboBox_result.SelectedIndex = 2;
        }

        private void button_Main_Click(object sender, EventArgs e)
        {
            try
            {   
                int valueindex = Index[comboBox_num.SelectedIndex];
                int resultindex = Index[comboBox_result.SelectedIndex];
                textBox_result.Text = NumConverter(textBox_num.Text, valueindex, resultindex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
        private string NumConverter(string value,int valueindex,int resultindex)
        {
            if (NumAnalysis(value, valueindex))
            {
                string result = null; int temp = 0;
                if (valueindex != 10)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int strindex = value.Length - i - 1;
                        string item = value[strindex].ToString();
                        if (Regex.IsMatch(item.ToString(), "[A-Z]"))
                            item = (value[strindex] - 'A' + 10).ToString();
                        else if (Regex.IsMatch(item.ToString(), "[a-z]"))
                            item = (value[strindex] - 'a' + 10).ToString();
                        temp += Convert.ToInt32(item) * Convert.ToInt32(Math.Pow(valueindex, i));
                    }
                }
                else
                {
                    temp = Convert.ToInt32(value);
                }

                while (temp > 0)
                {
                    int item = temp % resultindex;
                    if (item < 10)
                        result = item.ToString() + result;
                    else
                        result = ((char)(item - 10 + 'a')).ToString() + result;

                    temp /= resultindex;
                }
                return result;
            }
            else
            {
                throw new FormatException("输入字符串的格式不正确。");
            }
        }
        private bool NumAnalysis(string value,int valueindex)
        {
            bool result = false;
            if (valueindex == 10)
                result = Regex.IsMatch(value, "^[0-9]+$");
            if (valueindex == 2)
                result = Regex.IsMatch(value, "^[01]+$");
            if (valueindex == 8)
                result = Regex.IsMatch(value, "^[0-7]+$");
            if (valueindex == 16)
                result = Regex.IsMatch(value, "^[0-9A-Fa-f]+$");
            return result;
        }
    }
}
