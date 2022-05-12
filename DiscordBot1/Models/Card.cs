using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot1.Models
{
    public class Card
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public Card_Images[] card_images { get; set; }
        public Card_Prices[] card_prices { get; set; }
    }

    public class Card_Images
    {
        public string image_url { get; set; }
        public string image_url_small { get; set; }
    }

    public class Card_Prices
    {
        public string cardmarket_price { get; set; }
        public string tcgplayer_price { get; set; }
        public string ebay_price { get; set; }
        public string amazon_price { get; set; }
    }

}
