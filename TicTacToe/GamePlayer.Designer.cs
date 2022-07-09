namespace TicTacToe
{
    partial class GamePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlayer));
            this.BT_2_1 = new System.Windows.Forms.Button();
            this.BT_1_1 = new System.Windows.Forms.Button();
            this.BT_3_1 = new System.Windows.Forms.Button();
            this.BT_2_2 = new System.Windows.Forms.Button();
            this.BT_3_2 = new System.Windows.Forms.Button();
            this.BT_1_2 = new System.Windows.Forms.Button();
            this.BT_2_3 = new System.Windows.Forms.Button();
            this.BT_3_3 = new System.Windows.Forms.Button();
            this.BT_1_3 = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_2_1
            // 
            resources.ApplyResources(this.BT_2_1, "BT_2_1");
            this.BT_2_1.Name = "BT_2_1";
            this.BT_2_1.UseVisualStyleBackColor = true;
            this.BT_2_1.Click += new System.EventHandler(this.BT_2_1_Click);
            // 
            // BT_1_1
            // 
            resources.ApplyResources(this.BT_1_1, "BT_1_1");
            this.BT_1_1.Name = "BT_1_1";
            this.BT_1_1.UseVisualStyleBackColor = true;
            this.BT_1_1.Click += new System.EventHandler(this.BT_1_1_Click);
            // 
            // BT_3_1
            // 
            resources.ApplyResources(this.BT_3_1, "BT_3_1");
            this.BT_3_1.Name = "BT_3_1";
            this.BT_3_1.UseVisualStyleBackColor = true;
            this.BT_3_1.Click += new System.EventHandler(this.BT_3_1_Click);
            // 
            // BT_2_2
            // 
            resources.ApplyResources(this.BT_2_2, "BT_2_2");
            this.BT_2_2.Name = "BT_2_2";
            this.BT_2_2.UseVisualStyleBackColor = true;
            this.BT_2_2.Click += new System.EventHandler(this.BT_2_2_Click);
            // 
            // BT_3_2
            // 
            resources.ApplyResources(this.BT_3_2, "BT_3_2");
            this.BT_3_2.Name = "BT_3_2";
            this.BT_3_2.UseVisualStyleBackColor = true;
            this.BT_3_2.Click += new System.EventHandler(this.BT_3_2_Click);
            // 
            // BT_1_2
            // 
            resources.ApplyResources(this.BT_1_2, "BT_1_2");
            this.BT_1_2.Name = "BT_1_2";
            this.BT_1_2.UseVisualStyleBackColor = true;
            this.BT_1_2.Click += new System.EventHandler(this.BT_1_2_Click);
            // 
            // BT_2_3
            // 
            resources.ApplyResources(this.BT_2_3, "BT_2_3");
            this.BT_2_3.Name = "BT_2_3";
            this.BT_2_3.UseVisualStyleBackColor = true;
            this.BT_2_3.Click += new System.EventHandler(this.BT_2_3_Click);
            // 
            // BT_3_3
            // 
            resources.ApplyResources(this.BT_3_3, "BT_3_3");
            this.BT_3_3.Name = "BT_3_3";
            this.BT_3_3.UseVisualStyleBackColor = true;
            this.BT_3_3.Click += new System.EventHandler(this.BT_3_3_Click);
            // 
            // BT_1_3
            // 
            resources.ApplyResources(this.BT_1_3, "BT_1_3");
            this.BT_1_3.Name = "BT_1_3";
            this.BT_1_3.UseVisualStyleBackColor = true;
            this.BT_1_3.Click += new System.EventHandler(this.BT_1_3_Click);
            // 
            // Player
            // 
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            // 
            // restart
            // 
            resources.ApplyResources(this.restart, "restart");
            this.restart.Name = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // GamePlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.BT_1_3);
            this.Controls.Add(this.BT_1_2);
            this.Controls.Add(this.BT_1_1);
            this.Controls.Add(this.BT_3_3);
            this.Controls.Add(this.BT_3_2);
            this.Controls.Add(this.BT_3_1);
            this.Controls.Add(this.BT_2_3);
            this.Controls.Add(this.BT_2_2);
            this.Controls.Add(this.BT_2_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePlayer";
            this.Load += new System.EventHandler(this.GamePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_2_1;
        private System.Windows.Forms.Button BT_1_1;
        private System.Windows.Forms.Button BT_3_1;
        private System.Windows.Forms.Button BT_2_2;
        private System.Windows.Forms.Button BT_3_2;
        private System.Windows.Forms.Button BT_1_2;
        private System.Windows.Forms.Button BT_2_3;
        private System.Windows.Forms.Button BT_3_3;
        private System.Windows.Forms.Button BT_1_3;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button menu;
    }
}