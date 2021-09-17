using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// block 1: les variables 
        /// </summary>

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

        private void currentMonth(DateTime date)
        {
            labelMoisEnCours.Text = "Mois en Cours : " + date.ToString("M / yyyy");
        }


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
                   // this.buttons[ligne, col].Click += new EventHandler(this.button_ClickEvent);
                    horizontal += 60;

                }
                horizontal = 115;
                vertical += 60;
            }
            

        }


        private void daysLabels()
        {
            int x;
            int y;
            x = 115;
            y = 60;
            //DateTime day=day.Date
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


        private int convertDays(DateTime thisDay)
        {
            // Cette méthode convertit les jours de la semaine en valeur int pour remplir le tableau
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




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuiter_Click(object sender, EventArgs e)
        {
            //test git
        }
    }
}
