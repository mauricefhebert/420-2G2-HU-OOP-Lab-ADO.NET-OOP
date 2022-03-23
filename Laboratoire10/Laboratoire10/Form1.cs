using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
/**
 * Maurice filiatreault hebert
 * 2195109
 */


namespace Laboratoire10
{
    public partial class Form1 : Form
    {
        EtudiantDataContext dt;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["BaseEtudiants"].ConnectionString;
            dt = new EtudiantDataContext(strConnection);
            /**
             * Home - BaseEtudiants
             * School - BaseEtudiantsSchool
             */
        }
        private void btnProgrammesAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Si le numero ou la descripton et vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si le numero de programme existe deja affiche un message d'erreur a l'utilisateur
                 * Autrement ajoute le programme et affiche un message de confirmation a l'utilisateur
                 **/
                if (txtProgNumero.Text.Trim() == string.Empty || txtProgDesc.Text.Trim() == string.Empty)
                    MessageBox.Show("Le numero et la description ne peuvent etre vide");
                else if (!txtProgNumero.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero de programme ne dois contenir que des chiffres");
                else if (dt.GetAllProgrammes().Exists(x => x.ProgrammesId == int.Parse(txtProgNumero.Text)))
                    MessageBox.Show("Le programme entrée existe deja veuillez choisir un autre numero");
                else
                {
                    Programme programme = new Programme(int.Parse(this.txtProgNumero.Text), this.txtProgDesc.Text);
                    dt.InsertProgramme(programme);
                    MessageBox.Show($"Programmes {programme.ProgrammeName} ajouter avec success");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammeRechercher_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgProg.DataSource = null;
                dgProg.DataSource = dt.GetAllProgrammes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void btnProgrammesSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Si le numero et vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si un programme assosier au champs numero de programme existe affiche un message de confirmation de modification
                 * Si l'utilisateur selection "OK" supprime le programme, autrement ne fait rien
                 **/
                if (txtProgNumero.Text.Trim() == string.Empty)
                    MessageBox.Show("Le champs numero de programme ne peu etre vide");
                else if (!txtProgNumero.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero de programme ne dois contenir que des chiffres");
                else
                {
                    if (dt.GetAllProgrammes().FirstOrDefault(x => x.ProgrammesId == int.Parse(this.txtProgNumero.Text)) != null)
                    {
                        DialogResult rep = MessageBox.Show($"Voulez-vous vraiment modifier le programme {this.txtProgNumero.Text}", "Confirmation", MessageBoxButtons.OKCancel);
                        if (rep == DialogResult.OK)
                        {
                            dt.DeleteProgramme(int.Parse(this.txtProgNumero.Text));
                            MessageBox.Show($"Programmes supprimer avec success");
                        }
                    }
                    else MessageBox.Show("Le programme n'existe pas");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammesModifier_Click(object sender, EventArgs e)
        {

            try
            {
                /**
                 * Si le numero et vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si aucun program n'est associé au numero de programme dans le text box afficher un message d'erreur a l'utilisateur
                 * Si un programme est trouvée affiche un message de confirmation a l'utilisateur
                 * Si'l'utilisateur selectionne "OK" modifier le programme
                 **/
                if (txtProgNumero.Text.Trim() == string.Empty)
                    MessageBox.Show("Le champs numero de programme ne peu etre vide");
                else if (!txtProgNumero.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero de programme ne dois contenir que des chiffres");
                else if (!dt.GetAllProgrammes().Exists(x => x.ProgrammesId == int.Parse(txtProgNumero.Text)))
                    MessageBox.Show("Le programme entrée n'existe pas veuillez choisir un programme existant");
                else
                {
                    DialogResult rep = MessageBox.Show($"Voulez-vous vraiment modifier le programme {this.txtProgNumero.Text}", "Confirmation", MessageBoxButtons.OKCancel);
                    if (rep == DialogResult.OK)
                    {
                        Programme programme = new Programme(int.Parse(this.txtProgNumero.Text), this.txtProgDesc.Text);
                        dt.UpdateProgramme(programme);
                        MessageBox.Show("Programme modifier avec succes");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProgrammesAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Si le numero et vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si le numero de programme n'existe pas affiche un message d'erreur a l'utilisateur
                 * Autrement affiche tous les etudiants qui participe au programme selectionner
                 **/
                if (txtProgNumero.Text.Trim() == string.Empty)
                    MessageBox.Show("Le champs numero de programme ne peu etre vide");
                else if (!txtProgNumero.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero de programme ne dois contenir que des chiffres");
                else if (!dt.GetAllProgrammes().Exists(x => x.ProgrammesId == int.Parse(txtProgNumero.Text)))
                    MessageBox.Show("Le programme entrée n'existe pas veuillez choisir un programme existant");
                else
                {
                    dgProg.DataSource = null;
                    dgProg.DataSource = dt.GetEtudiantsByProgramme(int.Parse(this.txtProgNumero.Text));
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tabEtudiant_Enter(object sender, EventArgs e)
        {
            /**
             * Rempli le combo box avec les valeur de la list de programme
             * Assign le ProgrammeName comme valeur d'affichage a l'utilisateur (les valeur qui seront afficher dans le combo box)
             * Le 'ValueMember' sera utiliser plus loin pour la creation des etudiant
             **/
            this.cmbEtudiantProg.DataSource = null;
            this.cmbEtudiantProg.DataSource = dt.GetAllProgrammes().Select(x => new KeyValuePair<int, string>(x.ProgrammesId, x.ProgrammeName)).ToList();
            this.cmbEtudiantProg.DisplayMember = "Value";
            this.cmbEtudiantProg.ValueMember = "Key";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdMasculin.Checked = true;
        }

        private void btnEtudiantAjouter_Click(object sender, EventArgs e)
        {
            //Assign une caracters a la variable 'tempGenre' selon le radio boutton selectionner
            char tempGenre;
            if (rdMasculin.Checked) tempGenre = 'M';
            else if (rdFeminin.Checked) tempGenre = 'F';
            else tempGenre = 'A';
            try
            {
                /**
                 * Si un des text box est vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si l'etudiant existe deja affiche un message d'erreur a l'utilisateur
                 * Autrement ajoute l'etudiant et affiche un message de confirmation a l'utilisateur
                 **/
                if (this.txtNumEtudiant.Text.Trim() == string.Empty || this.txtFirstNameEtudiant.Text.Trim() == string.Empty || this.txtLastNameEtudiant.Text.Trim() == string.Empty || this.txtAdresseEtudiant.Text.Trim() == string.Empty)
                    MessageBox.Show("Un ou plusieur champs son vide");
                else if (!txtNumEtudiant.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero d'etudiant dois contenir que des chiffres");
                else if (dt.GetAllEtudiant().Exists(x => x.EtudiantId == int.Parse(txtNumEtudiant.Text)))
                    MessageBox.Show("L'etudiant entrée existe deja veuillez choisir un autre numero d'etudiant");
                else
                {
                    Etudiant etudiant = new Etudiant(
                    int.Parse(this.txtNumEtudiant.Text),
                    this.txtFirstNameEtudiant.Text,
                    this.txtLastNameEtudiant.Text,
                    this.txtAdresseEtudiant.Text,
                    this.dtBirthdayEtudiant.Value,
                    tempGenre,
                    //La valeur recuperer du combo box et la 'Key' ValueMember voir ligne 161
                    (int)this.cmbEtudiantProg.SelectedValue);
                    dt.InsertEtudiant(etudiant);
                    MessageBox.Show($"Etudiant {etudiant.FirstName} {etudiant.LastName} ajouter avec success");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Si le numero est vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si l'etudiant selectionner n'existe pas affiche un message d'erreur a l'utilisateur
                 * Autrement affiche l'etudiant dans le dataGrid
                 **/
                if (this.txtNumEtudiant.Text.Trim() == string.Empty)
                    MessageBox.Show("Veuillez entree un numero d'etudiant a rechercher");
                else if (!txtNumEtudiant.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero d'etudiant dois contenir que des chiffres");
                else if (!dt.GetAllEtudiant().Exists(x => x.EtudiantId == int.Parse(txtNumEtudiant.Text)))
                    MessageBox.Show("L'etudiant entrée n'existe pas veuillez entrée un numero d'etudiant existent");
                else
                {
                    dgEtudiant.DataSource = null;
                    dgEtudiant.DataSource = dt.GetEtudiant(int.Parse(txtNumEtudiant.Text));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                //Afficher tous les etudiants
                dgEtudiant.DataSource = null;
                dgEtudiant.DataSource = dt.GetAllEtudiant();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * Si le numero est vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si l'etudiant selectionner n'existe pas affiche un message d'erreur a l'utilisateur
                 * Si un etudiant est trouvée affiche un message de confirmation a l'utilisateur
                 * Si'l'utilisateur selectionne "OK" supprimer l'etudiant
                 **/
                if (this.txtNumEtudiant.Text.Trim() == string.Empty)
                    MessageBox.Show("Veuillez entree un numero d'etudiant a supprimer");
                else if (!txtNumEtudiant.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero d'etudiant dois contenir que des chiffres");
                else if (!dt.GetAllEtudiant().Exists(x => x.EtudiantId == int.Parse(txtNumEtudiant.Text)))
                    MessageBox.Show("L'etudiant entrée n'existe pas veuillez entrée un numero d'etudiant existent");
                else
                {
                    DialogResult rep = MessageBox.Show($"Voulez-vous vraiment supprimer l'etudiant?", "Confirmation", MessageBoxButtons.OKCancel);
                    if (rep == DialogResult.OK)
                    {
                        dt.DeleteEtudiant(int.Parse(this.txtNumEtudiant.Text));
                        MessageBox.Show($"Etudiant supprimer avec success");
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEtudiantModifier_Click(object sender, EventArgs e)
        {
            char tempGenre;
            if (rdMasculin.Checked) tempGenre = 'M';
            else if (rdFeminin.Checked) tempGenre = 'F';
            else tempGenre = 'A';
            try
            {
                /**
                 * Si le numero est vide affiche un message d'erreur a l'utilisateur,
                 * Si le numero ne contient pas que des chiffre affiche un message d'erreur a l'utilisateur,
                 * Si l'etudiant n'existe pas affiche un message d'erreur a l'utilisateur
                 * Si un etudiant est trouvée affiche un message de confirmation a l'utilisateur
                 * Si'l'utilisateur selectionne "OK" modifie l'etudiant et afficher un message de succes
                 **/
                if (this.txtNumEtudiant.Text.Trim() == string.Empty)
                    MessageBox.Show("Veuillez entree un numero d'etudiant a modifier");
                else if (!txtNumEtudiant.Text.Trim().All(char.IsDigit))
                    MessageBox.Show("Le champs numero d'etudiant dois contenir que des chiffres");
                else if (!dt.GetAllEtudiant().Exists(x => x.EtudiantId == int.Parse(txtNumEtudiant.Text)))
                    MessageBox.Show("L'etudiant entrée n'existe pas veuillez entrée un numero d'etudiant existent");
                else
                {
                    DialogResult rep = MessageBox.Show($"Voulez-vous vraiment modifier l'etudiant?", "Confirmation", MessageBoxButtons.OKCancel);
                    if (rep == DialogResult.OK)
                    {
                        Etudiant etudiant = new Etudiant(
                         int.Parse(this.txtNumEtudiant.Text),
                         this.txtFirstNameEtudiant.Text,
                         this.txtLastNameEtudiant.Text,
                         this.txtAdresseEtudiant.Text,
                         this.dtBirthdayEtudiant.Value,
                         tempGenre,
                        //La valeur recuperer du combo box et la 'Key' ValueMember voir ligne 161
                        (int)this.cmbEtudiantProg.SelectedValue);
                        dt.UpdateEtudiant(etudiant);
                        MessageBox.Show($"Etudiant modifier avec success");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}