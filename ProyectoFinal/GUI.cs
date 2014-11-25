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
    public partial class GUI : Form
    {
        bool automataLoaded = false;
        AFN_E afn = new AFN_E();
      
        private void restartValues()
        {
          
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
        public GUI()
        {
            InitializeComponent();
            evalBtn.BackColor = Color.LightSkyBlue;
            evalBtn.ForeColor = Color.White;
            evalBtn.FlatAppearance.BorderColor = Color.LightSkyBlue;
            evalBtn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            evalBtn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
           
            this.MinimumSize = new System.Drawing.Size(/*this.Width*/ 389, this.Height);
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

        private void loadAFN_Click(object sender, EventArgs e)
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
                   statusDisplay.Text = "Valid Automata";
                   statusDisplay.BackColor = Color.SlateGray;
               }
               else
               {
                   restartValues();
                   showData();
                   statusDisplay.Text = "Not Valid Automata";
                   statusDisplay.BackColor = Color.SlateGray;
               }
              
            }

        }


        private void evalBtn_Click(object sender, EventArgs e)
        {
            if (automataLoaded)
            {
                bool test = afn.eval(inputString.Text);
                statusDisplay.Text = '"'+inputString.Text +'"'+ (test ? " is Acepted": " is Not Acepted ");
                statusDisplay.BackColor = test ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
        
            }
            else
            {
                statusDisplay.Text = "Not Loaded";
                statusDisplay.BackColor = Color.SlateGray;

            }
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
           
            Mod1 m1 = new Mod1(regex.Text);
            Mod2 m2 = new Mod2();
            m2.computeAFN_E(m1.getResult());
            afn = m2.result; //fix conversion.
            bool test = m2.NBresult.evaluate(evaluate.Text);
            statusDisplay.Text = '"' + evaluate.Text + '"' + (test ? " is Acepted" : " is Not Acepted ");
            statusDisplay.BackColor = test ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
            
        }

        private void exportAFN_Click(object sender, EventArgs e)
        {
            
            //Load in case not loaded.
            Mod1 m1 = new Mod1();
            Mod2 m2 = new Mod2();
            m1.convertToPostfix(regex.Text);
            m2.computeAFN_E(m1.getResult());
            Mod3.quitaEpsilon(m2.result);
            afn = m2.result;
            //Parsed string.
            string afnS = afn.AFNtoString();

            SaveFileDialog savePicker = new SaveFileDialog();
            savePicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            savePicker.Filter = "Automata Files (*.af*)|*.af*|AFN Files (*.afn)|*.afn|AFD Files (*.afd)|*.afd";
            savePicker.FileName = "New AFN";
            savePicker.DefaultExt=".afn";

             if (savePicker.ShowDialog() == DialogResult.OK)
            {
                 System.IO.File.WriteAllText(savePicker.FileName, afnS);
            }
            
            
        }

        //Views
        private void viewAFN_Click(object sender, EventArgs e)
        {
            panelregex.Visible = false;
            panelAFN.Visible = true;
            panelTextEval.Visible = false;
            loadAFN.Visible = true;
            exportAFN.Visible = false;
            loadText.Visible = false;
        }

        private void viewRegex_Click(object sender, EventArgs e)
        {
            panelregex.Visible = true;
            panelAFN.Visible = false;
            panelTextEval.Visible = false;
            loadAFN.Visible = false;
            exportAFN.Visible = true;
            loadText.Visible = false;
        }

        private void viewTextEval_Click(object sender, EventArgs e)
        {
            panelregex.Visible = false;
            panelAFN.Visible = false;
            panelTextEval.Visible = true;
            loadAFN.Visible = false;
            exportAFN.Visible = true;
            loadText.Visible = true;
        }
        //text eval
        private void textEval_Click(object sender, EventArgs e)
        {
            if (textRegex.Text== "") return;
            Mod1 m1 = new Mod1(textRegex.Text);
            Mod2 m2 = new Mod2();
            m2.computeAFN_E(m1.getResult());
            afn = m2.result; //fix conversion.
            List<string> match = m2.NBresult.textEval(textTextbox.Text);
            resultTextbox.Text = string.Join("\n", match.ToArray());

            statusDisplay.Text = match.Count+" strings Accepted";
            statusDisplay.BackColor = match.Count != 0 ? Color.FromArgb(95, 183, 70) : Color.FromArgb(250, 47, 67);
        }

        private void loadText_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            file.Filter = "Text Files (*.txt)|*.txt";
            
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                textTextbox.Text = System.IO.File.ReadAllText(path);
                for (int i = 0; i < textTextbox.Text.Length; i++)
                {
                    if (textTextbox.Text[i] == '\n') resultTextbox.Text = "LOL";
                }
                    statusDisplay.Text = "Text Loaded";
                statusDisplay.BackColor = Color.SlateGray;
            }
        }

        private void textRegex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                textEval_Click(sender, e);
        }

        private void inputString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                evalBtn_Click(sender, e);
        }

        private void regex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                regbutton_Click(sender, e);
        }
    }
}
