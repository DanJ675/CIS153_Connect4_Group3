
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
            this.HvCbutt = new System.Windows.Forms.Button();
            this.HvHbutt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatButt
            // 
            this.StatButt.BackColor = System.Drawing.SystemColors.Info;
            this.StatButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.StatButt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.StatButt.Location = new System.Drawing.Point(12, 245);
            this.StatButt.Name = "StatButt";
            this.StatButt.Size = new System.Drawing.Size(249, 105);
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
            this.ExitButt.Location = new System.Drawing.Point(447, 245);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(249, 105);
            this.ExitButt.TabIndex = 1;
            this.ExitButt.Text = "Exit Game";
            this.ExitButt.UseVisualStyleBackColor = false;
            // 
            // HvCbutt
            // 
            this.HvCbutt.BackColor = System.Drawing.SystemColors.Info;
            this.HvCbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HvCbutt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HvCbutt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.HvCbutt.Location = new System.Drawing.Point(12, 134);
            this.HvCbutt.Name = "HvCbutt";
            this.HvCbutt.Size = new System.Drawing.Size(249, 105);
            this.HvCbutt.TabIndex = 2;
            this.HvCbutt.Text = "Human Vs. AI";
            this.HvCbutt.UseVisualStyleBackColor = false;
            // 
            // HvHbutt
            // 
            this.HvHbutt.BackColor = System.Drawing.SystemColors.Info;
            this.HvHbutt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HvHbutt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HvHbutt.FlatAppearance.BorderSize = 10;
            this.HvHbutt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HvHbutt.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.HvHbutt.Location = new System.Drawing.Point(447, 134);
            this.HvHbutt.Name = "HvHbutt";
            this.HvHbutt.Size = new System.Drawing.Size(249, 105);
            this.HvHbutt.TabIndex = 3;
            this.HvHbutt.Text = "Human Vs. Human";
            this.HvHbutt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To Connect 4!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please choose an option:";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(708, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HvHbutt);
            this.Controls.Add(this.HvCbutt);
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
        private System.Windows.Forms.Button HvCbutt;
        private System.Windows.Forms.Button HvHbutt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

