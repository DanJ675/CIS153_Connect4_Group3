
namespace CIS153_Connect4_Group3
{
    partial class Stats
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
            this.StatL = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Button();
            this.pvpw = new System.Windows.Forms.Label();
            this.pvpl = new System.Windows.Forms.Label();
            this.pvcw = new System.Windows.Forms.Label();
            this.pvcl = new System.Windows.Forms.Label();
            this.pvpt = new System.Windows.Forms.Label();
            this.pvct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatL
            // 
            this.StatL.AutoSize = true;
            this.StatL.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatL.Location = new System.Drawing.Point(12, 4);
            this.StatL.Name = "StatL";
            this.StatL.Size = new System.Drawing.Size(452, 76);
            this.StatL.TabIndex = 0;
            this.StatL.Text = "Game Statistics";
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(156, 447);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(127, 42);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // pvpw
            // 
            this.pvpw.AutoSize = true;
            this.pvpw.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvpw.Location = new System.Drawing.Point(19, 124);
            this.pvpw.Name = "pvpw";
            this.pvpw.Size = new System.Drawing.Size(184, 31);
            this.pvpw.TabIndex = 3;
            this.pvpw.Text = "Wins vs Players";
            // 
            // pvpl
            // 
            this.pvpl.AutoSize = true;
            this.pvpl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvpl.Location = new System.Drawing.Point(19, 170);
            this.pvpl.Name = "pvpl";
            this.pvpl.Size = new System.Drawing.Size(201, 31);
            this.pvpl.TabIndex = 4;
            this.pvpl.Text = "Losses vs Players";
            // 
            // pvcw
            // 
            this.pvcw.AutoSize = true;
            this.pvcw.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvcw.Location = new System.Drawing.Point(19, 278);
            this.pvcw.Name = "pvcw";
            this.pvcw.Size = new System.Drawing.Size(214, 31);
            this.pvcw.TabIndex = 5;
            this.pvcw.Text = "Wins vs Computer";
            // 
            // pvcl
            // 
            this.pvcl.AutoSize = true;
            this.pvcl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvcl.Location = new System.Drawing.Point(19, 324);
            this.pvcl.Name = "pvcl";
            this.pvcl.Size = new System.Drawing.Size(231, 31);
            this.pvcl.TabIndex = 6;
            this.pvcl.Text = "Losses vs Computer";
            // 
            // pvpt
            // 
            this.pvpt.AutoSize = true;
            this.pvpt.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvpt.Location = new System.Drawing.Point(19, 213);
            this.pvpt.Name = "pvpt";
            this.pvpt.Size = new System.Drawing.Size(163, 31);
            this.pvpt.TabIndex = 7;
            this.pvpt.Text = "Tie vs Players";
            // 
            // pvct
            // 
            this.pvct.AutoSize = true;
            this.pvct.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvct.Location = new System.Drawing.Point(19, 365);
            this.pvct.Name = "pvct";
            this.pvct.Size = new System.Drawing.Size(193, 31);
            this.pvct.TabIndex = 8;
            this.pvct.Text = "Tie vs Computer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(477, 498);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pvct);
            this.Controls.Add(this.pvpt);
            this.Controls.Add(this.pvcl);
            this.Controls.Add(this.pvcw);
            this.Controls.Add(this.pvpl);
            this.Controls.Add(this.pvpw);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.StatL);
            this.Name = "Stats";
            this.Text = "stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatL;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label pvpw;
        private System.Windows.Forms.Label pvpl;
        private System.Windows.Forms.Label pvcw;
        private System.Windows.Forms.Label pvcl;
        private System.Windows.Forms.Label pvpt;
        private System.Windows.Forms.Label pvct;
        private System.Windows.Forms.Label label7;
    }
}