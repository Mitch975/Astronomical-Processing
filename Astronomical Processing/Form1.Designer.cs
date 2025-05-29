namespace Astronomical_Processing
{
    partial class SprintForm1
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
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.Location = new System.Drawing.Point(7, 58);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(219, 264);
            this.ListBoxResults.TabIndex = 0;
            this.ListBoxResults.SelectedIndexChanged += new System.EventHandler(this.ListBoxResults_SelectedIndexChanged);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(335, 72);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(75, 23);
            this.ButtonSort.TabIndex = 1;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(254, 115);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(288, 144);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(335, 115);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 0;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonShow
            // 
            this.ButtonShow.Location = new System.Drawing.Point(254, 72);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(75, 23);
            this.ButtonShow.TabIndex = 4;
            this.ButtonShow.Text = "Show Array";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // SprintForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 368);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ListBoxResults);
            this.Name = "SprintForm1";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonShow;
    }
}

