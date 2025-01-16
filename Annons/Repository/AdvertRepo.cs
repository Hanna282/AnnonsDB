using Annons.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Annons.Repository
{
    public class AdvertRepo
    {
        private DataContext _context = new();

        public List<Advert> Search(string condition, string selectedCategory)
        {
            List<SqlParameter> parameters = new();
            List<Advert> adverts = new();

            if(!string.IsNullOrEmpty(selectedCategory))
                parameters.Add(new SqlParameter("@selectedCategory", selectedCategory));
            else
                parameters.Add(new SqlParameter("@selectedCategory", DBNull.Value));

            if (!string.IsNullOrEmpty(condition))
                parameters.Add(new SqlParameter("@Condition", condition));
            else
                parameters.Add(new SqlParameter("@Condition", DBNull.Value));

            DataTable data = _context.ExecuteSPReturnTable("SearchAdverts", parameters);

            foreach (DataRow row in data.Rows)
            {
                Category category = new((int)row.ItemArray[5], row.ItemArray[6].ToString());
                Seller seller = new((int)row.ItemArray[7], row.ItemArray[8].ToString(), row.ItemArray[9].ToString());
                Advert advert = new((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(),
                                    (decimal)row.ItemArray[3], (DateTime)row.ItemArray[4], category, seller);
                adverts.Add(advert);
            }
            return adverts;
        }

        public void Update(Advert selectedAdvert)
        {
            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@AdvertId", selectedAdvert.AdvertId));
            parameters.Add(new SqlParameter("@Title", selectedAdvert.Title));
            parameters.Add(new SqlParameter("@Description", selectedAdvert.Description));
            parameters.Add(new SqlParameter("@Price", selectedAdvert.Price));
            parameters.Add(new SqlParameter("@CategoryId", selectedAdvert.Category.CategoryId));
            parameters.Add(new SqlParameter("@SellerId", selectedAdvert.Seller.SellerId));

            _context.ExecuteSPNonQuery("UpdateAdvert", parameters);
        }

        public void Delete(Advert selectedAdvert)
        {
            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@Advertid", selectedAdvert.AdvertId));

            _context.ExecuteSPNonQuery("DeleteAdvert", parameters);
        }

        public void Create(Advert newAdvert, Seller signedInSeller, Category selectedCategory)
        {
            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@Title", newAdvert.Title));
            parameters.Add(new SqlParameter("@Description", newAdvert.Description));
            parameters.Add(new SqlParameter("@Price", newAdvert.Price));
            parameters.Add(new SqlParameter("@Date", newAdvert.Date));
            parameters.Add(new SqlParameter("@CategoryId", selectedCategory.CategoryId));
            parameters.Add(new SqlParameter("@SellerId", signedInSeller.SellerId));

            _context.ExecuteSPNonQuery("CreateAdvert", parameters);
        }

        public List<Advert> GetSellerAdverts(int sellerId)
        {
            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@SellerId", sellerId));

            List<Advert> adverts = new();

            DataTable data = _context.ExecuteSPReturnTable("GetAdvertsBySeller", parameters);

            foreach (DataRow row in data.Rows)
            {
                Category category = new((int)row.ItemArray[5], row.ItemArray[6].ToString());
                Seller seller = new((int)row.ItemArray[7], row.ItemArray[8].ToString(), row.ItemArray[9].ToString());
                Advert advert = new((int)row.ItemArray[0], row.ItemArray[1].ToString(), row.ItemArray[2].ToString(),
                                    (decimal)row.ItemArray[3], (DateTime)row.ItemArray[4], category, seller);
                adverts.Add(advert);
            }
            return adverts;
        }
    }
}
