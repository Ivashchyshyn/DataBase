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
    public partial class Form2 : Form
    {
        public object HospitalBindingSource { get; private set; }
        public 
            HospitalEntities H { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void hospitalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            H.SaveChanges();
            this.Validate();
            hospitalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Hospital". При необходимости она может быть перемещена или удалена.
            this.hospitalTableAdapter.Fill(this.hospitalDataSet.Hospital);
            H = new HospitalEntities();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Laboratory". При необходимости она может быть перемещена или удалена.

        }
    }
}