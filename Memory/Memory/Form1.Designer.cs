namespace Memory
{
    partial class Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trycounter = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.stopp = new System.Windows.Forms.Button();
            this.highscores = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card10 = new System.Windows.Forms.PictureBox();
            this.card9 = new System.Windows.Forms.PictureBox();
            this.card8 = new System.Windows.Forms.PictureBox();
            this.card7 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zeit:";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.Control;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Enabled = false;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(53, 644);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 21);
            this.time.TabIndex = 1;
            this.time.Text = "0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Versuche:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trycounter
            // 
            this.trycounter.BackColor = System.Drawing.SystemColors.Control;
            this.trycounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trycounter.Enabled = false;
            this.trycounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trycounter.Location = new System.Drawing.Point(215, 645);
            this.trycounter.Name = "trycounter";
            this.trycounter.Size = new System.Drawing.Size(100, 21);
            this.trycounter.TabIndex = 3;
            this.trycounter.Text = "0";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(925, 76);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(149, 35);
            this.start.TabIndex = 4;
            this.start.Text = "Spiel Starten";
            this.start.UseVisualStyleBackColor = true;
            // 
            // stopp
            // 
            this.stopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopp.Location = new System.Drawing.Point(925, 138);
            this.stopp.Name = "stopp";
            this.stopp.Size = new System.Drawing.Size(149, 35);
            this.stopp.TabIndex = 5;
            this.stopp.Text = "Spiel Stoppen";
            this.stopp.UseVisualStyleBackColor = true;
            // 
            // highscores
            // 
            this.highscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscores.Location = new System.Drawing.Point(925, 203);
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(149, 35);
            this.highscores.TabIndex = 6;
            this.highscores.Text = "Highscores";
            this.highscores.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(925, 269);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(149, 35);
            this.end.TabIndex = 7;
            this.end.Text = "Beenden";
            this.end.UseVisualStyleBackColor = true;
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.InitialImage = ((System.Drawing.Image)(resources.GetObject("card1.InitialImage")));
            this.card1.Location = new System.Drawing.Point(31, 27);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(120, 180);
            this.card1.TabIndex = 8;
            this.card1.TabStop = false;
            this.card1.WaitOnLoad = true;
            // 
            // card2
            // 
            this.card2.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Location = new System.Drawing.Point(210, 27);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(120, 180);
            this.card2.TabIndex = 9;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card3.Location = new System.Drawing.Point(391, 27);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(120, 180);
            this.card3.TabIndex = 10;
            this.card3.TabStop = false;
            // 
            // card4
            // 
            this.card4.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card4.Location = new System.Drawing.Point(561, 27);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(120, 180);
            this.card4.TabIndex = 11;
            this.card4.TabStop = false;
            // 
            // card5
            // 
            this.card5.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card5.Location = new System.Drawing.Point(731, 27);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(120, 180);
            this.card5.TabIndex = 12;
            this.card5.TabStop = false;
            // 
            // card10
            // 
            this.card10.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card10.Location = new System.Drawing.Point(731, 292);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(120, 180);
            this.card10.TabIndex = 17;
            this.card10.TabStop = false;
            // 
            // card9
            // 
            this.card9.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card9.Location = new System.Drawing.Point(561, 292);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(120, 180);
            this.card9.TabIndex = 16;
            this.card9.TabStop = false;
            // 
            // card8
            // 
            this.card8.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card8.ImageLocation = "";
            this.card8.InitialImage = null;
            this.card8.Location = new System.Drawing.Point(391, 290);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(120, 180);
            this.card8.TabIndex = 15;
            this.card8.TabStop = false;
            // 
            // card7
            // 
            this.card7.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card7.Location = new System.Drawing.Point(210, 290);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(120, 180);
            this.card7.TabIndex = 14;
            this.card7.TabStop = false;
            // 
            // card6
            // 
            this.card6.BackgroundImage = global::Memory.Properties.Resources.Kartenrücken___Kopie;
            this.card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card6.Location = new System.Drawing.Point(31, 292);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(120, 180);
            this.card6.TabIndex = 13;
            this.card6.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 719);
            this.Controls.Add(this.card10);
            this.Controls.Add(this.card9);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.highscores);
            this.Controls.Add(this.stopp);
            this.Controls.Add(this.start);
            this.Controls.Add(this.trycounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox time;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox trycounter;
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Button stopp;
        public System.Windows.Forms.Button highscores;
        public System.Windows.Forms.Button end;
        public System.Windows.Forms.PictureBox card1;
        public System.Windows.Forms.PictureBox card2;
        public System.Windows.Forms.PictureBox card3;
        public System.Windows.Forms.PictureBox card4;
        public System.Windows.Forms.PictureBox card5;
        public System.Windows.Forms.PictureBox card10;
        public System.Windows.Forms.PictureBox card9;
        public System.Windows.Forms.PictureBox card8;
        public System.Windows.Forms.PictureBox card7;
        public System.Windows.Forms.PictureBox card6;
    }
}

