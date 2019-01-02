using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkingData
{
    public partial class MainForm : Form
    {
        public string[] Nicknames;
        public int iterator = 0;
        public int colNames = 0;
        public int countOfPerson = 0;
        public int countOfNotPerson = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader fs = new StreamReader(@"C:\Users\nikit\Documents\ML\Instagram Classification\data\needToMark.txt"))
            {
                colNames = Convert.ToInt32(fs.ReadLine());
                Nicknames = new string[colNames];
                int itr = 0;
                while (itr < colNames) 
                {
                    string temp = fs.ReadLine();

                    if (temp == null) break;

                    Nicknames[itr++] = temp;
                }
            }
            ShowPage();
        }

        void ShowPage()
        {
            wB.Url = new Uri("https://instagram.com/" + Nicknames[iterator]);
            countLbl.Text = (colNames - iterator).ToString();
            countOfNotPersonLbl.Text = countOfNotPerson.ToString();
            countOfPersonLbl.Text = countOfPerson.ToString();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            iterator++;
            ShowPage();
        }

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\nikit\Documents\ML\Instagram Classification\data\persons.txt";
            File.AppendAllText(filename, Nicknames[iterator++]);
            File.AppendAllText(filename, "\n");
            countOfPerson++;
            ShowPage();
        }

        private void SpamBtn_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\nikit\Documents\ML\Instagram Classification\data\spams.txt";
            File.AppendAllText(filename, Nicknames[iterator++]);
            File.AppendAllText(filename, "\n");
            countOfNotPerson++;
            ShowPage();
        }
    }
}
