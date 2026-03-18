using MediaTekDocuments.view;
using MediaTekDocuments.model;
using System;
using System.Windows.Forms;

namespace MediaTekDocuments
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmAuthentification frmAuth = new FrmAuthentification();
            if (frmAuth.ShowDialog() == DialogResult.OK)
            {
                Utilisateur utilisateur = frmAuth.GetUtilisateurConnecte();
                if (utilisateur.IdService.Equals("culture"))
                {
                    MessageBox.Show("Vos droits ne sont pas suffisants pour accéder à cette application.", 
                        "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Application.Run(new FrmMediatek(utilisateur));
            }
        }
    }
}