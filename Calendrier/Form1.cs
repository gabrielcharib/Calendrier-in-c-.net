using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class Form1 : Form
    {
        private const int MaxRow = 6;
        private const int MaxCol = 7;
        Button[,] buttons = new Button[MaxRow, MaxCol];
        Label[] days = new Label[7];
        int nbButton;
        int horizontal;
        int vertical;
        DateTime today = DateTime.Now;
        int cptClick = 0;
        int cptClickP = 0;

        public Form1()
        {
            InitializeComponent();
            createMonthButtons();
            daysLabels();



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillFromDateFirstThisMonth(firstDAY(), lastDayOfMonth());

        }

        private void textCurrentMonth(DateTime date)
        {
            labelMoisEnCours.Text = "Mois en cours: " + date.ToString("M / yyyy");
        }

        /// <summary>
        /// creation des boutons.remplir un tableaux de boutons 
        /// </summary>
        private void createMonthButtons()
        {
           
            horizontal = 115;
            vertical = 80;
            for (int ligne = 0; ligne < MaxRow; ligne++)
            {
                for (int col = 0; col < MaxCol; col++)
                {
                    nbButton++;
                    this.buttons[ligne, col] = new Button();
                    this.buttons[ligne, col].Location = new System.Drawing.Point(horizontal, vertical);
                    this.buttons[ligne, col].Name = "button" + nbButton;
                    this.buttons[ligne, col].Size = new System.Drawing.Size(55, 55);
                    this.buttons[ligne, col].Text = "";
                    this.Controls.Add(buttons[ligne, col]);
                    horizontal += 60;

                }
                horizontal = 115;
                vertical += 60;
            }

        }

        private int firstDAY()
        {
            // Cette méthode retourne le premier jour du MOIS COURANT et convertit les jours de la semaine en valeur int pour remplir le tableau
            textCurrentMonth(today);
            DateTime thisDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return convertDaysToInt(thisDay);
        }

        /// <summary>
        /// retuner le premier jour du mois suivant 
        /// </summary>
        /// <param name="cptClique"></param>
        /// <returns></returns>
        private int firstDayNextMonth(int cptClique)// à chaque clique ça va faire +1
        {
            DateTime dayNextMonth = new DateTime(today.AddMonths(cptClique).Year, today.AddMonths(cptClique).Month, 1);
            textCurrentMonth(dayNextMonth);
            return convertDaysToInt(dayNextMonth);
        }

        private int firstDayPrevMonth(int click)
        {
            DateTime dayPrevMonth = new DateTime(today.AddMonths(-click).Year, today.AddMonths(-click).Month, 1);
            textCurrentMonth(dayPrevMonth);
            return convertDaysToInt(dayPrevMonth);
        }
        /// <summary>
        /// comvertite les noms des jours en int .pour repmir les tableaux 
        /// </summary>
        /// <param name="thisDay"></param>
        /// <returns></returns>
        private int convertDaysToInt(DateTime thisDay)
        {
            if (thisDay.DayOfWeek == DayOfWeek.Monday)
            {
                return 0;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 1;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 2;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Thursday)
            {
                return 3;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Friday)
            {
                return 4;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Saturday)
            {
                return 5;
            }
            else if (thisDay.DayOfWeek == DayOfWeek.Sunday)
            {
                return 6;
            }
            return 0;
        }

        /// <summary>
        /// calcule le dernier jour du mois 
        /// </summary>
        /// <returns>le dernier jours du mois </returns>
        private int lastDayOfMonth()
        {
            DateTime dayOne = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime last = dayOne.AddMonths(1).AddDays(-1);
            int dayMax = last.Day;
            return dayMax;

        }

        /// <summary>
        /// calculer le dernier jour du mois suivant 
        /// </summary>
        /// <param name="click"></param>
        /// <returns></returns>
        /// 


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////attantion ca resamble au code precesent//////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private int lastDayNextMonth(int click)
        {
            DateTime dayNextMonth = new DateTime(today.AddMonths(click).Year, today.AddMonths(click).Month, 1);
            DateTime last = dayNextMonth.AddMonths(1).AddDays(-1);
            int dayMax = last.Day;
            return dayMax;
        }

        /// <summary>
        /// calculer le dernier mois de mois precendent 
        /// </summary>
        /// <param name="click"></param>
        /// <returns></returns>
        private int lastDayOfPreviousMonth(int click)
        {
            DateTime dayOne = new DateTime(today.AddMonths(-click).Year, today.AddMonths(-click).Month, 1);
            DateTime last = dayOne.AddDays(-1);
            int dayMax = last.Day;
            return dayMax;

        }
        private void daysLabels()
        {
            int x;
            int y;
            x = 115;
            y = 60;

            CultureInfo culture = new CultureInfo("fr-BE");

            DayOfWeek weekDays = culture.DateTimeFormat.FirstDayOfWeek;//monday

            for (int i = 0; i < days.Length; i++)
            {
                this.days[i] = new Label();
                this.days[i].AutoSize = true;
                this.days[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.days[i].Location = new System.Drawing.Point(x, y);
                this.days[i].Name = "day";
                this.days[i].Size = new System.Drawing.Size(55, 55);
                this.days[i].Text = weekDays.ToString();
                this.Controls.Add(this.days[i]);
                weekDays++;
                x += 60;
                if (i == 6)
                {
                    this.days[i].Text = DayOfWeek.Sunday.ToString();
                }


            }
        }




        /// <summary>
        /// remplir des boutons du calendrier 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private void fillFromDateFirstThisMonth(int min, int max)
        {
            int c = min;
            int r = 0;
            int dd = 1;
            while (dd != max)
            {
                this.buttons[r, c].Text = dd.ToString();
                dd++;
                c++;
                if (c == MaxCol)// arriver a la din de la commande 
                {
                    c = 0;
                    r++;

                }
                else if (r == MaxRow)
                {
                    r = 0;
                    c++;
                }

            }
            dd = max;
            this.buttons[r, c].Text = dd.ToString();
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    if (this.buttons[i, j].Text == "")
                    {
                        this.buttons[i, j].Enabled = false;
                    }

                }
            }

        }

        /// <summary>
        /// effacher les contenu des boutons 
        ///.utiliser pour le changement de date 
        /// </summary>
        private void clearButtons()
        {
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    this.buttons[i, j].Enabled = true;
                    this.buttons[i, j].Text = "";
                }

            }
        }


        private void btPrevious_Click(object sender, EventArgs e)
        {
            cptClickP++;
            clearButtons();
            lastDayOfPreviousMonth(cptClickP);
            fillFromDateFirstThisMonth(firstDayPrevMonth(cptClickP), lastDayOfPreviousMonth(cptClickP));

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            cptClick++;
            clearButtons();
            fillFromDateFirstThisMonth(firstDayNextMonth(cptClick), lastDayNextMonth(cptClick));
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
