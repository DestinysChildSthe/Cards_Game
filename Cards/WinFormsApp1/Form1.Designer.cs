
using System;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary> 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionlbl = new System.Windows.Forms.Label();
            this.twoclublabel = new System.Windows.Forms.PictureBox();
            this.jacksdiamondlabel = new System.Windows.Forms.PictureBox();
            this.queenspadelabel = new System.Windows.Forms.PictureBox();
            this.aceheartslabel = new System.Windows.Forms.PictureBox();
            this.redjokerlabel = new System.Windows.Forms.PictureBox();
            this.cardlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.twoclublabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jacksdiamondlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenspadelabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceheartslabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redjokerlabel)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionlbl
            // 
            this.instructionlbl.AutoSize = true;
            this.instructionlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructionlbl.Location = new System.Drawing.Point(256, 67);
            this.instructionlbl.Name = "instructionlbl";
            this.instructionlbl.Size = new System.Drawing.Size(316, 32);
            this.instructionlbl.TabIndex = 0;
            this.instructionlbl.Text = "Click a Card to See its Name\r\n";
            this.instructionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoclublabel
            // 
            this.twoclublabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoclublabel.Image = global::WinFormsApp1.Properties.Resources._2_Clubs;
            this.twoclublabel.Location = new System.Drawing.Point(31, 138);
            this.twoclublabel.Name = "Twoclublabel";
            this.twoclublabel.Size = new System.Drawing.Size(105, 147);
            this.twoclublabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoclublabel.TabIndex = 1;
            this.twoclublabel.TabStop = false;
            this.twoclublabel.Click += new System.EventHandler(this.Twoclublabel_Click_1);
            // 
            // jacksdiamondlabel
            // 
            this.jacksdiamondlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jacksdiamondlabel.Image = global::WinFormsApp1.Properties.Resources.Jack_Diamonds;
            this.jacksdiamondlabel.Location = new System.Drawing.Point(500, 138);
            this.jacksdiamondlabel.Name = "Jacksdiamondlabel";
            this.jacksdiamondlabel.Size = new System.Drawing.Size(105, 147);
            this.jacksdiamondlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jacksdiamondlabel.TabIndex = 2;
            this.jacksdiamondlabel.TabStop = false;
            this.jacksdiamondlabel.Click += new System.EventHandler(this.Jacksdiamondlabel_Click);
            // 
            // queenspadelabel
            // 
            this.queenspadelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queenspadelabel.Image = global::WinFormsApp1.Properties.Resources.Queen_Spades;
            this.queenspadelabel.Location = new System.Drawing.Point(349, 138);
            this.queenspadelabel.Name = "Queenspadelabel";
            this.queenspadelabel.Size = new System.Drawing.Size(105, 147);
            this.queenspadelabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queenspadelabel.TabIndex = 3;
            this.queenspadelabel.TabStop = false;
            this.queenspadelabel.Click += new System.EventHandler(this.Queenspadelabel_Click);
            // 
            // aceheartslabel
            // 
            this.aceheartslabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aceheartslabel.Image = global::WinFormsApp1.Properties.Resources.Ace_Hearts;
            this.aceheartslabel.Location = new System.Drawing.Point(195, 138);
            this.aceheartslabel.Name = "Aceheartslabel";
            this.aceheartslabel.Size = new System.Drawing.Size(105, 147);
            this.aceheartslabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceheartslabel.TabIndex = 4;
            this.aceheartslabel.TabStop = false;
            this.aceheartslabel.Click += new System.EventHandler(this.Aceheartslabel_Click);
            // 
            // redjokerlabel
            // 
            this.redjokerlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redjokerlabel.Image = global::WinFormsApp1.Properties.Resources.Joker_Red;
            this.redjokerlabel.Location = new System.Drawing.Point(653, 138);
            this.redjokerlabel.Name = "Redjokerlabel";
            this.redjokerlabel.Size = new System.Drawing.Size(105, 147);
            this.redjokerlabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redjokerlabel.TabIndex = 5;
            this.redjokerlabel.TabStop = false;
            this.redjokerlabel.Click += new System.EventHandler(this.Redjokerlabel_Click);
            // 
            // cardlabel
            // 
            this.cardlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardlabel.Location = new System.Drawing.Point(112, 345);
            this.cardlabel.Name = "cardlabel";
            this.cardlabel.Size = new System.Drawing.Size(588, 32);
            this.cardlabel.TabIndex = 6;
            this.cardlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardlabel.Click += new System.EventHandler(this.cardlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardlabel);
            this.Controls.Add(this.redjokerlabel);
            this.Controls.Add(this.aceheartslabel);
            this.Controls.Add(this.queenspadelabel);
            this.Controls.Add(this.jacksdiamondlabel);
            this.Controls.Add(this.twoclublabel);
            this.Controls.Add(this.instructionlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.twoclublabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jacksdiamondlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenspadelabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceheartslabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redjokerlabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cardlabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label instructionlbl;
        private System.Windows.Forms.PictureBox twoclublabel;
        private System.Windows.Forms.PictureBox jacksdiamondlabel;
        private System.Windows.Forms.PictureBox queenspadelabel;
        private System.Windows.Forms.PictureBox aceheartslabel;
        private System.Windows.Forms.PictureBox redjokerlabel;
        private System.Windows.Forms.Label cardlabel;
    }
}

