using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Parduotuve_povbuk
{
    public partial class Form2 : Form
    {
        public Form2(string vartotojoID, string vartotojoVardas, string vartotojoPavarde)
        {
            InitializeComponent();
            textBox1.Text = vartotojoID;
            rodyti();
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void buttonPatvirtinti_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            Table<Uzsakymai> uzsakymuTable = db.GetTable<Uzsakymai>();
            //Table<Preke> prekiuTable = db.GetTable<Preke>();
            List<Vartotojai> vartotojuSar = db.GetTable<Vartotojai>().ToList();
            Uzsakymai uzsakymas = new Uzsakymai();
            
            uzsakymas.Vartotojo_ID = textBox1.Text;
            uzsakymas.Kaina = 0;

            // su uzklausa randam vartotoja is DB, kuris atitinka musu pasirinkta vartotoja
            var data =
                from vartotojas in vartotojuSar
                where vartotojas.Vartotojo_ID == Convert.ToInt32(uzsakymas.Vartotojo_ID)
                select vartotojas;
            // toliau i kintamaji varpav isidedam reiksmes, kurias naudosime mbox pranesime del sukurto uzsakymo
            string varpav = "";
            foreach (var item in data)
            {
                varpav = (item.Vardas + " " + item.Pavarde);
            }
            // gauta adresa isidedam i naujai kuriamo uzsakymo objekta
            uzsakymas.Adresas = textBoxAdresas.Text;
            //-------------------------------- 0-grynais / 1-kortele
            int atsiskaitymoTipas = -1;
            if(comboBoxAtsiskaitymas.SelectedValue == "Grynais")
            {
                atsiskaitymoTipas = 0;
            }
            else
            {
                atsiskaitymoTipas = 1;
            }
            uzsakymas.Atsiskaitymo_tipas = atsiskaitymoTipas;
            //--------------------------------------------------------

            uzsakymuTable.InsertOnSubmit(uzsakymas);
            db.SubmitChanges();
            MessageBox.Show("Uzsakymas vartotojui " + varpav + " sukurtas sekmingai!");
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void rodyti()
        {
            int vartID = Convert.ToInt32(textBox1.Text);
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            List<Uzsakymai> uzsakymuSar = db.GetTable<Uzsakymai>().ToList();

            var data =
                from uzsakymas in uzsakymuSar
                where uzsakymas.Vartotojo_ID == vartID.ToString()
                select uzsakymas;

            string uzsakymoEilute = "";
            foreach (var item in data)
            {
                uzsakymoEilute = String.Format("{0,3}{1,3}{2,6}{3,17}{4,6}\n", item.Uzsakymo_ID, item.Vartotojo_ID, item.Kaina, item.Adresas, item.Atsiskaitymo_tipas);
                textBox2.AppendText(uzsakymoEilute);

            }
        }
    }
}

