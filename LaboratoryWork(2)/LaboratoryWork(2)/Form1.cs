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
namespace LaboratoryWork_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            string s = "";
            string[] text;
            path = @"C:\Users\misha\Desktop\Sentence.txt";//<- змінити шлях створення файлу та створити файл перед запуском програми
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            while (streamReader.EndOfStream != true)
            {
                s += streamReader.ReadLine();
            }
            text = s.Split(' ');
            streamReader.Close();
            file.Close();
            textBox1.Text = Convert.ToString(text.Length);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
