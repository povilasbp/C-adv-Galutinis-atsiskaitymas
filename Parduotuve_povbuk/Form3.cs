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
    public partial class Form3 : Form
    {
        public Form3(string vartotojoID)
        {
            InitializeComponent();
            // Pasileidus Formai comboBoxu uzpildymas
            // uzpildom prekiu comboBoxa--------------------------------
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            List<Preke> prekiuSar = db.GetTable<Preke>().ToList();
            foreach (var preke in prekiuSar)
            {
                comboBoxPrekesPavadinimas.Items.Add(preke.Pavadinimas);
            }
            //-----------------------------------------------------------
            // uzpildom uzsakymoID comboBoxa-----------------------------
            List<Uzsakymai> uzsakymuSar = db.GetTable<Uzsakymai>().ToList();
            var data =
                from uzsakymas in uzsakymuSar
                where uzsakymas.Vartotojo_ID == vartotojoID
                select uzsakymas;
            foreach (var item in data) // uzpildom comboboxa pasirinkto vartotojo uzsakymais
            {
                comboBoxUzsakymoID.Items.Add(item.Uzsakymo_ID);
            }
            //------------------------------------------------------------
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void buttonPatvirtinti_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            Table<Irasai> irasuTable = db.GetTable<Irasai>();
            List<Preke> prekiuSar = db.GetTable<Preke>().ToList();
            Irasai irasas = new Irasai();
            bool PridejoIrasa = false;

            // randam prekes id, pagal pasirinktos prekes pavadinima is combobox
            // del to, kad comboboxe isvedam prekiu pavadinimus, o ne id
            var prekesData =
                from preke in prekiuSar
                where preke.Pavadinimas == (comboBoxPrekesPavadinimas.Text).ToString()
                select preke;
            int prekesIndeksas = -1;
            int prekiuKiekis = -1;
            foreach (var item in prekesData)
            {
                prekesIndeksas = item.Prekes_ID;
                prekiuKiekis = (int)item.Kiekis;
            }
            //---------------------------------------------
            // PILDOM DUOMENIS I IRASO OBJEKTA
            // errorai trukstant duomenu
            string error = "Truksta siu duomenu:\n";
            int errorDydis = error.Length;
            if (string.IsNullOrEmpty(comboBoxUzsakymoID.Text))
                error += "*Uzsakymo ID\n";
            else
                irasas.Uzsakymo_ID = Convert.ToInt32(comboBoxUzsakymoID.Text);

            if (string.IsNullOrEmpty(comboBoxPrekesPavadinimas.Text))
                error += "*Preke\n";
            else
                irasas.Prekes_ID = prekesIndeksas;

            if (string.IsNullOrEmpty(textBoxPerkamasKiekis.Text))
                error += "*Kiekis\n";

            irasas.Kiekis = Convert.ToInt32(textBoxPerkamasKiekis.Text);
            irasas.Kaina = Convert.ToInt32(textBoxPirkimoKaina.Text);

            if (error.Length > errorDydis)
            {
                MessageBox.Show(error, "Klaida");
            }
            else
            {
                irasuTable.InsertOnSubmit(irasas);
                db.SubmitChanges();
                MessageBox.Show("Irasas sekmingai sukurtas!", "Pranesimas");
                PridejoIrasa = true;
            }

            // Sekmingai pridejus irasa, tvarkom kitas susijusias lenteles (prekes, uzsakymus)
            Table<Uzsakymai> uzsakymuTable = db.GetTable<Uzsakymai>();

            // Nusipirkus kazkokia preke, is kiekio sandelyje atimam ta kieki kuri nupirkom irase
            foreach (var item in prekesData)
            {
                item.Kiekis -= irasas.Kiekis;
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //--------------------------------------------
            // Pridejus nauja irasa prie uzsakymo, prie uzsakymo kainos pridedam ir naujo iraso kaina
            // gaunam viso uzsakymo kaina. Arba visu irasu kaina, priskirtu tam uzsakymui
            var uzsakymoData =
                from uzsakymas in uzsakymuTable
                where uzsakymas.Uzsakymo_ID == irasas.Uzsakymo_ID
                select uzsakymas;
            foreach (var item in uzsakymoData)
            {
                item.Kaina += irasas.Kaina;
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        // tiesiog vartotojo patogumui pasirinkus preke, isvedam jos kaina ir kieki, kad zinotu
        private void comboBoxPrekesPavadinimas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            List<Preke> prekiuSar = db.GetTable<Preke>().ToList();
            var prekesData =
                from preke in prekiuSar
                where preke.Pavadinimas == (comboBoxPrekesPavadinimas.SelectedItem).ToString()
                select preke;
            foreach (var preke in prekesData)
            {
                textBoxPrekesKaina.Text = preke.Kaina.ToString();
                textBoxPrekiuKiekis.Text = preke.Kiekis.ToString();
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        // errorai nurodzius per dideli kieki arba nepasirinkus prekes vedant kieki
        private void textBoxPerkamasKiekis_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBoxPrekesPavadinimas.Text))
            {
                MessageBox.Show("Pirma pasirinkite preke", "Klaida");
            }

            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            List<Preke> prekiuSar = db.GetTable<Preke>().ToList();
            var prekesData =
                from preke in prekiuSar
                where preke.Pavadinimas == comboBoxPrekesPavadinimas.Text
                select preke;
            int kiekis = -1;
            foreach (var item in prekesData)
            {
                kiekis = (int)item.Kiekis;
            }

            if (!(String.IsNullOrEmpty(comboBoxPrekesPavadinimas.Text)))
            {
                if (Convert.ToInt32(textBoxPerkamasKiekis.Text) > kiekis)
                {
                    MessageBox.Show("Tiek prekiu nera!", "Klaida");
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------
        private void comboBoxUzsakymoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Povilas\source\repos\Parduotuve_povbuk\Parduotuve_povbuk\DuomenuBaze.mdf; Integrated Security = True");
            List<Uzsakymai> uzsakymuSar = db.GetTable<Uzsakymai>().ToList();
            var uzsakymoData =
                from uzsakymas in uzsakymuSar
                where uzsakymas.Uzsakymo_ID == Convert.ToInt32(comboBoxUzsakymoID.SelectedItem)
                select uzsakymas;
            // parodom adresa pasirinkus uzsakymo id
            // tiesiog del patogumo vartotojui
            foreach (var item in uzsakymoData)
            {
                textBoxUzsakymoAdresas.Text = item.Adresas;
            }
        }
    }
}
