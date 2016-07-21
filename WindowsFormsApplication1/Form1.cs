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
        public Form1()
        {
            InitializeComponent();
        }

        private void enumChoosen_Click_1(object sender, EventArgs e)
        {

        }

        private void Newitem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // создаем
            f.ShowDialog(); // показываем
        }
    }
}
