using System.Configuration;
using System.Data.SqlClient;

namespace Laboratoire10
{
    public partial class Form1 : Form
    {
        EtudiantDataContext dt;
        public Form1()
        {
            InitializeComponent();
            //string strConnection = ConfigurationManager.ConnectionStrings["BaseEtudiants"].ConnectionString;
            this.dt = new EtudiantDataContext(@"Data Source=.\sqlexpress;Initial Catalog=BaseEtudiants;Integrated Security=True");
        }

        private void btnProgrammesAjouter_Click(object sender, EventArgs e)
        {
            Programme programme = new Programme(int.Parse(this.txtProgNumero.Text),this.txtProgDesc.Text);
            try
            {
                dt.InsertProgramme(programme);
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammesSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                dt.DeleteProgramme(int.Parse(this.txtProgNumero.Text));
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammesModifier_Click(object sender, EventArgs e)
        {
            Programme programme = new Programme(int.Parse(this.txtProgNumero.Text), this.txtProgDesc.Text);
            try
            {
                dt.UpdateProgramme(programme);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammesAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                dgProg.DataSource = null;
                dgProg.DataSource = dt.GetAllProgrammes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tabEtudiant_Enter(object sender, EventArgs e)
        {
            this.cmbEtudiantProg.DataSource = null;
            this.cmbEtudiantProg.DataSource = dt.GetAllProgrammes().Select(x => x.ProgrammeName).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdMasculin.Checked = true;
        }

        private void btnEtudiantAjouter_Click(object sender, EventArgs e)
        {
            char tempGenre;
            if (rdMasculin.Checked) tempGenre = 'M';
            else if (rdFeminin.Checked) tempGenre = 'F';
            else tempGenre = 'A';
            Etudiant etudiant = new Etudiant(
                int.Parse(this.txtNumEtudiant.Text),
                this.txtFirstNameEtudiant.Text,
                this.txtLastNameEtudiant.Text,
                this.txtAdresseEtudiant.Text,
                this.dtBirthdayEtudiant.Value,
                tempGenre,
                this.cmbEtudiantProg.SelectedIndex);
            try
            {
                dt.InsertEtudiant(etudiant);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                dt.DeleteEtudiant(int.Parse(this.txtNumEtudiant.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantModifier_Click(object sender, EventArgs e)
        {
            char tempGenre;
            if (rdMasculin.Checked) tempGenre = 'M';
            else if (rdFeminin.Checked) tempGenre = 'F';
            else tempGenre = 'A';
            Etudiant etudiant = new Etudiant(
                int.Parse(this.txtNumEtudiant.Text),
                this.txtFirstNameEtudiant.Text,
                this.txtLastNameEtudiant.Text,
                this.txtAdresseEtudiant.Text,
                this.dtBirthdayEtudiant.Value,
                tempGenre,
                this.cmbEtudiantProg.SelectedIndex);
            try
            {
                dt.UpdateEtudiant(etudiant);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                dgEtudiant.DataSource = null;
                dgEtudiant.DataSource = dt.GetAllEtudiant();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}