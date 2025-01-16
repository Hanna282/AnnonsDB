using Annons.Entities;
using Annons.Repository;

namespace Annons.Views
{
    public partial class FrmCreateAdvert : Form
    {
        private Seller _loggedInSeller;

        public FrmCreateAdvert(Seller seller)
        {
            InitializeComponent();
            this._loggedInSeller = seller;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(txtTitle.Text) &&
                    !string.IsNullOrWhiteSpace(txtDescription.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text)
                    && decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    var selectedCategory = cmbCategory.SelectedItem as Category;

                    Advert newAdvert = new(0, txtTitle.Text, txtDescription.Text, price,
                                           DateTime.Now, selectedCategory, _loggedInSeller);

                    AdvertRepo advertRepo = new();
                    advertRepo.Create(newAdvert, _loggedInSeller, selectedCategory);

                    MessageBox.Show("Ny annons skapad");

                    this.Hide();
                    FrmSellerAdverts frmSellerAdverts = new(_loggedInSeller);
                    frmSellerAdverts.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Alla fält måste vara ifyllda!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void cmbCategory_DropDown(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSellerAdverts frmSellerAdverts = new(_loggedInSeller);
                this.Hide();
                frmSellerAdverts.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnToStartClose_Click(object sender, EventArgs e)
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
