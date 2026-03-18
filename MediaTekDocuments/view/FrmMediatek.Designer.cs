namespace MediaTekDocuments.view
{
    partial class FrmMediatek
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.tabOngletsApplication = new System.Windows.Forms.TabControl();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.grpLivresInfos = new System.Windows.Forms.GroupBox();
            this.btnLivresSupprimerDoc = new System.Windows.Forms.Button();
            this.label59 = new System.Windows.Forms.Label();
            this.btnLivresModifier = new System.Windows.Forms.Button();
            this.btnLivresAjouter = new System.Windows.Forms.Button();
            this.txbLivresIsbn = new System.Windows.Forms.TextBox();
            this.txbLivresImage = new System.Windows.Forms.TextBox();
            this.txbLivresRayon = new System.Windows.Forms.TextBox();
            this.txbLivresPublic = new System.Windows.Forms.TextBox();
            this.txbLivresGenre = new System.Windows.Forms.TextBox();
            this.txbLivresCollection = new System.Windows.Forms.TextBox();
            this.txbLivresAuteur = new System.Windows.Forms.TextBox();
            this.txbLivresTitre = new System.Windows.Forms.TextBox();
            this.txbLivresNumero = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pcbLivresImage = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpLivresRecherche = new System.Windows.Forms.GroupBox();
            this.btnLivresAnnulRayons = new System.Windows.Forms.Button();
            this.btnlivresAnnulPublics = new System.Windows.Forms.Button();
            this.btnLivresNumRecherche = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLivresNumRecherche = new System.Windows.Forms.TextBox();
            this.btnLivresAnnulGenres = new System.Windows.Forms.Button();
            this.cbxLivresRayons = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxLivresPublics = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxLivresGenres = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLivresListe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLivresTitreRecherche = new System.Windows.Forms.TextBox();
            // Exemplaires Livres
            this.grpLivresExemplaires = new System.Windows.Forms.GroupBox();
            this.dgvLivresExemplaires = new System.Windows.Forms.DataGridView();
            this.labelLivresEtat = new System.Windows.Forms.Label();
            this.cbxLivresEtat = new System.Windows.Forms.ComboBox();
            this.btnLivresModifierEtat = new System.Windows.Forms.Button();
            this.btnLivresSupprimerExemplaire = new System.Windows.Forms.Button();
            this.tabDvd = new System.Windows.Forms.TabPage();
            this.grpDvdInfos = new System.Windows.Forms.GroupBox();
            this.btnDvdSupprimerDoc = new System.Windows.Forms.Button();
            this.btnDvdModifier = new System.Windows.Forms.Button();
            this.btnDvdAjouter = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.txbDvdDuree = new System.Windows.Forms.TextBox();
            this.txbDvdImage = new System.Windows.Forms.TextBox();
            this.txbDvdRayon = new System.Windows.Forms.TextBox();
            this.txbDvdPublic = new System.Windows.Forms.TextBox();
            this.txbDvdGenre = new System.Windows.Forms.TextBox();
            this.txbDvdSynopsis = new System.Windows.Forms.TextBox();
            this.txbDvdRealisateur = new System.Windows.Forms.TextBox();
            this.txbDvdTitre = new System.Windows.Forms.TextBox();
            this.txbDvdNumero = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pcbDvdImage = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.grpDvdRecherche = new System.Windows.Forms.GroupBox();
            this.btnDvdAnnulRayons = new System.Windows.Forms.Button();
            this.btnDvdAnnulPublics = new System.Windows.Forms.Button();
            this.btnDvdNumRecherche = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.txbDvdNumRecherche = new System.Windows.Forms.TextBox();
            this.btnDvdAnnulGenres = new System.Windows.Forms.Button();
            this.cbxDvdRayons = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cbxDvdPublics = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.cbxDvdGenres = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dgvDvdListe = new System.Windows.Forms.DataGridView();
            this.label42 = new System.Windows.Forms.Label();
            this.txbDvdTitreRecherche = new System.Windows.Forms.TextBox();
            // Exemplaires DVD
            this.grpDvdExemplaires = new System.Windows.Forms.GroupBox();
            this.dgvDvdExemplaires = new System.Windows.Forms.DataGridView();
            this.labelDvdEtat = new System.Windows.Forms.Label();
            this.cbxDvdEtat = new System.Windows.Forms.ComboBox();
            this.btnDvdModifierEtat = new System.Windows.Forms.Button();
            this.btnDvdSupprimerExemplaire = new System.Windows.Forms.Button();
            this.tabRevues = new System.Windows.Forms.TabPage();
            this.grpRevuesInfos = new System.Windows.Forms.GroupBox();
            this.btnRevuesSupprimerDoc = new System.Windows.Forms.Button();
            this.btnRevuesModifier = new System.Windows.Forms.Button();
            this.btnRevuesAjouter = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.txbRevuesImage = new System.Windows.Forms.TextBox();
            this.txbRevuesRayon = new System.Windows.Forms.TextBox();
            this.txbRevuesPublic = new System.Windows.Forms.TextBox();
            this.txbRevuesGenre = new System.Windows.Forms.TextBox();
            this.txbRevuesDateMiseADispo = new System.Windows.Forms.TextBox();
            this.txbRevuesPeriodicite = new System.Windows.Forms.TextBox();
            this.txbRevuesTitre = new System.Windows.Forms.TextBox();
            this.txbRevuesNumero = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.pcbRevuesImage = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.grpRevuesRecherche = new System.Windows.Forms.GroupBox();
            this.btnRevuesAnnulRayons = new System.Windows.Forms.Button();
            this.btnRevuesAnnulPublics = new System.Windows.Forms.Button();
            this.btnRevuesNumRecherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRevuesNumRecherche = new System.Windows.Forms.TextBox();
            this.btnRevuesAnnulGenres = new System.Windows.Forms.Button();
            this.cbxRevuesRayons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRevuesPublics = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbxRevuesGenres = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvRevuesListe = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.txbRevuesTitreRecherche = new System.Windows.Forms.TextBox();
            this.tabReceptionRevue = new System.Windows.Forms.TabPage();
            this.grpReceptionExemplaire = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.btnReceptionExemplaireImage = new System.Windows.Forms.Button();
            this.pcbReceptionExemplaireImage = new System.Windows.Forms.PictureBox();
            this.btnReceptionExemplaireValider = new System.Windows.Forms.Button();
            this.txbReceptionExemplaireImage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbReceptionExemplaireNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpReceptionExemplaireDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.grpReceptionRevue = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.pcbReceptionExemplaireRevueImage = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvReceptionExemplairesListe = new System.Windows.Forms.DataGridView();
            this.txbReceptionRevueImage = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueRayon = new System.Windows.Forms.TextBox();
            this.txbReceptionRevuePublic = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueGenre = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueDelaiMiseADispo = new System.Windows.Forms.TextBox();
            this.txbReceptionRevuePeriodicite = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueTitre = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbReceptionRevueImage = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.btnReceptionRechercher = new System.Windows.Forms.Button();
            // Etat Parutions
            this.labelReceptionEtat = new System.Windows.Forms.Label();
            this.cbxReceptionEtat = new System.Windows.Forms.ComboBox();
            this.btnReceptionModifierEtat = new System.Windows.Forms.Button();
            this.btnReceptionSupprimerExemplaire = new System.Windows.Forms.Button();
            // Commandes Livres
            this.tabCommandesLivres = new System.Windows.Forms.TabPage();
            this.grpCommandesLivresRecherche = new System.Windows.Forms.GroupBox();
            this.txbCommandesLivresNumero = new System.Windows.Forms.TextBox();
            this.btnCommandesLivresRechercher = new System.Windows.Forms.Button();
            this.labelCmdLivresNum = new System.Windows.Forms.Label();
            this.labelCmdLivresTitre = new System.Windows.Forms.Label();
            this.txbCommandesLivresTitre = new System.Windows.Forms.TextBox();
            this.dgvCommandesLivresListe = new System.Windows.Forms.DataGridView();
            this.grpCommandesLivresNouvelle = new System.Windows.Forms.GroupBox();
            this.labelCmdLivresNumCmd = new System.Windows.Forms.Label();
            this.txbCommandesLivresNumCommande = new System.Windows.Forms.TextBox();
            this.labelCmdLivresDate = new System.Windows.Forms.Label();
            this.dtpCommandesLivresDate = new System.Windows.Forms.DateTimePicker();
            this.labelCmdLivresMontant = new System.Windows.Forms.Label();
            this.txbCommandesLivresMontant = new System.Windows.Forms.TextBox();
            this.labelCmdLivresNbEx = new System.Windows.Forms.Label();
            this.txbCommandesLivresNbExemplaires = new System.Windows.Forms.TextBox();
            this.btnCommandesLivresAjouter = new System.Windows.Forms.Button();
            this.grpCommandesLivresSuivi = new System.Windows.Forms.GroupBox();
            this.labelCmdLivresSuivi = new System.Windows.Forms.Label();
            this.cbxCommandesLivresSuivi = new System.Windows.Forms.ComboBox();
            this.btnCommandesLivresModifierSuivi = new System.Windows.Forms.Button();
            this.btnCommandesLivresSupprimerCommande = new System.Windows.Forms.Button();
            // Commandes DVD
            this.tabCommandesDvd = new System.Windows.Forms.TabPage();
            this.grpCommandesDvdRecherche = new System.Windows.Forms.GroupBox();
            this.txbCommandesDvdNumero = new System.Windows.Forms.TextBox();
            this.btnCommandesDvdRechercher = new System.Windows.Forms.Button();
            this.labelCmdDvdNum = new System.Windows.Forms.Label();
            this.labelCmdDvdTitre = new System.Windows.Forms.Label();
            this.txbCommandesDvdTitre = new System.Windows.Forms.TextBox();
            this.dgvCommandesDvdListe = new System.Windows.Forms.DataGridView();
            this.grpCommandesDvdNouvelle = new System.Windows.Forms.GroupBox();
            this.labelCmdDvdNumCmd = new System.Windows.Forms.Label();
            this.txbCommandesDvdNumCommande = new System.Windows.Forms.TextBox();
            this.labelCmdDvdDate = new System.Windows.Forms.Label();
            this.dtpCommandesDvdDate = new System.Windows.Forms.DateTimePicker();
            this.labelCmdDvdMontant = new System.Windows.Forms.Label();
            this.txbCommandesDvdMontant = new System.Windows.Forms.TextBox();
            this.labelCmdDvdNbEx = new System.Windows.Forms.Label();
            this.txbCommandesDvdNbExemplaires = new System.Windows.Forms.TextBox();
            this.btnCommandesDvdAjouter = new System.Windows.Forms.Button();
            this.grpCommandesDvdSuivi = new System.Windows.Forms.GroupBox();
            this.labelCmdDvdSuivi = new System.Windows.Forms.Label();
            this.cbxCommandesDvdSuivi = new System.Windows.Forms.ComboBox();
            this.btnCommandesDvdModifierSuivi = new System.Windows.Forms.Button();
            this.btnCommandesDvdSupprimerCommande = new System.Windows.Forms.Button();
            // Commandes Revues
            this.tabCommandesRevues = new System.Windows.Forms.TabPage();
            this.grpCommandesRevuesRecherche = new System.Windows.Forms.GroupBox();
            this.txbCommandesRevuesNumero = new System.Windows.Forms.TextBox();
            this.btnCommandesRevuesRechercher = new System.Windows.Forms.Button();
            this.labelCmdRevuesNum = new System.Windows.Forms.Label();
            this.labelCmdRevuesTitre = new System.Windows.Forms.Label();
            this.txbCommandesRevuesTitre = new System.Windows.Forms.TextBox();
            this.dgvCommandesRevuesListe = new System.Windows.Forms.DataGridView();
            this.grpCommandesRevuesNouvelle = new System.Windows.Forms.GroupBox();
            this.labelCmdRevuesNumCmd = new System.Windows.Forms.Label();
            this.txbCommandesRevuesNumCommande = new System.Windows.Forms.TextBox();
            this.labelCmdRevuesDate = new System.Windows.Forms.Label();
            this.dtpCommandesRevuesDate = new System.Windows.Forms.DateTimePicker();
            this.labelCmdRevuesMontant = new System.Windows.Forms.Label();
            this.txbCommandesRevuesMontant = new System.Windows.Forms.TextBox();
            this.labelCmdRevuesDateFin = new System.Windows.Forms.Label();
            this.dtpCommandesRevuesDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnCommandesRevuesAjouter = new System.Windows.Forms.Button();
            this.btnCommandesRevuesSupprimerCommande = new System.Windows.Forms.Button();

            this.tabOngletsApplication.SuspendLayout();
            this.tabLivres.SuspendLayout();
            this.grpLivresInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).BeginInit();
            this.grpLivresRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).BeginInit();
            this.grpLivresExemplaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresExemplaires)).BeginInit();
            this.tabDvd.SuspendLayout();
            this.grpDvdInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).BeginInit();
            this.grpDvdRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).BeginInit();
            this.grpDvdExemplaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdExemplaires)).BeginInit();
            this.tabRevues.SuspendLayout();
            this.grpRevuesInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).BeginInit();
            this.grpRevuesRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).BeginInit();
            this.tabReceptionRevue.SuspendLayout();
            this.grpReceptionExemplaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).BeginInit();
            this.grpReceptionRevue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).BeginInit();
            this.tabCommandesLivres.SuspendLayout();
            this.grpCommandesLivresRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesLivresListe)).BeginInit();
            this.grpCommandesLivresNouvelle.SuspendLayout();
            this.grpCommandesLivresSuivi.SuspendLayout();
            this.tabCommandesDvd.SuspendLayout();
            this.grpCommandesDvdRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesDvdListe)).BeginInit();
            this.grpCommandesDvdNouvelle.SuspendLayout();
            this.grpCommandesDvdSuivi.SuspendLayout();
            this.tabCommandesRevues.SuspendLayout();
            this.grpCommandesRevuesRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesRevuesListe)).BeginInit();
            this.grpCommandesRevuesNouvelle.SuspendLayout();
            this.SuspendLayout();

            // tabOngletsApplication
            this.tabOngletsApplication.Controls.Add(this.tabLivres);
            this.tabOngletsApplication.Controls.Add(this.tabDvd);
            this.tabOngletsApplication.Controls.Add(this.tabRevues);
            this.tabOngletsApplication.Controls.Add(this.tabReceptionRevue);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesLivres);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesDvd);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesRevues);
            this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tabOngletsApplication.Name = "tabOngletsApplication";
            this.tabOngletsApplication.SelectedIndex = 0;
            this.tabOngletsApplication.Size = new System.Drawing.Size(883, 900);
            this.tabOngletsApplication.TabIndex = 0;

            // tabLivres
            this.tabLivres.Controls.Add(this.grpLivresExemplaires);
            this.tabLivres.Controls.Add(this.grpLivresInfos);
            this.tabLivres.Controls.Add(this.grpLivresRecherche);
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(875, 874);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.TabLivres_Enter);

            // grpLivresInfos - inchangé, juste repositionné
            this.grpLivresInfos.Controls.Add(this.btnLivresSupprimerDoc);
            this.grpLivresInfos.Controls.Add(this.label59);
            this.grpLivresInfos.Controls.Add(this.btnLivresModifier);
            this.grpLivresInfos.Controls.Add(this.btnLivresAjouter);
            this.grpLivresInfos.Controls.Add(this.txbLivresIsbn);
            this.grpLivresInfos.Controls.Add(this.txbLivresImage);
            this.grpLivresInfos.Controls.Add(this.txbLivresRayon);
            this.grpLivresInfos.Controls.Add(this.txbLivresPublic);
            this.grpLivresInfos.Controls.Add(this.txbLivresGenre);
            this.grpLivresInfos.Controls.Add(this.txbLivresCollection);
            this.grpLivresInfos.Controls.Add(this.txbLivresAuteur);
            this.grpLivresInfos.Controls.Add(this.txbLivresTitre);
            this.grpLivresInfos.Controls.Add(this.txbLivresNumero);
            this.grpLivresInfos.Controls.Add(this.label22);
            this.grpLivresInfos.Controls.Add(this.pcbLivresImage);
            this.grpLivresInfos.Controls.Add(this.label19);
            this.grpLivresInfos.Controls.Add(this.label1);
            this.grpLivresInfos.Controls.Add(this.label10);
            this.grpLivresInfos.Controls.Add(this.label7);
            this.grpLivresInfos.Controls.Add(this.label11);
            this.grpLivresInfos.Controls.Add(this.label8);
            this.grpLivresInfos.Controls.Add(this.label12);
            this.grpLivresInfos.Controls.Add(this.label9);
            this.grpLivresInfos.Location = new System.Drawing.Point(8, 381);
            this.grpLivresInfos.Name = "grpLivresInfos";
            this.grpLivresInfos.Size = new System.Drawing.Size(859, 260);
            this.grpLivresInfos.TabIndex = 19;
            this.grpLivresInfos.TabStop = false;
            this.grpLivresInfos.Text = "Informations détaillées";

            this.btnLivresSupprimerDoc.Location = new System.Drawing.Point(174, 227);
            this.btnLivresSupprimerDoc.Name = "btnLivresSupprimerDoc";
            this.btnLivresSupprimerDoc.Size = new System.Drawing.Size(75, 23);
            this.btnLivresSupprimerDoc.TabIndex = 19;
            this.btnLivresSupprimerDoc.Text = "Supprimer";
            this.btnLivresSupprimerDoc.UseVisualStyleBackColor = true;
            this.btnLivresSupprimerDoc.Click += new System.EventHandler(this.btnLivresSupprimerDoc_Click_1);

            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label59.Location = new System.Drawing.Point(557, 11);
            this.label59.Name = "label59";
            this.label59.Text = "Image :";

            this.btnLivresModifier.Location = new System.Drawing.Point(89, 227);
            this.btnLivresModifier.Name = "btnLivresModifier";
            this.btnLivresModifier.Size = new System.Drawing.Size(75, 23);
            this.btnLivresModifier.TabIndex = 18;
            this.btnLivresModifier.Text = "Modifier";
            this.btnLivresModifier.UseVisualStyleBackColor = true;
            this.btnLivresModifier.Click += new System.EventHandler(this.btnLivresModifier_Click_1);

            this.btnLivresAjouter.Location = new System.Drawing.Point(8, 227);
            this.btnLivresAjouter.Name = "btnLivresAjouter";
            this.btnLivresAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnLivresAjouter.TabIndex = 17;
            this.btnLivresAjouter.Text = "Ajouter";
            this.btnLivresAjouter.UseVisualStyleBackColor = true;
            this.btnLivresAjouter.Click += new System.EventHandler(this.btnLivresAjouter_Click);

            this.txbLivresIsbn.Location = new System.Drawing.Point(441, 20);
            this.txbLivresIsbn.Name = "txbLivresIsbn";
            this.txbLivresIsbn.Size = new System.Drawing.Size(100, 20);
            this.txbLivresIsbn.TabIndex = 32;

            this.txbLivresImage.Location = new System.Drawing.Point(150, 195);
            this.txbLivresImage.Name = "txbLivresImage";
            this.txbLivresImage.Size = new System.Drawing.Size(391, 20);
            this.txbLivresImage.TabIndex = 31;

            this.txbLivresRayon.Location = new System.Drawing.Point(150, 170);
            this.txbLivresRayon.Name = "txbLivresRayon";
            this.txbLivresRayon.ReadOnly = true;
            this.txbLivresRayon.Size = new System.Drawing.Size(207, 20);
            this.txbLivresRayon.TabIndex = 30;

            this.txbLivresPublic.Location = new System.Drawing.Point(150, 145);
            this.txbLivresPublic.Name = "txbLivresPublic";
            this.txbLivresPublic.ReadOnly = true;
            this.txbLivresPublic.Size = new System.Drawing.Size(207, 20);
            this.txbLivresPublic.TabIndex = 29;

            this.txbLivresGenre.Location = new System.Drawing.Point(150, 120);
            this.txbLivresGenre.Name = "txbLivresGenre";
            this.txbLivresGenre.ReadOnly = true;
            this.txbLivresGenre.Size = new System.Drawing.Size(207, 20);
            this.txbLivresGenre.TabIndex = 28;

            this.txbLivresCollection.Location = new System.Drawing.Point(150, 95);
            this.txbLivresCollection.Name = "txbLivresCollection";
            this.txbLivresCollection.Size = new System.Drawing.Size(391, 20);
            this.txbLivresCollection.TabIndex = 27;

            this.txbLivresAuteur.Location = new System.Drawing.Point(150, 70);
            this.txbLivresAuteur.Name = "txbLivresAuteur";
            this.txbLivresAuteur.Size = new System.Drawing.Size(207, 20);
            this.txbLivresAuteur.TabIndex = 26;

            this.txbLivresTitre.Location = new System.Drawing.Point(150, 45);
            this.txbLivresTitre.Name = "txbLivresTitre";
            this.txbLivresTitre.Size = new System.Drawing.Size(391, 20);
            this.txbLivresTitre.TabIndex = 25;

            this.txbLivresNumero.Location = new System.Drawing.Point(150, 20);
            this.txbLivresNumero.Name = "txbLivresNumero";
            this.txbLivresNumero.Size = new System.Drawing.Size(100, 20);
            this.txbLivresNumero.TabIndex = 24;

            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(6, 120);
            this.label22.Name = "label22";
            this.label22.Text = "Genre :";

            this.pcbLivresImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLivresImage.Location = new System.Drawing.Point(560, 27);
            this.pcbLivresImage.Name = "pcbLivresImage";
            this.pcbLivresImage.Size = new System.Drawing.Size(284, 210);
            this.pcbLivresImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLivresImage.TabStop = false;

            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(6, 145);
            this.label19.Text = "Public :";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Text = "Rayon :";

            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Text = "Titre :";

            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Text = "Numéro de document :";

            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Text = "Auteur(e) :";

            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 195);
            this.label8.Text = "Chemin de l\'image :";

            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 95);
            this.label12.Text = "Collection :";

            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(357, 20);
            this.label9.Text = "Code ISBN :";

            // grpLivresRecherche
            this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulRayons);
            this.grpLivresRecherche.Controls.Add(this.btnlivresAnnulPublics);
            this.grpLivresRecherche.Controls.Add(this.btnLivresNumRecherche);
            this.grpLivresRecherche.Controls.Add(this.label5);
            this.grpLivresRecherche.Controls.Add(this.txbLivresNumRecherche);
            this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulGenres);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresRayons);
            this.grpLivresRecherche.Controls.Add(this.label21);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresPublics);
            this.grpLivresRecherche.Controls.Add(this.label20);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresGenres);
            this.grpLivresRecherche.Controls.Add(this.label14);
            this.grpLivresRecherche.Controls.Add(this.dgvLivresListe);
            this.grpLivresRecherche.Controls.Add(this.label6);
            this.grpLivresRecherche.Controls.Add(this.txbLivresTitreRecherche);
            this.grpLivresRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpLivresRecherche.Name = "grpLivresRecherche";
            this.grpLivresRecherche.Size = new System.Drawing.Size(859, 362);
            this.grpLivresRecherche.TabIndex = 18;
            this.grpLivresRecherche.TabStop = false;
            this.grpLivresRecherche.Text = "Recherches";

            this.btnLivresAnnulRayons.Location = new System.Drawing.Point(833, 104);
            this.btnLivresAnnulRayons.Name = "btnLivresAnnulRayons";
            this.btnLivresAnnulRayons.Size = new System.Drawing.Size(22, 22);
            this.btnLivresAnnulRayons.Text = "X";
            this.btnLivresAnnulRayons.UseVisualStyleBackColor = true;
            this.btnLivresAnnulRayons.Click += new System.EventHandler(this.BtnLivresAnnulRayons_Click);

            this.btnlivresAnnulPublics.Location = new System.Drawing.Point(833, 60);
            this.btnlivresAnnulPublics.Name = "btnlivresAnnulPublics";
            this.btnlivresAnnulPublics.Size = new System.Drawing.Size(22, 22);
            this.btnlivresAnnulPublics.Text = "X";
            this.btnlivresAnnulPublics.UseVisualStyleBackColor = true;
            this.btnlivresAnnulPublics.Click += new System.EventHandler(this.BtnLivresAnnulPublics_Click);

            this.btnLivresNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLivresNumRecherche.Location = new System.Drawing.Point(314, 59);
            this.btnLivresNumRecherche.Name = "btnLivresNumRecherche";
            this.btnLivresNumRecherche.Size = new System.Drawing.Size(96, 22);
            this.btnLivresNumRecherche.Text = "Rechercher";
            this.btnLivresNumRecherche.UseVisualStyleBackColor = true;
            this.btnLivresNumRecherche.Click += new System.EventHandler(this.BtnLivresNumRecherche_Click);

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Text = "Saisir un numéro de document :";

            this.txbLivresNumRecherche.Location = new System.Drawing.Point(220, 60);
            this.txbLivresNumRecherche.Name = "txbLivresNumRecherche";
            this.txbLivresNumRecherche.Size = new System.Drawing.Size(67, 20);

            this.btnLivresAnnulGenres.Location = new System.Drawing.Point(833, 17);
            this.btnLivresAnnulGenres.Name = "btnLivresAnnulGenres";
            this.btnLivresAnnulGenres.Size = new System.Drawing.Size(22, 22);
            this.btnLivresAnnulGenres.Text = "X";
            this.btnLivresAnnulGenres.UseVisualStyleBackColor = true;
            this.btnLivresAnnulGenres.Click += new System.EventHandler(this.BtnLivresAnnulGenres_Click);

            this.cbxLivresRayons.FormattingEnabled = true;
            this.cbxLivresRayons.Location = new System.Drawing.Point(620, 105);
            this.cbxLivresRayons.Name = "cbxLivresRayons";
            this.cbxLivresRayons.Size = new System.Drawing.Size(207, 21);
            this.cbxLivresRayons.SelectedIndexChanged += new System.EventHandler(this.CbxLivresRayons_SelectedIndexChanged);

            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(458, 108);
            this.label21.Text = "Ou sélectionner le rayon :";

            this.cbxLivresPublics.FormattingEnabled = true;
            this.cbxLivresPublics.Location = new System.Drawing.Point(620, 60);
            this.cbxLivresPublics.Name = "cbxLivresPublics";
            this.cbxLivresPublics.Size = new System.Drawing.Size(207, 21);
            this.cbxLivresPublics.SelectedIndexChanged += new System.EventHandler(this.CbxLivresPublics_SelectedIndexChanged);

            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(458, 63);
            this.label20.Text = "Ou sélectionner le public :";

            this.cbxLivresGenres.FormattingEnabled = true;
            this.cbxLivresGenres.Location = new System.Drawing.Point(620, 18);
            this.cbxLivresGenres.Name = "cbxLivresGenres";
            this.cbxLivresGenres.Size = new System.Drawing.Size(207, 21);
            this.cbxLivresGenres.SelectedIndexChanged += new System.EventHandler(this.CbxLivresGenres_SelectedIndexChanged);

            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(460, 21);
            this.label14.Text = "Ou sélectionner le genre :";

            this.dgvLivresListe.AllowUserToAddRows = false;
            this.dgvLivresListe.AllowUserToDeleteRows = false;
            this.dgvLivresListe.AllowUserToResizeColumns = false;
            this.dgvLivresListe.AllowUserToResizeRows = false;
            this.dgvLivresListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivresListe.Location = new System.Drawing.Point(15, 156);
            this.dgvLivresListe.MultiSelect = false;
            this.dgvLivresListe.Name = "dgvLivresListe";
            this.dgvLivresListe.ReadOnly = true;
            this.dgvLivresListe.RowHeadersVisible = false;
            this.dgvLivresListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivresListe.Size = new System.Drawing.Size(844, 200);
            this.dgvLivresListe.TabIndex = 4;
            this.dgvLivresListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLivresListe_ColumnHeaderMouseClick);
            this.dgvLivresListe.SelectionChanged += new System.EventHandler(this.DgvLivresListe_SelectionChanged);

            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Text = "Saisir le titre ou la partie d\'un titre :";

            this.txbLivresTitreRecherche.Location = new System.Drawing.Point(220, 18);
            this.txbLivresTitreRecherche.Name = "txbLivresTitreRecherche";
            this.txbLivresTitreRecherche.Size = new System.Drawing.Size(190, 20);
            this.txbLivresTitreRecherche.TextChanged += new System.EventHandler(this.TxbLivresTitreRecherche_TextChanged);

            // grpLivresExemplaires
            this.grpLivresExemplaires.Controls.Add(this.dgvLivresExemplaires);
            this.grpLivresExemplaires.Controls.Add(this.labelLivresEtat);
            this.grpLivresExemplaires.Controls.Add(this.cbxLivresEtat);
            this.grpLivresExemplaires.Controls.Add(this.btnLivresModifierEtat);
            this.grpLivresExemplaires.Controls.Add(this.btnLivresSupprimerExemplaire);
            this.grpLivresExemplaires.Location = new System.Drawing.Point(8, 648);
            this.grpLivresExemplaires.Name = "grpLivresExemplaires";
            this.grpLivresExemplaires.Size = new System.Drawing.Size(859, 210);
            this.grpLivresExemplaires.TabIndex = 20;
            this.grpLivresExemplaires.TabStop = false;
            this.grpLivresExemplaires.Text = "Exemplaires du livre sélectionné";

            this.dgvLivresExemplaires.AllowUserToAddRows = false;
            this.dgvLivresExemplaires.AllowUserToDeleteRows = false;
            this.dgvLivresExemplaires.AllowUserToResizeColumns = false;
            this.dgvLivresExemplaires.AllowUserToResizeRows = false;
            this.dgvLivresExemplaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivresExemplaires.Location = new System.Drawing.Point(8, 20);
            this.dgvLivresExemplaires.MultiSelect = false;
            this.dgvLivresExemplaires.Name = "dgvLivresExemplaires";
            this.dgvLivresExemplaires.ReadOnly = true;
            this.dgvLivresExemplaires.RowHeadersVisible = false;
            this.dgvLivresExemplaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivresExemplaires.Size = new System.Drawing.Size(600, 170);
            this.dgvLivresExemplaires.TabIndex = 0;
            this.dgvLivresExemplaires.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLivresExemplaires_ColumnHeaderMouseClick);
            this.dgvLivresExemplaires.SelectionChanged += new System.EventHandler(this.dgvLivresExemplaires_SelectionChanged);

            this.labelLivresEtat.AutoSize = true;
            this.labelLivresEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelLivresEtat.Location = new System.Drawing.Point(620, 25);
            this.labelLivresEtat.Name = "labelLivresEtat";
            this.labelLivresEtat.Text = "État :";

            this.cbxLivresEtat.FormattingEnabled = true;
            this.cbxLivresEtat.Location = new System.Drawing.Point(660, 22);
            this.cbxLivresEtat.Name = "cbxLivresEtat";
            this.cbxLivresEtat.Size = new System.Drawing.Size(180, 21);
            this.cbxLivresEtat.TabIndex = 1;

            this.btnLivresModifierEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLivresModifierEtat.Location = new System.Drawing.Point(620, 60);
            this.btnLivresModifierEtat.Name = "btnLivresModifierEtat";
            this.btnLivresModifierEtat.Size = new System.Drawing.Size(220, 23);
            this.btnLivresModifierEtat.TabIndex = 2;
            this.btnLivresModifierEtat.Text = "Modifier l\'état";
            this.btnLivresModifierEtat.UseVisualStyleBackColor = true;
            this.btnLivresModifierEtat.Click += new System.EventHandler(this.btnLivresModifierEtat_Click);

            this.btnLivresSupprimerExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLivresSupprimerExemplaire.Location = new System.Drawing.Point(620, 93);
            this.btnLivresSupprimerExemplaire.Name = "btnLivresSupprimerExemplaire";
            this.btnLivresSupprimerExemplaire.Size = new System.Drawing.Size(220, 23);
            this.btnLivresSupprimerExemplaire.TabIndex = 3;
            this.btnLivresSupprimerExemplaire.Text = "Supprimer exemplaire";
            this.btnLivresSupprimerExemplaire.UseVisualStyleBackColor = true;
            this.btnLivresSupprimerExemplaire.Click += new System.EventHandler(this.btnLivresSupprimerExemplaire_Click);

            // tabDvd
            this.tabDvd.Controls.Add(this.grpDvdExemplaires);
            this.tabDvd.Controls.Add(this.grpDvdInfos);
            this.tabDvd.Controls.Add(this.grpDvdRecherche);
            this.tabDvd.Location = new System.Drawing.Point(4, 22);
            this.tabDvd.Name = "tabDvd";
            this.tabDvd.Size = new System.Drawing.Size(875, 874);
            this.tabDvd.TabIndex = 3;
            this.tabDvd.Text = "DVD";
            this.tabDvd.UseVisualStyleBackColor = true;
            this.tabDvd.Enter += new System.EventHandler(this.tabDvd_Enter);

            this.grpDvdInfos.Controls.Add(this.btnDvdSupprimerDoc);
            this.grpDvdInfos.Controls.Add(this.btnDvdModifier);
            this.grpDvdInfos.Controls.Add(this.btnDvdAjouter);
            this.grpDvdInfos.Controls.Add(this.label58);
            this.grpDvdInfos.Controls.Add(this.txbDvdDuree);
            this.grpDvdInfos.Controls.Add(this.txbDvdImage);
            this.grpDvdInfos.Controls.Add(this.txbDvdRayon);
            this.grpDvdInfos.Controls.Add(this.txbDvdPublic);
            this.grpDvdInfos.Controls.Add(this.txbDvdGenre);
            this.grpDvdInfos.Controls.Add(this.txbDvdSynopsis);
            this.grpDvdInfos.Controls.Add(this.txbDvdRealisateur);
            this.grpDvdInfos.Controls.Add(this.txbDvdTitre);
            this.grpDvdInfos.Controls.Add(this.txbDvdNumero);
            this.grpDvdInfos.Controls.Add(this.label23);
            this.grpDvdInfos.Controls.Add(this.pcbDvdImage);
            this.grpDvdInfos.Controls.Add(this.label24);
            this.grpDvdInfos.Controls.Add(this.label25);
            this.grpDvdInfos.Controls.Add(this.label26);
            this.grpDvdInfos.Controls.Add(this.label27);
            this.grpDvdInfos.Controls.Add(this.label28);
            this.grpDvdInfos.Controls.Add(this.label29);
            this.grpDvdInfos.Controls.Add(this.label30);
            this.grpDvdInfos.Controls.Add(this.label31);
            this.grpDvdInfos.Location = new System.Drawing.Point(8, 381);
            this.grpDvdInfos.Name = "grpDvdInfos";
            this.grpDvdInfos.Size = new System.Drawing.Size(859, 271);
            this.grpDvdInfos.TabIndex = 21;
            this.grpDvdInfos.TabStop = false;
            this.grpDvdInfos.Text = "Informations détaillées";

            this.btnDvdSupprimerDoc.Location = new System.Drawing.Point(171, 242);
            this.btnDvdSupprimerDoc.Name = "btnDvdSupprimerDoc";
            this.btnDvdSupprimerDoc.Size = new System.Drawing.Size(75, 23);
            this.btnDvdSupprimerDoc.Text = "Supprimer";
            this.btnDvdSupprimerDoc.UseVisualStyleBackColor = true;
            this.btnDvdSupprimerDoc.Click += new System.EventHandler(this.btnDvdSupprimerDoc_Click_1);

            this.btnDvdModifier.Location = new System.Drawing.Point(90, 242);
            this.btnDvdModifier.Name = "btnDvdModifier";
            this.btnDvdModifier.Size = new System.Drawing.Size(75, 23);
            this.btnDvdModifier.Text = "Modifier";
            this.btnDvdModifier.UseVisualStyleBackColor = true;
            this.btnDvdModifier.Click += new System.EventHandler(this.btnDvdModifier_Click_1);

            this.btnDvdAjouter.Location = new System.Drawing.Point(9, 242);
            this.btnDvdAjouter.Name = "btnDvdAjouter";
            this.btnDvdAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnDvdAjouter.Text = "Ajouter";
            this.btnDvdAjouter.UseVisualStyleBackColor = true;
            this.btnDvdAjouter.Click += new System.EventHandler(this.btnDvdAjouter_Click_1);

            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label58.Location = new System.Drawing.Point(557, 11);
            this.label58.Text = "Image :";

            this.txbDvdDuree.Location = new System.Drawing.Point(441, 20);
            this.txbDvdDuree.Name = "txbDvdDuree";
            this.txbDvdDuree.Size = new System.Drawing.Size(100, 20);

            this.txbDvdImage.Location = new System.Drawing.Point(150, 215);
            this.txbDvdImage.Name = "txbDvdImage";
            this.txbDvdImage.Size = new System.Drawing.Size(391, 20);

            this.txbDvdRayon.Location = new System.Drawing.Point(150, 190);
            this.txbDvdRayon.Name = "txbDvdRayon";
            this.txbDvdRayon.ReadOnly = true;
            this.txbDvdRayon.Size = new System.Drawing.Size(207, 20);

            this.txbDvdPublic.Location = new System.Drawing.Point(150, 165);
            this.txbDvdPublic.Name = "txbDvdPublic";
            this.txbDvdPublic.ReadOnly = true;
            this.txbDvdPublic.Size = new System.Drawing.Size(207, 20);

            this.txbDvdGenre.Location = new System.Drawing.Point(150, 140);
            this.txbDvdGenre.Name = "txbDvdGenre";
            this.txbDvdGenre.ReadOnly = true;
            this.txbDvdGenre.Size = new System.Drawing.Size(207, 20);

            this.txbDvdSynopsis.AcceptsReturn = true;
            this.txbDvdSynopsis.Location = new System.Drawing.Point(150, 95);
            this.txbDvdSynopsis.Multiline = true;
            this.txbDvdSynopsis.Name = "txbDvdSynopsis";
            this.txbDvdSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDvdSynopsis.Size = new System.Drawing.Size(391, 39);

            this.txbDvdRealisateur.Location = new System.Drawing.Point(150, 70);
            this.txbDvdRealisateur.Name = "txbDvdRealisateur";
            this.txbDvdRealisateur.Size = new System.Drawing.Size(207, 20);

            this.txbDvdTitre.Location = new System.Drawing.Point(150, 45);
            this.txbDvdTitre.Name = "txbDvdTitre";
            this.txbDvdTitre.Size = new System.Drawing.Size(391, 20);

            this.txbDvdNumero.Location = new System.Drawing.Point(150, 20);
            this.txbDvdNumero.Name = "txbDvdNumero";
            this.txbDvdNumero.Size = new System.Drawing.Size(100, 20);

            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(6, 140);
            this.label23.Text = "Genre :";

            this.pcbDvdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbDvdImage.Location = new System.Drawing.Point(560, 27);
            this.pcbDvdImage.Name = "pcbDvdImage";
            this.pcbDvdImage.Size = new System.Drawing.Size(284, 210);
            this.pcbDvdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDvdImage.TabStop = false;

            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(6, 165);
            this.label24.Text = "Public :";

            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(6, 190);
            this.label25.Text = "Rayon :";

            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(6, 45);
            this.label26.Text = "Titre :";

            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(6, 20);
            this.label27.Text = "Numéro de document :";

            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(6, 70);
            this.label28.Text = "Réalisateur(trice) :";

            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(6, 215);
            this.label29.Text = "Chemin de l\'image :";

            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(6, 95);
            this.label30.Text = "Synopsis :";

            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(357, 20);
            this.label31.Text = "Durée :";

            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulRayons);
            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulPublics);
            this.grpDvdRecherche.Controls.Add(this.btnDvdNumRecherche);
            this.grpDvdRecherche.Controls.Add(this.label38);
            this.grpDvdRecherche.Controls.Add(this.txbDvdNumRecherche);
            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulGenres);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdRayons);
            this.grpDvdRecherche.Controls.Add(this.label39);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdPublics);
            this.grpDvdRecherche.Controls.Add(this.label40);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdGenres);
            this.grpDvdRecherche.Controls.Add(this.label41);
            this.grpDvdRecherche.Controls.Add(this.dgvDvdListe);
            this.grpDvdRecherche.Controls.Add(this.label42);
            this.grpDvdRecherche.Controls.Add(this.txbDvdTitreRecherche);
            this.grpDvdRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpDvdRecherche.Name = "grpDvdRecherche";
            this.grpDvdRecherche.Size = new System.Drawing.Size(859, 362);
            this.grpDvdRecherche.TabIndex = 20;
            this.grpDvdRecherche.TabStop = false;
            this.grpDvdRecherche.Text = "Recherches";

            this.btnDvdAnnulRayons.Location = new System.Drawing.Point(833, 104);
            this.btnDvdAnnulRayons.Name = "btnDvdAnnulRayons";
            this.btnDvdAnnulRayons.Size = new System.Drawing.Size(22, 22);
            this.btnDvdAnnulRayons.Text = "X";
            this.btnDvdAnnulRayons.UseVisualStyleBackColor = true;
            this.btnDvdAnnulRayons.Click += new System.EventHandler(this.btnDvdAnnulRayons_Click);

            this.btnDvdAnnulPublics.Location = new System.Drawing.Point(833, 60);
            this.btnDvdAnnulPublics.Name = "btnDvdAnnulPublics";
            this.btnDvdAnnulPublics.Size = new System.Drawing.Size(22, 22);
            this.btnDvdAnnulPublics.Text = "X";
            this.btnDvdAnnulPublics.UseVisualStyleBackColor = true;
            this.btnDvdAnnulPublics.Click += new System.EventHandler(this.btnDvdAnnulPublics_Click);

            this.btnDvdNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDvdNumRecherche.Location = new System.Drawing.Point(314, 59);
            this.btnDvdNumRecherche.Name = "btnDvdNumRecherche";
            this.btnDvdNumRecherche.Size = new System.Drawing.Size(96, 22);
            this.btnDvdNumRecherche.Text = "Rechercher";
            this.btnDvdNumRecherche.UseVisualStyleBackColor = true;
            this.btnDvdNumRecherche.Click += new System.EventHandler(this.btnDvdNumRecherche_Click);

            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label38.Location = new System.Drawing.Point(6, 63);
            this.label38.Text = "Saisir un numéro de document :";

            this.txbDvdNumRecherche.Location = new System.Drawing.Point(220, 60);
            this.txbDvdNumRecherche.Name = "txbDvdNumRecherche";
            this.txbDvdNumRecherche.Size = new System.Drawing.Size(67, 20);

            this.btnDvdAnnulGenres.Location = new System.Drawing.Point(833, 17);
            this.btnDvdAnnulGenres.Name = "btnDvdAnnulGenres";
            this.btnDvdAnnulGenres.Size = new System.Drawing.Size(22, 22);
            this.btnDvdAnnulGenres.Text = "X";
            this.btnDvdAnnulGenres.UseVisualStyleBackColor = true;
            this.btnDvdAnnulGenres.Click += new System.EventHandler(this.btnDvdAnnulGenres_Click);

            this.cbxDvdRayons.FormattingEnabled = true;
            this.cbxDvdRayons.Location = new System.Drawing.Point(620, 105);
            this.cbxDvdRayons.Name = "cbxDvdRayons";
            this.cbxDvdRayons.Size = new System.Drawing.Size(207, 21);
            this.cbxDvdRayons.SelectedIndexChanged += new System.EventHandler(this.cbxDvdRayons_SelectedIndexChanged);

            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label39.Location = new System.Drawing.Point(458, 108);
            this.label39.Text = "Ou sélectionner le rayon :";

            this.cbxDvdPublics.FormattingEnabled = true;
            this.cbxDvdPublics.Location = new System.Drawing.Point(620, 60);
            this.cbxDvdPublics.Name = "cbxDvdPublics";
            this.cbxDvdPublics.Size = new System.Drawing.Size(207, 21);
            this.cbxDvdPublics.SelectedIndexChanged += new System.EventHandler(this.cbxDvdPublics_SelectedIndexChanged);

            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label40.Location = new System.Drawing.Point(458, 63);
            this.label40.Text = "Ou sélectionner le public :";

            this.cbxDvdGenres.FormattingEnabled = true;
            this.cbxDvdGenres.Location = new System.Drawing.Point(620, 18);
            this.cbxDvdGenres.Name = "cbxDvdGenres";
            this.cbxDvdGenres.Size = new System.Drawing.Size(207, 21);
            this.cbxDvdGenres.SelectedIndexChanged += new System.EventHandler(this.cbxDvdGenres_SelectedIndexChanged);

            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label41.Location = new System.Drawing.Point(460, 21);
            this.label41.Text = "Ou sélectionner le genre :";

            this.dgvDvdListe.AllowUserToAddRows = false;
            this.dgvDvdListe.AllowUserToDeleteRows = false;
            this.dgvDvdListe.AllowUserToResizeColumns = false;
            this.dgvDvdListe.AllowUserToResizeRows = false;
            this.dgvDvdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvdListe.Location = new System.Drawing.Point(9, 150);
            this.dgvDvdListe.MultiSelect = false;
            this.dgvDvdListe.Name = "dgvDvdListe";
            this.dgvDvdListe.ReadOnly = true;
            this.dgvDvdListe.RowHeadersVisible = false;
            this.dgvDvdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDvdListe.Size = new System.Drawing.Size(844, 200);
            this.dgvDvdListe.TabIndex = 4;
            this.dgvDvdListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDvdListe_ColumnHeaderMouseClick);
            this.dgvDvdListe.SelectionChanged += new System.EventHandler(this.dgvDvdListe_SelectionChanged);

            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label42.Location = new System.Drawing.Point(6, 21);
            this.label42.Text = "Saisir le titre ou la partie d\'un titre :";

            this.txbDvdTitreRecherche.Location = new System.Drawing.Point(220, 18);
            this.txbDvdTitreRecherche.Name = "txbDvdTitreRecherche";
            this.txbDvdTitreRecherche.Size = new System.Drawing.Size(190, 20);
            this.txbDvdTitreRecherche.TextChanged += new System.EventHandler(this.txbDvdTitreRecherche_TextChanged);

            // grpDvdExemplaires
            this.grpDvdExemplaires.Controls.Add(this.dgvDvdExemplaires);
            this.grpDvdExemplaires.Controls.Add(this.labelDvdEtat);
            this.grpDvdExemplaires.Controls.Add(this.cbxDvdEtat);
            this.grpDvdExemplaires.Controls.Add(this.btnDvdModifierEtat);
            this.grpDvdExemplaires.Controls.Add(this.btnDvdSupprimerExemplaire);
            this.grpDvdExemplaires.Location = new System.Drawing.Point(8, 658);
            this.grpDvdExemplaires.Name = "grpDvdExemplaires";
            this.grpDvdExemplaires.Size = new System.Drawing.Size(859, 210);
            this.grpDvdExemplaires.TabIndex = 22;
            this.grpDvdExemplaires.TabStop = false;
            this.grpDvdExemplaires.Text = "Exemplaires du DVD sélectionné";

            this.dgvDvdExemplaires.AllowUserToAddRows = false;
            this.dgvDvdExemplaires.AllowUserToDeleteRows = false;
            this.dgvDvdExemplaires.AllowUserToResizeColumns = false;
            this.dgvDvdExemplaires.AllowUserToResizeRows = false;
            this.dgvDvdExemplaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvdExemplaires.Location = new System.Drawing.Point(8, 20);
            this.dgvDvdExemplaires.MultiSelect = false;
            this.dgvDvdExemplaires.Name = "dgvDvdExemplaires";
            this.dgvDvdExemplaires.ReadOnly = true;
            this.dgvDvdExemplaires.RowHeadersVisible = false;
            this.dgvDvdExemplaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDvdExemplaires.Size = new System.Drawing.Size(600, 170);
            this.dgvDvdExemplaires.TabIndex = 0;
            this.dgvDvdExemplaires.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDvdExemplaires_ColumnHeaderMouseClick);
            this.dgvDvdExemplaires.SelectionChanged += new System.EventHandler(this.dgvDvdExemplaires_SelectionChanged);

            this.labelDvdEtat.AutoSize = true;
            this.labelDvdEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelDvdEtat.Location = new System.Drawing.Point(620, 25);
            this.labelDvdEtat.Name = "labelDvdEtat";
            this.labelDvdEtat.Text = "État :";

            this.cbxDvdEtat.FormattingEnabled = true;
            this.cbxDvdEtat.Location = new System.Drawing.Point(660, 22);
            this.cbxDvdEtat.Name = "cbxDvdEtat";
            this.cbxDvdEtat.Size = new System.Drawing.Size(180, 21);
            this.cbxDvdEtat.TabIndex = 1;

            this.btnDvdModifierEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDvdModifierEtat.Location = new System.Drawing.Point(620, 60);
            this.btnDvdModifierEtat.Name = "btnDvdModifierEtat";
            this.btnDvdModifierEtat.Size = new System.Drawing.Size(220, 23);
            this.btnDvdModifierEtat.TabIndex = 2;
            this.btnDvdModifierEtat.Text = "Modifier l\'état";
            this.btnDvdModifierEtat.UseVisualStyleBackColor = true;
            this.btnDvdModifierEtat.Click += new System.EventHandler(this.btnDvdModifierEtat_Click);

            this.btnDvdSupprimerExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDvdSupprimerExemplaire.Location = new System.Drawing.Point(620, 93);
            this.btnDvdSupprimerExemplaire.Name = "btnDvdSupprimerExemplaire";
            this.btnDvdSupprimerExemplaire.Size = new System.Drawing.Size(220, 23);
            this.btnDvdSupprimerExemplaire.TabIndex = 3;
            this.btnDvdSupprimerExemplaire.Text = "Supprimer exemplaire";
            this.btnDvdSupprimerExemplaire.UseVisualStyleBackColor = true;
            this.btnDvdSupprimerExemplaire.Click += new System.EventHandler(this.btnDvdSupprimerExemplaire_Click);

            // tabRevues - inchangé
            this.tabRevues.Controls.Add(this.grpRevuesInfos);
            this.tabRevues.Controls.Add(this.grpRevuesRecherche);
            this.tabRevues.Location = new System.Drawing.Point(4, 22);
            this.tabRevues.Name = "tabRevues";
            this.tabRevues.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevues.Size = new System.Drawing.Size(875, 874);
            this.tabRevues.TabIndex = 1;
            this.tabRevues.Text = "Revues";
            this.tabRevues.UseVisualStyleBackColor = true;
            this.tabRevues.Enter += new System.EventHandler(this.tabRevues_Enter);

            this.grpRevuesInfos.Controls.Add(this.btnRevuesSupprimerDoc);
            this.grpRevuesInfos.Controls.Add(this.btnRevuesModifier);
            this.grpRevuesInfos.Controls.Add(this.btnRevuesAjouter);
            this.grpRevuesInfos.Controls.Add(this.label57);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesImage);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesRayon);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesPublic);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesGenre);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesDateMiseADispo);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesPeriodicite);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesTitre);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesNumero);
            this.grpRevuesInfos.Controls.Add(this.label35);
            this.grpRevuesInfos.Controls.Add(this.pcbRevuesImage);
            this.grpRevuesInfos.Controls.Add(this.label36);
            this.grpRevuesInfos.Controls.Add(this.label37);
            this.grpRevuesInfos.Controls.Add(this.label43);
            this.grpRevuesInfos.Controls.Add(this.label44);
            this.grpRevuesInfos.Controls.Add(this.label45);
            this.grpRevuesInfos.Controls.Add(this.label46);
            this.grpRevuesInfos.Controls.Add(this.label47);
            this.grpRevuesInfos.Location = new System.Drawing.Point(8, 381);
            this.grpRevuesInfos.Name = "grpRevuesInfos";
            this.grpRevuesInfos.Size = new System.Drawing.Size(859, 254);
            this.grpRevuesInfos.TabIndex = 20;
            this.grpRevuesInfos.TabStop = false;
            this.grpRevuesInfos.Text = "Informations détaillées";

            this.btnRevuesSupprimerDoc.Location = new System.Drawing.Point(169, 223);
            this.btnRevuesSupprimerDoc.Name = "btnRevuesSupprimerDoc";
            this.btnRevuesSupprimerDoc.Size = new System.Drawing.Size(75, 23);
            this.btnRevuesSupprimerDoc.Text = "Supprimer";
            this.btnRevuesSupprimerDoc.UseVisualStyleBackColor = true;
            this.btnRevuesSupprimerDoc.Click += new System.EventHandler(this.btnRevuesSupprimerDoc_Click_1);

            this.btnRevuesModifier.Location = new System.Drawing.Point(88, 223);
            this.btnRevuesModifier.Name = "btnRevuesModifier";
            this.btnRevuesModifier.Size = new System.Drawing.Size(75, 23);
            this.btnRevuesModifier.Text = "Modifier";
            this.btnRevuesModifier.UseVisualStyleBackColor = true;
            this.btnRevuesModifier.Click += new System.EventHandler(this.btnRevuesModifier_Click_1);

            this.btnRevuesAjouter.Location = new System.Drawing.Point(7, 223);
            this.btnRevuesAjouter.Name = "btnRevuesAjouter";
            this.btnRevuesAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnRevuesAjouter.Text = "Ajouter";
            this.btnRevuesAjouter.UseVisualStyleBackColor = true;
            this.btnRevuesAjouter.Click += new System.EventHandler(this.btnRevuesAjouter_Click_1);

            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label57.Location = new System.Drawing.Point(557, 11);
            this.label57.Text = "Image :";

            this.txbRevuesImage.Location = new System.Drawing.Point(150, 195);
            this.txbRevuesImage.Name = "txbRevuesImage";
            this.txbRevuesImage.Size = new System.Drawing.Size(391, 20);

            this.txbRevuesRayon.Location = new System.Drawing.Point(150, 170);
            this.txbRevuesRayon.Name = "txbRevuesRayon";
            this.txbRevuesRayon.ReadOnly = true;
            this.txbRevuesRayon.Size = new System.Drawing.Size(207, 20);

            this.txbRevuesPublic.Location = new System.Drawing.Point(150, 145);
            this.txbRevuesPublic.Name = "txbRevuesPublic";
            this.txbRevuesPublic.ReadOnly = true;
            this.txbRevuesPublic.Size = new System.Drawing.Size(207, 20);

            this.txbRevuesGenre.Location = new System.Drawing.Point(150, 120);
            this.txbRevuesGenre.Name = "txbRevuesGenre";
            this.txbRevuesGenre.ReadOnly = true;
            this.txbRevuesGenre.Size = new System.Drawing.Size(207, 20);

            this.txbRevuesDateMiseADispo.Location = new System.Drawing.Point(150, 95);
            this.txbRevuesDateMiseADispo.Name = "txbRevuesDateMiseADispo";
            this.txbRevuesDateMiseADispo.Size = new System.Drawing.Size(100, 20);

            this.txbRevuesPeriodicite.Location = new System.Drawing.Point(150, 70);
            this.txbRevuesPeriodicite.Name = "txbRevuesPeriodicite";
            this.txbRevuesPeriodicite.Size = new System.Drawing.Size(100, 20);

            this.txbRevuesTitre.Location = new System.Drawing.Point(150, 45);
            this.txbRevuesTitre.Name = "txbRevuesTitre";
            this.txbRevuesTitre.Size = new System.Drawing.Size(391, 20);

            this.txbRevuesNumero.Location = new System.Drawing.Point(150, 20);
            this.txbRevuesNumero.Name = "txbRevuesNumero";
            this.txbRevuesNumero.Size = new System.Drawing.Size(100, 20);

            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(6, 120);
            this.label35.Text = "Genre :";

            this.pcbRevuesImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRevuesImage.Location = new System.Drawing.Point(560, 27);
            this.pcbRevuesImage.Name = "pcbRevuesImage";
            this.pcbRevuesImage.Size = new System.Drawing.Size(284, 210);
            this.pcbRevuesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRevuesImage.TabStop = false;

            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label36.Location = new System.Drawing.Point(6, 145);
            this.label36.Text = "Public :";

            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label37.Location = new System.Drawing.Point(6, 170);
            this.label37.Text = "Rayon :";

            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label43.Location = new System.Drawing.Point(6, 45);
            this.label43.Text = "Titre :";

            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label44.Location = new System.Drawing.Point(6, 20);
            this.label44.Text = "Numéro de document :";

            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label45.Location = new System.Drawing.Point(6, 70);
            this.label45.Text = "Périodicité :";

            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label46.Location = new System.Drawing.Point(6, 195);
            this.label46.Text = "Chemin de l\'image :";

            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label47.Location = new System.Drawing.Point(6, 95);
            this.label47.Text = "Délai mise à dispo :";

            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulRayons);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulPublics);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesNumRecherche);
            this.grpRevuesRecherche.Controls.Add(this.label2);
            this.grpRevuesRecherche.Controls.Add(this.txbRevuesNumRecherche);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulGenres);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesRayons);
            this.grpRevuesRecherche.Controls.Add(this.label4);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesPublics);
            this.grpRevuesRecherche.Controls.Add(this.label32);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesGenres);
            this.grpRevuesRecherche.Controls.Add(this.label33);
            this.grpRevuesRecherche.Controls.Add(this.dgvRevuesListe);
            this.grpRevuesRecherche.Controls.Add(this.label34);
            this.grpRevuesRecherche.Controls.Add(this.txbRevuesTitreRecherche);
            this.grpRevuesRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpRevuesRecherche.Name = "grpRevuesRecherche";
            this.grpRevuesRecherche.Size = new System.Drawing.Size(859, 362);
            this.grpRevuesRecherche.TabIndex = 19;
            this.grpRevuesRecherche.TabStop = false;
            this.grpRevuesRecherche.Text = "Recherches";

            this.btnRevuesAnnulRayons.Location = new System.Drawing.Point(833, 104);
            this.btnRevuesAnnulRayons.Name = "btnRevuesAnnulRayons";
            this.btnRevuesAnnulRayons.Size = new System.Drawing.Size(22, 22);
            this.btnRevuesAnnulRayons.Text = "X";
            this.btnRevuesAnnulRayons.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulRayons.Click += new System.EventHandler(this.btnRevuesAnnulRayons_Click);

            this.btnRevuesAnnulPublics.Location = new System.Drawing.Point(833, 60);
            this.btnRevuesAnnulPublics.Name = "btnRevuesAnnulPublics";
            this.btnRevuesAnnulPublics.Size = new System.Drawing.Size(22, 22);
            this.btnRevuesAnnulPublics.Text = "X";
            this.btnRevuesAnnulPublics.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulPublics.Click += new System.EventHandler(this.btnRevuesAnnulPublics_Click);

            this.btnRevuesNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRevuesNumRecherche.Location = new System.Drawing.Point(314, 59);
            this.btnRevuesNumRecherche.Name = "btnRevuesNumRecherche";
            this.btnRevuesNumRecherche.Size = new System.Drawing.Size(96, 22);
            this.btnRevuesNumRecherche.Text = "Rechercher";
            this.btnRevuesNumRecherche.UseVisualStyleBackColor = true;
            this.btnRevuesNumRecherche.Click += new System.EventHandler(this.btnRevuesNumRecherche_Click);

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Text = "Saisir un numéro de document :";

            this.txbRevuesNumRecherche.Location = new System.Drawing.Point(220, 60);
            this.txbRevuesNumRecherche.Name = "txbRevuesNumRecherche";
            this.txbRevuesNumRecherche.Size = new System.Drawing.Size(67, 20);

            this.btnRevuesAnnulGenres.Location = new System.Drawing.Point(833, 17);
            this.btnRevuesAnnulGenres.Name = "btnRevuesAnnulGenres";
            this.btnRevuesAnnulGenres.Size = new System.Drawing.Size(22, 22);
            this.btnRevuesAnnulGenres.Text = "X";
            this.btnRevuesAnnulGenres.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulGenres.Click += new System.EventHandler(this.btnRevuesAnnulGenres_Click);

            this.cbxRevuesRayons.FormattingEnabled = true;
            this.cbxRevuesRayons.Location = new System.Drawing.Point(620, 105);
            this.cbxRevuesRayons.Name = "cbxRevuesRayons";
            this.cbxRevuesRayons.Size = new System.Drawing.Size(207, 21);
            this.cbxRevuesRayons.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesRayons_SelectedIndexChanged);

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(458, 108);
            this.label4.Text = "Ou sélectionner le rayon :";

            this.cbxRevuesPublics.FormattingEnabled = true;
            this.cbxRevuesPublics.Location = new System.Drawing.Point(620, 60);
            this.cbxRevuesPublics.Name = "cbxRevuesPublics";
            this.cbxRevuesPublics.Size = new System.Drawing.Size(207, 21);
            this.cbxRevuesPublics.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesPublics_SelectedIndexChanged);

            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(458, 63);
            this.label32.Text = "Ou sélectionner le public :";

            this.cbxRevuesGenres.FormattingEnabled = true;
            this.cbxRevuesGenres.Location = new System.Drawing.Point(620, 18);
            this.cbxRevuesGenres.Name = "cbxRevuesGenres";
            this.cbxRevuesGenres.Size = new System.Drawing.Size(207, 21);
            this.cbxRevuesGenres.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesGenres_SelectedIndexChanged);

            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(460, 21);
            this.label33.Text = "Ou sélectionner le genre :";

            this.dgvRevuesListe.AllowUserToAddRows = false;
            this.dgvRevuesListe.AllowUserToDeleteRows = false;
            this.dgvRevuesListe.AllowUserToResizeColumns = false;
            this.dgvRevuesListe.AllowUserToResizeRows = false;
            this.dgvRevuesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevuesListe.Location = new System.Drawing.Point(9, 150);
            this.dgvRevuesListe.MultiSelect = false;
            this.dgvRevuesListe.Name = "dgvRevuesListe";
            this.dgvRevuesListe.ReadOnly = true;
            this.dgvRevuesListe.RowHeadersVisible = false;
            this.dgvRevuesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevuesListe.Size = new System.Drawing.Size(844, 200);
            this.dgvRevuesListe.TabIndex = 4;
            this.dgvRevuesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRevuesListe_ColumnHeaderMouseClick);
            this.dgvRevuesListe.SelectionChanged += new System.EventHandler(this.dgvRevuesListe_SelectionChanged);

            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(6, 21);
            this.label34.Text = "Saisir le titre ou la partie d\'un titre :";

            this.txbRevuesTitreRecherche.Location = new System.Drawing.Point(220, 18);
            this.txbRevuesTitreRecherche.Name = "txbRevuesTitreRecherche";
            this.txbRevuesTitreRecherche.Size = new System.Drawing.Size(190, 20);
            this.txbRevuesTitreRecherche.TextChanged += new System.EventHandler(this.txbRevuesTitreRecherche_TextChanged);

            // tabReceptionRevue
            this.tabReceptionRevue.Controls.Add(this.grpReceptionExemplaire);
            this.tabReceptionRevue.Controls.Add(this.grpReceptionRevue);
            this.tabReceptionRevue.Location = new System.Drawing.Point(4, 22);
            this.tabReceptionRevue.Name = "tabReceptionRevue";
            this.tabReceptionRevue.Size = new System.Drawing.Size(875, 874);
            this.tabReceptionRevue.TabIndex = 4;
            this.tabReceptionRevue.Text = "Parutions des revues";
            this.tabReceptionRevue.UseVisualStyleBackColor = true;
            this.tabReceptionRevue.Enter += new System.EventHandler(this.tabReceptionRevue_Enter);

            this.grpReceptionExemplaire.Controls.Add(this.label55);
            this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.pcbReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireValider);
            this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.label18);
            this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireNumero);
            this.grpReceptionExemplaire.Controls.Add(this.label17);
            this.grpReceptionExemplaire.Controls.Add(this.dtpReceptionExemplaireDate);
            this.grpReceptionExemplaire.Controls.Add(this.label16);
            this.grpReceptionExemplaire.Location = new System.Drawing.Point(8, 420);
            this.grpReceptionExemplaire.Name = "grpReceptionExemplaire";
            this.grpReceptionExemplaire.Size = new System.Drawing.Size(859, 130);
            this.grpReceptionExemplaire.TabIndex = 16;
            this.grpReceptionExemplaire.TabStop = false;
            this.grpReceptionExemplaire.Text = "Nouvelle parution réceptionnée pour cette revue";

            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label55.Location = new System.Drawing.Point(557, 10);
            this.label55.Text = "Image exemplaire :";

            this.btnReceptionExemplaireImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReceptionExemplaireImage.Location = new System.Drawing.Point(446, 69);
            this.btnReceptionExemplaireImage.Name = "btnReceptionExemplaireImage";
            this.btnReceptionExemplaireImage.Size = new System.Drawing.Size(96, 22);
            this.btnReceptionExemplaireImage.Text = "Rechercher";
            this.btnReceptionExemplaireImage.UseVisualStyleBackColor = true;
            this.btnReceptionExemplaireImage.Click += new System.EventHandler(this.btnReceptionExemplaireImage_Click);

            this.pcbReceptionExemplaireImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionExemplaireImage.Location = new System.Drawing.Point(660, 10);
            this.pcbReceptionExemplaireImage.Name = "pcbReceptionExemplaireImage";
            this.pcbReceptionExemplaireImage.Size = new System.Drawing.Size(100, 100);
            this.pcbReceptionExemplaireImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionExemplaireImage.TabStop = false;

            this.btnReceptionExemplaireValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReceptionExemplaireValider.Location = new System.Drawing.Point(6, 95);
            this.btnReceptionExemplaireValider.Name = "btnReceptionExemplaireValider";
            this.btnReceptionExemplaireValider.Size = new System.Drawing.Size(535, 22);
            this.btnReceptionExemplaireValider.Text = "Valider la réception";
            this.btnReceptionExemplaireValider.UseVisualStyleBackColor = true;
            this.btnReceptionExemplaireValider.Click += new System.EventHandler(this.btnReceptionExemplaireValider_Click);

            this.txbReceptionExemplaireImage.Location = new System.Drawing.Point(150, 70);
            this.txbReceptionExemplaireImage.Name = "txbReceptionExemplaireImage";
            this.txbReceptionExemplaireImage.ReadOnly = true;
            this.txbReceptionExemplaireImage.Size = new System.Drawing.Size(290, 20);

            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(6, 70);
            this.label18.Text = "Emplacement image :";

            this.txbReceptionExemplaireNumero.Location = new System.Drawing.Point(150, 20);
            this.txbReceptionExemplaireNumero.Name = "txbReceptionExemplaireNumero";
            this.txbReceptionExemplaireNumero.Size = new System.Drawing.Size(100, 20);

            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(6, 45);
            this.label17.Text = "Date de parution :";

            this.dtpReceptionExemplaireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceptionExemplaireDate.Location = new System.Drawing.Point(150, 45);
            this.dtpReceptionExemplaireDate.Name = "dtpReceptionExemplaireDate";
            this.dtpReceptionExemplaireDate.Size = new System.Drawing.Size(100, 20);

            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Text = "Numéro réceptionné :";

            // grpReceptionRevue - agrandi pour inclure les nouveaux contrôles
            this.grpReceptionRevue.Controls.Add(this.label48);
            this.grpReceptionRevue.Controls.Add(this.label56);
            this.grpReceptionRevue.Controls.Add(this.pcbReceptionExemplaireRevueImage);
            this.grpReceptionRevue.Controls.Add(this.label13);
            this.grpReceptionRevue.Controls.Add(this.dgvReceptionExemplairesListe);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueImage);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueRayon);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePublic);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueGenre);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueDelaiMiseADispo);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePeriodicite);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueTitre);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueNumero);
            this.grpReceptionRevue.Controls.Add(this.label3);
            this.grpReceptionRevue.Controls.Add(this.pcbReceptionRevueImage);
            this.grpReceptionRevue.Controls.Add(this.label15);
            this.grpReceptionRevue.Controls.Add(this.label49);
            this.grpReceptionRevue.Controls.Add(this.label50);
            this.grpReceptionRevue.Controls.Add(this.label51);
            this.grpReceptionRevue.Controls.Add(this.label52);
            this.grpReceptionRevue.Controls.Add(this.label53);
            this.grpReceptionRevue.Controls.Add(this.label54);
            this.grpReceptionRevue.Controls.Add(this.btnReceptionRechercher);
            this.grpReceptionRevue.Controls.Add(this.labelReceptionEtat);
            this.grpReceptionRevue.Controls.Add(this.cbxReceptionEtat);
            this.grpReceptionRevue.Controls.Add(this.btnReceptionModifierEtat);
            this.grpReceptionRevue.Controls.Add(this.btnReceptionSupprimerExemplaire);
            this.grpReceptionRevue.Location = new System.Drawing.Point(8, 13);
            this.grpReceptionRevue.Name = "grpReceptionRevue";
            this.grpReceptionRevue.Size = new System.Drawing.Size(859, 400);
            this.grpReceptionRevue.TabIndex = 15;
            this.grpReceptionRevue.TabStop = false;
            this.grpReceptionRevue.Text = "Recherche revue";

            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label48.Location = new System.Drawing.Point(557, 127);
            this.label48.Text = "Image exemplaire :";

            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label56.Location = new System.Drawing.Point(557, 20);
            this.label56.Text = "Image revue :";

            this.pcbReceptionExemplaireRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionExemplaireRevueImage.Location = new System.Drawing.Point(560, 145);
            this.pcbReceptionExemplaireRevueImage.Name = "pcbReceptionExemplaireRevueImage";
            this.pcbReceptionExemplaireRevueImage.Size = new System.Drawing.Size(150, 120);
            this.pcbReceptionExemplaireRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionExemplaireRevueImage.TabStop = false;

            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 220);
            this.label13.Text = "Parutions :";

            this.dgvReceptionExemplairesListe.AllowUserToAddRows = false;
            this.dgvReceptionExemplairesListe.AllowUserToDeleteRows = false;
            this.dgvReceptionExemplairesListe.AllowUserToResizeColumns = false;
            this.dgvReceptionExemplairesListe.AllowUserToResizeRows = false;
            this.dgvReceptionExemplairesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionExemplairesListe.Location = new System.Drawing.Point(150, 221);
            this.dgvReceptionExemplairesListe.MultiSelect = false;
            this.dgvReceptionExemplairesListe.Name = "dgvReceptionExemplairesListe";
            this.dgvReceptionExemplairesListe.ReadOnly = true;
            this.dgvReceptionExemplairesListe.RowHeadersVisible = false;
            this.dgvReceptionExemplairesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptionExemplairesListe.Size = new System.Drawing.Size(391, 134);
            this.dgvReceptionExemplairesListe.TabIndex = 52;
            this.dgvReceptionExemplairesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExemplairesListe_ColumnHeaderMouseClick);
            this.dgvReceptionExemplairesListe.SelectionChanged += new System.EventHandler(this.dgvReceptionExemplairesListe_SelectionChanged);

            this.txbReceptionRevueImage.Location = new System.Drawing.Point(150, 195);
            this.txbReceptionRevueImage.Name = "txbReceptionRevueImage";
            this.txbReceptionRevueImage.ReadOnly = true;
            this.txbReceptionRevueImage.Size = new System.Drawing.Size(391, 20);

            this.txbReceptionRevueRayon.Location = new System.Drawing.Point(150, 170);
            this.txbReceptionRevueRayon.Name = "txbReceptionRevueRayon";
            this.txbReceptionRevueRayon.ReadOnly = true;
            this.txbReceptionRevueRayon.Size = new System.Drawing.Size(207, 20);

            this.txbReceptionRevuePublic.Location = new System.Drawing.Point(150, 145);
            this.txbReceptionRevuePublic.Name = "txbReceptionRevuePublic";
            this.txbReceptionRevuePublic.ReadOnly = true;
            this.txbReceptionRevuePublic.Size = new System.Drawing.Size(207, 20);

            this.txbReceptionRevueGenre.Location = new System.Drawing.Point(150, 120);
            this.txbReceptionRevueGenre.Name = "txbReceptionRevueGenre";
            this.txbReceptionRevueGenre.ReadOnly = true;
            this.txbReceptionRevueGenre.Size = new System.Drawing.Size(207, 20);

            this.txbReceptionRevueDelaiMiseADispo.Location = new System.Drawing.Point(150, 95);
            this.txbReceptionRevueDelaiMiseADispo.Name = "txbReceptionRevueDelaiMiseADispo";
            this.txbReceptionRevueDelaiMiseADispo.ReadOnly = true;
            this.txbReceptionRevueDelaiMiseADispo.Size = new System.Drawing.Size(100, 20);

            this.txbReceptionRevuePeriodicite.Location = new System.Drawing.Point(150, 70);
            this.txbReceptionRevuePeriodicite.Name = "txbReceptionRevuePeriodicite";
            this.txbReceptionRevuePeriodicite.ReadOnly = true;
            this.txbReceptionRevuePeriodicite.Size = new System.Drawing.Size(100, 20);

            this.txbReceptionRevueTitre.Location = new System.Drawing.Point(150, 45);
            this.txbReceptionRevueTitre.Name = "txbReceptionRevueTitre";
            this.txbReceptionRevueTitre.ReadOnly = true;
            this.txbReceptionRevueTitre.Size = new System.Drawing.Size(391, 20);

            this.txbReceptionRevueNumero.Location = new System.Drawing.Point(150, 20);
            this.txbReceptionRevueNumero.Name = "txbReceptionRevueNumero";
            this.txbReceptionRevueNumero.Size = new System.Drawing.Size(100, 20);
            this.txbReceptionRevueNumero.TextChanged += new System.EventHandler(this.txbReceptionRevueNumero_TextChanged);

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Text = "Genre :";

            this.pcbReceptionRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionRevueImage.Location = new System.Drawing.Point(690, 20);
            this.pcbReceptionRevueImage.Name = "pcbReceptionRevueImage";
            this.pcbReceptionRevueImage.Size = new System.Drawing.Size(154, 114);
            this.pcbReceptionRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionRevueImage.TabStop = false;

            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(6, 145);
            this.label15.Text = "Public :";

            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label49.Location = new System.Drawing.Point(6, 170);
            this.label49.Text = "Rayon :";

            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label50.Location = new System.Drawing.Point(6, 45);
            this.label50.Text = "Titre :";

            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label51.Location = new System.Drawing.Point(6, 20);
            this.label51.Text = "Numéro revue :";

            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label52.Location = new System.Drawing.Point(6, 70);
            this.label52.Text = "Périodicité :";

            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label53.Location = new System.Drawing.Point(6, 195);
            this.label53.Text = "Chemin de l\'image :";

            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label54.Location = new System.Drawing.Point(6, 95);
            this.label54.Text = "Délai mise à dispo :";

            this.btnReceptionRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReceptionRechercher.Location = new System.Drawing.Point(261, 19);
            this.btnReceptionRechercher.Name = "btnReceptionRechercher";
            this.btnReceptionRechercher.Size = new System.Drawing.Size(96, 22);
            this.btnReceptionRechercher.Text = "Rechercher";
            this.btnReceptionRechercher.UseVisualStyleBackColor = true;
            this.btnReceptionRechercher.Click += new System.EventHandler(this.btnReceptionRechercher_Click);

            // Nouveaux contrôles état parutions
            this.labelReceptionEtat.AutoSize = true;
            this.labelReceptionEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelReceptionEtat.Location = new System.Drawing.Point(6, 365);
            this.labelReceptionEtat.Name = "labelReceptionEtat";
            this.labelReceptionEtat.Text = "État :";

            this.cbxReceptionEtat.FormattingEnabled = true;
            this.cbxReceptionEtat.Location = new System.Drawing.Point(60, 362);
            this.cbxReceptionEtat.Name = "cbxReceptionEtat";
            this.cbxReceptionEtat.Size = new System.Drawing.Size(180, 21);
            this.cbxReceptionEtat.TabIndex = 60;

            this.btnReceptionModifierEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReceptionModifierEtat.Location = new System.Drawing.Point(255, 361);
            this.btnReceptionModifierEtat.Name = "btnReceptionModifierEtat";
            this.btnReceptionModifierEtat.Size = new System.Drawing.Size(150, 23);
            this.btnReceptionModifierEtat.TabIndex = 61;
            this.btnReceptionModifierEtat.Text = "Modifier l\'état";
            this.btnReceptionModifierEtat.UseVisualStyleBackColor = true;
            this.btnReceptionModifierEtat.Click += new System.EventHandler(this.btnReceptionModifierEtat_Click);

            this.btnReceptionSupprimerExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReceptionSupprimerExemplaire.Location = new System.Drawing.Point(415, 361);
            this.btnReceptionSupprimerExemplaire.Name = "btnReceptionSupprimerExemplaire";
            this.btnReceptionSupprimerExemplaire.Size = new System.Drawing.Size(170, 23);
            this.btnReceptionSupprimerExemplaire.TabIndex = 62;
            this.btnReceptionSupprimerExemplaire.Text = "Supprimer exemplaire";
            this.btnReceptionSupprimerExemplaire.UseVisualStyleBackColor = true;
            this.btnReceptionSupprimerExemplaire.Click += new System.EventHandler(this.btnReceptionSupprimerExemplaire_Click);

            // =====================================================================
            // tabCommandesLivres - inchangé
            // =====================================================================
            this.tabCommandesLivres.Controls.Add(this.grpCommandesLivresRecherche);
            this.tabCommandesLivres.Controls.Add(this.grpCommandesLivresNouvelle);
            this.tabCommandesLivres.Controls.Add(this.grpCommandesLivresSuivi);
            this.tabCommandesLivres.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesLivres.Name = "tabCommandesLivres";
            this.tabCommandesLivres.Size = new System.Drawing.Size(875, 874);
            this.tabCommandesLivres.TabIndex = 5;
            this.tabCommandesLivres.Text = "Commandes livres";
            this.tabCommandesLivres.UseVisualStyleBackColor = true;
            this.tabCommandesLivres.Enter += new System.EventHandler(this.tabCommandesLivres_Enter);

            this.grpCommandesLivresRecherche.Controls.Add(this.labelCmdLivresNum);
            this.grpCommandesLivresRecherche.Controls.Add(this.txbCommandesLivresNumero);
            this.grpCommandesLivresRecherche.Controls.Add(this.btnCommandesLivresRechercher);
            this.grpCommandesLivresRecherche.Controls.Add(this.labelCmdLivresTitre);
            this.grpCommandesLivresRecherche.Controls.Add(this.txbCommandesLivresTitre);
            this.grpCommandesLivresRecherche.Controls.Add(this.dgvCommandesLivresListe);
            this.grpCommandesLivresRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpCommandesLivresRecherche.Name = "grpCommandesLivresRecherche";
            this.grpCommandesLivresRecherche.Size = new System.Drawing.Size(859, 300);
            this.grpCommandesLivresRecherche.TabIndex = 0;
            this.grpCommandesLivresRecherche.TabStop = false;
            this.grpCommandesLivresRecherche.Text = "Recherche et liste des commandes";

            this.labelCmdLivresNum.AutoSize = true;
            this.labelCmdLivresNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresNum.Location = new System.Drawing.Point(6, 21);
            this.labelCmdLivresNum.Text = "Numéro de document :";

            this.txbCommandesLivresNumero.Location = new System.Drawing.Point(160, 18);
            this.txbCommandesLivresNumero.Name = "txbCommandesLivresNumero";
            this.txbCommandesLivresNumero.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesLivresRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesLivresRechercher.Location = new System.Drawing.Point(270, 17);
            this.btnCommandesLivresRechercher.Name = "btnCommandesLivresRechercher";
            this.btnCommandesLivresRechercher.Size = new System.Drawing.Size(96, 22);
            this.btnCommandesLivresRechercher.Text = "Rechercher";
            this.btnCommandesLivresRechercher.UseVisualStyleBackColor = true;
            this.btnCommandesLivresRechercher.Click += new System.EventHandler(this.btnCommandesLivresRechercher_Click);

            this.labelCmdLivresTitre.AutoSize = true;
            this.labelCmdLivresTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresTitre.Location = new System.Drawing.Point(6, 48);
            this.labelCmdLivresTitre.Text = "Titre :";

            this.txbCommandesLivresTitre.Location = new System.Drawing.Point(160, 45);
            this.txbCommandesLivresTitre.Name = "txbCommandesLivresTitre";
            this.txbCommandesLivresTitre.ReadOnly = true;
            this.txbCommandesLivresTitre.Size = new System.Drawing.Size(391, 20);

            this.dgvCommandesLivresListe.AllowUserToAddRows = false;
            this.dgvCommandesLivresListe.AllowUserToDeleteRows = false;
            this.dgvCommandesLivresListe.AllowUserToResizeColumns = false;
            this.dgvCommandesLivresListe.AllowUserToResizeRows = false;
            this.dgvCommandesLivresListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandesLivresListe.Location = new System.Drawing.Point(9, 75);
            this.dgvCommandesLivresListe.MultiSelect = false;
            this.dgvCommandesLivresListe.Name = "dgvCommandesLivresListe";
            this.dgvCommandesLivresListe.ReadOnly = true;
            this.dgvCommandesLivresListe.RowHeadersVisible = false;
            this.dgvCommandesLivresListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandesLivresListe.Size = new System.Drawing.Size(844, 215);
            this.dgvCommandesLivresListe.TabIndex = 5;
            this.dgvCommandesLivresListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesLivresListe_ColumnHeaderMouseClick);
            this.dgvCommandesLivresListe.SelectionChanged += new System.EventHandler(this.dgvCommandesLivresListe_SelectionChanged);

            this.grpCommandesLivresNouvelle.Controls.Add(this.labelCmdLivresNumCmd);
            this.grpCommandesLivresNouvelle.Controls.Add(this.txbCommandesLivresNumCommande);
            this.grpCommandesLivresNouvelle.Controls.Add(this.labelCmdLivresDate);
            this.grpCommandesLivresNouvelle.Controls.Add(this.dtpCommandesLivresDate);
            this.grpCommandesLivresNouvelle.Controls.Add(this.labelCmdLivresMontant);
            this.grpCommandesLivresNouvelle.Controls.Add(this.txbCommandesLivresMontant);
            this.grpCommandesLivresNouvelle.Controls.Add(this.labelCmdLivresNbEx);
            this.grpCommandesLivresNouvelle.Controls.Add(this.txbCommandesLivresNbExemplaires);
            this.grpCommandesLivresNouvelle.Controls.Add(this.btnCommandesLivresAjouter);
            this.grpCommandesLivresNouvelle.Location = new System.Drawing.Point(8, 320);
            this.grpCommandesLivresNouvelle.Name = "grpCommandesLivresNouvelle";
            this.grpCommandesLivresNouvelle.Size = new System.Drawing.Size(430, 130);
            this.grpCommandesLivresNouvelle.TabIndex = 1;
            this.grpCommandesLivresNouvelle.TabStop = false;
            this.grpCommandesLivresNouvelle.Text = "Nouvelle commande";

            this.labelCmdLivresNumCmd.AutoSize = true;
            this.labelCmdLivresNumCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresNumCmd.Location = new System.Drawing.Point(6, 20);
            this.labelCmdLivresNumCmd.Text = "Numéro commande :";

            this.txbCommandesLivresNumCommande.Location = new System.Drawing.Point(160, 17);
            this.txbCommandesLivresNumCommande.Name = "txbCommandesLivresNumCommande";
            this.txbCommandesLivresNumCommande.Size = new System.Drawing.Size(100, 20);

            this.labelCmdLivresDate.AutoSize = true;
            this.labelCmdLivresDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresDate.Location = new System.Drawing.Point(6, 45);
            this.labelCmdLivresDate.Text = "Date commande :";

            this.dtpCommandesLivresDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCommandesLivresDate.Location = new System.Drawing.Point(160, 42);
            this.dtpCommandesLivresDate.Name = "dtpCommandesLivresDate";
            this.dtpCommandesLivresDate.Size = new System.Drawing.Size(100, 20);

            this.labelCmdLivresMontant.AutoSize = true;
            this.labelCmdLivresMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresMontant.Location = new System.Drawing.Point(6, 70);
            this.labelCmdLivresMontant.Text = "Montant :";

            this.txbCommandesLivresMontant.Location = new System.Drawing.Point(160, 67);
            this.txbCommandesLivresMontant.Name = "txbCommandesLivresMontant";
            this.txbCommandesLivresMontant.Size = new System.Drawing.Size(100, 20);

            this.labelCmdLivresNbEx.AutoSize = true;
            this.labelCmdLivresNbEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresNbEx.Location = new System.Drawing.Point(6, 95);
            this.labelCmdLivresNbEx.Text = "Nb exemplaires :";

            this.txbCommandesLivresNbExemplaires.Location = new System.Drawing.Point(160, 92);
            this.txbCommandesLivresNbExemplaires.Name = "txbCommandesLivresNbExemplaires";
            this.txbCommandesLivresNbExemplaires.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesLivresAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesLivresAjouter.Location = new System.Drawing.Point(270, 89);
            this.btnCommandesLivresAjouter.Name = "btnCommandesLivresAjouter";
            this.btnCommandesLivresAjouter.Size = new System.Drawing.Size(130, 23);
            this.btnCommandesLivresAjouter.Text = "Enregistrer commande";
            this.btnCommandesLivresAjouter.UseVisualStyleBackColor = true;
            this.btnCommandesLivresAjouter.Click += new System.EventHandler(this.btnCommandesLivresAjouter_Click);

            this.grpCommandesLivresSuivi.Controls.Add(this.labelCmdLivresSuivi);
            this.grpCommandesLivresSuivi.Controls.Add(this.cbxCommandesLivresSuivi);
            this.grpCommandesLivresSuivi.Controls.Add(this.btnCommandesLivresModifierSuivi);
            this.grpCommandesLivresSuivi.Controls.Add(this.btnCommandesLivresSupprimerCommande);
            this.grpCommandesLivresSuivi.Location = new System.Drawing.Point(450, 320);
            this.grpCommandesLivresSuivi.Name = "grpCommandesLivresSuivi";
            this.grpCommandesLivresSuivi.Size = new System.Drawing.Size(417, 130);
            this.grpCommandesLivresSuivi.TabIndex = 2;
            this.grpCommandesLivresSuivi.TabStop = false;
            this.grpCommandesLivresSuivi.Text = "Suivi de la commande sélectionnée";

            this.labelCmdLivresSuivi.AutoSize = true;
            this.labelCmdLivresSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdLivresSuivi.Location = new System.Drawing.Point(6, 25);
            this.labelCmdLivresSuivi.Text = "Étape de suivi :";

            this.cbxCommandesLivresSuivi.FormattingEnabled = true;
            this.cbxCommandesLivresSuivi.Location = new System.Drawing.Point(130, 22);
            this.cbxCommandesLivresSuivi.Name = "cbxCommandesLivresSuivi";
            this.cbxCommandesLivresSuivi.Size = new System.Drawing.Size(207, 21);

            this.btnCommandesLivresModifierSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesLivresModifierSuivi.Location = new System.Drawing.Point(6, 60);
            this.btnCommandesLivresModifierSuivi.Name = "btnCommandesLivresModifierSuivi";
            this.btnCommandesLivresModifierSuivi.Size = new System.Drawing.Size(150, 23);
            this.btnCommandesLivresModifierSuivi.Text = "Modifier le suivi";
            this.btnCommandesLivresModifierSuivi.UseVisualStyleBackColor = true;
            this.btnCommandesLivresModifierSuivi.Click += new System.EventHandler(this.btnCommandesLivresModifierSuivi_Click);

            this.btnCommandesLivresSupprimerCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesLivresSupprimerCommande.Location = new System.Drawing.Point(166, 60);
            this.btnCommandesLivresSupprimerCommande.Name = "btnCommandesLivresSupprimerCommande";
            this.btnCommandesLivresSupprimerCommande.Size = new System.Drawing.Size(150, 23);
            this.btnCommandesLivresSupprimerCommande.Text = "Supprimer commande";
            this.btnCommandesLivresSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnCommandesLivresSupprimerCommande.Click += new System.EventHandler(this.btnCommandesLivresSupprimerCommande_Click);

            // =====================================================================
            // tabCommandesDvd - inchangé
            // =====================================================================
            this.tabCommandesDvd.Controls.Add(this.grpCommandesDvdRecherche);
            this.tabCommandesDvd.Controls.Add(this.grpCommandesDvdNouvelle);
            this.tabCommandesDvd.Controls.Add(this.grpCommandesDvdSuivi);
            this.tabCommandesDvd.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesDvd.Name = "tabCommandesDvd";
            this.tabCommandesDvd.Size = new System.Drawing.Size(875, 874);
            this.tabCommandesDvd.TabIndex = 6;
            this.tabCommandesDvd.Text = "Commandes DVD";
            this.tabCommandesDvd.UseVisualStyleBackColor = true;
            this.tabCommandesDvd.Enter += new System.EventHandler(this.tabCommandesDvd_Enter);

            this.grpCommandesDvdRecherche.Controls.Add(this.labelCmdDvdNum);
            this.grpCommandesDvdRecherche.Controls.Add(this.txbCommandesDvdNumero);
            this.grpCommandesDvdRecherche.Controls.Add(this.btnCommandesDvdRechercher);
            this.grpCommandesDvdRecherche.Controls.Add(this.labelCmdDvdTitre);
            this.grpCommandesDvdRecherche.Controls.Add(this.txbCommandesDvdTitre);
            this.grpCommandesDvdRecherche.Controls.Add(this.dgvCommandesDvdListe);
            this.grpCommandesDvdRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpCommandesDvdRecherche.Name = "grpCommandesDvdRecherche";
            this.grpCommandesDvdRecherche.Size = new System.Drawing.Size(859, 300);
            this.grpCommandesDvdRecherche.TabIndex = 0;
            this.grpCommandesDvdRecherche.TabStop = false;
            this.grpCommandesDvdRecherche.Text = "Recherche et liste des commandes";

            this.labelCmdDvdNum.AutoSize = true;
            this.labelCmdDvdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdNum.Location = new System.Drawing.Point(6, 21);
            this.labelCmdDvdNum.Text = "Numéro de document :";

            this.txbCommandesDvdNumero.Location = new System.Drawing.Point(160, 18);
            this.txbCommandesDvdNumero.Name = "txbCommandesDvdNumero";
            this.txbCommandesDvdNumero.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesDvdRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesDvdRechercher.Location = new System.Drawing.Point(270, 17);
            this.btnCommandesDvdRechercher.Name = "btnCommandesDvdRechercher";
            this.btnCommandesDvdRechercher.Size = new System.Drawing.Size(96, 22);
            this.btnCommandesDvdRechercher.Text = "Rechercher";
            this.btnCommandesDvdRechercher.UseVisualStyleBackColor = true;
            this.btnCommandesDvdRechercher.Click += new System.EventHandler(this.btnCommandesDvdRechercher_Click);

            this.labelCmdDvdTitre.AutoSize = true;
            this.labelCmdDvdTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdTitre.Location = new System.Drawing.Point(6, 48);
            this.labelCmdDvdTitre.Text = "Titre :";

            this.txbCommandesDvdTitre.Location = new System.Drawing.Point(160, 45);
            this.txbCommandesDvdTitre.Name = "txbCommandesDvdTitre";
            this.txbCommandesDvdTitre.ReadOnly = true;
            this.txbCommandesDvdTitre.Size = new System.Drawing.Size(391, 20);

            this.dgvCommandesDvdListe.AllowUserToAddRows = false;
            this.dgvCommandesDvdListe.AllowUserToDeleteRows = false;
            this.dgvCommandesDvdListe.AllowUserToResizeColumns = false;
            this.dgvCommandesDvdListe.AllowUserToResizeRows = false;
            this.dgvCommandesDvdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandesDvdListe.Location = new System.Drawing.Point(9, 75);
            this.dgvCommandesDvdListe.MultiSelect = false;
            this.dgvCommandesDvdListe.Name = "dgvCommandesDvdListe";
            this.dgvCommandesDvdListe.ReadOnly = true;
            this.dgvCommandesDvdListe.RowHeadersVisible = false;
            this.dgvCommandesDvdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandesDvdListe.Size = new System.Drawing.Size(844, 215);
            this.dgvCommandesDvdListe.TabIndex = 5;
            this.dgvCommandesDvdListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesDvdListe_ColumnHeaderMouseClick);
            this.dgvCommandesDvdListe.SelectionChanged += new System.EventHandler(this.dgvCommandesDvdListe_SelectionChanged);

            this.grpCommandesDvdNouvelle.Controls.Add(this.labelCmdDvdNumCmd);
            this.grpCommandesDvdNouvelle.Controls.Add(this.txbCommandesDvdNumCommande);
            this.grpCommandesDvdNouvelle.Controls.Add(this.labelCmdDvdDate);
            this.grpCommandesDvdNouvelle.Controls.Add(this.dtpCommandesDvdDate);
            this.grpCommandesDvdNouvelle.Controls.Add(this.labelCmdDvdMontant);
            this.grpCommandesDvdNouvelle.Controls.Add(this.txbCommandesDvdMontant);
            this.grpCommandesDvdNouvelle.Controls.Add(this.labelCmdDvdNbEx);
            this.grpCommandesDvdNouvelle.Controls.Add(this.txbCommandesDvdNbExemplaires);
            this.grpCommandesDvdNouvelle.Controls.Add(this.btnCommandesDvdAjouter);
            this.grpCommandesDvdNouvelle.Location = new System.Drawing.Point(8, 320);
            this.grpCommandesDvdNouvelle.Name = "grpCommandesDvdNouvelle";
            this.grpCommandesDvdNouvelle.Size = new System.Drawing.Size(430, 130);
            this.grpCommandesDvdNouvelle.TabIndex = 1;
            this.grpCommandesDvdNouvelle.TabStop = false;
            this.grpCommandesDvdNouvelle.Text = "Nouvelle commande";

            this.labelCmdDvdNumCmd.AutoSize = true;
            this.labelCmdDvdNumCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdNumCmd.Location = new System.Drawing.Point(6, 20);
            this.labelCmdDvdNumCmd.Text = "Numéro commande :";

            this.txbCommandesDvdNumCommande.Location = new System.Drawing.Point(160, 17);
            this.txbCommandesDvdNumCommande.Name = "txbCommandesDvdNumCommande";
            this.txbCommandesDvdNumCommande.Size = new System.Drawing.Size(100, 20);

            this.labelCmdDvdDate.AutoSize = true;
            this.labelCmdDvdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdDate.Location = new System.Drawing.Point(6, 45);
            this.labelCmdDvdDate.Text = "Date commande :";

            this.dtpCommandesDvdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCommandesDvdDate.Location = new System.Drawing.Point(160, 42);
            this.dtpCommandesDvdDate.Name = "dtpCommandesDvdDate";
            this.dtpCommandesDvdDate.Size = new System.Drawing.Size(100, 20);

            this.labelCmdDvdMontant.AutoSize = true;
            this.labelCmdDvdMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdMontant.Location = new System.Drawing.Point(6, 70);
            this.labelCmdDvdMontant.Text = "Montant :";

            this.txbCommandesDvdMontant.Location = new System.Drawing.Point(160, 67);
            this.txbCommandesDvdMontant.Name = "txbCommandesDvdMontant";
            this.txbCommandesDvdMontant.Size = new System.Drawing.Size(100, 20);

            this.labelCmdDvdNbEx.AutoSize = true;
            this.labelCmdDvdNbEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdNbEx.Location = new System.Drawing.Point(6, 95);
            this.labelCmdDvdNbEx.Text = "Nb exemplaires :";

            this.txbCommandesDvdNbExemplaires.Location = new System.Drawing.Point(160, 92);
            this.txbCommandesDvdNbExemplaires.Name = "txbCommandesDvdNbExemplaires";
            this.txbCommandesDvdNbExemplaires.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesDvdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesDvdAjouter.Location = new System.Drawing.Point(270, 89);
            this.btnCommandesDvdAjouter.Name = "btnCommandesDvdAjouter";
            this.btnCommandesDvdAjouter.Size = new System.Drawing.Size(130, 23);
            this.btnCommandesDvdAjouter.Text = "Enregistrer commande";
            this.btnCommandesDvdAjouter.UseVisualStyleBackColor = true;
            this.btnCommandesDvdAjouter.Click += new System.EventHandler(this.btnCommandesDvdAjouter_Click);

            this.grpCommandesDvdSuivi.Controls.Add(this.labelCmdDvdSuivi);
            this.grpCommandesDvdSuivi.Controls.Add(this.cbxCommandesDvdSuivi);
            this.grpCommandesDvdSuivi.Controls.Add(this.btnCommandesDvdModifierSuivi);
            this.grpCommandesDvdSuivi.Controls.Add(this.btnCommandesDvdSupprimerCommande);
            this.grpCommandesDvdSuivi.Location = new System.Drawing.Point(450, 320);
            this.grpCommandesDvdSuivi.Name = "grpCommandesDvdSuivi";
            this.grpCommandesDvdSuivi.Size = new System.Drawing.Size(417, 130);
            this.grpCommandesDvdSuivi.TabIndex = 2;
            this.grpCommandesDvdSuivi.TabStop = false;
            this.grpCommandesDvdSuivi.Text = "Suivi de la commande sélectionnée";

            this.labelCmdDvdSuivi.AutoSize = true;
            this.labelCmdDvdSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdDvdSuivi.Location = new System.Drawing.Point(6, 25);
            this.labelCmdDvdSuivi.Text = "Étape de suivi :";

            this.cbxCommandesDvdSuivi.FormattingEnabled = true;
            this.cbxCommandesDvdSuivi.Location = new System.Drawing.Point(130, 22);
            this.cbxCommandesDvdSuivi.Name = "cbxCommandesDvdSuivi";
            this.cbxCommandesDvdSuivi.Size = new System.Drawing.Size(207, 21);

            this.btnCommandesDvdModifierSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesDvdModifierSuivi.Location = new System.Drawing.Point(6, 60);
            this.btnCommandesDvdModifierSuivi.Name = "btnCommandesDvdModifierSuivi";
            this.btnCommandesDvdModifierSuivi.Size = new System.Drawing.Size(150, 23);
            this.btnCommandesDvdModifierSuivi.Text = "Modifier le suivi";
            this.btnCommandesDvdModifierSuivi.UseVisualStyleBackColor = true;
            this.btnCommandesDvdModifierSuivi.Click += new System.EventHandler(this.btnCommandesDvdModifierSuivi_Click);

            this.btnCommandesDvdSupprimerCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesDvdSupprimerCommande.Location = new System.Drawing.Point(166, 60);
            this.btnCommandesDvdSupprimerCommande.Name = "btnCommandesDvdSupprimerCommande";
            this.btnCommandesDvdSupprimerCommande.Size = new System.Drawing.Size(150, 23);
            this.btnCommandesDvdSupprimerCommande.Text = "Supprimer commande";
            this.btnCommandesDvdSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnCommandesDvdSupprimerCommande.Click += new System.EventHandler(this.btnCommandesDvdSupprimerCommande_Click);

            // =====================================================================
            // tabCommandesRevues - inchangé
            // =====================================================================
            this.tabCommandesRevues.Controls.Add(this.grpCommandesRevuesRecherche);
            this.tabCommandesRevues.Controls.Add(this.grpCommandesRevuesNouvelle);
            this.tabCommandesRevues.Controls.Add(this.btnCommandesRevuesSupprimerCommande);
            this.tabCommandesRevues.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesRevues.Name = "tabCommandesRevues";
            this.tabCommandesRevues.Size = new System.Drawing.Size(875, 874);
            this.tabCommandesRevues.TabIndex = 7;
            this.tabCommandesRevues.Text = "Commandes revues";
            this.tabCommandesRevues.UseVisualStyleBackColor = true;
            this.tabCommandesRevues.Enter += new System.EventHandler(this.tabCommandesRevues_Enter);

            this.grpCommandesRevuesRecherche.Controls.Add(this.labelCmdRevuesNum);
            this.grpCommandesRevuesRecherche.Controls.Add(this.txbCommandesRevuesNumero);
            this.grpCommandesRevuesRecherche.Controls.Add(this.btnCommandesRevuesRechercher);
            this.grpCommandesRevuesRecherche.Controls.Add(this.labelCmdRevuesTitre);
            this.grpCommandesRevuesRecherche.Controls.Add(this.txbCommandesRevuesTitre);
            this.grpCommandesRevuesRecherche.Controls.Add(this.dgvCommandesRevuesListe);
            this.grpCommandesRevuesRecherche.Location = new System.Drawing.Point(8, 13);
            this.grpCommandesRevuesRecherche.Name = "grpCommandesRevuesRecherche";
            this.grpCommandesRevuesRecherche.Size = new System.Drawing.Size(859, 300);
            this.grpCommandesRevuesRecherche.TabIndex = 0;
            this.grpCommandesRevuesRecherche.TabStop = false;
            this.grpCommandesRevuesRecherche.Text = "Recherche et liste des abonnements";

            this.labelCmdRevuesNum.AutoSize = true;
            this.labelCmdRevuesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesNum.Location = new System.Drawing.Point(6, 21);
            this.labelCmdRevuesNum.Text = "Numéro de revue :";

            this.txbCommandesRevuesNumero.Location = new System.Drawing.Point(160, 18);
            this.txbCommandesRevuesNumero.Name = "txbCommandesRevuesNumero";
            this.txbCommandesRevuesNumero.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesRevuesRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesRevuesRechercher.Location = new System.Drawing.Point(270, 17);
            this.btnCommandesRevuesRechercher.Name = "btnCommandesRevuesRechercher";
            this.btnCommandesRevuesRechercher.Size = new System.Drawing.Size(96, 22);
            this.btnCommandesRevuesRechercher.Text = "Rechercher";
            this.btnCommandesRevuesRechercher.UseVisualStyleBackColor = true;
            this.btnCommandesRevuesRechercher.Click += new System.EventHandler(this.btnCommandesRevuesRechercher_Click);

            this.labelCmdRevuesTitre.AutoSize = true;
            this.labelCmdRevuesTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesTitre.Location = new System.Drawing.Point(6, 48);
            this.labelCmdRevuesTitre.Text = "Titre :";

            this.txbCommandesRevuesTitre.Location = new System.Drawing.Point(160, 45);
            this.txbCommandesRevuesTitre.Name = "txbCommandesRevuesTitre";
            this.txbCommandesRevuesTitre.ReadOnly = true;
            this.txbCommandesRevuesTitre.Size = new System.Drawing.Size(391, 20);

            this.dgvCommandesRevuesListe.AllowUserToAddRows = false;
            this.dgvCommandesRevuesListe.AllowUserToDeleteRows = false;
            this.dgvCommandesRevuesListe.AllowUserToResizeColumns = false;
            this.dgvCommandesRevuesListe.AllowUserToResizeRows = false;
            this.dgvCommandesRevuesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandesRevuesListe.Location = new System.Drawing.Point(9, 75);
            this.dgvCommandesRevuesListe.MultiSelect = false;
            this.dgvCommandesRevuesListe.Name = "dgvCommandesRevuesListe";
            this.dgvCommandesRevuesListe.ReadOnly = true;
            this.dgvCommandesRevuesListe.RowHeadersVisible = false;
            this.dgvCommandesRevuesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandesRevuesListe.Size = new System.Drawing.Size(844, 215);
            this.dgvCommandesRevuesListe.TabIndex = 5;
            this.dgvCommandesRevuesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesRevuesListe_ColumnHeaderMouseClick);
            this.dgvCommandesRevuesListe.SelectionChanged += new System.EventHandler(this.dgvCommandesRevuesListe_SelectionChanged);

            this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCmdRevuesNumCmd);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.txbCommandesRevuesNumCommande);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCmdRevuesDate);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.dtpCommandesRevuesDate);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCmdRevuesMontant);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.txbCommandesRevuesMontant);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCmdRevuesDateFin);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.dtpCommandesRevuesDateFin);
            this.grpCommandesRevuesNouvelle.Controls.Add(this.btnCommandesRevuesAjouter);
            this.grpCommandesRevuesNouvelle.Location = new System.Drawing.Point(8, 320);
            this.grpCommandesRevuesNouvelle.Name = "grpCommandesRevuesNouvelle";
            this.grpCommandesRevuesNouvelle.Size = new System.Drawing.Size(859, 130);
            this.grpCommandesRevuesNouvelle.TabIndex = 1;
            this.grpCommandesRevuesNouvelle.TabStop = false;
            this.grpCommandesRevuesNouvelle.Text = "Nouvel abonnement / Renouvellement";

            this.labelCmdRevuesNumCmd.AutoSize = true;
            this.labelCmdRevuesNumCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesNumCmd.Location = new System.Drawing.Point(6, 20);
            this.labelCmdRevuesNumCmd.Text = "Numéro commande :";

            this.txbCommandesRevuesNumCommande.Location = new System.Drawing.Point(160, 17);
            this.txbCommandesRevuesNumCommande.Name = "txbCommandesRevuesNumCommande";
            this.txbCommandesRevuesNumCommande.Size = new System.Drawing.Size(100, 20);

            this.labelCmdRevuesDate.AutoSize = true;
            this.labelCmdRevuesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesDate.Location = new System.Drawing.Point(6, 45);
            this.labelCmdRevuesDate.Text = "Date commande :";

            this.dtpCommandesRevuesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCommandesRevuesDate.Location = new System.Drawing.Point(160, 42);
            this.dtpCommandesRevuesDate.Name = "dtpCommandesRevuesDate";
            this.dtpCommandesRevuesDate.Size = new System.Drawing.Size(100, 20);

            this.labelCmdRevuesMontant.AutoSize = true;
            this.labelCmdRevuesMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesMontant.Location = new System.Drawing.Point(6, 70);
            this.labelCmdRevuesMontant.Text = "Montant :";

            this.txbCommandesRevuesMontant.Location = new System.Drawing.Point(160, 67);
            this.txbCommandesRevuesMontant.Name = "txbCommandesRevuesMontant";
            this.txbCommandesRevuesMontant.Size = new System.Drawing.Size(100, 20);

            this.labelCmdRevuesDateFin.AutoSize = true;
            this.labelCmdRevuesDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCmdRevuesDateFin.Location = new System.Drawing.Point(6, 95);
            this.labelCmdRevuesDateFin.Text = "Date fin abonnement :";

            this.dtpCommandesRevuesDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCommandesRevuesDateFin.Location = new System.Drawing.Point(160, 92);
            this.dtpCommandesRevuesDateFin.Name = "dtpCommandesRevuesDateFin";
            this.dtpCommandesRevuesDateFin.Size = new System.Drawing.Size(100, 20);

            this.btnCommandesRevuesAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesRevuesAjouter.Location = new System.Drawing.Point(270, 89);
            this.btnCommandesRevuesAjouter.Name = "btnCommandesRevuesAjouter";
            this.btnCommandesRevuesAjouter.Size = new System.Drawing.Size(150, 23);
            this.btnCommandesRevuesAjouter.Text = "Enregistrer abonnement";
            this.btnCommandesRevuesAjouter.UseVisualStyleBackColor = true;
            this.btnCommandesRevuesAjouter.Click += new System.EventHandler(this.btnCommandesRevuesAjouter_Click);

            this.btnCommandesRevuesSupprimerCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCommandesRevuesSupprimerCommande.Location = new System.Drawing.Point(8, 460);
            this.btnCommandesRevuesSupprimerCommande.Name = "btnCommandesRevuesSupprimerCommande";
            this.btnCommandesRevuesSupprimerCommande.Size = new System.Drawing.Size(220, 23);
            this.btnCommandesRevuesSupprimerCommande.Text = "Supprimer abonnement sélectionné";
            this.btnCommandesRevuesSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnCommandesRevuesSupprimerCommande.Click += new System.EventHandler(this.btnCommandesRevuesSupprimerCommande_Click);

            // FrmMediatek
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 900);
            this.Controls.Add(this.tabOngletsApplication);
            this.Name = "FrmMediatek";
            this.Text = "Gestion des documents de la médiathèque";
            this.Load += new System.EventHandler(this.FrmMediatek_Load);

            this.tabOngletsApplication.ResumeLayout(false);
            this.tabLivres.ResumeLayout(false);
            this.grpLivresInfos.ResumeLayout(false);
            this.grpLivresInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).EndInit();
            this.grpLivresRecherche.ResumeLayout(false);
            this.grpLivresRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).EndInit();
            this.grpLivresExemplaires.ResumeLayout(false);
            this.grpLivresExemplaires.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresExemplaires)).EndInit();
            this.tabDvd.ResumeLayout(false);
            this.grpDvdInfos.ResumeLayout(false);
            this.grpDvdInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).EndInit();
            this.grpDvdRecherche.ResumeLayout(false);
            this.grpDvdRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).EndInit();
            this.grpDvdExemplaires.ResumeLayout(false);
            this.grpDvdExemplaires.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdExemplaires)).EndInit();
            this.tabRevues.ResumeLayout(false);
            this.grpRevuesInfos.ResumeLayout(false);
            this.grpRevuesInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).EndInit();
            this.grpRevuesRecherche.ResumeLayout(false);
            this.grpRevuesRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).EndInit();
            this.tabReceptionRevue.ResumeLayout(false);
            this.grpReceptionExemplaire.ResumeLayout(false);
            this.grpReceptionExemplaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).EndInit();
            this.grpReceptionRevue.ResumeLayout(false);
            this.grpReceptionRevue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).EndInit();
            this.tabCommandesLivres.ResumeLayout(false);
            this.grpCommandesLivresRecherche.ResumeLayout(false);
            this.grpCommandesLivresRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesLivresListe)).EndInit();
            this.grpCommandesLivresNouvelle.ResumeLayout(false);
            this.grpCommandesLivresNouvelle.PerformLayout();
            this.grpCommandesLivresSuivi.ResumeLayout(false);
            this.grpCommandesLivresSuivi.PerformLayout();
            this.tabCommandesDvd.ResumeLayout(false);
            this.grpCommandesDvdRecherche.ResumeLayout(false);
            this.grpCommandesDvdRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesDvdListe)).EndInit();
            this.grpCommandesDvdNouvelle.ResumeLayout(false);
            this.grpCommandesDvdNouvelle.PerformLayout();
            this.grpCommandesDvdSuivi.ResumeLayout(false);
            this.grpCommandesDvdSuivi.PerformLayout();
            this.tabCommandesRevues.ResumeLayout(false);
            this.grpCommandesRevuesRecherche.ResumeLayout(false);
            this.grpCommandesRevuesRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesRevuesListe)).EndInit();
            this.grpCommandesRevuesNouvelle.ResumeLayout(false);
            this.grpCommandesRevuesNouvelle.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Contrôles existants
        private System.Windows.Forms.TabControl tabOngletsApplication;
        private System.Windows.Forms.TabPage tabRevues;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.TabPage tabDvd;
        private System.Windows.Forms.TextBox txbLivresTitreRecherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpLivresRecherche;
        private System.Windows.Forms.DataGridView dgvLivresListe;
        private System.Windows.Forms.TabPage tabReceptionRevue;
        private System.Windows.Forms.GroupBox grpReceptionExemplaire;
        private System.Windows.Forms.Button btnReceptionExemplaireValider;
        private System.Windows.Forms.TextBox txbReceptionExemplaireImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbReceptionExemplaireNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpReceptionExemplaireDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpReceptionRevue;
        private System.Windows.Forms.ComboBox cbxLivresGenres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxLivresPublics;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxLivresRayons;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLivresAnnulGenres;
        private System.Windows.Forms.GroupBox grpLivresInfos;
        private System.Windows.Forms.PictureBox pcbLivresImage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLivresNumRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLivresNumRecherche;
        private System.Windows.Forms.Button btnlivresAnnulPublics;
        private System.Windows.Forms.Button btnLivresAnnulRayons;
        private System.Windows.Forms.GroupBox grpDvdRecherche;
        private System.Windows.Forms.Button btnDvdAnnulRayons;
        private System.Windows.Forms.Button btnDvdAnnulPublics;
        private System.Windows.Forms.Button btnDvdNumRecherche;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txbDvdNumRecherche;
        private System.Windows.Forms.Button btnDvdAnnulGenres;
        private System.Windows.Forms.ComboBox cbxDvdRayons;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cbxDvdPublics;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cbxDvdGenres;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView dgvDvdListe;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txbDvdTitreRecherche;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txbLivresTitre;
        private System.Windows.Forms.TextBox txbLivresNumero;
        private System.Windows.Forms.TextBox txbLivresIsbn;
        private System.Windows.Forms.TextBox txbLivresImage;
        private System.Windows.Forms.TextBox txbLivresRayon;
        private System.Windows.Forms.TextBox txbLivresPublic;
        private System.Windows.Forms.TextBox txbLivresGenre;
        private System.Windows.Forms.TextBox txbLivresCollection;
        private System.Windows.Forms.TextBox txbLivresAuteur;
        private System.Windows.Forms.GroupBox grpDvdInfos;
        private System.Windows.Forms.TextBox txbDvdDuree;
        private System.Windows.Forms.TextBox txbDvdImage;
        private System.Windows.Forms.TextBox txbDvdRayon;
        private System.Windows.Forms.TextBox txbDvdPublic;
        private System.Windows.Forms.TextBox txbDvdGenre;
        private System.Windows.Forms.TextBox txbDvdSynopsis;
        private System.Windows.Forms.TextBox txbDvdRealisateur;
        private System.Windows.Forms.TextBox txbDvdTitre;
        private System.Windows.Forms.TextBox txbDvdNumero;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pcbDvdImage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox grpRevuesInfos;
        private System.Windows.Forms.TextBox txbRevuesImage;
        private System.Windows.Forms.TextBox txbRevuesRayon;
        private System.Windows.Forms.TextBox txbRevuesPublic;
        private System.Windows.Forms.TextBox txbRevuesGenre;
        private System.Windows.Forms.TextBox txbRevuesDateMiseADispo;
        private System.Windows.Forms.TextBox txbRevuesPeriodicite;
        private System.Windows.Forms.TextBox txbRevuesTitre;
        private System.Windows.Forms.TextBox txbRevuesNumero;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pcbRevuesImage;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox grpRevuesRecherche;
        private System.Windows.Forms.Button btnRevuesAnnulRayons;
        private System.Windows.Forms.Button btnRevuesAnnulPublics;
        private System.Windows.Forms.Button btnRevuesNumRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRevuesNumRecherche;
        private System.Windows.Forms.Button btnRevuesAnnulGenres;
        private System.Windows.Forms.ComboBox cbxRevuesRayons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRevuesPublics;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbxRevuesGenres;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvRevuesListe;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txbRevuesTitreRecherche;
        private System.Windows.Forms.Button btnReceptionRechercher;
        private System.Windows.Forms.TextBox txbReceptionRevueImage;
        private System.Windows.Forms.TextBox txbReceptionRevueRayon;
        private System.Windows.Forms.TextBox txbReceptionRevuePublic;
        private System.Windows.Forms.TextBox txbReceptionRevueGenre;
        private System.Windows.Forms.TextBox txbReceptionRevueDelaiMiseADispo;
        private System.Windows.Forms.TextBox txbReceptionRevuePeriodicite;
        private System.Windows.Forms.TextBox txbReceptionRevueTitre;
        private System.Windows.Forms.TextBox txbReceptionRevueNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbReceptionRevueImage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.PictureBox pcbReceptionExemplaireImage;
        private System.Windows.Forms.Button btnReceptionExemplaireImage;
        private System.Windows.Forms.DataGridView dgvReceptionExemplairesListe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pcbReceptionExemplaireRevueImage;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button btnLivresSupprimerDoc;
        private System.Windows.Forms.Button btnLivresModifier;
        private System.Windows.Forms.Button btnLivresAjouter;
        private System.Windows.Forms.Button btnDvdSupprimerDoc;
        private System.Windows.Forms.Button btnDvdModifier;
        private System.Windows.Forms.Button btnDvdAjouter;
        private System.Windows.Forms.Button btnRevuesSupprimerDoc;
        private System.Windows.Forms.Button btnRevuesModifier;
        private System.Windows.Forms.Button btnRevuesAjouter;
        // Exemplaires Livres
        private System.Windows.Forms.GroupBox grpLivresExemplaires;
        private System.Windows.Forms.DataGridView dgvLivresExemplaires;
        private System.Windows.Forms.Label labelLivresEtat;
        private System.Windows.Forms.ComboBox cbxLivresEtat;
        private System.Windows.Forms.Button btnLivresModifierEtat;
        private System.Windows.Forms.Button btnLivresSupprimerExemplaire;
        // Exemplaires DVD
        private System.Windows.Forms.GroupBox grpDvdExemplaires;
        private System.Windows.Forms.DataGridView dgvDvdExemplaires;
        private System.Windows.Forms.Label labelDvdEtat;
        private System.Windows.Forms.ComboBox cbxDvdEtat;
        private System.Windows.Forms.Button btnDvdModifierEtat;
        private System.Windows.Forms.Button btnDvdSupprimerExemplaire;
        // Etat Parutions
        private System.Windows.Forms.Label labelReceptionEtat;
        private System.Windows.Forms.ComboBox cbxReceptionEtat;
        private System.Windows.Forms.Button btnReceptionModifierEtat;
        private System.Windows.Forms.Button btnReceptionSupprimerExemplaire;
        // Commandes Livres
        private System.Windows.Forms.TabPage tabCommandesLivres;
        private System.Windows.Forms.GroupBox grpCommandesLivresRecherche;
        private System.Windows.Forms.Label labelCmdLivresNum;
        private System.Windows.Forms.TextBox txbCommandesLivresNumero;
        private System.Windows.Forms.Button btnCommandesLivresRechercher;
        private System.Windows.Forms.Label labelCmdLivresTitre;
        private System.Windows.Forms.TextBox txbCommandesLivresTitre;
        private System.Windows.Forms.DataGridView dgvCommandesLivresListe;
        private System.Windows.Forms.GroupBox grpCommandesLivresNouvelle;
        private System.Windows.Forms.Label labelCmdLivresNumCmd;
        private System.Windows.Forms.TextBox txbCommandesLivresNumCommande;
        private System.Windows.Forms.Label labelCmdLivresDate;
        private System.Windows.Forms.DateTimePicker dtpCommandesLivresDate;
        private System.Windows.Forms.Label labelCmdLivresMontant;
        private System.Windows.Forms.TextBox txbCommandesLivresMontant;
        private System.Windows.Forms.Label labelCmdLivresNbEx;
        private System.Windows.Forms.TextBox txbCommandesLivresNbExemplaires;
        private System.Windows.Forms.Button btnCommandesLivresAjouter;
        private System.Windows.Forms.GroupBox grpCommandesLivresSuivi;
        private System.Windows.Forms.Label labelCmdLivresSuivi;
        private System.Windows.Forms.ComboBox cbxCommandesLivresSuivi;
        private System.Windows.Forms.Button btnCommandesLivresModifierSuivi;
        private System.Windows.Forms.Button btnCommandesLivresSupprimerCommande;
        // Commandes DVD
        private System.Windows.Forms.TabPage tabCommandesDvd;
        private System.Windows.Forms.GroupBox grpCommandesDvdRecherche;
        private System.Windows.Forms.Label labelCmdDvdNum;
        private System.Windows.Forms.TextBox txbCommandesDvdNumero;
        private System.Windows.Forms.Button btnCommandesDvdRechercher;
        private System.Windows.Forms.Label labelCmdDvdTitre;
        private System.Windows.Forms.TextBox txbCommandesDvdTitre;
        private System.Windows.Forms.DataGridView dgvCommandesDvdListe;
        private System.Windows.Forms.GroupBox grpCommandesDvdNouvelle;
        private System.Windows.Forms.Label labelCmdDvdNumCmd;
        private System.Windows.Forms.TextBox txbCommandesDvdNumCommande;
        private System.Windows.Forms.Label labelCmdDvdDate;
        private System.Windows.Forms.DateTimePicker dtpCommandesDvdDate;
        private System.Windows.Forms.Label labelCmdDvdMontant;
        private System.Windows.Forms.TextBox txbCommandesDvdMontant;
        private System.Windows.Forms.Label labelCmdDvdNbEx;
        private System.Windows.Forms.TextBox txbCommandesDvdNbExemplaires;
        private System.Windows.Forms.Button btnCommandesDvdAjouter;
        private System.Windows.Forms.GroupBox grpCommandesDvdSuivi;
        private System.Windows.Forms.Label labelCmdDvdSuivi;
        private System.Windows.Forms.ComboBox cbxCommandesDvdSuivi;
        private System.Windows.Forms.Button btnCommandesDvdModifierSuivi;
        private System.Windows.Forms.Button btnCommandesDvdSupprimerCommande;
        // Commandes Revues
        private System.Windows.Forms.TabPage tabCommandesRevues;
        private System.Windows.Forms.GroupBox grpCommandesRevuesRecherche;
        private System.Windows.Forms.Label labelCmdRevuesNum;
        private System.Windows.Forms.TextBox txbCommandesRevuesNumero;
        private System.Windows.Forms.Button btnCommandesRevuesRechercher;
        private System.Windows.Forms.Label labelCmdRevuesTitre;
        private System.Windows.Forms.TextBox txbCommandesRevuesTitre;
        private System.Windows.Forms.DataGridView dgvCommandesRevuesListe;
        private System.Windows.Forms.GroupBox grpCommandesRevuesNouvelle;
        private System.Windows.Forms.Label labelCmdRevuesNumCmd;
        private System.Windows.Forms.TextBox txbCommandesRevuesNumCommande;
        private System.Windows.Forms.Label labelCmdRevuesDate;
        private System.Windows.Forms.DateTimePicker dtpCommandesRevuesDate;
        private System.Windows.Forms.Label labelCmdRevuesMontant;
        private System.Windows.Forms.TextBox txbCommandesRevuesMontant;
        private System.Windows.Forms.Label labelCmdRevuesDateFin;
        private System.Windows.Forms.DateTimePicker dtpCommandesRevuesDateFin;
        private System.Windows.Forms.Button btnCommandesRevuesAjouter;
        private System.Windows.Forms.Button btnCommandesRevuesSupprimerCommande;
    }
}