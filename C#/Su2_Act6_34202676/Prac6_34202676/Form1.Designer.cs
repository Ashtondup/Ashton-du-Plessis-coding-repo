namespace Prac6_34202676
{
    partial class frmTheaters
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
            this.dgvViewData = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSmallTheaters = new System.Windows.Forms.Button();
            this.btnMediumandLargeTheaters = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbTheterNum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewData
            // 
            this.dgvViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewData.Location = new System.Drawing.Point(13, 13);
            this.dgvViewData.Name = "dgvViewData";
            this.dgvViewData.Size = new System.Drawing.Size(484, 345);
            this.dgvViewData.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(535, 13);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 40);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSmallTheaters
            // 
            this.btnSmallTheaters.Location = new System.Drawing.Point(535, 71);
            this.btnSmallTheaters.Name = "btnSmallTheaters";
            this.btnSmallTheaters.Size = new System.Drawing.Size(108, 40);
            this.btnSmallTheaters.TabIndex = 2;
            this.btnSmallTheaters.Text = "Open Seats < 50";
            this.btnSmallTheaters.UseVisualStyleBackColor = true;
            this.btnSmallTheaters.Click += new System.EventHandler(this.btnSmallTheaters_Click);
            // 
            // btnMediumandLargeTheaters
            // 
            this.btnMediumandLargeTheaters.Location = new System.Drawing.Point(535, 128);
            this.btnMediumandLargeTheaters.Name = "btnMediumandLargeTheaters";
            this.btnMediumandLargeTheaters.Size = new System.Drawing.Size(108, 40);
            this.btnMediumandLargeTheaters.TabIndex = 3;
            this.btnMediumandLargeTheaters.Text = "Open Seats 120-260";
            this.btnMediumandLargeTheaters.UseVisualStyleBackColor = true;
            this.btnMediumandLargeTheaters.Click += new System.EventHandler(this.btnMediumandLargeTheaters_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(535, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(535, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbTheterNum
            // 
            this.cbTheterNum.FormattingEnabled = true;
            this.cbTheterNum.Location = new System.Drawing.Point(535, 253);
            this.cbTheterNum.Name = "cbTheterNum";
            this.cbTheterNum.Size = new System.Drawing.Size(121, 21);
            this.cbTheterNum.TabIndex = 6;
            // 
            // frmTheaters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 374);
            this.Controls.Add(this.cbTheterNum);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMediumandLargeTheaters);
            this.Controls.Add(this.btnSmallTheaters);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvViewData);
            this.Name = "frmTheaters";
            this.Text = "Theaters";
            this.Load += new System.EventHandler(this.frmTheaters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewData;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSmallTheaters;
        private System.Windows.Forms.Button btnMediumandLargeTheaters;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbTheterNum;
    }
}

