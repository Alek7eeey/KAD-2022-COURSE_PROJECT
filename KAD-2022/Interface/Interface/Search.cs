using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public string searchText = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if(inputSearch.Text.Length > 0) 
            {
                searchText = inputSearch.Text;
                this.Close();

  
              
                if (StartForm.textSearch.Substring(0, StartForm.textSearch.Length).Contains(searchText) && searchText != "")
                {
                    MessageBox.Show("Такое слово присутствует в исходном тексте!", "Сообщение");
                }

                else
                {
                    MessageBox.Show("Такое слово отсутствует в исходном тексте!", "Сообщение");
                }
            }

            else
            {
                MessageBox.Show("Вы ничего не ввели!", "Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Point lastPoint2;

        private void Search_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }

        private void Search_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void NameOfTransl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint2 = new Point(e.X, e.Y);
        }

        private void NameOfTransl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint2.X;
                this.Top += e.Y - lastPoint2.Y;
            }
        }
    }
}
