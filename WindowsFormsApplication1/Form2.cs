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
            FileStream data_base = new FileStream("C:\\Users\\Stepan\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\base.csv", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(data_base);
            StreamWriter writer = new StreamWriter(data_base);
            string a = "";
            string[] checklist_values = {"false", "false", "false", "false", "false"};
            foreach (var elem_number in checkedListBox1.CheckedIndices)
            {
                int num = Convert.ToInt32(elem_number);
                checklist_values[num] = "true";               
            }
            for (int i = 0; i < checklist_values.Length; i++)
            {
                a += checklist_values[i] + ";";
            }
            if (reader.EndOfStream)
            {
                writer.WriteLine("ID;Name;Place;Picture;Comments;Official;Normal;Sport;Bad;Dead;");
                writer.WriteLine("1;" + textBox1.Text + ";" + textBox3.Text + ";" + textBox2.Text + ";" + textBox4.Text + ";" + a);
                writer.Close();
            }
            else
            {
                int items_count = 0;
                while (!reader.EndOfStream){
                    reader.ReadLine();
                    items_count++;
                }
                writer.WriteLine(items_count + ";" + textBox1.Text + ";" + textBox3.Text + ";" + textBox2.Text + ";" + textBox4.Text + ";" + a);
                writer.Close();
            }
            reader.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
