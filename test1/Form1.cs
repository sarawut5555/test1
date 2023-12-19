using System;
using System.IO;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textTosave = textBox1.Text;
            String Filename = "test.txt";
            File.WriteAllText(Filename, textTosave);
            textBox1.Clear();
            textBox1.Text = ("บันทึกเรียบร้อย");
        }
    }
}