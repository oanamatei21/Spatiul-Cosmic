namespace Invaders
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btInstructions = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "DODGER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btStart.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btStart.Location = new System.Drawing.Point(317, 215);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(278, 57);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start Game";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btInstructions
            // 
            this.btInstructions.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btInstructions.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btInstructions.Location = new System.Drawing.Point(317, 278);
            this.btInstructions.Name = "btInstructions";
            this.btInstructions.Size = new System.Drawing.Size(278, 57);
            this.btInstructions.TabIndex = 2;
            this.btInstructions.Text = "Instructions";
            this.btInstructions.UseVisualStyleBackColor = false;
            this.btInstructions.Click += new System.EventHandler(this.btInstructions_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btExit.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(317, 341);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(278, 57);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit Game";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 465);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btInstructions);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btInstructions;
        private System.Windows.Forms.Button btExit;
    }
}

