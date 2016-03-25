using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaratoria
{
    public partial class button : Form
    {
        public button()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 hospital = new Form2();
            hospital.Show();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            lABARATORY Labaratory = new lABARATORY();
            Labaratory. Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ENGINER Engineer = new ENGINER();
            Engineer.Show();
        }

        private void button_Load(object sender, EventArgs e)
        {

        }
    }
}
