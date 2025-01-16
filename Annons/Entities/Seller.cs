namespace Annons.Entities
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Seller(int sellerId, string email, string password)
        {
            SellerId = sellerId;
            Email = email;
            Password = password;
        }
    }
}
