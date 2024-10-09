namespace GameIteration4
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTPause = new System.Windows.Forms.Button();
            this.LBDialogue = new System.Windows.Forms.ListBox();
            this.BTBlock = new System.Windows.Forms.Button();
            this.BTSouth = new System.Windows.Forms.Button();
            this.BTHeal = new System.Windows.Forms.Button();
            this.BTEast = new System.Windows.Forms.Button();
            this.BTInteract = new System.Windows.Forms.Button();
            this.BTWest = new System.Windows.Forms.Button();
            this.BTRest = new System.Windows.Forms.Button();
            this.BTNorth = new System.Windows.Forms.Button();
            this.BTAttack = new System.Windows.Forms.Button();
            this.PlayerSpace = new System.Windows.Forms.Panel();
            this.TiGameTick = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTPause);
            this.groupBox1.Controls.Add(this.LBDialogue);
            this.groupBox1.Controls.Add(this.BTBlock);
            this.groupBox1.Controls.Add(this.BTSouth);
            this.groupBox1.Controls.Add(this.BTHeal);
            this.groupBox1.Controls.Add(this.BTEast);
            this.groupBox1.Controls.Add(this.BTInteract);
            this.groupBox1.Controls.Add(this.BTWest);
            this.groupBox1.Controls.Add(this.BTRest);
            this.groupBox1.Controls.Add(this.BTNorth);
            this.groupBox1.Controls.Add(this.BTAttack);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(333, 689);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BTPause
            // 
            this.BTPause.Location = new System.Drawing.Point(11, 130);
            this.BTPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTPause.Name = "BTPause";
            this.BTPause.Size = new System.Drawing.Size(315, 41);
            this.BTPause.TabIndex = 10;
            this.BTPause.Text = "Pause";
            this.BTPause.UseVisualStyleBackColor = true;
            this.BTPause.Click += new System.EventHandler(this.GamePaused);
            // 
            // LBDialogue
            // 
            this.LBDialogue.FormattingEnabled = true;
            this.LBDialogue.ItemHeight = 16;
            this.LBDialogue.Location = new System.Drawing.Point(11, 178);
            this.LBDialogue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LBDialogue.Name = "LBDialogue";
            this.LBDialogue.Size = new System.Drawing.Size(313, 180);
            this.LBDialogue.TabIndex = 9;
            // 
            // BTBlock
            // 
            this.BTBlock.Location = new System.Drawing.Point(225, 94);
            this.BTBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTBlock.Name = "BTBlock";
            this.BTBlock.Size = new System.Drawing.Size(100, 28);
            this.BTBlock.TabIndex = 8;
            this.BTBlock.Text = "Parry/Block";
            this.BTBlock.UseVisualStyleBackColor = true;
            // 
            // BTSouth
            // 
            this.BTSouth.Location = new System.Drawing.Point(117, 94);
            this.BTSouth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTSouth.Name = "BTSouth";
            this.BTSouth.Size = new System.Drawing.Size(100, 28);
            this.BTSouth.TabIndex = 7;
            this.BTSouth.Text = "South";
            this.BTSouth.UseVisualStyleBackColor = true;
            this.BTSouth.Click += new System.EventHandler(this.MoveSouth);
            // 
            // BTHeal
            // 
            this.BTHeal.Location = new System.Drawing.Point(11, 94);
            this.BTHeal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTHeal.Name = "BTHeal";
            this.BTHeal.Size = new System.Drawing.Size(100, 28);
            this.BTHeal.TabIndex = 6;
            this.BTHeal.Text = "Heal";
            this.BTHeal.UseVisualStyleBackColor = true;
            // 
            // BTEast
            // 
            this.BTEast.Location = new System.Drawing.Point(225, 60);
            this.BTEast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTEast.Name = "BTEast";
            this.BTEast.Size = new System.Drawing.Size(100, 28);
            this.BTEast.TabIndex = 5;
            this.BTEast.Text = "East";
            this.BTEast.UseVisualStyleBackColor = true;
            this.BTEast.Click += new System.EventHandler(this.MoveEast);
            // 
            // BTInteract
            // 
            this.BTInteract.Location = new System.Drawing.Point(119, 59);
            this.BTInteract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTInteract.Name = "BTInteract";
            this.BTInteract.Size = new System.Drawing.Size(100, 28);
            this.BTInteract.TabIndex = 4;
            this.BTInteract.Text = "Interact";
            this.BTInteract.UseVisualStyleBackColor = true;
            // 
            // BTWest
            // 
            this.BTWest.Location = new System.Drawing.Point(11, 59);
            this.BTWest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTWest.Name = "BTWest";
            this.BTWest.Size = new System.Drawing.Size(100, 28);
            this.BTWest.TabIndex = 3;
            this.BTWest.Text = "West";
            this.BTWest.UseVisualStyleBackColor = true;
            this.BTWest.Click += new System.EventHandler(this.MoveWest);
            // 
            // BTRest
            // 
            this.BTRest.Location = new System.Drawing.Point(225, 23);
            this.BTRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTRest.Name = "BTRest";
            this.BTRest.Size = new System.Drawing.Size(100, 28);
            this.BTRest.TabIndex = 2;
            this.BTRest.Text = "Rest";
            this.BTRest.UseVisualStyleBackColor = true;
            // 
            // BTNorth
            // 
            this.BTNorth.Location = new System.Drawing.Point(119, 23);
            this.BTNorth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNorth.Name = "BTNorth";
            this.BTNorth.Size = new System.Drawing.Size(100, 28);
            this.BTNorth.TabIndex = 1;
            this.BTNorth.Text = "North";
            this.BTNorth.UseVisualStyleBackColor = true;
            this.BTNorth.Click += new System.EventHandler(this.MoveNorth);
            // 
            // BTAttack
            // 
            this.BTAttack.Location = new System.Drawing.Point(11, 23);
            this.BTAttack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTAttack.Name = "BTAttack";
            this.BTAttack.Size = new System.Drawing.Size(100, 28);
            this.BTAttack.TabIndex = 0;
            this.BTAttack.Text = "Attack";
            this.BTAttack.UseVisualStyleBackColor = true;
            // 
            // PlayerSpace
            // 
            this.PlayerSpace.BackColor = System.Drawing.Color.NavajoWhite;
            this.PlayerSpace.Location = new System.Drawing.Point(359, 16);
            this.PlayerSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerSpace.Name = "PlayerSpace";
            this.PlayerSpace.Size = new System.Drawing.Size(732, 674);
            this.PlayerSpace.TabIndex = 1;
            // 
            // TiGameTick
            // 
            this.TiGameTick.Enabled = true;
            this.TiGameTick.Interval = 1000;
            this.TiGameTick.Tick += new System.EventHandler(this.GameTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 731);
            this.Controls.Add(this.PlayerSpace);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTPause;
        private System.Windows.Forms.ListBox LBDialogue;
        private System.Windows.Forms.Button BTBlock;
        private System.Windows.Forms.Button BTSouth;
        private System.Windows.Forms.Button BTHeal;
        private System.Windows.Forms.Button BTEast;
        private System.Windows.Forms.Button BTInteract;
        private System.Windows.Forms.Button BTWest;
        private System.Windows.Forms.Button BTRest;
        private System.Windows.Forms.Button BTNorth;
        private System.Windows.Forms.Button BTAttack;
        private System.Windows.Forms.Panel PlayerSpace;
        private System.Windows.Forms.Timer TiGameTick;
    }
}

