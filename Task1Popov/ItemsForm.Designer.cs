namespace Task1Popov
{
    partial class ItemsForm
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(531, 34);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(563, 9);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(192, 37);
            this.comboBoxSort.TabIndex = 1;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(772, 9);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(192, 37);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnImage,
            this.columnArticle,
            this.columnName,
            this.columnCost});
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 52);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(952, 474);
            this.listViewItems.TabIndex = 3;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            // 
            // columnImage
            // 
            this.columnImage.Text = "";
            this.columnImage.Width = 100;
            // 
            // columnArticle
            // 
            this.columnArticle.Text = "";
            this.columnArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnArticle.Width = 100;
            // 
            // columnName
            // 
            this.columnName.Text = "";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 100;
            // 
            // columnCost
            // 
            this.columnCost.Text = "";
            this.columnCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCost.Width = 100;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(976, 538);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "ItemsForm";
            this.Text = "Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemsForm_FormClosing);
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnImage;
        private System.Windows.Forms.ColumnHeader columnArticle;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCost;
    }
}