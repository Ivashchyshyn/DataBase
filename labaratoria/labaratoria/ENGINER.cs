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
    public partial class ENGINER : Form
    {
        public ENGINER()
        {
            InitializeComponent();
        }

        public object HospitalBindingSource { get; private set; }
        public
            HospitalEntities H
        { get; private set; }

        private void engineer_1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            H.SaveChanges();
            this.Validate();
            this.engineer_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            H = new HospitalEntities();
           

        }
    }
}
