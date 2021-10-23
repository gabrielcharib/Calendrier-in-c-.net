using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class Form2 : Form
    {

        Dictionary<DateTime, String> noteCalendrier = new Dictionary<DateTime, string>(); //dico ou on va stoque les informations 


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnregistre_Click(object sender, EventArgs e)
        {

            String txt = text.Text;
            MessageBox.Show(txt);
        // si text vide afficher message  d'ereur 

        //si non vide 

        //recupere date 
        // date = cle dico 
        // enregistre message dans dico
        // tout enregistre

        }
    }
}
