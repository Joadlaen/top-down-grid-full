namespace GameIteration4
{
    partial class PauseMenu
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
            this.BTContinue = new System.Windows.Forms.Button();
            this.BTOptions = new System.Windows.Forms.Button();
            this.BTSaveGame = new System.Windows.Forms.Button();
            this.BTLoadGame = new System.Windows.Forms.Button();
            this.SaveSpace = new System.Windows.Forms.Panel();
            this.LBTips = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTContinue
            // 
            this.BTContinue.Location = new System.Drawing.Point(13, 13);
            this.BTContinue.Name = "BTContinue";
            this.BTContinue.Size = new System.Drawing.Size(220, 50);
            this.BTContinue.TabIndex = 0;
            this.BTContinue.Text = "Continue?";
            this.BTContinue.UseVisualStyleBackColor = true;
            this.BTContinue.Click += new System.EventHandler(this.Continue);
            // 
            // BTOptions
            // 
            this.BTOptions.Location = new System.Drawing.Point(13, 69);
            this.BTOptions.Name = "BTOptions";
            this.BTOptions.Size = new System.Drawing.Size(220, 50);
            this.BTOptions.TabIndex = 1;
            this.BTOptions.Text = "Options";
            this.BTOptions.UseVisualStyleBackColor = true;
            this.BTOptions.Click += new System.EventHandler(this.Options);
            // 
            // BTSaveGame
            // 
            this.BTSaveGame.Location = new System.Drawing.Point(13, 126);
            this.BTSaveGame.Name = "BTSaveGame";
            this.BTSaveGame.Size = new System.Drawing.Size(220, 50);
            this.BTSaveGame.TabIndex = 2;
            this.BTSaveGame.Text = "Save Game";
            this.BTSaveGame.UseVisualStyleBackColor = true;
            this.BTSaveGame.Click += new System.EventHandler(this.SaveGame);
            // 
            // BTLoadGame
            // 
            this.BTLoadGame.Location = new System.Drawing.Point(13, 183);
            this.BTLoadGame.Name = "BTLoadGame";
            this.BTLoadGame.Size = new System.Drawing.Size(220, 50);
            this.BTLoadGame.TabIndex = 3;
            this.BTLoadGame.Text = "Load Game";
            this.BTLoadGame.UseVisualStyleBackColor = true;
            this.BTLoadGame.Click += new System.EventHandler(this.LoadGame);
            // 
            // SaveSpace
            // 
            this.SaveSpace.Location = new System.Drawing.Point(255, 13);
            this.SaveSpace.Name = "SaveSpace";
            this.SaveSpace.Size = new System.Drawing.Size(540, 338);
            this.SaveSpace.TabIndex = 4;
            // 
            // LBTips
            // 
            this.LBTips.FormattingEnabled = true;
            this.LBTips.Location = new System.Drawing.Point(13, 239);
            this.LBTips.Name = "LBTips";
            this.LBTips.Size = new System.Drawing.Size(220, 95);
            this.LBTips.TabIndex = 5;
            // 
            // PauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBTips);
            this.Controls.Add(this.SaveSpace);
            this.Controls.Add(this.BTLoadGame);
            this.Controls.Add(this.BTSaveGame);
            this.Controls.Add(this.BTOptions);
            this.Controls.Add(this.BTContinue);
            this.Name = "PauseMenu";
            this.Text = "PauseMenu";
            this.Load += new System.EventHandler(this.GamePaused);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTContinue;
        private System.Windows.Forms.Button BTOptions;
        private System.Windows.Forms.Button BTSaveGame;
        private System.Windows.Forms.Button BTLoadGame;
        private System.Windows.Forms.Panel SaveSpace;
        private System.Windows.Forms.ListBox LBTips;
    }
}