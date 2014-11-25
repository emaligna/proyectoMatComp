namespace AutomataND
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAFN = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAFN = new System.Windows.Forms.ToolStripMenuItem();
            this.loadText = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAFN = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTextEval = new System.Windows.Forms.ToolStripMenuItem();
            this.inputString = new System.Windows.Forms.TextBox();
            this.evalBtn = new System.Windows.Forms.Button();
            this.statusDisplay = new System.Windows.Forms.Label();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.statesLabel = new System.Windows.Forms.Label();
            this.initLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.matrixLabel = new System.Windows.Forms.Label();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.panelregex = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regbutton = new System.Windows.Forms.Button();
            this.evaluate = new System.Windows.Forms.TextBox();
            this.regex = new System.Windows.Forms.TextBox();
            this.panelAFN = new System.Windows.Forms.Panel();
            this.panelTextEval = new System.Windows.Forms.Panel();
            this.textEval = new System.Windows.Forms.Button();
            this.textRegex = new System.Windows.Forms.TextBox();
            this.resultTextbox = new System.Windows.Forms.RichTextBox();
            this.textTextbox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.panelregex.SuspendLayout();
            this.panelAFN.SuspendLayout();
            this.panelTextEval.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ViewMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAFN,
            this.exportAFN,
            this.loadText});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // loadAFN
            // 
            this.loadAFN.Name = "loadAFN";
            this.loadAFN.Size = new System.Drawing.Size(152, 22);
            this.loadAFN.Text = "Load AFN";
            this.loadAFN.Click += new System.EventHandler(this.loadAFN_Click);
            // 
            // exportAFN
            // 
            this.exportAFN.Name = "exportAFN";
            this.exportAFN.Size = new System.Drawing.Size(152, 22);
            this.exportAFN.Text = "Export AFN";
            this.exportAFN.Visible = false;
            this.exportAFN.Click += new System.EventHandler(this.exportAFN_Click);
            // 
            // loadText
            // 
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(152, 22);
            this.loadText.Text = "Load Text";
            this.loadText.Visible = false;
            this.loadText.Click += new System.EventHandler(this.loadText_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAFN,
            this.viewRegex,
            this.viewTextEval});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(44, 20);
            this.ViewMenu.Text = "View";
            // 
            // viewAFN
            // 
            this.viewAFN.Name = "viewAFN";
            this.viewAFN.Size = new System.Drawing.Size(154, 22);
            this.viewAFN.Text = "AFN";
            this.viewAFN.Click += new System.EventHandler(this.viewAFN_Click);
            // 
            // viewRegex
            // 
            this.viewRegex.Name = "viewRegex";
            this.viewRegex.Size = new System.Drawing.Size(154, 22);
            this.viewRegex.Text = "Regex";
            this.viewRegex.Click += new System.EventHandler(this.viewRegex_Click);
            // 
            // viewTextEval
            // 
            this.viewTextEval.Name = "viewTextEval";
            this.viewTextEval.Size = new System.Drawing.Size(154, 22);
            this.viewTextEval.Text = "Text Evaluation";
            this.viewTextEval.Click += new System.EventHandler(this.viewTextEval_Click);
            // 
            // inputString
            // 
            this.inputString.Location = new System.Drawing.Point(17, 3);
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(193, 20);
            this.inputString.TabIndex = 2;
            this.inputString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputString_KeyPress);
            // 
            // evalBtn
            // 
            this.evalBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.evalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.evalBtn.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.evalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.evalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.evalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evalBtn.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalBtn.ForeColor = System.Drawing.Color.White;
            this.evalBtn.Location = new System.Drawing.Point(206, 3);
            this.evalBtn.Name = "evalBtn";
            this.evalBtn.Size = new System.Drawing.Size(75, 20);
            this.evalBtn.TabIndex = 3;
            this.evalBtn.Text = "Evaluate";
            this.evalBtn.UseVisualStyleBackColor = false;
            this.evalBtn.Click += new System.EventHandler(this.evalBtn_Click);
            // 
            // statusDisplay
            // 
            this.statusDisplay.AutoSize = true;
            this.statusDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplay.ForeColor = System.Drawing.Color.White;
            this.statusDisplay.Location = new System.Drawing.Point(15, 28);
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(10, 14);
            this.statusDisplay.TabIndex = 4;
            this.statusDisplay.Text = " ";
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetLabel.Location = new System.Drawing.Point(14, 43);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(68, 11);
            this.alphabetLabel.TabIndex = 5;
            this.alphabetLabel.Text = "Alphabet:";
            // 
            // statesLabel
            // 
            this.statesLabel.AutoSize = true;
            this.statesLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statesLabel.Location = new System.Drawing.Point(14, 56);
            this.statesLabel.Name = "statesLabel";
            this.statesLabel.Size = new System.Drawing.Size(54, 11);
            this.statesLabel.TabIndex = 6;
            this.statesLabel.Text = "States:";
            // 
            // initLabel
            // 
            this.initLabel.AutoSize = true;
            this.initLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initLabel.Location = new System.Drawing.Point(14, 69);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(103, 11);
            this.initLabel.TabIndex = 7;
            this.initLabel.Text = "Initial State:";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(14, 82);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(89, 11);
            this.finalLabel.TabIndex = 8;
            this.finalLabel.Text = "Final State:";
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixLabel.Location = new System.Drawing.Point(14, 107);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(131, 11);
            this.matrixLabel.TabIndex = 9;
            this.matrixLabel.Text = "Transition Matrix:";
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(20, 121);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.Size = new System.Drawing.Size(240, 150);
            this.tableView.TabIndex = 10;
            // 
            // panelregex
            // 
            this.panelregex.Controls.Add(this.label2);
            this.panelregex.Controls.Add(this.label1);
            this.panelregex.Controls.Add(this.regbutton);
            this.panelregex.Controls.Add(this.evaluate);
            this.panelregex.Controls.Add(this.regex);
            this.panelregex.Location = new System.Drawing.Point(14, 48);
            this.panelregex.Name = "panelregex";
            this.panelregex.Size = new System.Drawing.Size(353, 292);
            this.panelregex.TabIndex = 12;
            this.panelregex.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Regex";
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.regbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbutton.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.regbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.regbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.regbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbutton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.ForeColor = System.Drawing.Color.White;
            this.regbutton.Location = new System.Drawing.Point(266, 38);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(75, 20);
            this.regbutton.TabIndex = 4;
            this.regbutton.Text = "Evaluate";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // evaluate
            // 
            this.evaluate.Location = new System.Drawing.Point(52, 49);
            this.evaluate.Name = "evaluate";
            this.evaluate.Size = new System.Drawing.Size(208, 20);
            this.evaluate.TabIndex = 2;
            this.evaluate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regex_KeyPress);
            // 
            // regex
            // 
            this.regex.Location = new System.Drawing.Point(52, 23);
            this.regex.Name = "regex";
            this.regex.Size = new System.Drawing.Size(208, 20);
            this.regex.TabIndex = 1;
            this.regex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regex_KeyPress);
            // 
            // panelAFN
            // 
            this.panelAFN.AutoSize = true;
            this.panelAFN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAFN.Controls.Add(this.inputString);
            this.panelAFN.Controls.Add(this.evalBtn);
            this.panelAFN.Controls.Add(this.alphabetLabel);
            this.panelAFN.Controls.Add(this.tableView);
            this.panelAFN.Controls.Add(this.statesLabel);
            this.panelAFN.Controls.Add(this.matrixLabel);
            this.panelAFN.Controls.Add(this.initLabel);
            this.panelAFN.Controls.Add(this.finalLabel);
            this.panelAFN.Location = new System.Drawing.Point(12, 46);
            this.panelAFN.Name = "panelAFN";
            this.panelAFN.Size = new System.Drawing.Size(284, 274);
            this.panelAFN.TabIndex = 13;
            // 
            // panelTextEval
            // 
            this.panelTextEval.Controls.Add(this.textEval);
            this.panelTextEval.Controls.Add(this.textRegex);
            this.panelTextEval.Controls.Add(this.resultTextbox);
            this.panelTextEval.Controls.Add(this.textTextbox);
            this.panelTextEval.Location = new System.Drawing.Point(12, 46);
            this.panelTextEval.Name = "panelTextEval";
            this.panelTextEval.Size = new System.Drawing.Size(724, 294);
            this.panelTextEval.TabIndex = 14;
            this.panelTextEval.Visible = false;
            // 
            // textEval
            // 
            this.textEval.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textEval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textEval.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.textEval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.textEval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.textEval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textEval.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEval.ForeColor = System.Drawing.Color.White;
            this.textEval.Location = new System.Drawing.Point(618, 25);
            this.textEval.Name = "textEval";
            this.textEval.Size = new System.Drawing.Size(75, 20);
            this.textEval.TabIndex = 4;
            this.textEval.Text = "Evaluate";
            this.textEval.UseVisualStyleBackColor = false;
            this.textEval.Click += new System.EventHandler(this.textEval_Click);
            // 
            // textRegex
            // 
            this.textRegex.Location = new System.Drawing.Point(20, 26);
            this.textRegex.Name = "textRegex";
            this.textRegex.Size = new System.Drawing.Size(601, 20);
            this.textRegex.TabIndex = 2;
            this.textRegex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRegex_KeyPress);
            // 
            // resultTextbox
            // 
            this.resultTextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.resultTextbox.DetectUrls = false;
            this.resultTextbox.Location = new System.Drawing.Point(391, 58);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.ReadOnly = true;
            this.resultTextbox.Size = new System.Drawing.Size(299, 233);
            this.resultTextbox.TabIndex = 1;
            this.resultTextbox.Text = "";
            // 
            // textTextbox
            // 
            this.textTextbox.DetectUrls = false;
            this.textTextbox.Location = new System.Drawing.Point(20, 58);
            this.textTextbox.Name = "textTextbox";
            this.textTextbox.Size = new System.Drawing.Size(334, 233);
            this.textTextbox.TabIndex = 0;
            this.textTextbox.Text = "";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 375);
            this.Controls.Add(this.panelTextEval);
            this.Controls.Add(this.panelAFN);
            this.Controls.Add(this.panelregex);
            this.Controls.Add(this.statusDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI";
            this.Text = "AFN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.panelregex.ResumeLayout(false);
            this.panelregex.PerformLayout();
            this.panelAFN.ResumeLayout(false);
            this.panelAFN.PerformLayout();
            this.panelTextEval.ResumeLayout(false);
            this.panelTextEval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem loadAFN;
        private System.Windows.Forms.TextBox inputString;
        private System.Windows.Forms.Button evalBtn;
        private System.Windows.Forms.Label statusDisplay;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.Label statesLabel;
        private System.Windows.Forms.Label initLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label matrixLabel;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.Panel panelregex;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.TextBox evaluate;
        private System.Windows.Forms.TextBox regex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exportAFN;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAFN;
        private System.Windows.Forms.ToolStripMenuItem viewRegex;
        private System.Windows.Forms.ToolStripMenuItem viewTextEval;
        private System.Windows.Forms.Panel panelAFN;
        private System.Windows.Forms.Panel panelTextEval;
        private System.Windows.Forms.RichTextBox resultTextbox;
        private System.Windows.Forms.RichTextBox textTextbox;
        private System.Windows.Forms.Button textEval;
        private System.Windows.Forms.TextBox textRegex;
        private System.Windows.Forms.ToolStripMenuItem loadText;
    }
}

