using Annons.Entities;
using Annons.Repository;

namespace Annons.Views
{
    public partial class FrmSellerAdverts : Form
    {
        private Seller _loggedInSeller;
        private Advert _selectedAdvert = new();
        private List<Advert> _adverts = new();
        private AdvertRepo _advertRepo = new();
        private DateTime _orgDate;

        public FrmSellerAdverts(Seller currentSeller)
        {
            InitializeComponent();

            this._loggedInSeller = currentSeller;
            lblSeller.Text = _loggedInSeller.Email.Split('@')[0];

            EnableSaveDeleteButtons(false);
            EnableTextBoxeState(false);
            UpdateForm();

            cmbSorting.Items.Add("Dyrast");
            cmbSorting.Items.Add("Billigast");
            cmbSorting.Items.Add("Senaste");
            cmbSorting.Items.Add("Äldst");
        }

        private void btnManageAdvert_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCategories();
                EnableTextBoxeState(true);
                EnableSaveDeleteButtons(true);

                _selectedAdvert = lstSearchResult.SelectedItem as Advert;
                cmbCategory.SelectedValue = _selectedAdvert.Category.CategoryId;
                txtTitle.Text = _selectedAdvert.Title;
                txtPrice.Text = _selectedAdvert.Price.ToString();
                lblDate.Text = _selectedAdvert.Date.ToString("yyyy-MM-dd");
                txtDescription.Text = _selectedAdvert.Description;
                _orgDate = _selectedAdvert.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtDescription.Text)
                    && !string.IsNullOrWhiteSpace(txtPrice.Text) && decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    var selectedCategory = cmbCategory.SelectedItem as Category;

                    Advert advert = new(_selectedAdvert.AdvertId, txtTitle.Text, txtDescription.Text, price,
                                        _orgDate, selectedCategory, _loggedInSeller);

                    _advertRepo.Update(advert);

                    MessageBox.Show("Annonsen är uppdaterad");
                    UpdateForm();
                    EnableSaveDeleteButtons(false);
                    EnableTextBoxeState(false);
                }
                else
                    MessageBox.Show("Alla fält måste vara ifyllda!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Är du säker på att du vill ta bort annonsen?",
                                                "Bekräfta borttagning", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _advertRepo.Delete(_selectedAdvert);
                    MessageBox.Show("Annonsen är borttagen");

                    UpdateForm();
                    EnableSaveDeleteButtons(false);
                    EnableTextBoxeState(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnNewAdvert_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmCreateAdvert frmCreateAdvert = new(_loggedInSeller);
                frmCreateAdvert.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSorting.SelectedIndex != -1)
            {
                if (cmbSorting.SelectedItem.ToString() == "Dyrast")
                    _adverts = _adverts.OrderByDescending(a => a.Price).ToList();
                else if (cmbSorting.SelectedItem.ToString() == "Billigast")
                    _adverts = _adverts.OrderBy(a => a.Price).ToList();
                else if (cmbSorting.SelectedItem.ToString() == "Senaste")
                    _adverts = _adverts.OrderByDescending(a => a.Date).ToList();
                else if (cmbSorting.SelectedItem.ToString() == "Äldst")
                    _adverts = _adverts.OrderBy(a => a.Date).ToList();

                lstSearchResult.DataSource = _adverts;
            }
        }

        private void EnableSaveDeleteButtons(bool advSelected)
        {
            if (advSelected)
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void EnableTextBoxeState(bool advSelected)
        {
            if (advSelected)
            {
                cmbCategory.Enabled = true;
                txtTitle.Enabled = true;
                txtDescription.Enabled = true;
                txtPrice.Enabled = true;
            }
            else
            {
                cmbCategory.Enabled = false;
                txtTitle.Enabled = false;
                txtDescription.Enabled = false;
                txtPrice.Enabled = false;
                txtCurrency.Enabled = false;
            }
        }

        private void LoadCategories()
        {
            try
            {
                CategoryRepo categoryRepo = new();
                List<Category> categories = categoryRepo.GetCategories();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void UpdateForm()
        {
            try
            {
                cmbSorting.SelectedIndex = -1;
                cmbCategory.SelectedIndex = -1;
                txtTitle.Clear();
                txtDescription.Clear();
                txtPrice.Clear();
                lblDate.Text = "";
                _adverts = _advertRepo.GetSellerAdverts(_loggedInSeller.SellerId);
                lstSearchResult.DataSource = _adverts;

                if (lstSearchResult.Items.Count == 0)
                    btnManageAdvert.Enabled = false;
                else
                    btnManageAdvert.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmStart frmStart = new();
                frmStart.LoggedInSeller = _loggedInSeller;
                frmStart.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }
    }
}
