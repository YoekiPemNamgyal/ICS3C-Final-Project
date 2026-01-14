namespace ICS3C_Final_Project
{
    partial class ScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Restartbtn = new System.Windows.Forms.Button();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Scorelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Niagara Solid", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.Location = new System.Drawing.Point(461, 311);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(82, 58);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "EXIT";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Restartbtn
            // 
            this.Restartbtn.Font = new System.Drawing.Font("Niagara Solid", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restartbtn.Location = new System.Drawing.Point(268, 311);
            this.Restartbtn.Name = "Restartbtn";
            this.Restartbtn.Size = new System.Drawing.Size(132, 58);
            this.Restartbtn.TabIndex = 4;
            this.Restartbtn.Text = "RESTART";
            this.Restartbtn.UseVisualStyleBackColor = true;
            this.Restartbtn.Click += new System.EventHandler(this.Restartbtn_Click);
            // 
            // Titlelbl
            // 
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.Color.White;
            this.Titlelbl.Location = new System.Drawing.Point(12, 9);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(776, 67);
            this.Titlelbl.TabIndex = 3;
            this.Titlelbl.Text = "SCRAMBLE GAME";
            this.Titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titlelbl.Click += new System.EventHandler(this.Titlelbl_Click);
            // 
            // Scorelbl
            // 
            this.Scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.Scorelbl.Font = new System.Drawing.Font("Niagara Solid", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scorelbl.Location = new System.Drawing.Point(12, 126);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(776, 141);
            this.Scorelbl.TabIndex = 7;
            this.Scorelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Restartbtn);
            this.Controls.Add(this.Titlelbl);
            this.Name = "ScoreForm";
            this.Text = "FinalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Restartbtn;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Scorelbl;
    }
}