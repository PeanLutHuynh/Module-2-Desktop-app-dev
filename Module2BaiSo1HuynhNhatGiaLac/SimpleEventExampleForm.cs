using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2BaiSo1HuynhNhatGiaLac
{
    public partial class SimpleEventExampleForm : Form
    {
        public SimpleEventExampleForm()
        {
            InitializeComponent();
            SimpleEventExampleForm_Load(this, EventArgs.Empty);
        }

        private void SimpleEventExampleForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked.");
        }

        private void SimpleEventExampleForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi , Welcome to C# 2010 programming!");
        }
    }
}
