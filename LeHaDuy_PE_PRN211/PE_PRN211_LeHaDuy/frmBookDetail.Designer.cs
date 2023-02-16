namespace PE_PRN211_LeHaDuy
{
    partial class frmBookDetail
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
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbAuthorName = new System.Windows.Forms.Label();
            this.lbPublisherID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboPublisherID = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Location = new System.Drawing.Point(65, 59);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(58, 20);
            this.lbBookID.TabIndex = 0;
            this.lbBookID.Text = "BookID";
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(65, 118);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(83, 20);
            this.lbBookName.TabIndex = 1;
            this.lbBookName.Text = "BookName";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(65, 179);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 2;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbAuthorName
            // 
            this.lbAuthorName.AutoSize = true;
            this.lbAuthorName.Location = new System.Drawing.Point(65, 244);
            this.lbAuthorName.Name = "lbAuthorName";
            this.lbAuthorName.Size = new System.Drawing.Size(94, 20);
            this.lbAuthorName.TabIndex = 3;
            this.lbAuthorName.Text = "AuthorName";
            // 
            // lbPublisherID
            // 
            this.lbPublisherID.AutoSize = true;
            this.lbPublisherID.Location = new System.Drawing.Point(65, 315);
            this.lbPublisherID.Name = "lbPublisherID";
            this.lbPublisherID.Size = new System.Drawing.Size(84, 20);
            this.lbPublisherID.TabIndex = 4;
            this.lbPublisherID.Text = "PublisherID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(198, 52);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(253, 27);
            this.txtBookID.TabIndex = 5;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(198, 111);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(253, 27);
            this.txtBookName.TabIndex = 6;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(198, 237);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(253, 27);
            this.txtAuthorName.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(303, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboPublisherID
            // 
            this.cboPublisherID.FormattingEnabled = true;
            this.cboPublisherID.Location = new System.Drawing.Point(198, 307);
            this.cboPublisherID.Name = "cboPublisherID";
            this.cboPublisherID.Size = new System.Drawing.Size(253, 28);
            this.cboPublisherID.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(198, 172);
            this.txtQuantity.Mask = "000";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(253, 27);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.Text = "0";
            // 
            // frmBookDetail
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboPublisherID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbPublisherID);
            this.Controls.Add(this.lbAuthorName);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbBookID);
            this.Name = "frmBookDetail";
            this.Text = "frmBookDetail";
            this.Load += new System.EventHandler(this.frmBookDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbAuthorName;
        private System.Windows.Forms.Label lbPublisherID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboPublisherID;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
    }
}