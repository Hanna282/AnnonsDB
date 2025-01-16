namespace Annons.Views
{
    partial class FrmSellerAdverts
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
            lblFyndit = new Label();
            lblDateCreated = new Label();
            lblDate = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            txtCurrency = new TextBox();
            lblManageAdvert = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            lstSearchResult = new ListBox();
            lblAdverts = new Label();
            btnManageAdvert = new Button();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnClose = new Button();
            lblSeller = new Label();
            btnNewAdvert = new Button();
            lblSorting = new Label();
            cmbSorting = new ComboBox();
            lblShowSeller = new Label();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // lblFyndit
            // 
            lblFyndit.AutoSize = true;
            lblFyndit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFyndit.Location = new Point(36, 36);
            lblFyndit.Name = "lblFyndit";
            lblFyndit.Size = new Size(142, 54);
            lblFyndit.TabIndex = 28;
            lblFyndit.Text = "Fyndit";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(616, 706);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(75, 25);
            lblDateCreated.TabIndex = 78;
            lblDateCreated.Text = "Skapad:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(697, 706);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 25);
            lblDate.TabIndex = 77;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(616, 757);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(232, 46);
            btnSave.TabIndex = 76;
            btnSave.Text = "Spara annons";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(859, 757);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(243, 46);
            btnDelete.TabIndex = 75;
            btnDelete.Text = "Ta bort annons";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCurrency
            // 
            txtCurrency.BackColor = SystemColors.Window;
            txtCurrency.Location = new Point(1024, 636);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.ReadOnly = true;
            txtCurrency.Size = new Size(78, 31);
            txtCurrency.TabIndex = 74;
            txtCurrency.TabStop = false;
            txtCurrency.Text = "kr";
            txtCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // lblManageAdvert
            // 
            lblManageAdvert.AutoSize = true;
            lblManageAdvert.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageAdvert.Location = new Point(607, 159);
            lblManageAdvert.Name = "lblManageAdvert";
            lblManageAdvert.Size = new Size(225, 38);
            lblManageAdvert.TabIndex = 73;
            lblManageAdvert.Text = "Hantera annons";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(616, 433);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 70;
            lblDescription.Text = "Beskrivning";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(616, 608);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 25);
            lblPrice.TabIndex = 68;
            lblPrice.Text = "Pris";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(616, 244);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 25);
            lblCategory.TabIndex = 67;
            lblCategory.Text = "Kategori";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(616, 338);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 25);
            lblTitle.TabIndex = 65;
            lblTitle.Text = "Rubrik";
            // 
            // lstSearchResult
            // 
            lstSearchResult.FormattingEnabled = true;
            lstSearchResult.ItemHeight = 25;
            lstSearchResult.Location = new Point(36, 260);
            lstSearchResult.Name = "lstSearchResult";
            lstSearchResult.Size = new Size(429, 479);
            lstSearchResult.TabIndex = 79;
            lstSearchResult.TabStop = false;
            // 
            // lblAdverts
            // 
            lblAdverts.AutoSize = true;
            lblAdverts.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdverts.Location = new Point(36, 159);
            lblAdverts.Name = "lblAdverts";
            lblAdverts.Size = new Size(213, 38);
            lblAdverts.TabIndex = 80;
            lblAdverts.Text = "Mina annonser";
            // 
            // btnManageAdvert
            // 
            btnManageAdvert.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageAdvert.Location = new Point(273, 757);
            btnManageAdvert.Name = "btnManageAdvert";
            btnManageAdvert.Size = new Size(192, 46);
            btnManageAdvert.TabIndex = 81;
            btnManageAdvert.Text = "Visa annons";
            btnManageAdvert.UseVisualStyleBackColor = true;
            btnManageAdvert.Click += btnManageAdvert_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(616, 366);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(486, 31);
            txtTitle.TabIndex = 82;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(616, 461);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(486, 122);
            txtDescription.TabIndex = 83;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(616, 636);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(412, 31);
            txtPrice.TabIndex = 84;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(931, 836);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(171, 46);
            btnClose.TabIndex = 85;
            btnClose.Text = "Till start";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblSeller
            // 
            lblSeller.AutoSize = true;
            lblSeller.Location = new Point(947, 59);
            lblSeller.Name = "lblSeller";
            lblSeller.Size = new Size(0, 25);
            lblSeller.TabIndex = 86;
            // 
            // btnNewAdvert
            // 
            btnNewAdvert.BackColor = Color.MistyRose;
            btnNewAdvert.FlatStyle = FlatStyle.Flat;
            btnNewAdvert.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewAdvert.Location = new Point(100, 757);
            btnNewAdvert.Name = "btnNewAdvert";
            btnNewAdvert.Size = new Size(167, 46);
            btnNewAdvert.TabIndex = 87;
            btnNewAdvert.Text = "Skapa ny annons";
            btnNewAdvert.UseVisualStyleBackColor = false;
            btnNewAdvert.Click += btnNewAdvert_Click;
            // 
            // lblSorting
            // 
            lblSorting.AutoSize = true;
            lblSorting.Location = new Point(36, 221);
            lblSorting.Name = "lblSorting";
            lblSorting.Size = new Size(89, 25);
            lblSorting.TabIndex = 89;
            lblSorting.Text = "Sortering:";
            // 
            // cmbSorting
            // 
            cmbSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSorting.FormattingEnabled = true;
            cmbSorting.Location = new Point(131, 218);
            cmbSorting.Name = "cmbSorting";
            cmbSorting.Size = new Size(228, 33);
            cmbSorting.TabIndex = 88;
            cmbSorting.TabStop = false;
            cmbSorting.SelectedIndexChanged += cmbSorting_SelectedIndexChanged;
            // 
            // lblShowSeller
            // 
            lblShowSeller.AutoSize = true;
            lblShowSeller.Location = new Point(840, 59);
            lblShowSeller.Name = "lblShowSeller";
            lblShowSeller.Size = new Size(101, 25);
            lblShowSeller.TabIndex = 91;
            lblShowSeller.Text = "Användare:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(616, 272);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(486, 33);
            cmbCategory.TabIndex = 92;
            cmbCategory.TabStop = false;
            // 
            // FrmSellerAdverts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 919);
            Controls.Add(cmbCategory);
            Controls.Add(lblShowSeller);
            Controls.Add(lblSorting);
            Controls.Add(cmbSorting);
            Controls.Add(btnNewAdvert);
            Controls.Add(lblSeller);
            Controls.Add(btnClose);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(btnManageAdvert);
            Controls.Add(lblAdverts);
            Controls.Add(lstSearchResult);
            Controls.Add(lblDateCreated);
            Controls.Add(lblDate);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(txtCurrency);
            Controls.Add(lblManageAdvert);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(lblFyndit);
            Name = "FrmSellerAdverts";
            Text = "Mina sidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFyndit;
        private Label lblDateCreated;
        private Label lblDate;
        private Button btnSave;
        private Button btnDelete;
        private TextBox txtCurrency;
        private Label lblManageAdvert;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblCategory;
        private Label lblTitle;
        private ListBox lstSearchResult;
        private Label lblAdverts;
        private Button btnManageAdvert;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnClose;
        private Label lblSeller;
        private Button btnNewAdvert;
        private Label lblSorting;
        private ComboBox cmbSorting;
        private Label lblShowSeller;
        private ComboBox cmbCategory;
    }
}