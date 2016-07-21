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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream data_base = new FileStream("C:\\Users\\Stepan\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\base.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(data_base);
            StreamWriter writer = new StreamWriter(data_base);
            if (reader.EndOfStream)
            {
                writer.WriteLine("ID;Name;Place;Picture;Comments;Official;Normal;Sport;Bad;Dead;");
                writer.WriteLine(textBox1.Text + ";" + textBox3.Text + ";" + textBox2.Text + ";" + textBox4.Text + ";");
                writer.Close();
            }
            reader.Close();
        }
    }
}
