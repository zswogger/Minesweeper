
namespace MilestoneGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_moves = new System.Windows.Forms.Label();
            this.lbl_bombs = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 374);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_moves
            // 
            this.lbl_moves.AutoSize = true;
            this.lbl_moves.Location = new System.Drawing.Point(12, 5);
            this.lbl_moves.Name = "lbl_moves";
            this.lbl_moves.Size = new System.Drawing.Size(57, 13);
            this.lbl_moves.TabIndex = 1;
            this.lbl_moves.Text = "Moves: 00";
            // 
            // lbl_bombs
            // 
            this.lbl_bombs.AutoSize = true;
            this.lbl_bombs.Location = new System.Drawing.Point(327, 5);
            this.lbl_bombs.Name = "lbl_bombs";
            this.lbl_bombs.Size = new System.Drawing.Size(57, 13);
            this.lbl_bombs.TabIndex = 2;
            this.lbl_bombs.Text = "Bombs: 00";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(161, 5);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(63, 13);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time: 00:00";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 410);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_bombs);
            this.Controls.Add(this.lbl_moves);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_moves;
        private System.Windows.Forms.Label lbl_bombs;
        private System.Windows.Forms.Label lbl_time;
    }
}