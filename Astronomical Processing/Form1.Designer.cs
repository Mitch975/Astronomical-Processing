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
            this.MidExButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.AverageButton = new System.Windows.Forms.Button();
            this.RangeButton = new System.Windows.Forms.Button();
            this.SequentialSearchButton = new System.Windows.Forms.Button();
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
            this.ButtonSearch.Location = new System.Drawing.Point(254, 194);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(254, 223);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(156, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(335, 194);
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
            // MidExButton
            // 
            this.MidExButton.Location = new System.Drawing.Point(254, 107);
            this.MidExButton.Name = "MidExButton";
            this.MidExButton.Size = new System.Drawing.Size(75, 23);
            this.MidExButton.TabIndex = 5;
            this.MidExButton.Text = "Mid-Extreme";
            this.MidExButton.UseVisualStyleBackColor = true;
            this.MidExButton.Click += new System.EventHandler(this.MidExButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(335, 107);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(75, 23);
            this.ModeButton.TabIndex = 6;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(254, 136);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(75, 23);
            this.AverageButton.TabIndex = 7;
            this.AverageButton.Text = "Average";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // RangeButton
            // 
            this.RangeButton.Location = new System.Drawing.Point(335, 136);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(75, 23);
            this.RangeButton.TabIndex = 8;
            this.RangeButton.Text = "Range";
            this.RangeButton.UseVisualStyleBackColor = true;
            this.RangeButton.Click += new System.EventHandler(this.RangeButton_Click);
            // 
            // SequentialSearchButton
            // 
            this.SequentialSearchButton.Location = new System.Drawing.Point(274, 165);
            this.SequentialSearchButton.Name = "SequentialSearchButton";
            this.SequentialSearchButton.Size = new System.Drawing.Size(114, 23);
            this.SequentialSearchButton.TabIndex = 9;
            this.SequentialSearchButton.Text = "Sequential Search";
            this.SequentialSearchButton.UseVisualStyleBackColor = true;
            this.SequentialSearchButton.Click += new System.EventHandler(this.SequentialSearchButton_Click);
            // 
            // SprintForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 409);
            this.Controls.Add(this.SequentialSearchButton);
            this.Controls.Add(this.RangeButton);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MidExButton);
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
        private System.Windows.Forms.Button MidExButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.Button RangeButton;
        private System.Windows.Forms.Button SequentialSearchButton;
    }
}

