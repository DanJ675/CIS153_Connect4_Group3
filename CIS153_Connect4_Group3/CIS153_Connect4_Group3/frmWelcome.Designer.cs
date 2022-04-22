
namespace CIS153_Connect4_Group3
{
    partial class frmWelcome
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
            this.StatButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1dl = new System.Windows.Forms.ComboBox();
            this.Player2dl = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatButt
            // 
            this.StatButt.BackColor = System.Drawing.SystemColors.Info;
            this.StatButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StatButt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.StatButt.Location = new System.Drawing.Point(12, 315);
            this.StatButt.Name = "StatButt";
            this.StatButt.Size = new System.Drawing.Size(186, 60);
            this.StatButt.TabIndex = 0;
            this.StatButt.Text = "View Statistics";
            this.StatButt.UseVisualStyleBackColor = false;
            this.StatButt.Click += new System.EventHandler(this.StatButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.SystemColors.Info;
            this.ExitButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ExitButt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.ExitButt.Location = new System.Drawing.Point(447, 315);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(186, 60);
            this.ExitButt.TabIndex = 1;
            this.ExitButt.Text = "Exit Game";
            this.ExitButt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Connect 4!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please choose an option:";
            // 
            // Player1dl
            // 
            this.Player1dl.FormattingEnabled = true;
            this.Player1dl.Items.AddRange(new object[] {
            "Dan",
            "Lee",
            "Ryan",
            "Matt",
            "Add..."});
            this.Player1dl.Location = new System.Drawing.Point(12, 184);
            this.Player1dl.Name = "Player1dl";
            this.Player1dl.Size = new System.Drawing.Size(186, 21);
            this.Player1dl.TabIndex = 6;
            // 
            // Player2dl
            // 
            this.Player2dl.FormattingEnabled = true;
            this.Player2dl.Items.AddRange(new object[] {
            "Computer ",
            "Dan",
            "Ryan",
            "Lee",
            "Matt",
            "Add..."});
            this.Player2dl.Location = new System.Drawing.Point(447, 184);
            this.Player2dl.Name = "Player2dl";
            this.Player2dl.Size = new System.Drawing.Size(186, 21);
            this.Player2dl.TabIndex = 7;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Info;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Start.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.Start.Location = new System.Drawing.Point(228, 249);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(186, 60);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Player2dl);
            this.Controls.Add(this.Player1dl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.StatButt);
            this.Name = "frmWelcome";
            this.Text = "pBox04P1";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StatButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Player1dl;
        private System.Windows.Forms.ComboBox Player2dl;
        private System.Windows.Forms.Button Start;
    }
}

