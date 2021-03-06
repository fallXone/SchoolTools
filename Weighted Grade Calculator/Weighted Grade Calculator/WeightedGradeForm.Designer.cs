﻿namespace Weighted_Grade_Calculator
{
    partial class WeightedGradeForm
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
            this.ptsEarnedLbl = new System.Windows.Forms.Label();
            this.ptsPossibleLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.percentEarnedBox = new System.Windows.Forms.TextBox();
            this.finalGradeBox = new System.Windows.Forms.TextBox();
            this.pctEarnedLbl = new System.Windows.Forms.Label();
            this.finalGradeLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.pointsEarnedNumeric = new System.Windows.Forms.NumericUpDown();
            this.pointsPossibleNumeric = new System.Windows.Forms.NumericUpDown();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalProgress = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpaBtn = new System.Windows.Forms.Button();
            this.weightedGradeBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.todoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointsEarnedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsPossibleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptsEarnedLbl
            // 
            this.ptsEarnedLbl.AutoSize = true;
            this.ptsEarnedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsEarnedLbl.Location = new System.Drawing.Point(31, 50);
            this.ptsEarnedLbl.Name = "ptsEarnedLbl";
            this.ptsEarnedLbl.Size = new System.Drawing.Size(76, 13);
            this.ptsEarnedLbl.TabIndex = 1;
            this.ptsEarnedLbl.Text = "Points Earned:";
            // 
            // ptsPossibleLbl
            // 
            this.ptsPossibleLbl.AutoSize = true;
            this.ptsPossibleLbl.Location = new System.Drawing.Point(247, 50);
            this.ptsPossibleLbl.Name = "ptsPossibleLbl";
            this.ptsPossibleLbl.Size = new System.Drawing.Size(81, 13);
            this.ptsPossibleLbl.TabIndex = 2;
            this.ptsPossibleLbl.Text = "Points Possible:";
            this.ptsPossibleLbl.UseMnemonic = false;
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(465, 50);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(61, 13);
            this.weightLbl.TabIndex = 3;
            this.weightLbl.Text = "Weight (%):";
            this.weightLbl.UseMnemonic = false;
            // 
            // percentEarnedBox
            // 
            this.percentEarnedBox.BackColor = System.Drawing.Color.Khaki;
            this.percentEarnedBox.Enabled = false;
            this.percentEarnedBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentEarnedBox.Location = new System.Drawing.Point(34, 121);
            this.percentEarnedBox.Multiline = true;
            this.percentEarnedBox.Name = "percentEarnedBox";
            this.percentEarnedBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.percentEarnedBox.Size = new System.Drawing.Size(294, 319);
            this.percentEarnedBox.TabIndex = 6;
            // 
            // finalGradeBox
            // 
            this.finalGradeBox.BackColor = System.Drawing.Color.Khaki;
            this.finalGradeBox.Enabled = false;
            this.finalGradeBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalGradeBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.finalGradeBox.Location = new System.Drawing.Point(338, 121);
            this.finalGradeBox.Multiline = true;
            this.finalGradeBox.Name = "finalGradeBox";
            this.finalGradeBox.Size = new System.Drawing.Size(294, 171);
            this.finalGradeBox.TabIndex = 7;
            // 
            // pctEarnedLbl
            // 
            this.pctEarnedLbl.AutoSize = true;
            this.pctEarnedLbl.Location = new System.Drawing.Point(31, 105);
            this.pctEarnedLbl.Name = "pctEarnedLbl";
            this.pctEarnedLbl.Size = new System.Drawing.Size(81, 13);
            this.pctEarnedLbl.TabIndex = 8;
            this.pctEarnedLbl.Text = "Percent Earned";
            // 
            // finalGradeLbl
            // 
            this.finalGradeLbl.AutoSize = true;
            this.finalGradeLbl.Location = new System.Drawing.Point(335, 105);
            this.finalGradeLbl.Name = "finalGradeLbl";
            this.finalGradeLbl.Size = new System.Drawing.Size(61, 13);
            this.finalGradeLbl.TabIndex = 9;
            this.finalGradeLbl.Text = "Final Grade";
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(113, 74);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add to List";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.Location = new System.Drawing.Point(253, 74);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 11;
            this.calculateBtn.Text = "Calculate Grade";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartBtn.Location = new System.Drawing.Point(399, 74);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 12;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // pointsEarnedNumeric
            // 
            this.pointsEarnedNumeric.BackColor = System.Drawing.Color.Khaki;
            this.pointsEarnedNumeric.DecimalPlaces = 2;
            this.pointsEarnedNumeric.Location = new System.Drawing.Point(104, 48);
            this.pointsEarnedNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pointsEarnedNumeric.Name = "pointsEarnedNumeric";
            this.pointsEarnedNumeric.Size = new System.Drawing.Size(120, 20);
            this.pointsEarnedNumeric.TabIndex = 13;
            this.pointsEarnedNumeric.Enter += new System.EventHandler(this.pointsEarnedNumeric_Enter);
            // 
            // pointsPossibleNumeric
            // 
            this.pointsPossibleNumeric.BackColor = System.Drawing.Color.Khaki;
            this.pointsPossibleNumeric.DecimalPlaces = 2;
            this.pointsPossibleNumeric.Location = new System.Drawing.Point(325, 48);
            this.pointsPossibleNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pointsPossibleNumeric.Name = "pointsPossibleNumeric";
            this.pointsPossibleNumeric.Size = new System.Drawing.Size(120, 20);
            this.pointsPossibleNumeric.TabIndex = 14;
            this.pointsPossibleNumeric.Enter += new System.EventHandler(this.pointsPossibleNumeric_Enter);
            // 
            // weightNumeric
            // 
            this.weightNumeric.BackColor = System.Drawing.Color.Khaki;
            this.weightNumeric.Location = new System.Drawing.Point(523, 48);
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(120, 20);
            this.weightNumeric.TabIndex = 15;
            this.weightNumeric.Enter += new System.EventHandler(this.weightNumeric_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helloToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.usageToolStripMenuItem.Text = "Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // finalProgress
            // 
            this.finalProgress.Location = new System.Drawing.Point(338, 298);
            this.finalProgress.Name = "finalProgress";
            this.finalProgress.Size = new System.Drawing.Size(294, 23);
            this.finalProgress.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.gpaBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightedGradeBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scheduleBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.todoBtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 327);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 142);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // gpaBtn
            // 
            this.gpaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpaBtn.Location = new System.Drawing.Point(101, 3);
            this.gpaBtn.Name = "gpaBtn";
            this.gpaBtn.Size = new System.Drawing.Size(91, 65);
            this.gpaBtn.TabIndex = 1;
            this.gpaBtn.Text = "GPA Calculator";
            this.gpaBtn.UseVisualStyleBackColor = true;
            this.gpaBtn.Click += new System.EventHandler(this.gpaButton_Click);
            // 
            // weightedGradeBtn
            // 
            this.weightedGradeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weightedGradeBtn.Location = new System.Drawing.Point(3, 3);
            this.weightedGradeBtn.Name = "weightedGradeBtn";
            this.weightedGradeBtn.Size = new System.Drawing.Size(91, 65);
            this.weightedGradeBtn.TabIndex = 0;
            this.weightedGradeBtn.Text = "Weighted Grade Calculator";
            this.weightedGradeBtn.UseVisualStyleBackColor = true;
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleBtn.Location = new System.Drawing.Point(199, 3);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(92, 65);
            this.scheduleBtn.TabIndex = 2;
            this.scheduleBtn.Text = "My Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            // 
            // todoBtn
            // 
            this.todoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoBtn.Location = new System.Drawing.Point(3, 74);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(91, 65);
            this.todoBtn.TabIndex = 3;
            this.todoBtn.Text = "Todo";
            this.todoBtn.UseVisualStyleBackColor = true;
            // 
            // WeightedGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(815, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.finalProgress);
            this.Controls.Add(this.weightNumeric);
            this.Controls.Add(this.pointsPossibleNumeric);
            this.Controls.Add(this.pointsEarnedNumeric);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.finalGradeLbl);
            this.Controls.Add(this.pctEarnedLbl);
            this.Controls.Add(this.finalGradeBox);
            this.Controls.Add(this.percentEarnedBox);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.ptsPossibleLbl);
            this.Controls.Add(this.ptsEarnedLbl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeightedGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pointsEarnedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsPossibleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ptsEarnedLbl;
        private System.Windows.Forms.Label ptsPossibleLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox percentEarnedBox;
        private System.Windows.Forms.TextBox finalGradeBox;
        private System.Windows.Forms.Label pctEarnedLbl;
        private System.Windows.Forms.Label finalGradeLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.NumericUpDown pointsEarnedNumeric;
        private System.Windows.Forms.NumericUpDown pointsPossibleNumeric;
        private System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ProgressBar finalProgress;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button weightedGradeBtn;
        private System.Windows.Forms.Button gpaBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button todoBtn;
    }
}

