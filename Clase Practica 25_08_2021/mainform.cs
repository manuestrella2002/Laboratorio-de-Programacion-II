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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
           
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
     
        }

        private void button_Mensaje_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Este es mi mensaje","Este es mi titulo",MessageBoxButtons.YesNo);
            
        
        
        }

        private void button_Dialog_Click(object sender, EventArgs e)
        {
            FormDialog formDialog = new FormDialog();
            DialogResult result = formDialog.ShowDialog();

            if (result==DialogResult.OK)
            {
                MessageBox.Show("Presiono OK");
            }
            if (result==DialogResult.Cancel)
            {
                MessageBox.Show("Presiono cancel");
            }
        }
    }
}
