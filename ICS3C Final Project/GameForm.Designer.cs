namespace ICS3C_Final_Project
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.Wordslbl = new System.Windows.Forms.Label();
            this.Hintlbl = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.Entertxt = new System.Windows.Forms.TextBox();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Wordslbl
            // 
            this.Wordslbl.BackColor = System.Drawing.Color.Transparent;
            this.Wordslbl.Font = new System.Drawing.Font("Niagara Solid", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wordslbl.ForeColor = System.Drawing.Color.White;
            this.Wordslbl.Location = new System.Drawing.Point(10, 51);
            this.Wordslbl.Name = "Wordslbl";
            this.Wordslbl.Size = new System.Drawing.Size(776, 124);
            this.Wordslbl.TabIndex = 0;
            this.Wordslbl.Text = "label1";
            this.Wordslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hintlbl
            // 
            this.Hintlbl.BackColor = System.Drawing.Color.Transparent;
            this.Hintlbl.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hintlbl.ForeColor = System.Drawing.Color.White;
            this.Hintlbl.Location = new System.Drawing.Point(10, 191);
            this.Hintlbl.Name = "Hintlbl";
            this.Hintlbl.Size = new System.Drawing.Size(776, 40);
            this.Hintlbl.TabIndex = 1;
            this.Hintlbl.Text = "HINT : ";
            this.Hintlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timelbl
            // 
            this.Timelbl.BackColor = System.Drawing.Color.Transparent;
            this.Timelbl.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelbl.ForeColor = System.Drawing.Color.White;
            this.Timelbl.Location = new System.Drawing.Point(10, 231);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(776, 40);
            this.Timelbl.TabIndex = 2;
            this.Timelbl.Text = "TIME LEFT : ";
            this.Timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Entertxt
            // 
            this.Entertxt.Font = new System.Drawing.Font("Niagara Solid", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entertxt.ForeColor = System.Drawing.Color.Black;
            this.Entertxt.Location = new System.Drawing.Point(310, 274);
            this.Entertxt.Name = "Entertxt";
            this.Entertxt.Size = new System.Drawing.Size(191, 36);
            this.Entertxt.TabIndex = 3;
            // 
            // Checkbtn
            // 
            this.Checkbtn.Font = new System.Drawing.Font("Niagara Solid", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbtn.ForeColor = System.Drawing.Color.Black;
            this.Checkbtn.Location = new System.Drawing.Point(351, 331);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(93, 45);
            this.Checkbtn.TabIndex = 4;
            this.Checkbtn.Text = "CHECK";
            this.Checkbtn.UseVisualStyleBackColor = true;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.BackColor = System.Drawing.Color.Transparent;
            this.Resultlbl.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.Resultlbl.Location = new System.Drawing.Point(10, 379);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(776, 71);
            this.Resultlbl.TabIndex = 5;
            this.Resultlbl.Text = "label4";
            this.Resultlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuizTimer
            // 
            this.QuizTimer.Interval = 1000;
            this.QuizTimer.Tick += new System.EventHandler(this.QuizTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Entertxt);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.Hintlbl);
            this.Controls.Add(this.Wordslbl);
            this.Name = "GameForm";
            this.Text = "SCRAMBLE GAME";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wordslbl;
        private System.Windows.Forms.Label Hintlbl;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.TextBox Entertxt;
        private System.Windows.Forms.Button Checkbtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Timer QuizTimer;
    }
}