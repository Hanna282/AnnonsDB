namespace Annons.Views
{
    partial class FrmCreateAdvert
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
            cmbCategory = new ComboBox();
            btnClose = new Button();
            btnCreate = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            lblFyndit = new Label();
            lblCreateAdvert = new Label();
            txtCurrency = new TextBox();
            btnToStartClose = new Button();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(57, 276);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(486, 33);
            cmbCategory.TabIndex = 45;
            cmbCategory.DropDown += cmbCategory_DropDown;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(394, 859);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 34);
            btnClose.TabIndex = 43;
            btnClose.Text = "Till mina sidor";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(57, 773);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(486, 46);
            btnCreate.TabIndex = 41;
            btnCreate.Text = "Skapa annons";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(57, 491);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Berätta gärna om skick och mått.";
            txtDescription.Size = new Size(486, 133);
            txtDescription.TabIndex = 40;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(57, 463);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 39;
            lblDescription.Text = "Beskrivning";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(57, 691);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Ange ett pris som är minst 0 kr";
            txtPrice.Size = new Size(412, 31);
            txtPrice.TabIndex = 38;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(57, 663);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 25);
            lblPrice.TabIndex = 37;
            lblPrice.Text = "Pris";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(57, 248);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(78, 25);
            lblCategory.TabIndex = 36;
            lblCategory.Text = "Kategori";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(57, 384);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Vad vill du sälja?";
            txtTitle.Size = new Size(486, 31);
            txtTitle.TabIndex = 35;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(57, 356);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 25);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Rubrik";
            // 
            // lblFyndit
            // 
            lblFyndit.AutoSize = true;
            lblFyndit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFyndit.Location = new Point(45, 47);
            lblFyndit.Name = "lblFyndit";
            lblFyndit.Size = new Size(142, 54);
            lblFyndit.TabIndex = 33;
            lblFyndit.Text = "Fyndit";
            // 
            // lblCreateAdvert
            // 
            lblCreateAdvert.AutoSize = true;
            lblCreateAdvert.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAdvert.Location = new Point(45, 151);
            lblCreateAdvert.Name = "lblCreateAdvert";
            lblCreateAdvert.Size = new Size(199, 38);
            lblCreateAdvert.TabIndex = 46;
            lblCreateAdvert.Text = "Skapa annons";
            // 
            // txtCurrency
            // 
            txtCurrency.BackColor = SystemColors.Window;
            txtCurrency.Location = new Point(465, 691);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.ReadOnly = true;
            txtCurrency.Size = new Size(78, 31);
            txtCurrency.TabIndex = 47;
            txtCurrency.TabStop = false;
            txtCurrency.Text = "kr";
            txtCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // btnToStartClose
            // 
            btnToStartClose.Location = new Point(239, 859);
            btnToStartClose.Name = "btnToStartClose";
            btnToStartClose.Size = new Size(149, 34);
            btnToStartClose.TabIndex = 48;
            btnToStartClose.Text = "Till startsidan";
            btnToStartClose.UseVisualStyleBackColor = true;
            btnToStartClose.Click += btnToStartClose_Click;
            // 
            // FrmCreateAdvert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 924);
            Controls.Add(btnToStartClose);
            Controls.Add(txtCurrency);
            Controls.Add(lblCreateAdvert);
            Controls.Add(cmbCategory);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblFyndit);
            Name = "FrmCreateAdvert";
            Text = "Skapa annons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Button btnClose;
        private Button btnCreate;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtTitle;
        private Label lblTitle;
        private Label lblFyndit;
        private Label lblCreateAdvert;
        private TextBox txtCurrency;
        private Button btnToStartClose;
    }
}