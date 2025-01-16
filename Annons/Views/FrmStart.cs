using Annons.Entities;
using Annons.Repository;

namespace Annons.Views
{
    public partial class FrmStart : Form
    {
        private List<Advert> _adverts = new();
        private Seller? _loggedInSeller; 
        private bool _isLoggedIn = false;

        public FrmStart()
        {
            InitializeComponent();

            cmbSorting.Items.Add("Dyrast");
            cmbSorting.Items.Add("Billigast");
            cmbSorting.Items.Add("Senaste");
            cmbSorting.Items.Add("Äldst");
            UpdateButtonsVisability();
        }

        public Seller LoggedInSeller
        {
            get { return _loggedInSeller; }
            set
            {
                _loggedInSeller = value;
                _isLoggedIn = (_loggedInSeller != null);  
                UpdateButtonsVisability();  
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtDate.Clear();
            txtDescription.Clear();
            cmbSorting.SelectedIndex = -1;

            try
            {
                AdvertRepo advertRepo = new();
                _adverts = advertRepo.Search(txtSearch.Text, cmbSearchFilter.Text);
                lstSearchResult.DataSource = null;

                if (_adverts.Count > 0)
                {
                    lstSearchResult.DataSource = _adverts;
                    btnOpenAdvert.Enabled = true;
                }
                else
                {
                    List<Advert> noResults = new();
                    var noCategory = new Category(0, "");
                    var noSeller = new Seller(0, "", "");
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        noResults.Add(new Advert(0, $"Inga annonser för \"{txtSearch.Text}\" hittades",
                            "", 0, DateTime.Now, noCategory, noSeller));
                    }
                    else
                    {
                        noResults.Add(new Advert(0, "Inga annonser hittades", "", 0, DateTime.Now,
                            noCategory, noSeller));
                    }
                    lstSearchResult.DataSource = noResults;
                    lstSearchResult.DisplayMember = "Title";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnOpenAdvert_Click(object sender, EventArgs e)
        {
            try
            {
                Advert selected = lstSearchResult.SelectedItem as Advert;

                txtCategory.Text = selected.Category.CategoryName;
                txtTitle.Text = selected.Title;
                txtPrice.Text = selected.Price.ToString();
                txtDate.Text = selected.Date.ToString("yyyy-MM-dd");
                txtDescription.Text = selected.Description;

                txtSearch.Clear();
                cmbSearchFilter.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void cmbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSorting.SelectedIndex != -1)
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

        private void cmbSearchFilter_DropDown(object sender, EventArgs e)
        {
            try
            {
                CategoryRepo categoryRepo = new();
                List<Category> categories = categoryRepo.GetCategories();
                cmbSearchFilter.DisplayMember = "CategoryName";
                cmbSearchFilter.ValueMember = "CategoryId";
                cmbSearchFilter.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            OpenLoginRegisterForm();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            OpenLoginRegisterForm();
        }

        private void btnNewAdvert_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCreateAdvert frmCreateAdvert = new(LoggedInSeller);
                this.Hide();
                frmCreateAdvert.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnMyAdverts_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSellerAdverts frmSellerAdverts = new(LoggedInSeller);
                this.Hide();
                frmSellerAdverts.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _isLoggedIn = false;
            LoggedInSeller = null;
            UpdateButtonsVisability();
        }

        private void OpenLoginRegisterForm()
        {
            this.Hide();
            FrmLoginRegister frmLoginRegister = new();
            frmLoginRegister.ShowDialog();
            UpdateButtonsVisability();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            cmbSearchFilter.SelectedIndex = -1;
        }

        private void UpdateButtonsVisability()
        {
            btnOpenAdvert.Enabled = false;

            if (_isLoggedIn)
            {
                btnRegister.Visible = false;
                btnSignIn.Visible = false;
                btnNewAdvert.Visible = true;
                btnSignOut.Visible = true;
                btnMyAdverts.Text = LoggedInSeller.Email.Split('@')[0];
                btnMyAdverts.Visible = true;
            }
            else
            {
                btnRegister.Visible = true;
                btnSignIn.Visible = true;
                btnNewAdvert.Visible = false;
                btnSignOut.Visible = false;
                btnMyAdverts.Visible = false;
            }
        }

        private void ClearAllFields()
        {
            txtSearch.Clear();
            cmbSorting.SelectedIndex = -1;
            cmbSearchFilter.SelectedIndex = -1;
            lstSearchResult.DataSource = null;
            txtCategory.Clear();
            txtTitle.Clear();
            txtPrice.Clear();
            txtDate.Clear();
            txtDescription.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
