
namespace Projekt_JPWP
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.level1Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level1Button
            // 
            this.level1Button.BackColor = System.Drawing.Color.Transparent;
            this.level1Button.BackgroundImage = global::Projekt_JPWP.Properties.Resources.buttonEmpty_150x75;
            this.level1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.level1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level1Button.Font = new System.Drawing.Font("Silkscreen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Button.Location = new System.Drawing.Point(12, 12);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(150, 75);
            this.level1Button.TabIndex = 2;
            this.level1Button.Text = "POZIOM 1";
            this.level1Button.UseVisualStyleBackColor = false;
            this.level1Button.Click += new System.EventHandler(this.level1Button_Click);
            // 
            // level2Button
            // 
            this.level2Button.BackColor = System.Drawing.Color.Transparent;
            this.level2Button.BackgroundImage = global::Projekt_JPWP.Properties.Resources.buttonEmpty_150x75;
            this.level2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.level2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level2Button.Font = new System.Drawing.Font("Silkscreen", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2Button.Location = new System.Drawing.Point(12, 93);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(150, 75);
            this.level2Button.TabIndex = 3;
            this.level2Button.Text = "POZIOM 2";
            this.level2Button.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = global::Projekt_JPWP.Properties.Resources.buttonEmpty_150x75;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Silkscreen", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(12, 363);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(150, 75);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "USTAWIENIA";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Droga do prawa jazdy";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.Button settingsButton;
    }
}