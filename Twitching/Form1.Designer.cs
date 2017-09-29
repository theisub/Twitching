namespace Twitching
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
            this.ChannelNameBox = new System.Windows.Forms.TextBox();
            this.UpdateDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.LastModifiedFile = new System.Windows.Forms.Label();
            this.BoardOfHaters = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ChannelNameBox
            // 
            this.ChannelNameBox.AcceptsTab = true;
            this.ChannelNameBox.Location = new System.Drawing.Point(324, 264);
            this.ChannelNameBox.Name = "ChannelNameBox";
            this.ChannelNameBox.Size = new System.Drawing.Size(75, 20);
            this.ChannelNameBox.TabIndex = 1;
            // 
            // UpdateDB
            // 
            this.UpdateDB.Location = new System.Drawing.Point(324, 222);
            this.UpdateDB.Name = "UpdateDB";
            this.UpdateDB.Size = new System.Drawing.Size(75, 36);
            this.UpdateDB.TabIndex = 2;
            this.UpdateDB.Text = "Обновить базу";
            this.UpdateDB.UseVisualStyleBackColor = true;
            this.UpdateDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Перейти на канал";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Compare
            // 
            this.Compare.Enabled = false;
            this.Compare.Location = new System.Drawing.Point(405, 222);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(75, 36);
            this.Compare.TabIndex = 4;
            this.Compare.Text = "Сравнить";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // LastModifiedFile
            // 
            this.LastModifiedFile.AutoSize = true;
            this.LastModifiedFile.Location = new System.Drawing.Point(525, 430);
            this.LastModifiedFile.Name = "LastModifiedFile";
            this.LastModifiedFile.Size = new System.Drawing.Size(161, 13);
            this.LastModifiedFile.TabIndex = 5;
            this.LastModifiedFile.Text = "Последнее обновление базы: ";
            // 
            // BoardOfHaters
            // 
            this.BoardOfHaters.Location = new System.Drawing.Point(324, 5);
            this.BoardOfHaters.Name = "BoardOfHaters";
            this.BoardOfHaters.Size = new System.Drawing.Size(156, 211);
            this.BoardOfHaters.TabIndex = 6;
            this.BoardOfHaters.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 452);
            this.Controls.Add(this.BoardOfHaters);
            this.Controls.Add(this.LastModifiedFile);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateDB);
            this.Controls.Add(this.ChannelNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ChannelNameBox;
        private System.Windows.Forms.Button UpdateDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Label LastModifiedFile;
        private System.Windows.Forms.RichTextBox BoardOfHaters;
    }
}

