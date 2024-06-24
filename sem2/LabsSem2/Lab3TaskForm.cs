using Lab3Sem2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_sem2
{
    public partial class Lab3TaskForm : Form
    {
        public Lab3TaskForm()
        {
            InitializeComponent();
        }
        private void button_Lab3CalculateForm(object sender, EventArgs e)
        {
            Lab3CalculateForm newForm = new Lab3CalculateForm();
            newForm.Show();
            this.Hide();
        }
    }
}
