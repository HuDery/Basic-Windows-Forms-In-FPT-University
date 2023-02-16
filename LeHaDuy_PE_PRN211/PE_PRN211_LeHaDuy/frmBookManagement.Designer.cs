namespace PE_PRN211_LeHaDuy
{
    partial class frmBookManagement
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
            this.dgvBookGrid = new System.Windows.Forms.DataGridView();
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.lbPublisherID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtPublisherID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookGrid
            // 
            this.dgvBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookGrid.Location = new System.Drawing.Point(80, 231);
            this.dgvBookGrid.Name = "dgvBookGrid";
            this.dgvBookGrid.ReadOnly = true;
            this.dgvBookGrid.RowHeadersWidth = 51;
            this.dgvBookGrid.RowTemplate.Height = 29;
            this.dgvBookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookGrid.Size = new System.Drawing.Size(806, 213);
            this.dgvBookGrid.TabIndex = 0;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Location = new System.Drawing.Point(34, 34);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(58, 20);
            this.lbBookID.TabIndex = 1;
            this.lbBookID.Text = "BookID";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(34, 82);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(83, 20);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "BookName";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(338, 34);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(338, 82);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(94, 20);
            this.lbAuthorName.TabIndex = 4;
            this.lbAuthorName.Text = "AuthorName";
            // 
            // lbPublisherID
            // 
            this.lbPublisherID.AutoSize = true;
            this.lbPublisherID.Location = new System.Drawing.Point(656, 34);
            this.lbPublisherID.Name = "lbPublisherID";
            this.lbPublisherID.Size = new System.Drawing.Size(84, 20);
            this.lbPublisherID.TabIndex = 5;
            this.lbPublisherID.Text = "PublisherID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(123, 31);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(200, 27);
            this.txtBookID.TabIndex = 6;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(123, 79);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 27);
            this.txtBookName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(436, 27);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(211, 27);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(436, 75);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(211, 27);
            this.txtAuthorName.TabIndex = 9;
            // 
            // txtPublisherID
            // 
            this.txtPublisherID.Location = new System.Drawing.Point(746, 27);
            this.txtPublisherID.Name = "txtPublisherID";
            this.txtPublisherID.Size = new System.Drawing.Size(193, 27);
            this.txtPublisherID.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(123, 179);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(338, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(746, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(436, 469);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(544, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 523);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtPublisherID);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbPublisherID);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbBookID);
            this.Controls.Add(this.dgvBookGrid);
            this.Name = "frmBookManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookManagement";
            this.Load += new System.EventHandler(this.frmBookManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookGrid;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Label lbPublisherID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtPublisherID;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}