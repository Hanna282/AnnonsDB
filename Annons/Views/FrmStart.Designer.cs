namespace Annons.Views
{
    partial class FrmStart
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblFilterCategories = new Label();
            lstSearchResult = new ListBox();
            lblSorting = new Label();
            cmbSorting = new ComboBox();
            btnSignIn = new Button();
            btnRegister = new Button();
            lblAdvert = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            txtDescription = new TextBox();
            btnClose = new Button();
            cmbSearchFilter = new ComboBox();
            btnOpenAdvert = new Button();
            txtCategory = new TextBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtDate = new TextBox();
            lblDate = new Label();
            btnSignOut = new Button();
            btnNewAdvert = new Button();
            btnMyAdverts = new Button();
            btnRemoveCategory = new Button();
            SuspendLayout();
            // 
            // lblFyndit
            // 
            lblFyndit.AutoSize = true;
            lblFyndit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFyndit.Location = new Point(36, 43);
            lblFyndit.Name = "lblFyndit";
            lblFyndit.Size = new Size(142, 54);
            lblFyndit.TabIndex = 0;
            lblFyndit.Text = "Fyndit";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 181);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Vad söker du efter?";
            txtSearch.Size = new Size(282, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(324, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(159, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Sök annons";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblFilterCategories
            // 
            lblFilterCategories.AutoSize = true;
            lblFilterCategories.Location = new Point(36, 226);
            lblFilterCategories.Name = "lblFilterCategories";
            lblFilterCategories.Size = new Size(130, 25);
            lblFilterCategories.TabIndex = 4;
            lblFilterCategories.Text = "Alla kategorier:";
            // 
            // lstSearchResult
            // 
            lstSearchResult.FormattingEnabled = true;
            lstSearchResult.ItemHeight = 25;
            lstSearchResult.Location = new Point(36, 412);
            lstSearchResult.Name = "lstSearchResult";
            lstSearchResult.Size = new Size(429, 479);
            lstSearchResult.TabIndex = 5;
            lstSearchResult.TabStop = false;
            // 
            // lblSorting
            // 
            lblSorting.AutoSize = true;
            lblSorting.Location = new Point(36, 367);
            lblSorting.Name = "lblSorting";
            lblSorting.Size = new Size(89, 25);
            lblSorting.TabIndex = 7;
            lblSorting.Text = "Sortering:";
            // 
            // cmbSorting
            // 
            cmbSorting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSorting.FormattingEnabled = true;
            cmbSorting.Location = new Point(131, 364);
            cmbSorting.Name = "cmbSorting";
            cmbSorting.Size = new Size(228, 33);
            cmbSorting.TabIndex = 6;
            cmbSorting.TabStop = false;
            cmbSorting.SelectedIndexChanged += cmbSorting_SelectedIndexChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.GhostWhite;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(815, 54);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(167, 47);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Logga in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LemonChiffon;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(988, 54);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(167, 47);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Skapa konto";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblAdvert
            // 
            lblAdvert.AutoSize = true;
            lblAdvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdvert.Location = new Point(670, 360);
            lblAdvert.Name = "lblAdvert";
            lblAdvert.Size = new Size(119, 32);
            lblAdvert.TabIndex = 10;
            lblAdvert.Text = "ANNONS";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(670, 664);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(109, 25);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Beskrivning";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(670, 431);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(83, 25);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Kategori";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Window;
            txtDescription.Location = new Point(670, 710);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(485, 181);
            txtDescription.TabIndex = 15;
            txtDescription.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(973, 931);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(182, 47);
            btnClose.TabIndex = 16;
            btnClose.Text = "Stäng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cmbSearchFilter
            // 
            cmbSearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchFilter.FormattingEnabled = true;
            cmbSearchFilter.Location = new Point(168, 223);
            cmbSearchFilter.Name = "cmbSearchFilter";
            cmbSearchFilter.Size = new Size(228, 33);
            cmbSearchFilter.TabIndex = 3;
            cmbSearchFilter.TabStop = false;
            cmbSearchFilter.DropDown += cmbSearchFilter_DropDown;
            // 
            // btnOpenAdvert
            // 
            btnOpenAdvert.Location = new Point(296, 911);
            btnOpenAdvert.Name = "btnOpenAdvert";
            btnOpenAdvert.Size = new Size(169, 46);
            btnOpenAdvert.TabIndex = 18;
            btnOpenAdvert.Text = "Öppna annons";
            btnOpenAdvert.UseVisualStyleBackColor = true;
            btnOpenAdvert.Click += btnOpenAdvert_Click;
            // 
            // txtCategory
            // 
            txtCategory.BackColor = SystemColors.Window;
            txtCategory.Location = new Point(815, 431);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(340, 31);
            txtCategory.TabIndex = 19;
            txtCategory.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Window;
            txtTitle.Location = new Point(815, 483);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(340, 31);
            txtTitle.TabIndex = 21;
            txtTitle.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(670, 483);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 25);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Rubrik";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Window;
            txtPrice.Location = new Point(815, 539);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(340, 31);
            txtPrice.TabIndex = 23;
            txtPrice.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(670, 539);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 25);
            lblPrice.TabIndex = 22;
            lblPrice.Text = "Pris";
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Window;
            txtDate.Location = new Point(815, 593);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(340, 31);
            txtDate.TabIndex = 25;
            txtDate.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(670, 593);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(71, 25);
            lblDate.TabIndex = 24;
            lblDate.Text = "Skapad";
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.GhostWhite;
            btnSignOut.FlatStyle = FlatStyle.Popup;
            btnSignOut.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignOut.Location = new Point(988, 63);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(167, 47);
            btnSignOut.TabIndex = 29;
            btnSignOut.Text = "Logga ut";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnNewAdvert
            // 
            btnNewAdvert.BackColor = Color.MistyRose;
            btnNewAdvert.FlatStyle = FlatStyle.Flat;
            btnNewAdvert.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewAdvert.Location = new Point(815, 64);
            btnNewAdvert.Name = "btnNewAdvert";
            btnNewAdvert.Size = new Size(167, 46);
            btnNewAdvert.TabIndex = 28;
            btnNewAdvert.Text = "Ny annons";
            btnNewAdvert.UseVisualStyleBackColor = false;
            btnNewAdvert.Click += btnNewAdvert_Click;
            // 
            // btnMyAdverts
            // 
            btnMyAdverts.BackColor = Color.Snow;
            btnMyAdverts.FlatStyle = FlatStyle.Flat;
            btnMyAdverts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyAdverts.Location = new Point(633, 63);
            btnMyAdverts.Name = "btnMyAdverts";
            btnMyAdverts.Size = new Size(167, 46);
            btnMyAdverts.TabIndex = 30;
            btnMyAdverts.UseVisualStyleBackColor = false;
            btnMyAdverts.Click += btnMyAdverts_Click;
            // 
            // btnRemoveCategory
            // 
            btnRemoveCategory.Location = new Point(402, 221);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(48, 34);
            btnRemoveCategory.TabIndex = 31;
            btnRemoveCategory.Text = "X";
            btnRemoveCategory.UseVisualStyleBackColor = true;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 1009);
            Controls.Add(btnRemoveCategory);
            Controls.Add(btnMyAdverts);
            Controls.Add(btnSignOut);
            Controls.Add(btnNewAdvert);
            Controls.Add(txtDate);
            Controls.Add(lblDate);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(txtCategory);
            Controls.Add(btnOpenAdvert);
            Controls.Add(btnClose);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblAdvert);
            Controls.Add(btnRegister);
            Controls.Add(btnSignIn);
            Controls.Add(lblSorting);
            Controls.Add(cmbSorting);
            Controls.Add(lstSearchResult);
            Controls.Add(lblFilterCategories);
            Controls.Add(cmbSearchFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblFyndit);
            Name = "FrmStart";
            Text = "Start Fyndit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFyndit;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblFilterCategories;
        private ListBox lstSearchResult;
        private Label lblSorting;
        private ComboBox cmbSorting;
        private Button btnSignIn;
        private Button btnRegister;
        private Label lblAdvert;
        private Label lblDescription;
        private Label lblCategory;
        private TextBox txtDescription;
        private Button btnClose;
        private ComboBox cmbSearchFilter;
        private Button btnOpenAdvert;
        private TextBox txtCategory;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtDate;
        private Label lblDate;
        private Button btnSignOut;
        private Button btnNewAdvert;
        private Button btnMyAdverts;
        private Button btnRemoveCategory;
    }
}