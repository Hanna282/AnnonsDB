using Annons.Entities;
using Annons.Repository;

namespace Annons.Views
{
    public partial class FrmLoginRegister : Form
    {
        private SellerRepo _sellerRepo = new();

        public FrmLoginRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            try
            {
                bool existingEmail = _sellerRepo.EmailRegistered(txtEmail.Text);
                bool signInSuccessful = _sellerRepo.LoggedIn(txtEmail.Text, txtPassword.Text);

                if (signInSuccessful && existingEmail)
                {
                    Seller loggedInSeller = _sellerRepo.GetCurrentSeller(txtEmail.Text);


                    FrmStart frmStart = new();
                    frmStart.LoggedInSeller = loggedInSeller;  
                    this.Hide(); 
                    frmStart.ShowDialog();
                }
                else if (existingEmail && !signInSuccessful)
                    MessageBox.Show("E-postadressen eller lösenordet är felaktigt. Försök igen."); 
                else if (!existingEmail)
                    MessageBox.Show("E-postadressen finns inte registrerad. "); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                bool existingEmail = _sellerRepo.EmailRegistered(txtEmail.Text);
                if (!existingEmail)
                {
                    bool regSuccessful = _sellerRepo.Register(txtEmail.Text, txtPassword.Text);
                    if (regSuccessful)
                    {
                        Seller loggedInSeller = _sellerRepo.GetCurrentSeller(txtEmail.Text);

                        FrmStart frmStart = new();
                        frmStart.LoggedInSeller = loggedInSeller;
                        this.Hide();
                        frmStart.ShowDialog();
                    }
                    else
                        MessageBox.Show("Ogiltig e-postadress"); 
                }
                else if (existingEmail)
                    MessageBox.Show("E-postadressen finns redan registrerad."); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Felmeddelande: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmStart frmStart = new();
            this.Hide();
            frmStart.ShowDialog();
        }
    }
}
