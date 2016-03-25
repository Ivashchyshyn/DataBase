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
    public partial class lABARATORY : Form
    {
        HospitalEntities H;

        public lABARATORY()
        {
            InitializeComponent();
        }

        private void laboratoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            H.SaveChanges();
            this.Validate();
            this.laboratoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(hospitalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            H = new HospitalEntities();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Laboratory". При необходимости она может быть перемещена или удалена.
            laboratoryTableAdapter.Fill(this.hospitalDataSet.Laboratory);

        }

        private void laboratoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}