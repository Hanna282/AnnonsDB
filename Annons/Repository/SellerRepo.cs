using Annons.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Annons.Repository
{
    public class SellerRepo
    {
        private DataContext _context = new();

        public bool LoggedIn(string email, string password)
        {
            bool signIn = false;

            if (email.Contains('@')) 
            {
                List<SqlParameter> parameters = new();
                parameters.Add(new SqlParameter("@Email", email));
                parameters.Add(new SqlParameter("@Password", password));

                DataTable result = _context.ExecuteSPReturnTable("CheckSellerLogin", parameters);

                if (result.Rows.Count > 0)
                    signIn = true; 
            }
            return signIn;
        }

        public bool Register(string email, string password)
        {
            bool registered = false;

            if (email.Contains('@'))
            {
                List<SqlParameter> parameters = new();
                parameters.Add(new SqlParameter("@Email", email));
                parameters.Add(new SqlParameter("@Password", password));

                _context.ExecuteSPNonQuery("RegisterSeller", parameters);
                registered = true;
            }
            return registered;
        }

        public bool EmailRegistered(string email)
        {
            bool emailRegistered = false;

            if (email.Contains('@'))
            {
                List<SqlParameter> parameters = new();
                parameters.Add(new SqlParameter("@Email", email));

                DataTable result = _context.ExecuteSPReturnTable("CheckEmailExists", parameters);

                if (result.Rows.Count > 0)
                    emailRegistered = true;
            }
            return emailRegistered;
        }

        public Seller GetCurrentSeller(string email)
        {
            Seller seller = null;

            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@Email", email));

            DataTable result = _context.ExecuteSPReturnTable("GetSellerByEmail", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                seller = new Seller((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString());
            }
            return seller;
        }
    }
}
