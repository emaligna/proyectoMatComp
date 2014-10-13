using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class AFD : Form
    {

        bool automataLoaded = false;
        //Automata variables
        List<List<String>> automataMatrix = new List<List<string>>();
        List<string> states = new List<string>();
        List<char> alphabet = new List<char>();
        string initialState;
        List<string> finalStates = new List<string>();

        //file parser
        private void restartValues()
        {
            automataMatrix = new List<List<string>>();
            states = new List<string>();
            alphabet = new List<char>();
            finalStates = new List<string>();
            initialState = "";
            tableView.DataSource = null;
            tableView.Rows.Clear();
            tableView.Columns.Clear();
            tableView.Update();
        }
        private bool parser(string path)
        {
            restartValues();
           try 
           {
               string[] lines = System.IO.File.ReadAllLines(path);
               string[] temp = lines[0].Split(',');
               for (int i = 0; i < temp.Length; i++)
               {
                   alphabet.Add(temp[i][0]);
               }
               temp = lines[1].Split('-');
               initialState = temp[0][0] == '*' ? temp[0].Substring(1) : temp[0];
               for (int i = 1; i < lines.Length; i++)
               {
                   temp = lines[i].Split('-');
                   //asigning states
                   if (i == 1)
                       initialState = temp[0][0] == '*' ? temp[0].Substring(1) : temp[0];
                   if (temp[0][0] == '*')
                   {
                       finalStates.Add(temp[0].Substring(1));
                       states.Add(temp[0].Substring(1));
                   }
                   else
                       states.Add(temp[0]);

                   //Create matrix
                   temp = temp[1].Split('&');
                   List<string> tempList = new List<string>();
                   for (int j = 0; j < temp.Length; j++)
                   {
                       tempList.Add(temp[j]);
                   }
                   automataMatrix.Add(tempList);
               }
               return true;
           }
           catch(Exception e)
           {
               return false;
           }
        }
        //Automata methods
        private int symbol(char c)
        {
            return alphabet.IndexOf(c);
        }
        private int state(string s)
        {
            return states.IndexOf(s);
        }
        private string transition(string state, char c)
        {
            int i=this.state(state);
            int j=this.symbol(c);
            if (i != -1 && j != -1)
            {
                return this.automataMatrix[i][j];
            }
            return null;
        }
        private bool eval(string s)
        {
            string curState = this.initialState;
            for (int i = 0; i < s.Length; i++)
            {
                curState = transition(curState, s[i]);
            }
            return (finalStates.IndexOf(curState) != -1);
        }
        private void createTable()
        {
            tableView.ReadOnly = false;
            for (int i = 0; i < alphabet.Count; i++)
            {
                tableView.Columns.Add(alphabet[i] + "", "'" + alphabet[i] + "'");
            }
            for (int i = 0; i < states.Count; i++)
            {
                tableView.Rows.Add();
                tableView.Rows[i].HeaderCell.Value = states[i];
                for (int j = 0; j < alphabet.Count; j++)
                {
                    tableView.Rows[i].Cells[j].Value = automataMatrix[i][j];
                }
            }
            tableView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            tableView.AutoResizeColumns();
            tableView.ReadOnly = true;
        }
        private void showData()
        {
            int offset_text = 15;
            alphabetLabel.Text = "Alphabet: ".PadRight(offset_text) + string.Join(",", alphabet.ToArray());
            statesLabel.Text = "States: ".PadRight(offset_text) + string.Join(",", states.ToArray());
            initLabel.Text = "Initial State: ".PadRight(offset_text) + initialState;
            finalLabel.Text = "Final States: ".PadRight(offset_text) + string.Join(",", finalStates.ToArray());
            matrixLabel.Text = "Transition Matrix:";
        }
        //UI stuff
        public AFD()
        {
            InitializeComponent();
            evalBtn.BackColor = Color.LightSkyBlue;
            evalBtn.ForeColor = Color.White;
            evalBtn.FlatAppearance.BorderColor = Color.LightSkyBlue;
            evalBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            evalBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
           
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            
        }
        override protected void OnResize(EventArgs e)
        {
            tableView.Width = this.Width - this.Width / 5; 
            inputString.Width = tableView.Width - evalBtn.Width;
            evalBtn.Location = new Point(inputString.Width, evalBtn.Location.Y);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadAutomataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
               path = file.FileName;
               automataLoaded = parser(path);
               if (automataLoaded)
               {
                   showData();
                   createTable();
                   textDisplay.Text = "Valid Automata";
                   textDisplay.BackColor = Color.SlateGray;
               }
               else
               {
                   restartValues();
                   showData();
                   textDisplay.Text = "Not Valid Automata";
                   textDisplay.BackColor = Color.SlateGray;
               }
              
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void evalBtn_Click(object sender, EventArgs e)
        {
            if (automataLoaded)
            {
                bool test = eval(inputString.Text);
                textDisplay.Text = '"'+inputString.Text +'"'+ (test ? " is Acepted": " is Not Acepted ");
                textDisplay.BackColor = test ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
        
            }
            else
            {
                textDisplay.Text = "Not Loaded";
                textDisplay.BackColor = Color.SlateGray;

            }
        }
    }
}
