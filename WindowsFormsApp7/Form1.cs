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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

            comboBox3.Items.Clear();
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            comboBox3.Items.AddRange(colores);

            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Items.Add("16");
            comboBox2.Items.Add("18");
            comboBox2.Items.Add("20");
            comboBox2.Items.Add("22");
            comboBox2.Items.Add("24");
            comboBox2.Items.Add("26");
            comboBox2.Items.Add("28");
            comboBox2.Items.Add("48");
            comboBox2.Items.Add("72");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(comboBox2.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);



        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;



        }



        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(comboBox3.Text);
        }



        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:\Users\LITHIUM\Desktop\" + textBox1.Text + ".txt", RichTextBoxStreamType.PlainText);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length != 0)
            {
                richTextBox1.SaveFile(@"C:\Users\LITHIUM\Desktop\" + textBox2.Text + ".txt", RichTextBoxStreamType.PlainText);
            }
        }
    }
}
