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
    public partial class Lab5TaskForm : Form
    {
        public Lab5TaskForm()
        {
            InitializeComponent();
        }


        private void button_Lab5CalculateForm(object sender, EventArgs e)
        {
            Lab5CalculateForm newForm = new Lab5CalculateForm();
            newForm.Show();
            this.Hide();
        }
    }


}
