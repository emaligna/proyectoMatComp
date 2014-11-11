namespace AutomataND
{
    partial class AFN
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
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAutomataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputString = new System.Windows.Forms.TextBox();
            this.evalBtn = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.Label();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.statesLabel = new System.Windows.Forms.Label();
            this.initLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.matrixLabel = new System.Windows.Forms.Label();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.checkwrite = new System.Windows.Forms.CheckBox();
            this.panelregex = new System.Windows.Forms.Panel();
            this.regbutton = new System.Windows.Forms.Button();
            this.evaluate = new System.Windows.Forms.TextBox();
            this.regex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.panelregex.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAutomataToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadAutomataToolStripMenuItem
            // 
            this.loadAutomataToolStripMenuItem.Name = "loadAutomataToolStripMenuItem";
            this.loadAutomataToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadAutomataToolStripMenuItem.Text = "Load AFN";
            this.loadAutomataToolStripMenuItem.Click += new System.EventHandler(this.loadAutomataToolStripMenuItem_Click);
            // 
            // inputString
            // 
            this.inputString.Location = new System.Drawing.Point(15, 65);
            this.inputString.Name = "inputString";
            this.inputString.Size = new System.Drawing.Size(193, 20);
            this.inputString.TabIndex = 2;
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
            this.evalBtn.Location = new System.Drawing.Point(204, 65);
            this.evalBtn.Name = "evalBtn";
            this.evalBtn.Size = new System.Drawing.Size(75, 20);
            this.evalBtn.TabIndex = 3;
            this.evalBtn.Text = "Evaluate";
            this.evalBtn.UseVisualStyleBackColor = false;
            this.evalBtn.Click += new System.EventHandler(this.evalBtn_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.AutoSize = true;
            this.textDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay.ForeColor = System.Drawing.Color.White;
            this.textDisplay.Location = new System.Drawing.Point(15, 28);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(10, 14);
            this.textDisplay.TabIndex = 4;
            this.textDisplay.Text = " ";
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetLabel.Location = new System.Drawing.Point(12, 105);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(68, 11);
            this.alphabetLabel.TabIndex = 5;
            this.alphabetLabel.Text = "Alphabet:";
            this.alphabetLabel.Click += new System.EventHandler(this.alphabetLabel_Click);
            // 
            // statesLabel
            // 
            this.statesLabel.AutoSize = true;
            this.statesLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statesLabel.Location = new System.Drawing.Point(12, 118);
            this.statesLabel.Name = "statesLabel";
            this.statesLabel.Size = new System.Drawing.Size(54, 11);
            this.statesLabel.TabIndex = 6;
            this.statesLabel.Text = "States:";
            // 
            // initLabel
            // 
            this.initLabel.AutoSize = true;
            this.initLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initLabel.Location = new System.Drawing.Point(12, 131);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(103, 11);
            this.initLabel.TabIndex = 7;
            this.initLabel.Text = "Initial State:";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(12, 144);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(89, 11);
            this.finalLabel.TabIndex = 8;
            this.finalLabel.Text = "Final State:";
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixLabel.Location = new System.Drawing.Point(12, 169);
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
            this.tableView.Location = new System.Drawing.Point(18, 183);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.Size = new System.Drawing.Size(240, 150);
            this.tableView.TabIndex = 10;
            // 
            // checkwrite
            // 
            this.checkwrite.AutoSize = true;
            this.checkwrite.BackColor = System.Drawing.SystemColors.Control;
            this.checkwrite.Location = new System.Drawing.Point(264, 12);
            this.checkwrite.Name = "checkwrite";
            this.checkwrite.Size = new System.Drawing.Size(109, 17);
            this.checkwrite.TabIndex = 11;
            this.checkwrite.Text = "Escribir Expresión";
            this.checkwrite.UseVisualStyleBackColor = false;
            this.checkwrite.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelregex
            // 
            this.panelregex.Controls.Add(this.label2);
            this.panelregex.Controls.Add(this.label1);
            this.panelregex.Controls.Add(this.regbutton);
            this.panelregex.Controls.Add(this.evaluate);
            this.panelregex.Controls.Add(this.regex);
            this.panelregex.Location = new System.Drawing.Point(0, 131);
            this.panelregex.Name = "panelregex";
            this.panelregex.Size = new System.Drawing.Size(353, 292);
            this.panelregex.TabIndex = 12;
            this.panelregex.Visible = false;
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
            // 
            // regex
            // 
            this.regex.Location = new System.Drawing.Point(52, 23);
            this.regex.Name = "regex";
            this.regex.Size = new System.Drawing.Size(208, 20);
            this.regex.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "String";
            // 
            // AFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 375);
            this.Controls.Add(this.panelregex);
            this.Controls.Add(this.checkwrite);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.matrixLabel);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.initLabel);
            this.Controls.Add(this.statesLabel);
            this.Controls.Add(this.alphabetLabel);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.evalBtn);
            this.Controls.Add(this.inputString);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AFN";
            this.Text = "AFN";
            this.Load += new System.EventHandler(this.AFN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.panelregex.ResumeLayout(false);
            this.panelregex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAutomataToolStripMenuItem;
        private System.Windows.Forms.TextBox inputString;
        private System.Windows.Forms.Button evalBtn;
        private System.Windows.Forms.Label textDisplay;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.Label statesLabel;
        private System.Windows.Forms.Label initLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label matrixLabel;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.CheckBox checkwrite;
        private System.Windows.Forms.Panel panelregex;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.TextBox evaluate;
        private System.Windows.Forms.TextBox regex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

