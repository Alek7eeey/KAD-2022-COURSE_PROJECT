using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;
using System.Threading;
using FastColoredTextBoxNS;
using Microsoft.VisualBasic;

namespace Interface
{
    public partial class StartForm : Form
    {
        public FastColoredTextBoxNS.Style OrangeStyle = new FastColoredTextBoxNS.TextStyle(Brushes.SaddleBrown, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style GreenStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Green, null, FontStyle.Bold);
        public FastColoredTextBoxNS.Style BlueStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Blue, null, FontStyle.Bold);
        public FastColoredTextBoxNS.Style LightBlueStyle = new FastColoredTextBoxNS.TextStyle(Brushes.LightBlue, null, FontStyle.Bold);
        public FastColoredTextBoxNS.Style LightGreenStyle = new FastColoredTextBoxNS.TextStyle(Brushes.LightGreen, null, FontStyle.Regular);
        public FastColoredTextBoxNS.Style DeepPinkStyle = new FastColoredTextBoxNS.TextStyle(Brushes.DeepPink, null, FontStyle.Regular);
        public FastColoredTextBoxNS.Style AddStyle = new FastColoredTextBoxNS.TextStyle(Brushes.Orange, null, FontStyle.Underline);
        public FastColoredTextBoxNS.Style StaticFunction = new FastColoredTextBoxNS.TextStyle(Brushes.Firebrick, null, FontStyle.Underline);

        public static int Count = 0;
        public static int sizeText = 9;
        public static string textSearch = "";

        public StartForm()
        {
            InitializeComponent();
            //autocompleteMenu2.Items = File.ReadAllLines("spk-reserv.dict");
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void StartForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StartForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void NameOfTransl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void NameOfTransl_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void iconInst_Click(object sender, EventArgs e)
        {
            string path = "https://www.instagram.com/kravchenko__aleksey/";
            MessageBox.Show(path, "Instagram");
        }

        private void iconVK_Click(object sender, EventArgs e)
        {
            string path = "https://vk.com/kravchenkoaleksey";
            MessageBox.Show(path,"VK");
        }

        private void iconGitHub_Click(object sender, EventArgs e)
        {
            string path = "https://github.com/Alek7eeey";
            MessageBox.Show(path, "GitHub");
        }

        private void sdfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileText = "";
            fileText += System.IO.File.ReadAllText("C:\\CourseProject\\KAD-2022\\Debug\\Files\\in.txt", System.Text.Encoding.Default);
            newTextBox.Text = fileText;
        }

        private void dfdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileText = "";
            fileText += System.IO.File.ReadAllText("C:\\CourseProject\\KAD-2022\\Debug\\Files\\in.txt.log", System.Text.Encoding.Default);
            newTextBox.Text = fileText;
        }

        private void sdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileText = "";
            fileText += System.IO.File.ReadAllText("C:\\CourseProject\\KAD-2022\\Debug\\Files\\Table.lex.txt", System.Text.Encoding.Default);
            newTextBox.Text = fileText;
        }

        private void sdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fileText = "";
            fileText += System.IO.File.ReadAllText("C:\\CourseProject\\KAD-2022\\Debug\\Files\\Table.id.txt", System.Text.Encoding.Default);
            newTextBox.Text = fileText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c"  +
                "cd C:\\CourseProject\\KAD-2022\\Debug\\Files & ml /c /coff in.txt.asm &" +
               "link /OPT:NOREF /DEBUG in.txt.obj StaticLib.lib /SUBSYSTEM:CONSOLE";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();

            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/k" +
                "cd C:\\CourseProject\\KAD-2022\\Debug\\Files & in.txt.exe";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            p2.WaitForExit();


        }

        private void compile_Click_1(object sender, EventArgs e)
        {
            if (newTextBox.Text.Count()!=0)
            {
                StreamWriter f = new StreamWriter("C:\\CourseProject\\KAD-2022\\Debug\\Files\\in.txt", false, System.Text.Encoding.Default);
                StreamWriter f2 = new StreamWriter("C:\\CourseProject\\KAD-2022\\KAD-2022\\Files\\in.txt", false, System.Text.Encoding.Default);
                using (StreamWriter str = f, str2 = f2)
                {
                    str.WriteLine(newTextBox.Text);
                    str2.WriteLine(newTextBox.Text);
                    str.Close();
                    str2.Close();
                }

                Process p = new Process();
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/k" + "cd C:\\CourseProject\\KAD-2022\\Debug & KAD-2022.exe -in:Files\\in.txt";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
            }

            else
            {
                MessageBox.Show("Вы пытаетесь скомпилировать пустой файл!", "Ошибка");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            newTextBox.Text= "";
        }

        private void newTextBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)  
        {
            e.ChangedRange.ClearFoldingMarkers(); //скрытие блоков кода
            e.ChangedRange.SetFoldingMarkers("{","}");

            e.ChangedRange.SetStyle(OrangeStyle, @"function");
            e.ChangedRange.SetStyle(OrangeStyle, @"main");

            e.ChangedRange.SetStyle(GreenStyle, @"str");
            e.ChangedRange.SetStyle(GreenStyle, @"int");

            e.ChangedRange.SetStyle(BlueStyle, @"var");
            e.ChangedRange.SetStyle(BlueStyle, @"param");
            e.ChangedRange.SetStyle(BlueStyle, @"repeat");
            e.ChangedRange.SetStyle(BlueStyle, @"return");

            e.ChangedRange.SetStyle(LightBlueStyle, @"repeat");
            e.ChangedRange.SetStyle(LightBlueStyle, @"if");

            e.ChangedRange.SetStyle(LightGreenStyle, @"write");

            e.ChangedRange.SetStyle(DeepPinkStyle, @"then");
            e.ChangedRange.SetStyle(DeepPinkStyle, @"else");

            e.ChangedRange.SetStyle(StaticFunction, @"lenght");
            e.ChangedRange.SetStyle(StaticFunction, @"copy");
            e.ChangedRange.SetStyle(StaticFunction, @"squareOfNumber");
            e.ChangedRange.SetStyle(StaticFunction, @"factorialOfNumber");
            e.ChangedRange.SetStyle(StaticFunction, @"random");
            e.ChangedRange.SetStyle(StaticFunction, @"powNumber");
            e.ChangedRange.SetStyle(StaticFunction, @"getLocalTimeAndDate");


            string textSymb = newTextBox.Text.Length.ToString();
           string[] textLine = newTextBox.Text.Split('\n');

            Symbol.Text= "Cимволов:" + textSymb;
            stroke.Text = "Cтрок:" + textLine.Length.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (newTextBox.BackColor == Color.DarkGray)
            {
                newTextBox.BackColor = Color.FromArgb(224, 255, 255);
                newTextBox.IndentBackColor= Color.FromArgb(135, 206, 250);
                newTextBox.LineNumberColor= Color.Black;
                StartForm.ActiveForm.BackColor= Color.FromArgb(135, 206, 235);
            }

            else
            {
                newTextBox.BackColor = Color.DarkGray;
                newTextBox.IndentBackColor = Color.DimGray;
                newTextBox.LineNumberColor = Color.SpringGreen;
                StartForm.ActiveForm.BackColor = Color.LightGray;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(Count != 3)
            {
                sizeText += 5;
                Count++;
                newTextBox.Font = new Font("Courier New", sizeText);
            }
            else
            {
                Count = 0;
                sizeText = 9;
                newTextBox.Font = new Font("Courier New", sizeText);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textSearch = newTextBox.Text;
            Search search= new Search();
            search.Show();
                       
        }
           
          
        }
}

