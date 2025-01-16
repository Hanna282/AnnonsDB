namespace Annons.Entities
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public Seller Seller { get; set; }

        public Advert()
        {
        }

        public Advert(int advertId, string title, string description, decimal price, 
                      DateTime date, Category category, Seller seller)
        {
            AdvertId = advertId;
            Title = title;
            Description = description;
            Price = price;
            Date = date;
            Category = category;
            Seller = seller;
        }

        public override string ToString()
        {
            return $"{Title},     {Price} kr,     {Date:yyyy-MM-dd}";
        }
    }
}
