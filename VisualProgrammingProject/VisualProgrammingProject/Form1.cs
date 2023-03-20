using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualProgrammingProject.patientsclasses;
using System.Configuration;
using System.Data.SqlClient;

namespace VisualProgrammingProject
{
    public partial class Form1 : Form
    {
        patientsclasses2 std = new patientsclasses2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2 = null;
                this.Show();
            
        }
    }
}
