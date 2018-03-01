using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parduotuve_povbuk
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void uzsakymaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uzsakymaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duomenuBazeDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duomenuBazeDataSet.Uzsakymai' table. You can move, or remove it, as needed.
            this.uzsakymaiTableAdapter.Fill(this.duomenuBazeDataSet.Uzsakymai);

        }

        private void pagal_Uzsakymo_IDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uzsakymaiTableAdapter.pagal_Uzsakymo_ID(this.duomenuBazeDataSet.Uzsakymai, ((int)(System.Convert.ChangeType(idToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pagal_Vartotojo_IDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uzsakymaiTableAdapter.pagal_Vartotojo_ID(this.duomenuBazeDataSet.Uzsakymai, idToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
