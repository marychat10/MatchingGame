﻿namespace MatchingGame.Forms
{
    partial class frmGame
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
            this.lblCutePairsGame = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCutePairsGame
            // 
            this.lblCutePairsGame.AutoSize = true;
            this.lblCutePairsGame.Location = new System.Drawing.Point(531, 64);
            this.lblCutePairsGame.Name = "lblCutePairsGame";
            this.lblCutePairsGame.Size = new System.Drawing.Size(147, 32);
            this.lblCutePairsGame.TabIndex = 0;
            this.lblCutePairsGame.Text = "Cute Pairs";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(184, 131);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(95, 32);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(671, 130);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(97, 32);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(285, 127);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(251, 38);
            this.txtTimer.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(789, 128);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(251, 38);
            this.txtScore.TabIndex = 4;
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(175, 224);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(917, 834);
            this.pnlCard.TabIndex = 5;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 1123);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCutePairsGame);
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCutePairsGame;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Panel pnlCard;
    }
}