namespace BrowerWordle
{
    partial class FormWordleControls
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWinPct = new System.Windows.Forms.TextBox();
            this.textBoxWinCount = new System.Windows.Forms.TextBox();
            this.textBoxPlayCount = new System.Windows.Forms.TextBox();
            this.buttonResetStatistics = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxWinPct);
            this.groupBox1.Controls.Add(this.textBoxWinCount);
            this.groupBox1.Controls.Add(this.textBoxPlayCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Win Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Games Won";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Games Played";
            // 
            // textBoxWinPct
            // 
            this.textBoxWinPct.Location = new System.Drawing.Point(107, 71);
            this.textBoxWinPct.Name = "textBoxWinPct";
            this.textBoxWinPct.ReadOnly = true;
            this.textBoxWinPct.Size = new System.Drawing.Size(100, 20);
            this.textBoxWinPct.TabIndex = 2;
            this.textBoxWinPct.Text = "%";
            // 
            // textBoxWinCount
            // 
            this.textBoxWinCount.Location = new System.Drawing.Point(107, 45);
            this.textBoxWinCount.Name = "textBoxWinCount";
            this.textBoxWinCount.ReadOnly = true;
            this.textBoxWinCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxWinCount.TabIndex = 1;
            // 
            // textBoxPlayCount
            // 
            this.textBoxPlayCount.Location = new System.Drawing.Point(107, 19);
            this.textBoxPlayCount.Name = "textBoxPlayCount";
            this.textBoxPlayCount.ReadOnly = true;
            this.textBoxPlayCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayCount.TabIndex = 0;
            // 
            // buttonResetStatistics
            // 
            this.buttonResetStatistics.Location = new System.Drawing.Point(12, 121);
            this.buttonResetStatistics.Name = "buttonResetStatistics";
            this.buttonResetStatistics.Size = new System.Drawing.Size(103, 23);
            this.buttonResetStatistics.TabIndex = 1;
            this.buttonResetStatistics.Text = "Reset Statistics";
            this.buttonResetStatistics.UseVisualStyleBackColor = true;
            this.buttonResetStatistics.Click += new System.EventHandler(this.buttonResetStatistics_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(130, 121);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(103, 23);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // FormWordleControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 155);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonResetStatistics);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormWordleControls";
            this.Text = "Wordle Controls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWinPct;
        private System.Windows.Forms.TextBox textBoxWinCount;
        private System.Windows.Forms.TextBox textBoxPlayCount;
        private System.Windows.Forms.Button buttonResetStatistics;
        private System.Windows.Forms.Button buttonNewGame;
    }
}