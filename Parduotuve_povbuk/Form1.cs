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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // fiksuojam formos dydi, kad negalima butu keisti
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void vartotojaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vartotojaiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.duomenuBazeDataSet);
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duomenuBazeDataSet.Vartotojai' table. You can move, or remove it, as needed.
            this.vartotojaiTableAdapter.Fill(this.duomenuBazeDataSet.Vartotojai);

        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void buttonNaujasUzsakymas_Click(object sender, EventArgs e)
        {
            var kitasLangas = new Form2(vartotojo_IDTextBox.Text, vardasTextBox.Text, pavardeTextBox.Text);
            string title = ("ID: " + vartotojo_IDTextBox.Text + " " + vardasTextBox.Text + " " + pavardeTextBox.Text).ToString();
            kitasLangas.Text = title;
            kitasLangas.FormBorderStyle = FormBorderStyle.FixedDialog; // fiksuojam formos Form2 dydi
            kitasLangas.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void buttonIrasas_Click(object sender, EventArgs e)
        {
            var kitasLangas = new Form3(vartotojo_IDTextBox.Text);
            string title = ("ID: " + vartotojo_IDTextBox.Text + " " + vardasTextBox.Text + " " + pavardeTextBox.Text).ToString();
            kitasLangas.Text = title;
            kitasLangas.FormBorderStyle = FormBorderStyle.FixedDialog; // fiksuojam formos Form2 dydi
            kitasLangas.ShowDialog();
        }

        private void buttonUzsakymai_Click(object sender, EventArgs e)
        {
            var kitasLangas = new Form4();
            kitasLangas.Text = "Visu parduotuves uzsakymu sarasas";
            kitasLangas.ShowDialog();
        }
    }
}
