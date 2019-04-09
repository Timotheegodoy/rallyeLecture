using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using métier;
using Connection;

namespace Nouvelle_Classe
{
    partial class FormNouvelleClasse : Form
    {
        public FormNouvelleClasse()
        {
            InitializeComponent();
            CbRepertoire.Click += new EventHandler(CbRepertoireOuvrir);
            ckbAleatoire.CheckedChanged += new EventHandler(ckbAleatoireCheck);
            ckbConstruit.CheckedChanged += new EventHandler(ckbConstruitCheck);
            List<Niveau> LesNiveaux = new List<Niveau>();
            TableNiveau LbNiveauSql = new TableNiveau("root", "siojjr", "rallyeLecture", "172.16.0.188");
            LesNiveaux = LbNiveauSql.GetAll();
            foreach (Niveau niveau in LesNiveaux)
            {
                LbNiveau.Items.Add(niveau.GetId + " (" + niveau.GetNiveauScolaire + ")");
            }

        }

        private void CbRepertoireOuvrir(object sender, EventArgs e)
        {
            ClbIntegrer.Items.Clear();
            FbdCsv.RootFolder = Environment.SpecialFolder.MyComputer;
            FbdCsv.ShowDialog();
            CbRepertoire.Text = FbdCsv.SelectedPath;
            DirectoryInfo dossier = new DirectoryInfo(@CbRepertoire.Text);
            FileInfo[] fichiers = dossier.GetFiles();
            foreach (FileInfo fichier in fichiers)
            {
                if (fichier.Name.Contains(".csv") == true)
                {
                    ClbIntegrer.Items.Add(fichier.Name);
                }
            }
        }

        private void ckbAleatoireCheck(object sender, EventArgs e)
        {
            if (ckbAleatoire.Checked == true)
            {
                ckbConstruit.Checked = false;
            }
        }

        private void ckbConstruitCheck(object sender, EventArgs e)
        {
            if (ckbConstruit.Checked == true)
            {
                ckbAleatoire.Checked = false;
            }
        }

        private void BtnIntegrer_Click(object sender, EventArgs e)
        {   
            // Dans constructeur classe niveau converti ascii vers int
            string niveau = Convert.ToString(LbNiveau.SelectedItem.ToString()[0]);
            int intniveau = Convert.ToInt32(niveau);
            Classe classe = new Classe (1,TbAnnee.Text,intniveau);
            MessageBox.Show(classe.GetAnneeScolaire + " " + classe.Getid + " " + classe.GetNiveau);
            TableClasse tableClasse = new TableClasse("root", "siojjr", "rallyeLecture", "172.16.0.188");
            TableEleve tableEleve = new TableEleve("root", "siojjr", "rallyeLecture", "172.16.0.188");
            LesEleves lesEleves = new LesEleves();
            if (ckbAleatoire.Checked == true)
            {
                lesEleves.LoadCsv(PassWordType.aleatoire,CbRepertoire.Text+'/'+ClbIntegrer.GetItemText(ClbIntegrer.CheckedItems[0]));
                lesEleves.CreateCsvPasswordFile("test");
                long idclasse = tableClasse.insert(classe);
                for (int i = 0; i < lesEleves.GetLesEleves.Count; i++)
                {
                    tableEleve.Insert(lesEleves.GetLesEleves[i], idclasse);
                }
            }
            if (ckbConstruit.Checked == true)
            {
                lesEleves.LoadCsv(PassWordType.construit, CbRepertoire.Text + '/' + ClbIntegrer.GetItemText(ClbIntegrer.CheckedItems[0]));
                lesEleves.CreateCsvPasswordFile("test");
                long idclasse = tableClasse.insert(classe);
                for (int i = 0; i < lesEleves.GetLesEleves.Count; i++)
                {
                    tableEleve.Insert(lesEleves.GetLesEleves[i], idclasse);
                }
            }
            if (ckbAleatoire.Checked == false && ckbConstruit.Checked == false)
            {
                MessageBox.Show("ERREUR \n Veuillez cochez un type de mot de passe");
            }
        }
    }
}