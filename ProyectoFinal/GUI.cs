using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomataND
{
    public partial class AFN : Form
    {
        bool automataLoaded = false;
        AFN_E afn = new AFN_E();
        //Automata variables
        /*
        List<List<List<string>>> automataMatrix = new List<List<List<string>>>();
        List<string> states = new List<string>();
        List<char> alphabet = new List<char>();
        string initialState;
        List<string> finalStates = new List<string>();
        */
        //file parser
        private void restartValues()
        {
            /*
            automataMatrix = new List<List<List<string>>>();
            states = new List<string>();
            alphabet = new List<char>();
            finalStates = new List<string>();
            initialState = "";
             */
            afn.clear();
            tableView.DataSource = null;
            tableView.Rows.Clear();
            tableView.Columns.Clear();
            tableView.Update();
        }
       
        private void createTable()
        {
            tableView.ReadOnly = false;
            for (int i = 0; i < afn.alphabet.Count; i++)
            {
                tableView.Columns.Add(afn.alphabet[i] + "", "'" + afn.alphabet[i] + "'");
            }
            for (int i = 0; i < afn.states.Count; i++)
            {
                tableView.Rows.Add();
                tableView.Rows[i].HeaderCell.Value = afn.states[i];
                for (int j = 0; j < afn.alphabet.Count; j++)
                {
                    string val = "";
                    for (int k = 0; k < afn.transitionMatrix[i][j].Count-1; k++)
                    {
                        val += afn.transitionMatrix[i][j][k] + ", ";
                    }
                    val += afn.transitionMatrix[i][j][afn.transitionMatrix[i][j].Count - 1] == "%" ? "Ø" : afn.transitionMatrix[i][j][afn.transitionMatrix[i][j].Count - 1];
                    //Ø used to imply empty state
                    tableView.Rows[i].Cells[j].Value = val;
                }
            }
            tableView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            tableView.AutoResizeColumns();
            tableView.ReadOnly = true;
        }
        private void showData()
        {
            int offset_text = 15;
            alphabetLabel.Text = "Alphabet: ".PadRight(offset_text) + string.Join(",", afn.alphabet.ToArray());
            statesLabel.Text = "States: ".PadRight(offset_text) + string.Join(",", afn.states.ToArray());
            initLabel.Text = "Initial State: ".PadRight(offset_text) + afn.initialState;
            finalLabel.Text = "Final States: ".PadRight(offset_text) + string.Join(",", afn.finalStates.ToArray());
            matrixLabel.Text = "Transition Matrix:";
        }

        //UI stuff
        public AFN()
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

        private void loadAutomataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            file.Filter = "Automata Files (*.af*)|*.af*|AFN Files (*.afn)|*.afn|AFD Files (*.afd)|*.afd";
            
            if (file.ShowDialog() == DialogResult.OK)
            {
               path = file.FileName;
               this.restartValues();
               automataLoaded = afn.parser(path);
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


        private void evalBtn_Click(object sender, EventArgs e)
        {
            if (automataLoaded)
            {
                bool test = afn.eval(inputString.Text);
                textDisplay.Text = '"'+inputString.Text +'"'+ (test ? " is Acepted": " is Not Acepted ");
                textDisplay.BackColor = test ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
        
            }
            else
            {
                textDisplay.Text = "Not Loaded";
                textDisplay.BackColor = Color.SlateGray;

            }
        }

        private void AFN_Load(object sender, EventArgs e)
        {

        }

        private void alphabetLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panelregex.Visible = checkwrite.Checked;
            
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            Mod1 m1 = new Mod1();
            Mod2 m2 = new Mod2();
            m1.convertToPostfix(regex.Text);
            m2.computeAFN_E(m1.getResult());
            Mod3.quitaEpsilon(m2.result);
            afn = m2.result;
            bool test = afn.eval(evaluate.Text);
            textDisplay.Text = '"' + evaluate.Text + '"' + (test ? " is Acepted" : " is Not Acepted ");
            textDisplay.BackColor = test ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
            
        }
    }
}
