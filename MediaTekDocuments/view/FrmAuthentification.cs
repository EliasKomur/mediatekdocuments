using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;

namespace MediaTekDocuments.view
{
    public partial class FrmAuthentification : Form
    {
        private readonly FrmMediatekController controller;
        private Utilisateur utilisateurConnecte = null;

        public Utilisateur GetUtilisateurConnecte()
        {
            return utilisateurConnecte;
        }

        public FrmAuthentification()
        {
            InitializeComponent();
            try
            {
                this.controller = new FrmMediatekController();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur init controller : " + ex.Message + "\n\n" + ex.StackTrace, "Erreur");
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (controller == null)
            {
                MessageBox.Show("Controller est null !", "Erreur");
                return;
            }
            try
            {
                Utilisateur utilisateur = controller.GetUtilisateur(txbLogin.Text, txbPwd.Text);
                MessageBox.Show("Résultat : " + (utilisateur == null ? "NULL" : utilisateur.Login));
                if (utilisateur == null)
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Erreur");
                    return;
                }
                utilisateurConnecte = utilisateur;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message + "\n\n" + ex.StackTrace, "Erreur détaillée");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}