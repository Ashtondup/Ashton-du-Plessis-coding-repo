namespace Prac4_34202676
{
    partial class List
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
            this.dtgListData = new System.Windows.Forms.DataGridView();
            this.lblSearchPhrase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPhrase = new System.Windows.Forms.TextBox();
            this.txtFindRating = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListData
            // 
            this.dtgListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListData.Location = new System.Drawing.Point(1, 0);
            this.dtgListData.Name = "dtgListData";
            this.dtgListData.Size = new System.Drawing.Size(592, 295);
            this.dtgListData.TabIndex = 0;
            // 
            // lblSearchPhrase
            // 
            this.lblSearchPhrase.AutoSize = true;
            this.lblSearchPhrase.Location = new System.Drawing.Point(12, 326);
            this.lblSearchPhrase.Name = "lblSearchPhrase";
            this.lblSearchPhrase.Size = new System.Drawing.Size(158, 13);
            this.lblSearchPhrase.TabIndex = 1;
            this.lblSearchPhrase.Text = "Search for phrase wthin Slogan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find acording to Rating:\r\n";
            // 
            // txtSearchPhrase
            // 
            this.txtSearchPhrase.Location = new System.Drawing.Point(197, 323);
            this.txtSearchPhrase.Name = "txtSearchPhrase";
            this.txtSearchPhrase.Size = new System.Drawing.Size(100, 20);
            this.txtSearchPhrase.TabIndex = 3;
            // 
            // txtFindRating
            // 
            this.txtFindRating.Location = new System.Drawing.Point(197, 389);
            this.txtFindRating.Name = "txtFindRating";
            this.txtFindRating.Size = new System.Drawing.Size(100, 20);
            this.txtFindRating.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(342, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(342, 386);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(518, 351);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display all";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFindRating);
            this.Controls.Add(this.txtSearchPhrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearchPhrase);
            this.Controls.Add(this.dtgListData);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListData;
        private System.Windows.Forms.Label lblSearchPhrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPhrase;
        private System.Windows.Forms.TextBox txtFindRating;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDisplay;
    }
}