using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Practica_25_08_2021
{
    public partial class Form1 : Form
    {
        mainform fORM;
        public Form1(mainform form_main)
        {
            InitializeComponent();
            fORM = form_main;
        }

        private void button1_Volver_Click(object sender, EventArgs e)
        {
            fORM.Show();
            this.Close();
        }
    }
}
