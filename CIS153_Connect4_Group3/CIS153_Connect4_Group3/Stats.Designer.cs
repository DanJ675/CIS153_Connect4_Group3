
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
            this.StatLB = new System.Windows.Forms.ListBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatL
            // 
            this.StatL.AutoSize = true;
            this.StatL.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatL.Location = new System.Drawing.Point(12, 9);
            this.StatL.Name = "StatL";
            this.StatL.Size = new System.Drawing.Size(452, 76);
            this.StatL.TabIndex = 0;
            this.StatL.Text = "Game Statistics";
            // 
            // StatLB
            // 
            this.StatLB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StatLB.FormattingEnabled = true;
            this.StatLB.Location = new System.Drawing.Point(28, 99);
            this.StatLB.Name = "StatLB";
            this.StatLB.Size = new System.Drawing.Size(405, 342);
            this.StatLB.TabIndex = 1;
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
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(477, 498);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.StatLB);
            this.Controls.Add(this.StatL);
            this.Name = "Stats";
            this.Text = "stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatL;
        private System.Windows.Forms.ListBox StatLB;
        private System.Windows.Forms.Button MenuButton;
    }
}