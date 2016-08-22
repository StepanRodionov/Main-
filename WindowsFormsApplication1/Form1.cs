using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string message;
        public Form1()
        {
            InitializeComponent();
        }

        private void enumChoosen_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (((RadioButton)groupBox1.Controls[i]).Checked == true)
                {                   
                    message = i.ToString();
                }
            }
            Form3 filtred = new Form3(message); // создаем
            filtred.ShowDialog(); // показываем
        }

        private void Newitem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // создаем
            f.ShowDialog(); // показываем
        }

        private void Allcloth_Click(object sender, EventArgs e)
        {
            Form3 all = new Form3(); // создаем
            all.ShowDialog(); // показываем
        }

        private void casualities_Click(object sender, EventArgs e)
        {
            message = "dead";
            Form3 dead = new Form3(message); // создаем
            dead.ShowDialog(); // показываем
        }
    }
}
