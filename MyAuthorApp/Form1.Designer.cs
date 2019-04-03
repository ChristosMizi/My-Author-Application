namespace MyAuthorApp
{
    partial class FrmDatabase
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
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.btnAllRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBooks
            // 
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Location = new System.Drawing.Point(26, 12);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(748, 284);
            this.grdBooks.TabIndex = 0;
            // 
            // btnAllRecords
            // 
            this.btnAllRecords.Location = new System.Drawing.Point(666, 399);
            this.btnAllRecords.Name = "btnAllRecords";
            this.btnAllRecords.Size = new System.Drawing.Size(105, 23);
            this.btnAllRecords.TabIndex = 1;
            this.btnAllRecords.Text = "Show All Records";
            this.btnAllRecords.UseVisualStyleBackColor = true;
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAllRecords);
            this.Controls.Add(this.grdBooks);
            this.Name = "FrmDatabase";
            this.Text = "Book Database";
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Button btnAllRecords;
    }
}

