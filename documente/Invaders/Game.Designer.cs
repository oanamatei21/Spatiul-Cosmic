namespace Invaders
{
    partial class Game
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
            this.txtTasta = new System.Windows.Forms.TextBox();
            this.btStartGame = new System.Windows.Forms.Button();
            this.timer_meteor_nou = new System.Windows.Forms.Timer(this.components);
            this.timer_cadere_meteor = new System.Windows.Forms.Timer(this.components);
            this.btQuit = new System.Windows.Forms.Button();
            this.lbTimp = new System.Windows.Forms.Label();
            this.timer_supravietuire = new System.Windows.Forms.Timer(this.components);
            this.timer_final = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbMeteor = new System.Windows.Forms.PictureBox();
            this.pbNava = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNava)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTasta
            // 
            this.txtTasta.Location = new System.Drawing.Point(789, -50);
            this.txtTasta.Name = "txtTasta";
            this.txtTasta.Size = new System.Drawing.Size(100, 20);
            this.txtTasta.TabIndex = 2;
            this.txtTasta.TextChanged += new System.EventHandler(this.txtTasta_TextChanged);
            // 
            // btStartGame
            // 
            this.btStartGame.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btStartGame.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btStartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btStartGame.Location = new System.Drawing.Point(186, 155);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(217, 106);
            this.btStartGame.TabIndex = 1;
            this.btStartGame.Text = "START GAME";
            this.btStartGame.UseVisualStyleBackColor = false;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // timer_meteor_nou
            // 
            this.timer_meteor_nou.Interval = 500;
            this.timer_meteor_nou.Tick += new System.EventHandler(this.timer_meteor_nou_Tick);
            // 
            // timer_cadere_meteor
            // 
            this.timer_cadere_meteor.Interval = 10;
            this.timer_cadere_meteor.Tick += new System.EventHandler(this.timer_cadere_meteor_Tick);
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.Red;
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btQuit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btQuit.Location = new System.Drawing.Point(555, 1);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(25, 23);
            this.btQuit.TabIndex = 4;
            this.btQuit.Text = "X";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // lbTimp
            // 
            this.lbTimp.AutoSize = true;
            this.lbTimp.BackColor = System.Drawing.Color.Transparent;
            this.lbTimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTimp.Location = new System.Drawing.Point(414, -30);
            this.lbTimp.Name = "lbTimp";
            this.lbTimp.Size = new System.Drawing.Size(20, 24);
            this.lbTimp.TabIndex = 6;
            this.lbTimp.Text = "0";
            this.lbTimp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_supravietuire
            // 
            this.timer_supravietuire.Interval = 1000;
            this.timer_supravietuire.Tick += new System.EventHandler(this.timer_supravietuire_Tick);
            // 
            // timer_final
            // 
            this.timer_final.Interval = 10;
            this.timer_final.Tick += new System.EventHandler(this.timer_final_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(437, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "/30 seconds";
            // 
            // pbMeteor
            // 
            this.pbMeteor.BackColor = System.Drawing.Color.Transparent;
            this.pbMeteor.BackgroundImage = global::Invaders.Properties.Resources.meteor_transparent;
            this.pbMeteor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMeteor.Location = new System.Drawing.Point(214, 12);
            this.pbMeteor.Name = "pbMeteor";
            this.pbMeteor.Size = new System.Drawing.Size(57, 50);
            this.pbMeteor.TabIndex = 3;
            this.pbMeteor.TabStop = false;
            this.pbMeteor.Visible = false;
            // 
            // pbNava
            // 
            this.pbNava.BackColor = System.Drawing.Color.Transparent;
            this.pbNava.BackgroundImage = global::Invaders.Properties.Resources.racheta;
            this.pbNava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNava.Location = new System.Drawing.Point(271, 364);
            this.pbNava.Name = "pbNava";
            this.pbNava.Size = new System.Drawing.Size(41, 66);
            this.pbNava.TabIndex = 0;
            this.pbNava.TabStop = false;
            this.pbNava.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Invaders.Properties.Resources.moon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 442);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimp);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.pbMeteor);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.txtTasta);
            this.Controls.Add(this.pbNava);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNava;
        private System.Windows.Forms.TextBox txtTasta;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Timer timer_meteor_nou;
        private System.Windows.Forms.Timer timer_cadere_meteor;
        private System.Windows.Forms.PictureBox pbMeteor;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lbTimp;
        private System.Windows.Forms.Timer timer_supravietuire;
        private System.Windows.Forms.Timer timer_final;
        private System.Windows.Forms.Label label1;
    }
}