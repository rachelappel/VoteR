using System.Collections.Generic;

namespace VoteR.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Votes { get; set; }
    }

    public class ItemsList : List<Item>
    {
        public ItemsList()
        {
            this.Add(new Item { Id = 1, Image = "microsoft.png", Name = "Microsoft", Votes = 0 });
            this.Add(new Item { Id = 2, Image = "apple.png", Name = "Apple", Votes = 0 });
            this.Add(new Item { Id = 3, Image = "google.png", Name = "Google", Votes = 0 });
            this.Add(new Item { Id = 4, Image = "twitter.jpg", Name = "Twitter", Votes = 0 });
            this.Add(new Item { Id = 5, Image = "ibm.png", Name = "IBM", Votes = 0 });
            this.Add(new Item { Id = 6, Image = "oracle.png", Name = "Oracle", Votes = 0 });
            this.Add(new Item { Id = 7, Image = "facebook.png", Name = "Facebook", Votes = 0 });
            this.Add(new Item { Id = 8, Image = "amazon.jpg", Name = "Amazon", Votes = 0 });

        }
    }
}