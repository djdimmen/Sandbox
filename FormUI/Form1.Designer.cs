﻿
namespace FormUI
{
    partial class Dashboard
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
            this.FoundPeopleListBox = new System.Windows.Forms.ListBox();
            this.LastName = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FoundPeopleListBox
            // 
            this.FoundPeopleListBox.FormattingEnabled = true;
            this.FoundPeopleListBox.ItemHeight = 37;
            this.FoundPeopleListBox.Location = new System.Drawing.Point(125, 341);
            this.FoundPeopleListBox.Name = "FoundPeopleListBox";
            this.FoundPeopleListBox.Size = new System.Drawing.Size(580, 707);
            this.FoundPeopleListBox.TabIndex = 0;
            this.FoundPeopleListBox.SelectedIndexChanged += new System.EventHandler(this.FoundPeopleListBox_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(125, 122);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(173, 37);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(322, 229);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 57);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(322, 122);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(382, 44);
            this.LastNameText.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1410, 1153);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FoundPeopleListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameTest;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox FoundPeopleListBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox LastNameText;
    }
}

