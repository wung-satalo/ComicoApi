using ComicoApi.Models;

namespace ComicoApi.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        if (db.Comics.Any() || db.Banners.Any()) return;

        // --- Banners ---
        var banners = new List<Banner>
        {
            new() { ImageUrl = "https://farm5.staticflickr.com/4905/46683324341_660f16ed0f_o.png" },
            new() { ImageUrl = "https://farm5.staticflickr.com/4854/32808153198_29f403338a_o.png" },
            new() { ImageUrl = "https://farm8.staticflickr.com/7854/39718376383_2ef44143ff_o.png" },
        };
        db.Banners.AddRange(banners);
        db.SaveChanges();
        // --- Comics ---
        var comics = new List<Comic>
        {
            new()
            {
                Name = "Doraemon", Category = "Comedy,Adventure",
                Image = "https://img.fictionlog.co/ebooks/users/5f718019f4f690001b732fdd/cover-images/eDt2vWJxv7v8UzSr3ioU9A21.jpeg",
                Chapters = new()
                {
                    new()
                    {
                        Name = "Vol.1 Chapter 1 : All The Way From A Future World",
                        Links = new()
                        {
                            "http://1.bp.blogspot.com/-85z8C-NxWu8/Vp2-JUlA3SI/AAAAAAAAAAU/1IaqwQaHme0/s1600/Doraemon%252Bv01%252Bc01%252B%252B01.jpg",
                            "http://4.bp.blogspot.com/-FTBemg84MOc/Vp2-JO6Cm3I/AAAAAAAAAAM/370fuoFgGYM/s1600/Doraemon%252Bv01%252Bc01%252B%252B02.jpg",
                            "http://1.bp.blogspot.com/-3-CZvfWT2uM/Vp2-JqYQAcI/AAAAAAAAAAY/JequG8dRuFU/s1600/Doraemon%252Bv01%252Bc01%252B%252B04.jpg",
                            "http://4.bp.blogspot.com/-vsvYJKCZL6M/Vp2-J3GXnKI/AAAAAAAAAAg/pV3vM4NdDLw/s1600/Doraemon%252Bv01%252Bc01%252B%252B05.jpg",
                            "http://3.bp.blogspot.com/-OrHRh1yj8TM/Vp2-Kb1cWBI/AAAAAAAAAAo/HCQbazwzdBc/s1600/Doraemon%252Bv01%252Bc01%252B%252B06.jpg",
                            "http://4.bp.blogspot.com/-UxfVBXwmujE/Vp2-KRfOxjI/AAAAAAAAAAs/l-TnIxhsm3s/s1600/Doraemon%252Bv01%252Bc01%252B%252B07.jpg",
                            "http://3.bp.blogspot.com/-JvSXNt5X_M0/Vp2-Kys8WWI/AAAAAAAAAA0/NW4l1uojSME/s1600/Doraemon%252Bv01%252Bc01%252B%252B08.jpg",
                            "http://3.bp.blogspot.com/-WV_UKVt7Pmo/Vp2-LHDad6I/AAAAAAAAAA8/FkzBLRGRVjs/s1600/Doraemon%252Bv01%252Bc01%252B%252B09.jpg",
                            "http://4.bp.blogspot.com/-QJkwwyh5a6Q/Vp2-LZg2vzI/AAAAAAAAABA/J1-tgl4auwI/s1600/Doraemon%252Bv01%252Bc01%252B%252B10.jpg",
                            "http://2.bp.blogspot.com/-STSSUTXr50s/Vp2-L8VhjkI/AAAAAAAAABM/7ZuaXxN4nPA/s1600/Doraemon%252Bv01%252Bc01%252B%252B11.jpg",
                            "http://1.bp.blogspot.com/-aha_GdDwmBA/Vp2-L374lKI/AAAAAAAAABU/hS52ISnOvX8/s1600/Doraemon%252Bv01%252Bc01%252B%252B12.jpg",
                            "http://3.bp.blogspot.com/-LK5EqICaYHk/Vp2-MRHedzI/AAAAAAAAABY/9a91AW_A8a4/s1600/Doraemon%252Bv01%252Bc01%252B%252B13.jpg",
                            "http://3.bp.blogspot.com/-ffrOqfeBBZw/Vp2-MjUqEGI/AAAAAAAAABk/-5viR0lBz6o/s1600/Doraemon%252Bv01%252Bc01%252B%252B14.jpg",
                            "http://1.bp.blogspot.com/-0pZX7iPjcgE/Vp2-M7_WZwI/AAAAAAAAABo/YkUqLSbda3Q/s1600/Doraemon%252Bv01%252Bc01%252B%252B15.jpg",
                            "http://4.bp.blogspot.com/-deZB1sJFnJ4/Vp2-NHl36bI/AAAAAAAAABw/ZzkfueKmVLE/s1600/Doraemon%252Bv01%252Bc01%252B%252B16.jpg",
                            "http://4.bp.blogspot.com/-De0227xOCsQ/Vp2-NjVL4fI/AAAAAAAAAB4/3kl3nK4CIV8/s1600/Doraemon%252Bv01%252Bc01%252B%252B17.jpg",
                            "http://4.bp.blogspot.com/-6-CBipKXy60/Vp2-Nsj3t0I/AAAAAAAAAB8/uL_LUZvaDgc/s1600/Doraemon%252Bv01%252Bc01%252B%252B18.jpg",
                        }
                    },
                    new()
                    {
                        Name = "Vol.1 chapter 1.1",
                        Links = new()
                        {
                            "http://4.bp.blogspot.com/-06SK8POTw_A/Vp3JaIJ0SaI/AAAAAAAAACs/1ZH49AyiJY8/s1600/Doraemon%252Bv01%252Bc02%252B01.jpg",
                        }
                    },
                    new() { Name = "Vol.1 chapter 2 : Prophecy Of Doraemon" },
                    new() { Name = "Vol.1 chapter 3 : Transforming Biscuit" },
                    new() { Name = "Vol.1 chapter 4 : Operation: Secret Spy" },
                    new() { Name = "Vol.1 chapter 5 : Kobe Abe" },
                    new() { Name = "Vol.1 chapter 6 : Antique Competition" },
                    new() { Name = "Vol.1 chapter 7 : Peko Peko Grasshopper" },
                    new() { Name = "Vol.1 chapter 8 : Chin Up To The Ancestors" },
                    new() { Name = "Vol.1 chapter 9 : Hunting Shades" },
                    new() { Name = "Vol.1 chapter 10 : Flattering Lipsticks" },
                    new() { Name = "Vol.1 chapter 11 : Full Points For Once In A Life Time" },
                    new() { Name = "Doraemon vol.1 chapter 12 : Operation: Propose" },
                    new() { Name = "Vol.1 chapter 13 : OO Will ^ ^ With XX" },
                    new() { Name = "Vol.1 chapter 14 : Hot Hot In The Snow" },
                    new() { Name = "Vol.1 chapter 15 : A Ghost Of The Lamp's Smoke" },
                    new() { Name = "Doraemon vol.1 chapter 16 : Run! Uma-Take" },
                }
            },
            new()
            {
                Name = "Dragon Ball", Category = "Action,Adventure",
                Image = "https://upload.wikimedia.org/wikipedia/en/c/c9/DB_Tank\u014dbon.png",
                Chapters = new()
                {
                    new() { Name = "Chapter 1 : Bloomers and the Monkey King" },
                    new() { Name = "Chapter 2 : No Balls!!" },
                    new() { Name = "Chapter 3 : Sea Monkeys" },
                    new() { Name = "Chapter 4 : They Call Him the Turtle Hermit!" },
                    new() { Name = "Chapter 5 : Oo! Oo! Oolong!" },
                    new() { Name = "Chapter 6 : So Longm OoLong!!" },
                    new() { Name = "Chapter 7 : Yamcha and Pu'ar" },
                    new() { Name = "Chapter 8 : One, Two, Yamcha-cha" },
                }
            },
            new() { Name = "The Amazing Spider-Man (1963)", Category = "Action,Adventure,Superhero", Image = "https://2.bp.blogspot.com/UyIClw5KWvyrIHioRjGeqaX3BdNRLF0jdlZTHesIxLZy6zX9zOwY26UrF6w5j_v5rGakyQxdPfoi=s1600" },
            new() { Name = "Spider-Man", Category = "Action,Adventure,Superhero", Image = "https://image.api.playstation.com/vulcan/img/rnd/202011/0714/vuF88yWPSnDfmFJVTyNJpVwW.png" },
            new() { Name = "The Invincible Iron Man", Category = "Action,Adventure,Superhero", Image = "https://cdn.marvel.com/u/prod/marvel/i/mg/a/10/58ffa5fd87314/portrait_uncanny.jpg" },
            new() { Name = "Ant-Man & The Wasp", Category = "Action,Adventure,Superhero", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT66eNmM7GIMfupWAzJGRqa_DPLvWYsqJF8Hg&s" },
            new() { Name = "Marvel Zombies", Category = "Action,Adventure,Superhero,Horror,Antihero", Image = "http://1.bp.blogspot.com/-vNUqD-HUcdQ/Vp5GXqrP7fI/AAAAAAAAIEE/OSIFYvS3D7k/s1600/0.jpg" },
            new() { Name = "Super Hero Adventures", Category = "Action,Adventure,Superhero", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKWBY9fuCKhnDI-wwoXwJ6zF1O6x9ELBaE7Y4YwAK1LahojieB" },
            new() { Name = "Cable", Category = "Action,Adventure,Superhero,Antihero", Image = "https://images-na.ssl-images-amazon.com/images/S/cmx-images-prod/Item/494347/494347._SX1280_QL80_TTD_.jpg" },
            new() { Name = "X-Force", Category = "Action,Adventure,Superhero", Image = "https://upload.wikimedia.org/wikipedia/en/7/76/Xforce_001.jpg" },
            new() { Name = "Avengers", Category = "Action,Adventure,Superhero", Image = "https://m.media-amazon.com/images/I/91SPP5V1TXL._AC_UF1000,1000_QL80_.jpg" },
            new() { Name = "Thor", Category = "Action,Adventure,Superhero", Image = "https://m.media-amazon.com/images/I/714QCPd0+pL._AC_UF1000,1000_QL80_.jpg" },
            new() { Name = "X-men Wolverine", Category = "Action,Adventure,Superhero", Image = "https://m.media-amazon.com/images/I/91X6TDy2PJL._UF894,1000_QL80_.jpg" },
            new() { Name = "DC Essential Graphic Novels 2016", Category = "Action,Adventure,Superhero", Image = "https://images-na.ssl-images-amazon.com/images/S/cmx-images-prod/Item/332255/332255._SX1280_QL80_TTD_.jpg" },
            new() { Name = "Aqua Man", Category = "Action,Adventure,Superhero", Image = "https://m.media-amazon.com/images/I/91FeE5U44FL._AC_UF1000,1000_QL80_.jpg" },
            new() { Name = "Variant Covers", Category = "Action,Adventure,Superhero", Image = "https://m.media-amazon.com/images/I/816hPkXyM3L._AC_UF1000,1000_QL80_.jpg" },
            new() { Name = "Batman", Category = "", Image = "http://4.bp.blogspot.com/-UVWO6oyjJqU/U_3jLJzL3MI/AAAAAAAEnhQ/_SyLqkLRvVo/s1600/-000.jpg" },
        };
        db.Comics.AddRange(comics);

        await db.SaveChangesAsync();
    }
}