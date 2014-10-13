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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
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
            this.loadAutomataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.evalBtn.Location = new System.Drawing.Point(207, 65);
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
            // AFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 375);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
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
    }
}

