
namespace MilestoneGUI
{
    partial class SelectLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Level";
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Checked = true;
            this.rb_easy.Location = new System.Drawing.Point(62, 42);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(48, 17);
            this.rb_easy.TabIndex = 1;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Easy";
            this.rb_easy.UseVisualStyleBackColor = true;
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(62, 103);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(62, 17);
            this.rb_medium.TabIndex = 2;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(62, 164);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(48, 17);
            this.rb_hard.TabIndex = 3;
            this.rb_hard.Text = "Hard";
            this.rb_hard.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(183, 206);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(96, 33);
            this.btn_play.TabIndex = 4;
            this.btn_play.Text = "Play Game";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            this.btn_play.MouseEnter += new System.EventHandler(this.btn_play_MouseEnter);
            this.btn_play.MouseLeave += new System.EventHandler(this.btn_play_MouseLeave);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 251);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_medium);
            this.Controls.Add(this.rb_easy);
            this.Controls.Add(this.label1);
            this.Name = "SelectLevel";
            this.Text = "Select Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.Button btn_play;
    }
}

