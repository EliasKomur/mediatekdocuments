using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

namespace MediaTekDocuments.view
{
    public partial class FrmMediatek : Form
    {
        #region Commun
        private readonly FrmMediatekController controller;
        private readonly BindingSource bdgGenres = new BindingSource();
        private readonly BindingSource bdgPublics = new BindingSource();
        private readonly BindingSource bdgRayons = new BindingSource();

        internal FrmMediatek()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
        }

        public void RemplirComboCategorie(List<Categorie> lesCategories, BindingSource bdg, ComboBox cbx)
        {
            bdg.DataSource = lesCategories;
            cbx.DataSource = bdg;
            if (cbx.Items.Count > 0)
                cbx.SelectedIndex = -1;
        }
        #endregion

        #region Onglet Livres
        private readonly BindingSource bdgLivresListe = new BindingSource();
        private List<Livre> lesLivres = new List<Livre>();

        private void TabLivres_Enter(object sender, EventArgs e)
        {
            lesLivres = controller.GetAllLivres();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxLivresGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxLivresPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxLivresRayons);
            RemplirLivresListeComplete();
        }

        private void RemplirLivresListe(List<Livre> livres)
        {
            bdgLivresListe.DataSource = livres;
            dgvLivresListe.DataSource = bdgLivresListe;
            dgvLivresListe.Columns["isbn"].Visible = false;
            dgvLivresListe.Columns["idRayon"].Visible = false;
            dgvLivresListe.Columns["idGenre"].Visible = false;
            dgvLivresListe.Columns["idPublic"].Visible = false;
            dgvLivresListe.Columns["image"].Visible = false;
            dgvLivresListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLivresListe.Columns["id"].DisplayIndex = 0;
            dgvLivresListe.Columns["titre"].DisplayIndex = 1;
        }

        private void BtnLivresNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbLivresNumRecherche.Text.Equals(""))
            {
                txbLivresTitreRecherche.Text = "";
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                Livre livre = lesLivres.Find(x => x.Id.Equals(txbLivresNumRecherche.Text));
                if (livre != null)
                    RemplirLivresListe(new List<Livre>() { livre });
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirLivresListeComplete();
                }
            }
            else RemplirLivresListeComplete();
        }

        private void TxbLivresTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbLivresTitreRecherche.Text.Equals(""))
            {
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                txbLivresNumRecherche.Text = "";
                RemplirLivresListe(lesLivres.FindAll(x => x.Titre.ToLower().Contains(txbLivresTitreRecherche.Text.ToLower())));
            }
            else
            {
                if (cbxLivresGenres.SelectedIndex < 0 && cbxLivresPublics.SelectedIndex < 0 && cbxLivresRayons.SelectedIndex < 0 && txbLivresNumRecherche.Text.Equals(""))
                    RemplirLivresListeComplete();
            }
        }

        private void AfficheLivresInfos(Livre livre)
        {
            cbxLivresGenres.SelectedIndexChanged -= CbxLivresGenres_SelectedIndexChanged;
            cbxLivresPublics.SelectedIndexChanged -= CbxLivresPublics_SelectedIndexChanged;
            cbxLivresRayons.SelectedIndexChanged -= CbxLivresRayons_SelectedIndexChanged;
            txbLivresNumero.ReadOnly = true;
            txbLivresAuteur.Text = livre.Auteur;
            txbLivresCollection.Text = livre.Collection;
            txbLivresImage.Text = livre.Image;
            txbLivresIsbn.Text = livre.Isbn;
            txbLivresNumero.Text = livre.Id;
            txbLivresGenre.Text = livre.Genre;
            txbLivresPublic.Text = livre.Public;
            txbLivresRayon.Text = livre.Rayon;
            txbLivresTitre.Text = livre.Titre;
            for (int i = 0; i < cbxLivresGenres.Items.Count; i++)
                if (((Genre)cbxLivresGenres.Items[i]).Id.Equals(livre.IdGenre)) { cbxLivresGenres.SelectedIndex = i; break; }
            for (int i = 0; i < cbxLivresPublics.Items.Count; i++)
                if (((Public)cbxLivresPublics.Items[i]).Id.Equals(livre.IdPublic)) { cbxLivresPublics.SelectedIndex = i; break; }
            for (int i = 0; i < cbxLivresRayons.Items.Count; i++)
                if (((Rayon)cbxLivresRayons.Items[i]).Id.Equals(livre.IdRayon)) { cbxLivresRayons.SelectedIndex = i; break; }
            try { pcbLivresImage.Image = Image.FromFile(livre.Image); }
            catch { pcbLivresImage.Image = null; }
            cbxLivresGenres.SelectedIndexChanged += CbxLivresGenres_SelectedIndexChanged;
            cbxLivresPublics.SelectedIndexChanged += CbxLivresPublics_SelectedIndexChanged;
            cbxLivresRayons.SelectedIndexChanged += CbxLivresRayons_SelectedIndexChanged;
        }

        private void VideLivresInfos()
        {
            txbLivresNumero.ReadOnly = false;
            txbLivresAuteur.Text = "";
            txbLivresCollection.Text = "";
            txbLivresImage.Text = "";
            txbLivresIsbn.Text = "";
            txbLivresNumero.Text = "";
            txbLivresGenre.Text = "";
            txbLivresPublic.Text = "";
            txbLivresRayon.Text = "";
            txbLivresTitre.Text = "";
            pcbLivresImage.Image = null;
        }

        private void CbxLivresGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresGenres.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Genre genre = (Genre)cbxLivresGenres.SelectedItem;
                RemplirLivresListe(lesLivres.FindAll(x => x.Genre.Equals(genre.Libelle)));
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

        private void CbxLivresPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresPublics.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Public lePublic = (Public)cbxLivresPublics.SelectedItem;
                RemplirLivresListe(lesLivres.FindAll(x => x.Public.Equals(lePublic.Libelle)));
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresGenres.SelectedIndex = -1;
            }
        }

        private void CbxLivresRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresRayons.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxLivresRayons.SelectedItem;
                RemplirLivresListe(lesLivres.FindAll(x => x.Rayon.Equals(rayon.Libelle)));
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

        private void DgvLivresListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLivresListe.CurrentCell != null)
            {
                try { AfficheLivresInfos((Livre)bdgLivresListe.List[bdgLivresListe.Position]); }
                catch { VideLivresZones(); }
            }
            else VideLivresInfos();
        }

        private void BtnLivresAnnulPublics_Click(object sender, EventArgs e) { RemplirLivresListeComplete(); }
        private void BtnLivresAnnulRayons_Click(object sender, EventArgs e) { RemplirLivresListeComplete(); }
        private void BtnLivresAnnulGenres_Click(object sender, EventArgs e) { RemplirLivresListeComplete(); }

        private void RemplirLivresListeComplete()
        {
            RemplirLivresListe(lesLivres);
            VideLivresZones();
        }

        private void VideLivresZones()
        {
            cbxLivresGenres.SelectedIndex = -1;
            cbxLivresRayons.SelectedIndex = -1;
            cbxLivresPublics.SelectedIndex = -1;
            txbLivresNumRecherche.Text = "";
            txbLivresTitreRecherche.Text = "";
        }

        private void DgvLivresListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideLivresZones();
            string col = dgvLivresListe.Columns[e.ColumnIndex].HeaderText;
            List<Livre> sorted = new List<Livre>();
            switch (col)
            {
                case "Id": sorted = lesLivres.OrderBy(o => o.Id).ToList(); break;
                case "Titre": sorted = lesLivres.OrderBy(o => o.Titre).ToList(); break;
                case "Collection": sorted = lesLivres.OrderBy(o => o.Collection).ToList(); break;
                case "Auteur": sorted = lesLivres.OrderBy(o => o.Auteur).ToList(); break;
                case "Genre": sorted = lesLivres.OrderBy(o => o.Genre).ToList(); break;
                case "Public": sorted = lesLivres.OrderBy(o => o.Public).ToList(); break;
                case "Rayon": sorted = lesLivres.OrderBy(o => o.Rayon).ToList(); break;
            }
            RemplirLivresListe(sorted);
        }

        private void btnLivresAjouter_Click(object sender, EventArgs e)
        {
            if (txbLivresNumero.Text.Equals("")) { MessageBox.Show("Le numéro est obligatoire.", "Information"); return; }
            string idGenre = cbxLivresGenres.SelectedIndex >= 0 ? ((Genre)cbxLivresGenres.SelectedItem).Id : "";
            string libelleGenre = cbxLivresGenres.SelectedIndex >= 0 ? ((Genre)cbxLivresGenres.SelectedItem).Libelle : "";
            string idPublic = cbxLivresPublics.SelectedIndex >= 0 ? ((Public)cbxLivresPublics.SelectedItem).Id : "";
            string libellePublic = cbxLivresPublics.SelectedIndex >= 0 ? ((Public)cbxLivresPublics.SelectedItem).Libelle : "";
            string idRayon = cbxLivresRayons.SelectedIndex >= 0 ? ((Rayon)cbxLivresRayons.SelectedItem).Id : "";
            string libelleRayon = cbxLivresRayons.SelectedIndex >= 0 ? ((Rayon)cbxLivresRayons.SelectedItem).Libelle : "";
            Livre livre = new Livre(txbLivresNumero.Text, txbLivresTitre.Text, txbLivresImage.Text,
                txbLivresIsbn.Text, txbLivresAuteur.Text, txbLivresCollection.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon);
            if (controller.CreerLivre(livre)) { lesLivres = controller.GetAllLivres(); RemplirLivresListeComplete(); MessageBox.Show("Le livre a été ajouté.", "Information"); }
            else MessageBox.Show("Erreur lors de l'ajout (l'id existe peut-être déjà).", "Erreur");
        }

        private void btnLivresModifier_Click_1(object sender, EventArgs e)
        {
            if (txbLivresNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner un livre à modifier.", "Information"); return; }
            string idGenre = cbxLivresGenres.SelectedIndex >= 0 ? ((Genre)cbxLivresGenres.SelectedItem).Id : "";
            string libelleGenre = cbxLivresGenres.SelectedIndex >= 0 ? ((Genre)cbxLivresGenres.SelectedItem).Libelle : "";
            string idPublic = cbxLivresPublics.SelectedIndex >= 0 ? ((Public)cbxLivresPublics.SelectedItem).Id : "";
            string libellePublic = cbxLivresPublics.SelectedIndex >= 0 ? ((Public)cbxLivresPublics.SelectedItem).Libelle : "";
            string idRayon = cbxLivresRayons.SelectedIndex >= 0 ? ((Rayon)cbxLivresRayons.SelectedItem).Id : "";
            string libelleRayon = cbxLivresRayons.SelectedIndex >= 0 ? ((Rayon)cbxLivresRayons.SelectedItem).Libelle : "";
            Livre livre = new Livre(txbLivresNumero.Text, txbLivresTitre.Text, txbLivresImage.Text,
                txbLivresIsbn.Text, txbLivresAuteur.Text, txbLivresCollection.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon);
            if (controller.ModifierLivre(livre)) { lesLivres = controller.GetAllLivres(); RemplirLivresListeComplete(); MessageBox.Show("Le livre a été modifié.", "Information"); }
            else MessageBox.Show("Erreur lors de la modification.", "Erreur");
        }

        private void btnLivresSupprimerDoc_Click_1(object sender, EventArgs e)
        {
            if (txbLivresNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner un livre à supprimer.", "Information"); return; }
            Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
            if (MessageBox.Show("Confirmer la suppression du livre \"" + livre.Titre + "\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.SupprimerLivre(livre)) { lesLivres = controller.GetAllLivres(); RemplirLivresListeComplete(); MessageBox.Show("Le livre a été supprimé.", "Information"); }
                else MessageBox.Show("Impossible de supprimer ce livre (des exemplaires ou commandes y sont liés).", "Erreur");
            }
        }
        #endregion

        #region Onglet Dvd
        private readonly BindingSource bdgDvdListe = new BindingSource();
        private List<Dvd> lesDvd = new List<Dvd>();

        private void tabDvd_Enter(object sender, EventArgs e)
        {
            lesDvd = controller.GetAllDvd();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxDvdGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxDvdPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxDvdRayons);
            RemplirDvdListeComplete();
        }

        private void RemplirDvdListe(List<Dvd> Dvds)
        {
            bdgDvdListe.DataSource = Dvds;
            dgvDvdListe.DataSource = bdgDvdListe;
            dgvDvdListe.Columns["idRayon"].Visible = false;
            dgvDvdListe.Columns["idGenre"].Visible = false;
            dgvDvdListe.Columns["idPublic"].Visible = false;
            dgvDvdListe.Columns["image"].Visible = false;
            dgvDvdListe.Columns["synopsis"].Visible = false;
            dgvDvdListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDvdListe.Columns["id"].DisplayIndex = 0;
            dgvDvdListe.Columns["titre"].DisplayIndex = 1;
        }

        private void btnDvdNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbDvdNumRecherche.Text.Equals(""))
            {
                txbDvdTitreRecherche.Text = "";
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                Dvd dvd = lesDvd.Find(x => x.Id.Equals(txbDvdNumRecherche.Text));
                if (dvd != null) RemplirDvdListe(new List<Dvd>() { dvd });
                else { MessageBox.Show("numéro introuvable"); RemplirDvdListeComplete(); }
            }
            else RemplirDvdListeComplete();
        }

        private void txbDvdTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbDvdTitreRecherche.Text.Equals(""))
            {
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                txbDvdNumRecherche.Text = "";
                RemplirDvdListe(lesDvd.FindAll(x => x.Titre.ToLower().Contains(txbDvdTitreRecherche.Text.ToLower())));
            }
            else
            {
                if (cbxDvdGenres.SelectedIndex < 0 && cbxDvdPublics.SelectedIndex < 0 && cbxDvdRayons.SelectedIndex < 0 && txbDvdNumRecherche.Text.Equals(""))
                    RemplirDvdListeComplete();
            }
        }

        private void AfficheDvdInfos(Dvd dvd)
        {
            cbxDvdGenres.SelectedIndexChanged -= cbxDvdGenres_SelectedIndexChanged;
            cbxDvdPublics.SelectedIndexChanged -= cbxDvdPublics_SelectedIndexChanged;
            cbxDvdRayons.SelectedIndexChanged -= cbxDvdRayons_SelectedIndexChanged;
            txbDvdNumero.ReadOnly = true;
            txbDvdRealisateur.Text = dvd.Realisateur;
            txbDvdSynopsis.Text = dvd.Synopsis;
            txbDvdImage.Text = dvd.Image;
            txbDvdDuree.Text = dvd.Duree.ToString();
            txbDvdNumero.Text = dvd.Id;
            txbDvdGenre.Text = dvd.Genre;
            txbDvdPublic.Text = dvd.Public;
            txbDvdRayon.Text = dvd.Rayon;
            txbDvdTitre.Text = dvd.Titre;
            for (int i = 0; i < cbxDvdGenres.Items.Count; i++)
                if (((Genre)cbxDvdGenres.Items[i]).Id.Equals(dvd.IdGenre)) { cbxDvdGenres.SelectedIndex = i; break; }
            for (int i = 0; i < cbxDvdPublics.Items.Count; i++)
                if (((Public)cbxDvdPublics.Items[i]).Id.Equals(dvd.IdPublic)) { cbxDvdPublics.SelectedIndex = i; break; }
            for (int i = 0; i < cbxDvdRayons.Items.Count; i++)
                if (((Rayon)cbxDvdRayons.Items[i]).Id.Equals(dvd.IdRayon)) { cbxDvdRayons.SelectedIndex = i; break; }
            try { pcbDvdImage.Image = Image.FromFile(dvd.Image); }
            catch { pcbDvdImage.Image = null; }
            cbxDvdGenres.SelectedIndexChanged += cbxDvdGenres_SelectedIndexChanged;
            cbxDvdPublics.SelectedIndexChanged += cbxDvdPublics_SelectedIndexChanged;
            cbxDvdRayons.SelectedIndexChanged += cbxDvdRayons_SelectedIndexChanged;
        }

        private void VideDvdInfos()
        {
            txbDvdNumero.ReadOnly = false;
            txbDvdRealisateur.Text = "";
            txbDvdSynopsis.Text = "";
            txbDvdImage.Text = "";
            txbDvdDuree.Text = "";
            txbDvdNumero.Text = "";
            txbDvdGenre.Text = "";
            txbDvdPublic.Text = "";
            txbDvdRayon.Text = "";
            txbDvdTitre.Text = "";
            pcbDvdImage.Image = null;
        }

        private void cbxDvdGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdGenres.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Genre genre = (Genre)cbxDvdGenres.SelectedItem;
                RemplirDvdListe(lesDvd.FindAll(x => x.Genre.Equals(genre.Libelle)));
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        private void cbxDvdPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdPublics.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Public lePublic = (Public)cbxDvdPublics.SelectedItem;
                RemplirDvdListe(lesDvd.FindAll(x => x.Public.Equals(lePublic.Libelle)));
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdGenres.SelectedIndex = -1;
            }
        }

        private void cbxDvdRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdRayons.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxDvdRayons.SelectedItem;
                RemplirDvdListe(lesDvd.FindAll(x => x.Rayon.Equals(rayon.Libelle)));
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        private void dgvDvdListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDvdListe.CurrentCell != null)
            {
                try { AfficheDvdInfos((Dvd)bdgDvdListe.List[bdgDvdListe.Position]); }
                catch { VideDvdZones(); }
            }
            else VideDvdInfos();
        }

        private void btnDvdAnnulPublics_Click(object sender, EventArgs e) { RemplirDvdListeComplete(); }
        private void btnDvdAnnulRayons_Click(object sender, EventArgs e) { RemplirDvdListeComplete(); }
        private void btnDvdAnnulGenres_Click(object sender, EventArgs e) { RemplirDvdListeComplete(); }

        private void RemplirDvdListeComplete()
        {
            RemplirDvdListe(lesDvd);
            VideDvdZones();
        }

        private void VideDvdZones()
        {
            cbxDvdGenres.SelectedIndex = -1;
            cbxDvdRayons.SelectedIndex = -1;
            cbxDvdPublics.SelectedIndex = -1;
            txbDvdNumRecherche.Text = "";
            txbDvdTitreRecherche.Text = "";
        }

        private void dgvDvdListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideDvdZones();
            string col = dgvDvdListe.Columns[e.ColumnIndex].HeaderText;
            List<Dvd> sorted = new List<Dvd>();
            switch (col)
            {
                case "Id": sorted = lesDvd.OrderBy(o => o.Id).ToList(); break;
                case "Titre": sorted = lesDvd.OrderBy(o => o.Titre).ToList(); break;
                case "Duree": sorted = lesDvd.OrderBy(o => o.Duree).ToList(); break;
                case "Realisateur": sorted = lesDvd.OrderBy(o => o.Realisateur).ToList(); break;
                case "Genre": sorted = lesDvd.OrderBy(o => o.Genre).ToList(); break;
                case "Public": sorted = lesDvd.OrderBy(o => o.Public).ToList(); break;
                case "Rayon": sorted = lesDvd.OrderBy(o => o.Rayon).ToList(); break;
            }
            RemplirDvdListe(sorted);
        }

        private void btnDvdAjouter_Click_1(object sender, EventArgs e)
        {
            if (txbDvdNumero.Text.Equals("")) { MessageBox.Show("Le numéro est obligatoire.", "Information"); return; }
            int duree = 0; int.TryParse(txbDvdDuree.Text, out duree);
            string idGenre = cbxDvdGenres.SelectedIndex >= 0 ? ((Genre)cbxDvdGenres.SelectedItem).Id : "";
            string libelleGenre = cbxDvdGenres.SelectedIndex >= 0 ? ((Genre)cbxDvdGenres.SelectedItem).Libelle : "";
            string idPublic = cbxDvdPublics.SelectedIndex >= 0 ? ((Public)cbxDvdPublics.SelectedItem).Id : "";
            string libellePublic = cbxDvdPublics.SelectedIndex >= 0 ? ((Public)cbxDvdPublics.SelectedItem).Libelle : "";
            string idRayon = cbxDvdRayons.SelectedIndex >= 0 ? ((Rayon)cbxDvdRayons.SelectedItem).Id : "";
            string libelleRayon = cbxDvdRayons.SelectedIndex >= 0 ? ((Rayon)cbxDvdRayons.SelectedItem).Libelle : "";
            Dvd dvd = new Dvd(txbDvdNumero.Text, txbDvdTitre.Text, txbDvdImage.Text, duree, txbDvdRealisateur.Text, txbDvdSynopsis.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon);
            if (controller.CreerDvd(dvd)) { lesDvd = controller.GetAllDvd(); RemplirDvdListeComplete(); MessageBox.Show("Le DVD a été ajouté.", "Information"); }
            else MessageBox.Show("Erreur lors de l'ajout (l'id existe peut-être déjà).", "Erreur");
        }

        private void btnDvdModifier_Click_1(object sender, EventArgs e)
        {
            if (txbDvdNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner un DVD à modifier.", "Information"); return; }
            int duree = 0; int.TryParse(txbDvdDuree.Text, out duree);
            string idGenre = cbxDvdGenres.SelectedIndex >= 0 ? ((Genre)cbxDvdGenres.SelectedItem).Id : "";
            string libelleGenre = cbxDvdGenres.SelectedIndex >= 0 ? ((Genre)cbxDvdGenres.SelectedItem).Libelle : "";
            string idPublic = cbxDvdPublics.SelectedIndex >= 0 ? ((Public)cbxDvdPublics.SelectedItem).Id : "";
            string libellePublic = cbxDvdPublics.SelectedIndex >= 0 ? ((Public)cbxDvdPublics.SelectedItem).Libelle : "";
            string idRayon = cbxDvdRayons.SelectedIndex >= 0 ? ((Rayon)cbxDvdRayons.SelectedItem).Id : "";
            string libelleRayon = cbxDvdRayons.SelectedIndex >= 0 ? ((Rayon)cbxDvdRayons.SelectedItem).Libelle : "";
            Dvd dvd = new Dvd(txbDvdNumero.Text, txbDvdTitre.Text, txbDvdImage.Text, duree, txbDvdRealisateur.Text, txbDvdSynopsis.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon);
            if (controller.ModifierDvd(dvd)) { lesDvd = controller.GetAllDvd(); RemplirDvdListeComplete(); MessageBox.Show("Le DVD a été modifié.", "Information"); }
            else MessageBox.Show("Erreur lors de la modification.", "Erreur");
        }

        private void btnDvdSupprimerDoc_Click_1(object sender, EventArgs e)
        {
            if (txbDvdNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner un DVD à supprimer.", "Information"); return; }
            Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
            if (MessageBox.Show("Confirmer la suppression du DVD \"" + dvd.Titre + "\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.SupprimerDvd(dvd)) { lesDvd = controller.GetAllDvd(); RemplirDvdListeComplete(); MessageBox.Show("Le DVD a été supprimé.", "Information"); }
                else MessageBox.Show("Impossible de supprimer ce DVD (des exemplaires ou commandes y sont liés).", "Erreur");
            }
        }
        #endregion

        #region Onglet Revues
        private readonly BindingSource bdgRevuesListe = new BindingSource();
        private List<Revue> lesRevues = new List<Revue>();

        private void tabRevues_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxRevuesGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxRevuesPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxRevuesRayons);
            RemplirRevuesListeComplete();
        }

        private void RemplirRevuesListe(List<Revue> revues)
        {
            bdgRevuesListe.DataSource = revues;
            dgvRevuesListe.DataSource = bdgRevuesListe;
            dgvRevuesListe.Columns["idRayon"].Visible = false;
            dgvRevuesListe.Columns["idGenre"].Visible = false;
            dgvRevuesListe.Columns["idPublic"].Visible = false;
            dgvRevuesListe.Columns["image"].Visible = false;
            dgvRevuesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRevuesListe.Columns["id"].DisplayIndex = 0;
            dgvRevuesListe.Columns["titre"].DisplayIndex = 1;
        }

        private void btnRevuesNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbRevuesNumRecherche.Text.Equals(""))
            {
                txbRevuesTitreRecherche.Text = "";
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                Revue revue = lesRevues.Find(x => x.Id.Equals(txbRevuesNumRecherche.Text));
                if (revue != null) RemplirRevuesListe(new List<Revue>() { revue });
                else { MessageBox.Show("numéro introuvable"); RemplirRevuesListeComplete(); }
            }
            else RemplirRevuesListeComplete();
        }

        private void txbRevuesTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbRevuesTitreRecherche.Text.Equals(""))
            {
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                txbRevuesNumRecherche.Text = "";
                RemplirRevuesListe(lesRevues.FindAll(x => x.Titre.ToLower().Contains(txbRevuesTitreRecherche.Text.ToLower())));
            }
            else
            {
                if (cbxRevuesGenres.SelectedIndex < 0 && cbxRevuesPublics.SelectedIndex < 0 && cbxRevuesRayons.SelectedIndex < 0 && txbRevuesNumRecherche.Text.Equals(""))
                    RemplirRevuesListeComplete();
            }
        }

        private void AfficheRevuesInfos(Revue revue)
        {
            cbxRevuesGenres.SelectedIndexChanged -= cbxRevuesGenres_SelectedIndexChanged;
            cbxRevuesPublics.SelectedIndexChanged -= cbxRevuesPublics_SelectedIndexChanged;
            cbxRevuesRayons.SelectedIndexChanged -= cbxRevuesRayons_SelectedIndexChanged;
            txbRevuesNumero.ReadOnly = true;
            txbRevuesPeriodicite.Text = revue.Periodicite;
            txbRevuesImage.Text = revue.Image;
            txbRevuesDateMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbRevuesNumero.Text = revue.Id;
            txbRevuesGenre.Text = revue.Genre;
            txbRevuesPublic.Text = revue.Public;
            txbRevuesRayon.Text = revue.Rayon;
            txbRevuesTitre.Text = revue.Titre;
            for (int i = 0; i < cbxRevuesGenres.Items.Count; i++)
                if (((Genre)cbxRevuesGenres.Items[i]).Id.Equals(revue.IdGenre)) { cbxRevuesGenres.SelectedIndex = i; break; }
            for (int i = 0; i < cbxRevuesPublics.Items.Count; i++)
                if (((Public)cbxRevuesPublics.Items[i]).Id.Equals(revue.IdPublic)) { cbxRevuesPublics.SelectedIndex = i; break; }
            for (int i = 0; i < cbxRevuesRayons.Items.Count; i++)
                if (((Rayon)cbxRevuesRayons.Items[i]).Id.Equals(revue.IdRayon)) { cbxRevuesRayons.SelectedIndex = i; break; }
            try { pcbRevuesImage.Image = Image.FromFile(revue.Image); }
            catch { pcbRevuesImage.Image = null; }
            cbxRevuesGenres.SelectedIndexChanged += cbxRevuesGenres_SelectedIndexChanged;
            cbxRevuesPublics.SelectedIndexChanged += cbxRevuesPublics_SelectedIndexChanged;
            cbxRevuesRayons.SelectedIndexChanged += cbxRevuesRayons_SelectedIndexChanged;
        }

        private void VideRevuesInfos()
        {
            txbRevuesNumero.ReadOnly = false;
            txbRevuesPeriodicite.Text = "";
            txbRevuesImage.Text = "";
            txbRevuesDateMiseADispo.Text = "";
            txbRevuesNumero.Text = "";
            txbRevuesGenre.Text = "";
            txbRevuesPublic.Text = "";
            txbRevuesRayon.Text = "";
            txbRevuesTitre.Text = "";
            pcbRevuesImage.Image = null;
        }

        private void cbxRevuesGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesGenres.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Genre genre = (Genre)cbxRevuesGenres.SelectedItem;
                RemplirRevuesListe(lesRevues.FindAll(x => x.Genre.Equals(genre.Libelle)));
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        private void cbxRevuesPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesPublics.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Public lePublic = (Public)cbxRevuesPublics.SelectedItem;
                RemplirRevuesListe(lesRevues.FindAll(x => x.Public.Equals(lePublic.Libelle)));
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesGenres.SelectedIndex = -1;
            }
        }

        private void cbxRevuesRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesRayons.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxRevuesRayons.SelectedItem;
                RemplirRevuesListe(lesRevues.FindAll(x => x.Rayon.Equals(rayon.Libelle)));
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        private void dgvRevuesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRevuesListe.CurrentCell != null)
            {
                try { AfficheRevuesInfos((Revue)bdgRevuesListe.List[bdgRevuesListe.Position]); }
                catch { VideRevuesZones(); }
            }
            else VideRevuesInfos();
        }

        private void btnRevuesAnnulPublics_Click(object sender, EventArgs e) { RemplirRevuesListeComplete(); }
        private void btnRevuesAnnulRayons_Click(object sender, EventArgs e) { RemplirRevuesListeComplete(); }
        private void btnRevuesAnnulGenres_Click(object sender, EventArgs e) { RemplirRevuesListeComplete(); }

        private void RemplirRevuesListeComplete()
        {
            RemplirRevuesListe(lesRevues);
            VideRevuesZones();
        }

        private void VideRevuesZones()
        {
            cbxRevuesGenres.SelectedIndex = -1;
            cbxRevuesRayons.SelectedIndex = -1;
            cbxRevuesPublics.SelectedIndex = -1;
            txbRevuesNumRecherche.Text = "";
            txbRevuesTitreRecherche.Text = "";
        }

        private void dgvRevuesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideRevuesZones();
            string col = dgvRevuesListe.Columns[e.ColumnIndex].HeaderText;
            List<Revue> sorted = new List<Revue>();
            switch (col)
            {
                case "Id": sorted = lesRevues.OrderBy(o => o.Id).ToList(); break;
                case "Titre": sorted = lesRevues.OrderBy(o => o.Titre).ToList(); break;
                case "Periodicite": sorted = lesRevues.OrderBy(o => o.Periodicite).ToList(); break;
                case "DelaiMiseADispo": sorted = lesRevues.OrderBy(o => o.DelaiMiseADispo).ToList(); break;
                case "Genre": sorted = lesRevues.OrderBy(o => o.Genre).ToList(); break;
                case "Public": sorted = lesRevues.OrderBy(o => o.Public).ToList(); break;
                case "Rayon": sorted = lesRevues.OrderBy(o => o.Rayon).ToList(); break;
            }
            RemplirRevuesListe(sorted);
        }

        private void btnRevuesAjouter_Click_1(object sender, EventArgs e)
        {
            if (txbRevuesNumero.Text.Equals("")) { MessageBox.Show("Le numéro est obligatoire.", "Information"); return; }
            int delai = 0; int.TryParse(txbRevuesDateMiseADispo.Text, out delai);
            string idGenre = cbxRevuesGenres.SelectedIndex >= 0 ? ((Genre)cbxRevuesGenres.SelectedItem).Id : "";
            string libelleGenre = cbxRevuesGenres.SelectedIndex >= 0 ? ((Genre)cbxRevuesGenres.SelectedItem).Libelle : "";
            string idPublic = cbxRevuesPublics.SelectedIndex >= 0 ? ((Public)cbxRevuesPublics.SelectedItem).Id : "";
            string libellePublic = cbxRevuesPublics.SelectedIndex >= 0 ? ((Public)cbxRevuesPublics.SelectedItem).Libelle : "";
            string idRayon = cbxRevuesRayons.SelectedIndex >= 0 ? ((Rayon)cbxRevuesRayons.SelectedItem).Id : "";
            string libelleRayon = cbxRevuesRayons.SelectedIndex >= 0 ? ((Rayon)cbxRevuesRayons.SelectedItem).Libelle : "";
            Revue revue = new Revue(txbRevuesNumero.Text, txbRevuesTitre.Text, txbRevuesImage.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon, txbRevuesPeriodicite.Text, delai);
            if (controller.CreerRevue(revue)) { lesRevues = controller.GetAllRevues(); RemplirRevuesListeComplete(); MessageBox.Show("La revue a été ajoutée.", "Information"); }
            else MessageBox.Show("Erreur lors de l'ajout (l'id existe peut-être déjà).", "Erreur");
        }

        private void btnRevuesModifier_Click_1(object sender, EventArgs e)
        {
            if (txbRevuesNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner une revue à modifier.", "Information"); return; }
            int delai = 0; int.TryParse(txbRevuesDateMiseADispo.Text, out delai);
            string idGenre = cbxRevuesGenres.SelectedIndex >= 0 ? ((Genre)cbxRevuesGenres.SelectedItem).Id : "";
            string libelleGenre = cbxRevuesGenres.SelectedIndex >= 0 ? ((Genre)cbxRevuesGenres.SelectedItem).Libelle : "";
            string idPublic = cbxRevuesPublics.SelectedIndex >= 0 ? ((Public)cbxRevuesPublics.SelectedItem).Id : "";
            string libellePublic = cbxRevuesPublics.SelectedIndex >= 0 ? ((Public)cbxRevuesPublics.SelectedItem).Libelle : "";
            string idRayon = cbxRevuesRayons.SelectedIndex >= 0 ? ((Rayon)cbxRevuesRayons.SelectedItem).Id : "";
            string libelleRayon = cbxRevuesRayons.SelectedIndex >= 0 ? ((Rayon)cbxRevuesRayons.SelectedItem).Libelle : "";
            Revue revue = new Revue(txbRevuesNumero.Text, txbRevuesTitre.Text, txbRevuesImage.Text,
                idGenre, libelleGenre, idPublic, libellePublic, idRayon, libelleRayon, txbRevuesPeriodicite.Text, delai);
            if (controller.ModifierRevue(revue)) { lesRevues = controller.GetAllRevues(); RemplirRevuesListeComplete(); MessageBox.Show("La revue a été modifiée.", "Information"); }
            else MessageBox.Show("Erreur lors de la modification.", "Erreur");
        }

        private void btnRevuesSupprimerDoc_Click_1(object sender, EventArgs e)
        {
            if (txbRevuesNumero.Text.Equals("")) { MessageBox.Show("Merci de sélectionner une revue à supprimer.", "Information"); return; }
            Revue revue = (Revue)bdgRevuesListe.List[bdgRevuesListe.Position];
            if (MessageBox.Show("Confirmer la suppression de la revue \"" + revue.Titre + "\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.SupprimerRevue(revue)) { lesRevues = controller.GetAllRevues(); RemplirRevuesListeComplete(); MessageBox.Show("La revue a été supprimée.", "Information"); }
                else MessageBox.Show("Impossible de supprimer cette revue (des exemplaires ou commandes y sont liés).", "Erreur");
            }
        }
        #endregion

        #region Onglet Parutions
        private readonly BindingSource bdgExemplairesListe = new BindingSource();
        private List<Exemplaire> lesExemplaires = new List<Exemplaire>();
        const string ETATNEUF = "00001";

        private void tabReceptionRevue_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            txbReceptionRevueNumero.Text = "";
        }

        private void RemplirReceptionExemplairesListe(List<Exemplaire> exemplaires)
        {
            if (exemplaires != null)
            {
                bdgExemplairesListe.DataSource = exemplaires;
                dgvReceptionExemplairesListe.DataSource = bdgExemplairesListe;
                dgvReceptionExemplairesListe.Columns["idEtat"].Visible = false;
                dgvReceptionExemplairesListe.Columns["id"].Visible = false;
                dgvReceptionExemplairesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvReceptionExemplairesListe.Columns["numero"].DisplayIndex = 0;
                dgvReceptionExemplairesListe.Columns["dateAchat"].DisplayIndex = 1;
            }
            else bdgExemplairesListe.DataSource = null;
        }

        private void btnReceptionRechercher_Click(object sender, EventArgs e)
        {
            if (!txbReceptionRevueNumero.Text.Equals(""))
            {
                Revue revue = lesRevues.Find(x => x.Id.Equals(txbReceptionRevueNumero.Text));
                if (revue != null) AfficheReceptionRevueInfos(revue);
                else MessageBox.Show("numéro introuvable");
            }
        }

        private void txbReceptionRevueNumero_TextChanged(object sender, EventArgs e)
        {
            txbReceptionRevuePeriodicite.Text = "";
            txbReceptionRevueImage.Text = "";
            txbReceptionRevueDelaiMiseADispo.Text = "";
            txbReceptionRevueGenre.Text = "";
            txbReceptionRevuePublic.Text = "";
            txbReceptionRevueRayon.Text = "";
            txbReceptionRevueTitre.Text = "";
            pcbReceptionRevueImage.Image = null;
            RemplirReceptionExemplairesListe(null);
            AccesReceptionExemplaireGroupBox(false);
        }

        private void AfficheReceptionRevueInfos(Revue revue)
        {
            txbReceptionRevuePeriodicite.Text = revue.Periodicite;
            txbReceptionRevueImage.Text = revue.Image;
            txbReceptionRevueDelaiMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbReceptionRevueNumero.Text = revue.Id;
            txbReceptionRevueGenre.Text = revue.Genre;
            txbReceptionRevuePublic.Text = revue.Public;
            txbReceptionRevueRayon.Text = revue.Rayon;
            txbReceptionRevueTitre.Text = revue.Titre;
            try { pcbReceptionRevueImage.Image = Image.FromFile(revue.Image); }
            catch { pcbReceptionRevueImage.Image = null; }
            AfficheReceptionExemplairesRevue();
        }

        private void AfficheReceptionExemplairesRevue()
        {
            lesExemplaires = controller.GetExemplairesRevue(txbReceptionRevueNumero.Text);
            RemplirReceptionExemplairesListe(lesExemplaires);
            AccesReceptionExemplaireGroupBox(true);
        }

        private void AccesReceptionExemplaireGroupBox(bool acces)
        {
            grpReceptionExemplaire.Enabled = acces;
            txbReceptionExemplaireImage.Text = "";
            txbReceptionExemplaireNumero.Text = "";
            pcbReceptionExemplaireImage.Image = null;
            dtpReceptionExemplaireDate.Value = DateTime.Now;
        }

        private void btnReceptionExemplaireImage_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Path.GetPathRoot(Environment.CurrentDirectory),
                Filter = "Files|*.jpg;*.bmp;*.jpeg;*.png;*.gif"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filePath = openFileDialog.FileName;
            txbReceptionExemplaireImage.Text = filePath;
            try { pcbReceptionExemplaireImage.Image = Image.FromFile(filePath); }
            catch { pcbReceptionExemplaireImage.Image = null; }
        }

        private void btnReceptionExemplaireValider_Click(object sender, EventArgs e)
        {
            if (!txbReceptionExemplaireNumero.Text.Equals(""))
            {
                try
                {
                    int numero = int.Parse(txbReceptionExemplaireNumero.Text);
                    Exemplaire exemplaire = new Exemplaire(numero, dtpReceptionExemplaireDate.Value, txbReceptionExemplaireImage.Text, ETATNEUF, txbReceptionRevueNumero.Text);
                    if (controller.CreerExemplaire(exemplaire)) AfficheReceptionExemplairesRevue();
                    else MessageBox.Show("numéro de publication déjà existant", "Erreur");
                }
                catch
                {
                    MessageBox.Show("le numéro de parution doit être numérique", "Information");
                    txbReceptionExemplaireNumero.Text = "";
                    txbReceptionExemplaireNumero.Focus();
                }
            }
            else MessageBox.Show("numéro de parution obligatoire", "Information");
        }

        private void dgvExemplairesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = dgvReceptionExemplairesListe.Columns[e.ColumnIndex].HeaderText;
            List<Exemplaire> sorted = new List<Exemplaire>();
            switch (col)
            {
                case "Numero": sorted = lesExemplaires.OrderBy(o => o.Numero).Reverse().ToList(); break;
                case "DateAchat": sorted = lesExemplaires.OrderBy(o => o.DateAchat).Reverse().ToList(); break;
                case "Photo": sorted = lesExemplaires.OrderBy(o => o.Photo).ToList(); break;
            }
            RemplirReceptionExemplairesListe(sorted);
        }

        private void dgvReceptionExemplairesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceptionExemplairesListe.CurrentCell != null)
            {
                Exemplaire exemplaire = (Exemplaire)bdgExemplairesListe.List[bdgExemplairesListe.Position];
                try { pcbReceptionExemplaireRevueImage.Image = Image.FromFile(exemplaire.Photo); }
                catch { pcbReceptionExemplaireRevueImage.Image = null; }
            }
            else pcbReceptionExemplaireRevueImage.Image = null;
        }
        #endregion

        #region Onglet Commandes Livres
        private readonly BindingSource bdgCommandesLivresListe = new BindingSource();
        private List<CommandeDocument> lesCommandesLivres = new List<CommandeDocument>();
        private List<Livre> lesLivresCommandes = new List<Livre>();

        /// <summary>
        /// Chargement de l'onglet commandes livres
        /// </summary>
        private void tabCommandesLivres_Enter(object sender, EventArgs e)
        {
            lesLivresCommandes = controller.GetAllLivres();
            RemplirComboCategorie(controller.GetAllSuivi(), new BindingSource(), cbxCommandesLivresSuivi);
            VideCommandesLivresInfos();
        }

        private void RemplirCommandesLivresListe(List<CommandeDocument> commandes)
        {
            bdgCommandesLivresListe.DataSource = commandes;
            dgvCommandesLivresListe.DataSource = bdgCommandesLivresListe;
            dgvCommandesLivresListe.Columns["idLivreDvd"].Visible = false;
            dgvCommandesLivresListe.Columns["idSuivi"].Visible = false;
            dgvCommandesLivresListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandesLivresListe.Columns["id"].DisplayIndex = 0;
            dgvCommandesLivresListe.Columns["dateCommande"].DisplayIndex = 1;
            dgvCommandesLivresListe.Columns["montant"].DisplayIndex = 2;
            dgvCommandesLivresListe.Columns["nbExemplaire"].DisplayIndex = 3;
            dgvCommandesLivresListe.Columns["suivi"].DisplayIndex = 4;
        }

        /// <summary>
        /// Recherche d'un livre par son numéro et affichage de ses commandes
        /// </summary>
        private void btnCommandesLivresRechercher_Click(object sender, EventArgs e)
        {
            if (txbCommandesLivresNumero.Text.Equals(""))
            {
                MessageBox.Show("Merci de saisir un numéro de livre.", "Information");
                return;
            }
            Livre livre = lesLivresCommandes.Find(x => x.Id.Equals(txbCommandesLivresNumero.Text));
            if (livre != null)
            {
                txbCommandesLivresTitre.Text = livre.Titre;
                lesCommandesLivres = controller.GetCommandesLivreDvd(livre.Id);
                RemplirCommandesLivresListe(lesCommandesLivres);
                grpCommandesLivresNouvelle.Enabled = true;
                grpCommandesLivresSuivi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Numéro de livre introuvable.", "Information");
                VideCommandesLivresInfos();
            }
        }

        private void dgvCommandesLivresListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCommandesLivresListe.CurrentCell != null && bdgCommandesLivresListe.Count > 0)
            {
                try
                {
                    CommandeDocument cmd = (CommandeDocument)bdgCommandesLivresListe.List[bdgCommandesLivresListe.Position];
                    // Sélectionner l'étape de suivi dans le combo
                    for (int i = 0; i < cbxCommandesLivresSuivi.Items.Count; i++)
                        if (((Categorie)cbxCommandesLivresSuivi.Items[i]).Id.Equals(cmd.IdSuivi)) { cbxCommandesLivresSuivi.SelectedIndex = i; break; }
                    grpCommandesLivresSuivi.Enabled = true;
                }
                catch { grpCommandesLivresSuivi.Enabled = false; }
            }
            else grpCommandesLivresSuivi.Enabled = false;
        }

        private void dgvCommandesLivresListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = dgvCommandesLivresListe.Columns[e.ColumnIndex].HeaderText;
            List<CommandeDocument> sorted = new List<CommandeDocument>();
            switch (col)
            {
                case "Id": sorted = lesCommandesLivres.OrderBy(o => o.Id).ToList(); break;
                case "DateCommande": sorted = lesCommandesLivres.OrderByDescending(o => o.DateCommande).ToList(); break;
                case "Montant": sorted = lesCommandesLivres.OrderBy(o => o.Montant).ToList(); break;
                case "NbExemplaire": sorted = lesCommandesLivres.OrderBy(o => o.NbExemplaire).ToList(); break;
                case "Suivi": sorted = lesCommandesLivres.OrderBy(o => o.Suivi).ToList(); break;
            }
            RemplirCommandesLivresListe(sorted);
        }

        /// <summary>
        /// Enregistrement d'une nouvelle commande de livre
        /// L'étape de suivi est automatiquement mise à "En cours"
        /// </summary>
        private void btnCommandesLivresAjouter_Click(object sender, EventArgs e)
        {
            if (txbCommandesLivresNumero.Text.Equals("")) { MessageBox.Show("Merci de rechercher un livre.", "Information"); return; }
            if (txbCommandesLivresNumCommande.Text.Equals("")) { MessageBox.Show("Le numéro de commande est obligatoire.", "Information"); return; }
            double montant = 0;
            double.TryParse(txbCommandesLivresMontant.Text, out montant);
            int nbEx = 0;
            int.TryParse(txbCommandesLivresNbExemplaires.Text, out nbEx);
            CommandeDocument commande = new CommandeDocument(
                txbCommandesLivresNumCommande.Text,
                dtpCommandesLivresDate.Value,
                montant, nbEx,
                txbCommandesLivresNumero.Text,
                "00001", "En cours");
            if (controller.CreerCommandeDocument(commande))
            {
                lesCommandesLivres = controller.GetCommandesLivreDvd(txbCommandesLivresNumero.Text);
                RemplirCommandesLivresListe(lesCommandesLivres);
                txbCommandesLivresNumCommande.Text = "";
                txbCommandesLivresMontant.Text = "";
                txbCommandesLivresNbExemplaires.Text = "";
                MessageBox.Show("La commande a été enregistrée.", "Information");
            }
            else MessageBox.Show("Erreur lors de l'enregistrement (l'id existe peut-être déjà).", "Erreur");
        }

        /// <summary>
        /// Modification du suivi d'une commande avec vérification des règles :
        /// - Une commande livrée ou réglée ne peut pas revenir à En cours ou Relancée
        /// - Une commande ne peut pas être réglée si elle n'est pas livrée
        /// </summary>
        private void btnCommandesLivresModifierSuivi_Click(object sender, EventArgs e)
        {
            if (dgvCommandesLivresListe.CurrentCell == null || bdgCommandesLivresListe.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner une commande.", "Information");
                return;
            }
            if (cbxCommandesLivresSuivi.SelectedIndex < 0)
            {
                MessageBox.Show("Merci de sélectionner une étape de suivi.", "Information");
                return;
            }
            CommandeDocument cmd = (CommandeDocument)bdgCommandesLivresListe.List[bdgCommandesLivresListe.Position];
            string nouveauSuivi = ((Categorie)cbxCommandesLivresSuivi.SelectedItem).Id;
            string ancienSuivi = cmd.IdSuivi;

            // Règle 1 : commande livrée ou réglée ne peut pas revenir en arrière
            if ((ancienSuivi == "00003" || ancienSuivi == "00004") && (nouveauSuivi == "00001" || nouveauSuivi == "00002"))
            {
                MessageBox.Show("Une commande livrée ou réglée ne peut pas revenir à une étape précédente.", "Erreur");
                return;
            }
            // Règle 2 : ne peut pas être réglée si pas livrée
            if (nouveauSuivi == "00004" && ancienSuivi != "00003")
            {
                MessageBox.Show("Une commande ne peut pas être réglée si elle n'est pas livrée.", "Erreur");
                return;
            }

            cmd.IdSuivi = nouveauSuivi;
            if (controller.ModifierSuiviCommande(cmd))
            {
                lesCommandesLivres = controller.GetCommandesLivreDvd(txbCommandesLivresNumero.Text);
                RemplirCommandesLivresListe(lesCommandesLivres);
                MessageBox.Show("Le suivi a été modifié.", "Information");
            }
            else MessageBox.Show("Erreur lors de la modification du suivi.", "Erreur");
        }

        /// <summary>
        /// Suppression d'une commande uniquement si elle n'est pas encore livrée
        /// </summary>
        private void btnCommandesLivresSupprimerCommande_Click(object sender, EventArgs e)
        {
            if (dgvCommandesLivresListe.CurrentCell == null || bdgCommandesLivresListe.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner une commande à supprimer.", "Information");
                return;
            }
            CommandeDocument cmd = (CommandeDocument)bdgCommandesLivresListe.List[bdgCommandesLivresListe.Position];
            if (cmd.IdSuivi == "00003" || cmd.IdSuivi == "00004")
            {
                MessageBox.Show("Impossible de supprimer une commande déjà livrée ou réglée.", "Erreur");
                return;
            }
            if (MessageBox.Show("Confirmer la suppression de la commande \"" + cmd.Id + "\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.SupprimerCommandeDocument(cmd))
                {
                    lesCommandesLivres = controller.GetCommandesLivreDvd(txbCommandesLivresNumero.Text);
                    RemplirCommandesLivresListe(lesCommandesLivres);
                    MessageBox.Show("La commande a été supprimée.", "Information");
                }
                else MessageBox.Show("Erreur lors de la suppression.", "Erreur");
            }
        }

        private void VideCommandesLivresInfos()
        {
            txbCommandesLivresTitre.Text = "";
            txbCommandesLivresNumCommande.Text = "";
            txbCommandesLivresMontant.Text = "";
            txbCommandesLivresNbExemplaires.Text = "";
            bdgCommandesLivresListe.DataSource = null;
            dgvCommandesLivresListe.DataSource = null;
            grpCommandesLivresNouvelle.Enabled = false;
            grpCommandesLivresSuivi.Enabled = false;
        }
        #endregion

        #region Onglet Commandes DVD
        private readonly BindingSource bdgCommandesDvdListe = new BindingSource();
        private List<CommandeDocument> lesCommandesDvd = new List<CommandeDocument>();
        private List<Dvd> lesDvdCommandes = new List<Dvd>();

        /// <summary>
        /// Chargement de l'onglet commandes DVD
        /// </summary>
        private void tabCommandesDvd_Enter(object sender, EventArgs e)
        {
            lesDvdCommandes = controller.GetAllDvd();
            RemplirComboCategorie(controller.GetAllSuivi(), new BindingSource(), cbxCommandesDvdSuivi);
            VideCommandesDvdInfos();
        }

        private void RemplirCommandesDvdListe(List<CommandeDocument> commandes)
        {
            bdgCommandesDvdListe.DataSource = commandes;
            dgvCommandesDvdListe.DataSource = bdgCommandesDvdListe;
            dgvCommandesDvdListe.Columns["idLivreDvd"].Visible = false;
            dgvCommandesDvdListe.Columns["idSuivi"].Visible = false;
            dgvCommandesDvdListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandesDvdListe.Columns["id"].DisplayIndex = 0;
            dgvCommandesDvdListe.Columns["dateCommande"].DisplayIndex = 1;
            dgvCommandesDvdListe.Columns["montant"].DisplayIndex = 2;
            dgvCommandesDvdListe.Columns["nbExemplaire"].DisplayIndex = 3;
            dgvCommandesDvdListe.Columns["suivi"].DisplayIndex = 4;
        }

        /// <summary>
        /// Recherche d'un DVD par son numéro et affichage de ses commandes
        /// </summary>
        private void btnCommandesDvdRechercher_Click(object sender, EventArgs e)
        {
            if (txbCommandesDvdNumero.Text.Equals(""))
            {
                MessageBox.Show("Merci de saisir un numéro de DVD.", "Information");
                return;
            }
            Dvd dvd = lesDvdCommandes.Find(x => x.Id.Equals(txbCommandesDvdNumero.Text));
            if (dvd != null)
            {
                txbCommandesDvdTitre.Text = dvd.Titre;
                lesCommandesDvd = controller.GetCommandesDvd(dvd.Id);
                RemplirCommandesDvdListe(lesCommandesDvd);
                grpCommandesDvdNouvelle.Enabled = true;
                grpCommandesDvdSuivi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Numéro de DVD introuvable.", "Information");
                VideCommandesDvdInfos();
            }
        }

        private void dgvCommandesDvdListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCommandesDvdListe.CurrentCell != null && bdgCommandesDvdListe.Count > 0)
            {
                try
                {
                    CommandeDocument cmd = (CommandeDocument)bdgCommandesDvdListe.List[bdgCommandesDvdListe.Position];
                    for (int i = 0; i < cbxCommandesDvdSuivi.Items.Count; i++)
                        if (((Categorie)cbxCommandesDvdSuivi.Items[i]).Id.Equals(cmd.IdSuivi)) { cbxCommandesDvdSuivi.SelectedIndex = i; break; }
                    grpCommandesDvdSuivi.Enabled = true;
                }
                catch { grpCommandesDvdSuivi.Enabled = false; }
            }
            else grpCommandesDvdSuivi.Enabled = false;
        }

        private void dgvCommandesDvdListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = dgvCommandesDvdListe.Columns[e.ColumnIndex].HeaderText;
            List<CommandeDocument> sorted = new List<CommandeDocument>();
            switch (col)
            {
                case "Id": sorted = lesCommandesDvd.OrderBy(o => o.Id).ToList(); break;
                case "DateCommande": sorted = lesCommandesDvd.OrderByDescending(o => o.DateCommande).ToList(); break;
                case "Montant": sorted = lesCommandesDvd.OrderBy(o => o.Montant).ToList(); break;
                case "NbExemplaire": sorted = lesCommandesDvd.OrderBy(o => o.NbExemplaire).ToList(); break;
                case "Suivi": sorted = lesCommandesDvd.OrderBy(o => o.Suivi).ToList(); break;
            }
            RemplirCommandesDvdListe(sorted);
        }

        /// <summary>
        /// Enregistrement d'une nouvelle commande de DVD
        /// </summary>
        private void btnCommandesDvdAjouter_Click(object sender, EventArgs e)
        {
            if (txbCommandesDvdNumero.Text.Equals("")) { MessageBox.Show("Merci de rechercher un DVD.", "Information"); return; }
            if (txbCommandesDvdNumCommande.Text.Equals("")) { MessageBox.Show("Le numéro de commande est obligatoire.", "Information"); return; }
            double montant = 0; double.TryParse(txbCommandesDvdMontant.Text, out montant);
            int nbEx = 0; int.TryParse(txbCommandesDvdNbExemplaires.Text, out nbEx);
            CommandeDocument commande = new CommandeDocument(
                txbCommandesDvdNumCommande.Text,
                dtpCommandesDvdDate.Value,
                montant, nbEx,
                txbCommandesDvdNumero.Text,
                "00001", "En cours");
            if (controller.CreerCommandeDocument(commande))
            {
                lesCommandesDvd = controller.GetCommandesDvd(txbCommandesDvdNumero.Text);
                RemplirCommandesDvdListe(lesCommandesDvd);
                txbCommandesDvdNumCommande.Text = "";
                txbCommandesDvdMontant.Text = "";
                txbCommandesDvdNbExemplaires.Text = "";
                MessageBox.Show("La commande a été enregistrée.", "Information");
            }
            else MessageBox.Show("Erreur lors de l'enregistrement (l'id existe peut-être déjà).", "Erreur");
        }

        /// <summary>
        /// Modification du suivi d'une commande DVD avec vérification des règles
        /// </summary>
        private void btnCommandesDvdModifierSuivi_Click(object sender, EventArgs e)
        {
            if (dgvCommandesDvdListe.CurrentCell == null || bdgCommandesDvdListe.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner une commande.", "Information");
                return;
            }
            if (cbxCommandesDvdSuivi.SelectedIndex < 0)
            {
                MessageBox.Show("Merci de sélectionner une étape de suivi.", "Information");
                return;
            }
            CommandeDocument cmd = (CommandeDocument)bdgCommandesDvdListe.List[bdgCommandesDvdListe.Position];
            string nouveauSuivi = ((Categorie)cbxCommandesDvdSuivi.SelectedItem).Id;
            string ancienSuivi = cmd.IdSuivi;

            if ((ancienSuivi == "00003" || ancienSuivi == "00004") && (nouveauSuivi == "00001" || nouveauSuivi == "00002"))
            {
                MessageBox.Show("Une commande livrée ou réglée ne peut pas revenir à une étape précédente.", "Erreur");
                return;
            }
            if (nouveauSuivi == "00004" && ancienSuivi != "00003")
            {
                MessageBox.Show("Une commande ne peut pas être réglée si elle n'est pas livrée.", "Erreur");
                return;
            }

            cmd.IdSuivi = nouveauSuivi;
            if (controller.ModifierSuiviCommande(cmd))
            {
                lesCommandesDvd = controller.GetCommandesDvd(txbCommandesDvdNumero.Text);
                RemplirCommandesDvdListe(lesCommandesDvd);
                MessageBox.Show("Le suivi a été modifié.", "Information");
            }
            else MessageBox.Show("Erreur lors de la modification du suivi.", "Erreur");
        }

        /// <summary>
        /// Suppression d'une commande DVD uniquement si elle n'est pas encore livrée
        /// </summary>
        private void btnCommandesDvdSupprimerCommande_Click(object sender, EventArgs e)
        {
            if (dgvCommandesDvdListe.CurrentCell == null || bdgCommandesDvdListe.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner une commande à supprimer.", "Information");
                return;
            }
            CommandeDocument cmd = (CommandeDocument)bdgCommandesDvdListe.List[bdgCommandesDvdListe.Position];
            if (cmd.IdSuivi == "00003" || cmd.IdSuivi == "00004")
            {
                MessageBox.Show("Impossible de supprimer une commande déjà livrée ou réglée.", "Erreur");
                return;
            }
            if (MessageBox.Show("Confirmer la suppression de la commande \"" + cmd.Id + "\" ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (controller.SupprimerCommandeDocument(cmd))
                {
                    lesCommandesDvd = controller.GetCommandesDvd(txbCommandesDvdNumero.Text);
                    RemplirCommandesDvdListe(lesCommandesDvd);
                    MessageBox.Show("La commande a été supprimée.", "Information");
                }
                else MessageBox.Show("Erreur lors de la suppression.", "Erreur");
            }
        }

        private void VideCommandesDvdInfos()
        {
            txbCommandesDvdTitre.Text = "";
            txbCommandesDvdNumCommande.Text = "";
            txbCommandesDvdMontant.Text = "";
            txbCommandesDvdNbExemplaires.Text = "";
            bdgCommandesDvdListe.DataSource = null;
            dgvCommandesDvdListe.DataSource = null;
            grpCommandesDvdNouvelle.Enabled = false;
            grpCommandesDvdSuivi.Enabled = false;
        }
        #endregion

        private void FrmMediatek_Load(object sender, EventArgs e) { }
        private void dgvLivresListe_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}