namespace AmongUsCheat_Senzaii
{
    partial class Form1
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
            this.btnForceImposter = new System.Windows.Forms.Button();
            this.lblConnectionToGame = new System.Windows.Forms.Label();
            this.btnKillCoolDown = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForceImposter
            // 
            this.btnForceImposter.Location = new System.Drawing.Point(4, 41);
            this.btnForceImposter.Name = "btnForceImposter";
            this.btnForceImposter.Size = new System.Drawing.Size(264, 23);
            this.btnForceImposter.TabIndex = 0;
            this.btnForceImposter.Text = "Force Imposter [OFF]";
            this.btnForceImposter.UseVisualStyleBackColor = true;
            this.btnForceImposter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConnectionToGame
            // 
            this.lblConnectionToGame.AutoSize = true;
            this.lblConnectionToGame.Location = new System.Drawing.Point(1, 18);
            this.lblConnectionToGame.Name = "lblConnectionToGame";
            this.lblConnectionToGame.Size = new System.Drawing.Size(136, 13);
            this.lblConnectionToGame.TabIndex = 1;
            this.lblConnectionToGame.Text = "Connection to game: Failed";
            // 
            // btnKillCoolDown
            // 
            this.btnKillCoolDown.Location = new System.Drawing.Point(4, 70);
            this.btnKillCoolDown.Name = "btnKillCoolDown";
            this.btnKillCoolDown.Size = new System.Drawing.Size(264, 23);
            this.btnKillCoolDown.TabIndex = 2;
            this.btnKillCoolDown.Text = "1s Kill Cooldown [OFF]";
            this.btnKillCoolDown.UseVisualStyleBackColor = true;
            this.btnKillCoolDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOST ONLY TOOL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKillCoolDown);
            this.Controls.Add(this.lblConnectionToGame);
            this.Controls.Add(this.btnForceImposter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Among Us Tool, 9.22 - Senzaii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForceImposter;
        private System.Windows.Forms.Label lblConnectionToGame;
        private System.Windows.Forms.Button btnKillCoolDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
    }
}

