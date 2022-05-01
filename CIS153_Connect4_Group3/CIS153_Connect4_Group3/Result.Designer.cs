
namespace CIS153_Connect4_Group3
{
    partial class Result
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
            this.NewButt = new System.Windows.Forms.Button();
            this.ReturnButt = new System.Windows.Forms.Button();
            this.StatButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewButt
            // 
            this.NewButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButt.Location = new System.Drawing.Point(16, 153);
            this.NewButt.Margin = new System.Windows.Forms.Padding(4);
            this.NewButt.Name = "NewButt";
            this.NewButt.Size = new System.Drawing.Size(186, 60);
            this.NewButt.TabIndex = 0;
            this.NewButt.Text = "New Game";
            this.NewButt.UseVisualStyleBackColor = true;
            this.NewButt.Click += new System.EventHandler(this.NewButt_Click);
            // 
            // ReturnButt
            // 
            this.ReturnButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButt.Location = new System.Drawing.Point(327, 153);
            this.ReturnButt.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButt.Name = "ReturnButt";
            this.ReturnButt.Size = new System.Drawing.Size(145, 60);
            this.ReturnButt.TabIndex = 1;
            this.ReturnButt.Text = "Return to Menu";
            this.ReturnButt.UseVisualStyleBackColor = true;
            this.ReturnButt.Click += new System.EventHandler(this.ReturnButt_Click);
            // 
            // StatButt
            // 
            this.StatButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatButt.Location = new System.Drawing.Point(16, 220);
            this.StatButt.Margin = new System.Windows.Forms.Padding(4);
            this.StatButt.Name = "StatButt";
            this.StatButt.Size = new System.Drawing.Size(186, 60);
            this.StatButt.TabIndex = 2;
            this.StatButt.Text = "View Board";
            this.StatButt.UseVisualStyleBackColor = true;
            this.StatButt.Click += new System.EventHandler(this.StatButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButt.Location = new System.Drawing.Point(327, 220);
            this.ExitButt.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(145, 60);
            this.ExitButt.TabIndex = 3;
            this.ExitButt.Text = "Exit";
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(201, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "We have a winner!";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(517, 292);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.StatButt);
            this.Controls.Add(this.ReturnButt);
            this.Controls.Add(this.NewButt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Result";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewButt;
        private System.Windows.Forms.Button ReturnButt;
        private System.Windows.Forms.Button StatButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label lblName;
    }
}