
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
            this.cmbPlayer1 = new System.Windows.Forms.ComboBox();
            this.cmbPlayer2 = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatButt
            // 
            this.StatButt.BackColor = System.Drawing.SystemColors.Info;
            this.StatButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StatButt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.StatButt.Location = new System.Drawing.Point(894, 397);
            this.StatButt.Margin = new System.Windows.Forms.Padding(6);
            this.StatButt.Name = "StatButt";
            this.StatButt.Size = new System.Drawing.Size(372, 115);
            this.StatButt.TabIndex = 0;
            this.StatButt.Text = "View Statistics";
            this.StatButt.UseVisualStyleBackColor = false;
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.SystemColors.Info;
            this.ExitButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ExitButt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.ExitButt.Location = new System.Drawing.Point(894, 606);
            this.ExitButt.Margin = new System.Windows.Forms.Padding(6);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(372, 115);
            this.ExitButt.TabIndex = 1;
            this.ExitButt.Text = "Exit Game";
            this.ExitButt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 122);
            this.label1.TabIndex = 4;
            this.label1.Text = "Play Connect 4!";
            // 
            // cmbPlayer1
            // 
            this.cmbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayer1.FormattingEnabled = true;
            this.cmbPlayer1.Location = new System.Drawing.Point(24, 251);
            this.cmbPlayer1.Margin = new System.Windows.Forms.Padding(6);
            this.cmbPlayer1.Name = "cmbPlayer1";
            this.cmbPlayer1.Size = new System.Drawing.Size(368, 45);
            this.cmbPlayer1.TabIndex = 6;
            // 
            // cmbPlayer2
            // 
            this.cmbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayer2.FormattingEnabled = true;
            this.cmbPlayer2.Location = new System.Drawing.Point(471, 251);
            this.cmbPlayer2.Margin = new System.Windows.Forms.Padding(6);
            this.cmbPlayer2.Name = "cmbPlayer2";
            this.cmbPlayer2.Size = new System.Drawing.Size(368, 45);
            this.cmbPlayer2.TabIndex = 7;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Info;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Start.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.Start.Location = new System.Drawing.Point(894, 215);
            this.Start.Margin = new System.Windows.Forms.Padding(6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(372, 115);
            this.Start.TabIndex = 9;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Player 2";
            // 
            // tbAdd
            // 
            this.tbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdd.Location = new System.Drawing.Point(24, 450);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(275, 44);
            this.tbAdd.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Add New Player";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(31, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(283, 107);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1296, 758);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.cmbPlayer2);
            this.Controls.Add(this.cmbPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.StatButt);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StatButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
    }
}

