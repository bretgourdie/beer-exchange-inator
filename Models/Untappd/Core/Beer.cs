namespace Models.Untappd.Core
{
    public class Beer
    {
        public int bid { get; set; }
        public string beer_name { get; set; }
        public string beer_label { get; set; }
        public double beer_abv { get; set; }
        public int beer_ibu { get; set; }
        public string beer_description { get; set; }
        public string created_at { get; set; }
        public string beer_style { get; set; }
        public int auth_rating { get; set; }
        public bool wish_list { get; set; }
        public int in_production { get; set; }
    }
}
