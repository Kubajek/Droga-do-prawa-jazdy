
namespace Projekt_JPWP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtScoreInt = new System.Windows.Forms.Label();
            this.txtHighScoreInt = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.spawnPos3 = new System.Windows.Forms.PictureBox();
            this.spawnPos1 = new System.Windows.Forms.PictureBox();
            this.spawnPos0 = new System.Windows.Forms.PictureBox();
            this.spawnPos2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(794, 665);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score:";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHighScore
            // 
            this.txtHighScore.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(794, 690);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(110, 25);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "HighScore:";
            this.txtHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtScoreInt
            // 
            this.txtScoreInt.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreInt.Location = new System.Drawing.Point(906, 665);
            this.txtScoreInt.Name = "txtScoreInt";
            this.txtScoreInt.Size = new System.Drawing.Size(40, 25);
            this.txtScoreInt.TabIndex = 2;
            this.txtScoreInt.Text = "0";
            this.txtScoreInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHighScoreInt
            // 
            this.txtHighScoreInt.Font = new System.Drawing.Font("Silkscreen Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScoreInt.Location = new System.Drawing.Point(906, 690);
            this.txtHighScoreInt.Name = "txtHighScoreInt";
            this.txtHighScoreInt.Size = new System.Drawing.Size(40, 25);
            this.txtHighScoreInt.TabIndex = 2;
            this.txtHighScoreInt.Text = "0";
            this.txtHighScoreInt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Enabled = false;
            this.gameOverText.Font = new System.Drawing.Font("Silkscreen", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.Color.Red;
            this.gameOverText.Location = new System.Drawing.Point(123, 338);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(489, 57);
            this.gameOverText.TabIndex = 3;
            this.gameOverText.Text = "GAME OVER";
            this.gameOverText.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Silkscreen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
            this.restartButton.Location = new System.Drawing.Point(796, 93);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(150, 75);
            this.restartButton.TabIndex = 0;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.restartButton.MouseLeave += new System.EventHandler(this.restartButton_MouseLeave);
            this.restartButton.MouseHover += new System.EventHandler(this.restartButton_MouseHover);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = global::Projekt_JPWP.Properties.Resources.buttonEmpty_150x75;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Silkscreen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(796, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 75);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            this.startButton.MouseHover += new System.EventHandler(this.startButton_MouseHover);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.DarkGray;
            this.picCanvas.Image = ((System.Drawing.Image)(resources.GetObject("picCanvas.Image")));
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(705, 705);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Silkscreen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(796, 566);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(150, 75);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // spawnPos3
            // 
            this.spawnPos3.BackColor = System.Drawing.Color.Red;
            this.spawnPos3.Location = new System.Drawing.Point(367, 483);
            this.spawnPos3.Name = "spawnPos3";
            this.spawnPos3.Size = new System.Drawing.Size(117, 234);
            this.spawnPos3.TabIndex = 5;
            this.spawnPos3.TabStop = false;
            this.spawnPos3.Visible = false;
            // 
            // spawnPos1
            // 
            this.spawnPos1.BackColor = System.Drawing.Color.Red;
            this.spawnPos1.Location = new System.Drawing.Point(246, 12);
            this.spawnPos1.Name = "spawnPos1";
            this.spawnPos1.Size = new System.Drawing.Size(120, 237);
            this.spawnPos1.TabIndex = 6;
            this.spawnPos1.TabStop = false;
            this.spawnPos1.Visible = false;
            // 
            // spawnPos0
            // 
            this.spawnPos0.BackColor = System.Drawing.Color.Red;
            this.spawnPos0.Location = new System.Drawing.Point(12, 365);
            this.spawnPos0.Name = "spawnPos0";
            this.spawnPos0.Size = new System.Drawing.Size(237, 120);
            this.spawnPos0.TabIndex = 7;
            this.spawnPos0.TabStop = false;
            this.spawnPos0.Visible = false;
            // 
            // spawnPos2
            // 
            this.spawnPos2.BackColor = System.Drawing.Color.Red;
            this.spawnPos2.Location = new System.Drawing.Point(482, 247);
            this.spawnPos2.Name = "spawnPos2";
            this.spawnPos2.Size = new System.Drawing.Size(235, 118);
            this.spawnPos2.TabIndex = 8;
            this.spawnPos2.TabStop = false;
            this.spawnPos2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.spawnPos2);
            this.Controls.Add(this.spawnPos0);
            this.Controls.Add(this.spawnPos1);
            this.Controls.Add(this.spawnPos3);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtHighScoreInt);
            this.Controls.Add(this.txtScoreInt);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Droga do prawa jazdy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnPos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtScoreInt;
        private System.Windows.Forms.Label txtHighScoreInt;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox spawnPos3;
        private System.Windows.Forms.PictureBox spawnPos1;
        private System.Windows.Forms.PictureBox spawnPos0;
        private System.Windows.Forms.PictureBox spawnPos2;
    }
}

