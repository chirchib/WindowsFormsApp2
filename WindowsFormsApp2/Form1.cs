using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] set;

        private void create_set1()
        {
            string[] string_set = textBox1.Text.Split(',');
            set = new int[string_set.Length];
            for (int i = 0; i < set.Length; ++i)
                set[i] = Int32.Parse(string_set[i]);
        }
        // удаление эл-та
        private void button1_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                create_set1();
                index = Convert.ToInt32(textBox3.Text);
                textBox1.Text = Set.Display(Set.removeElement(set, index));
                textBox6.Text = Set.Display(Set.removeElement(set, index));
            }
            catch (InvalidCastException)
            {
                textBox6.Text = "Недопустимое значение";
            }
            catch (NullReferenceException)
            {
                textBox6.Text = "Поле пустое";
            }
            catch (ArgumentOutOfRangeException)
            {
                textBox6.Text = "Введите правильный индекс";
            }
            catch (Exception)
            {
                textBox6.Text = "Ошибка";
            }
        }

        // добавление эт-та
        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            int index;
            try
            {
                create_set1();
                num = Int32.Parse(textBox4.Text);
                index = Int32.Parse(textBox3.Text);
                set = Set.addElement(set, index, num);
                textBox1.Text = Set.Display(set);
                textBox6.Text = Set.Display(set);
            }
            catch (InvalidCastException)
            {
                textBox6.Text = "Недопустимое значение";
            }
            catch (NullReferenceException)
            {
                textBox6.Text = "Поле пустое";
            }
            catch (ArgumentOutOfRangeException)
            {
                textBox6.Text = "Введите правильный индекс";
            }
            catch (Exception)
            {
                textBox6.Text = "Ошибка";
            }
        }

        private int[] set1;

        private void create_set2()
        {
            string[] string_set = textBox2.Text.Split(',');
            set1 = new int[string_set.Length];
            for (int i = 0; i < set1.Length; ++i)
                set1[i] = Int32.Parse(string_set[i]);
        }
        // объединиьь
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                create_set1();
                create_set2();
                set = Set.mergeArrays(set, set1);
                textBox1.Text = Set.Display(set);
                textBox6.Text = Set.Display(set);
            }
            catch (InvalidCastException)
            {
                textBox6.Text = "Недопустимое значение";
            }
            catch (NullReferenceException)
            {
                textBox6.Text = "Поле пустое";
            }
            catch (ArgumentOutOfRangeException)
            {
                textBox6.Text = "Введите правильный индекс";
            }
            catch (Exception)
            {
                textBox6.Text = "Ошибка";
            }
        }

        // опринадлежит
        private void button4_Click(object sender, EventArgs e)
        {
            int num;
            try
            {
                create_set1();
                num = Int32.Parse(textBox5.Text);
                if (Set.isInArray(set, num))
                {
                    textBox6.Text = "Принадлежит";
                }
                else
                {
                    textBox6.Text = "Не принадлежит";
                }
            }
            catch (InvalidCastException)
            {
                textBox6.Text = "Недопустимое значение";
            }
            catch (NullReferenceException)
            {
                textBox6.Text = "Поле пустое";
            }
            catch (ArgumentOutOfRangeException)
            {
                textBox6.Text = "Введите правильный индекс";
            }
            catch (Exception)
            {
                textBox6.Text = "Ошибка";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
