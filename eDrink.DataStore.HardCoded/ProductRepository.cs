using eDrink.Core.Models;
using eDrink.UseCases.PluginInterfaces.DataStore;

namespace eDrink.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {

        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product {Id=1,
Brand="Makers Mark Wood",
Name="Makers Mark Wood Finishing Series 2021 Limited Release FAE-02 Bourbon Whiskey",
Price=0.45,
ImageLink="https://uptownspirits.com/wp-content/uploads/2022/01/Makers-Mark-Wood-Finishing-Series-2021-Limited-Release-FAE-02-Bourbon-Whiskey-800x800.jpg",
Description="The Maker’s Mark® Wood Finishing Series returns with our anticipated Fall edition. Following up on spring’s FAE-01, this fourth limited release from the series is here after a full year of wood experimentation. The result is a rich, wonderfully oaky bourbon. FAE-02 honors our signature whisky with a focus on mouthfeel and big, round woody notes. There’s enough spice to give it body and balance but the luscious texture is what really stands out. Bottles of this rare bourbon will number in the precious few, so be on the lookout – or press your local shop about availability."},
new Product{Id=2,Brand="The Macallan",
Name="The Macallan A Night On Earth Scotch Whiskey 750ml",
Price=0.40,
ImageLink="https://uptownspirits.com/wp-content/uploads/2022/01/The-Macallan-A-Night-On-Earth-Scotch-Whiskey-750ml-800x800.jpg",
Description="A limited edition single malt that tells a story of New Year in Scotland, reflecting the joy of celebrating special occasions with loved ones."},
new Product{Id=3,Brand="Dom Perignon",
Name="Dom Perignon Vintage 1996 Brut Champagne 750ml",
Price=0.125,
ImageLink="https://uptownspirits.com/wp-content/uploads/2022/01/Dom-Perignon-Vintage-1996-Brut-Champagne-750ml-800x800.jpg",
Description="The year was full of contrasts and the summer changeable, with the wetter periods never quite making up for the earlier hydric deficit. Eventually, in the month before grape-picking (September 16), it was as much the spells of hot weather as the influence of north-easterly winds that led to the original maturity of the vintage."},
new Product{Id=4,Brand="Mandala",
Name="Mandala Dia De Muertos 2021 Limited Edition Extra Añejo 1L",
Price=0.40,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/Mandala-Dia-De-Muertos-2021-Limited-Edition-Extra-Anejo-1L-800x800.jpg",
Description="Mandala Dia De Muertos 2021 Limited Edition Extra Añejo 1L"},
new Product{Id=5,Brand="Kaiyo",
Name="Kaiyo Mizunara Oak The Rubi Japanese Whiskey 750ml",
Price=0.43,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/Kaiyo-Mizunara-Oak-The-Rubi-Japanese-Whiskey-750ml-800x800.jpg",
Description="Kaiyo Mizunara Oak The Rubi Japanese Whiskey 750ml"},
new Product{Id=6,Brand="Barrell Bourbon",
Name="Barrell Bourbon Gold Label 16 Years Whiskey 750ml",
Price=0.625,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/Barrell-Bourbon-Gold-Label-16-Years-Whiskey-750ml-800x800.jpg",
Description="Barrell Craft Spirits Gold Label Bourbon is a blend of 16- and 17-year-old straight bourbons. Barrels for this release were selected from four different collections: cherry bomb barrels with a rich mouthfeel, nutty oak-forward barrels, high proof and high complexity barrels, and barrels with pronounced milk chocolate notes. The last group underwent a secondary maturation in toasted virgin American oak casks before being added to this intricate and seductive blend."},
new Product{Id=7,Brand="Glengoyne",
Name="Glengoyne 30 Year Old Highland Single Malt Scotch Whisky 750ml",
Price=0.43,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/Glengoyne-30-Year-Old-Highland-Single-Malt-Scotch-Whisky-750ml-800x800.jpg",
Description="Matured in hand-selected sherry oak casks of exceptional character, this annual Glengoyne release of only 5200 bottles is the taste of 30 years, held in a single dram. Our finest sherry casks are left almost entirely to their own devices for 30 years. Almost, but not quite. Twice, perhaps three times in three decades, our malt master will taste this ongoing alchemy of cask and spirit. His aim: to hand-select only the best sherry oak casks. Each decade has added deep colour, intense flavour and limitless complexity to the precious contents. Only the best can become Glengoyne 30 Year Old."},
new Product{Id=8,Brand="Cascade Moon",
Name="Cascade Moon Mellow As Moonlight 13 Years Rye Whiskey 750ml",
Price=0.45,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/Cascade-Moon-Mellow-As-Moonlight-13-Years-Rye-Whiskey-750ml-800x800.jpg",
Description="Hand-selected by Nicole Austin, this Cascade Moon release complements the series by offering a complex and mature rye addition to the lineup. The barrels containing aging rye arrived from Indiana to Cascade Hollow in 2012, where they spent another nine years in Cascade Hollow’s single story rickhouses. The temperature conditions led to a gracefully slow maturation, bringing the beautiful and unique notes of the whisky forward. At 13-years old, this rye is both delightfully balanced and sophisticated. The whisky is a mellow and enjoyable rye at an ideal 100-proof."},
new Product{Id=9,Brand="Empress",
Name="Empress 1908 Gin 750ml",
Price=0.425,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Empress-1908-Gin-750ml-800x800.jpg",
Description="Micro-distilled in small batch copper-pot stills, Empress 1908 is hand-crafted using eight signature botanicals: tea, juniper, rose, coriander seed, grapefruit peel, ginger root, cinnamon bark, and butterfly pea blossom"},
new Product{Id=10,Brand="Diplomatico Ambassador",
Name="Diplomatico Ambassador Rum 750ml",
Price=0.47,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Diplomatico-Ambassador-Rum-750ml-1-800x800.jpg",
Description="Diplomático Ambassador rum is an exquisite rum crafted from the distillery’s best rum reserves. After a minimum of twelve years of aging in white oak casks, until optimal maturity is achieved, the rums are aged for two additional years in Pedro Ximénez sherry casks, contributing to Ambassador’s complex sensory profile."},
new Product{Id=11,Brand="Sluricane",
Name="Sluricane Blue Lagoon 12/750ml",
Price=0.07,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Sluricane-Blue-Lagoon-E-40-Cocktail-1-800x800.jpg",
Description="40 proof Blue Lagoon is a popular cocktail made with blue curacao flavor, vodka, and other delightful properties and components"},
new Product{Id=12,Brand="Sluricane",
Name="Sluricane Hurricane 12/750ml",
Price=0.18,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Sluricane-Hurricane-E-40-Cocktail-1-800x800.jpg",
Description="E-40 put his own formula of the popular New Orleans cocktail drink Hurricane together and made E-40 Sluricane Hurricane, A fruity and exotic taste that will enlighten your day"},
new Product{Id=13,Brand="Sluricane",
Name="Sluricane Yellowbird 12/750ml",
Price=0.13,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Sluricane-Yellowbird-12-750ml-E-40-Cocktail-1-800x800.jpg",
Description="Yellow bird is a popular Caribbean cocktail made with galliano flavor, rum, & other delightful properties & components. Put it in the fridge or pour it over ice and enjoy!"},
new Product{Id=14,Brand="Mount Gay 1703",
Name="Mount Gay 1703 Master Select Rum 750ml",
Price=0.40,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Mount-Gay-1703-Master-Select-Rum-750ml-1-800x800.jpg",
Description="The essence of time, the art of perfection and the finest in Bajan rum. Limited annual release. A consistent style, with varied tasting notes for every new edition."},
new Product{Id=15,Brand="Samaroli",
Name="Samaroli En Equilibre 2018 Rum 750ml",
Price=0.45,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/11/Samaroli-En-Equilibre-2018-Rum-750ml-800x800.jpg",
Description="on’t call me agricultural. Let us openly declare: we’re irreverent, we like to be a bit controversial… like the Woody Allen of rums. We blend a non-agricultural rum from Guadeloupe with an agricultural Barbados spirit, creating a semi-agricultural rarity. A Greek god with an agricultural head and a non-agricultural body, if you like, bedecked in fine attire with scythe in hand. A peasant at the ball…. Our greatest, fondest fans will understand us. As for new ones?… they’ll learn how to. After careful tasting, we isolated four dimensions around which this blend takes shape: Power, Elegance, Character and Softness. Spicy and marine tones linger at length but leave room for the elegant blackberries and sour cherries of an uncontaminated forest floor. On the palate, mineral elements laced with a balsamic hint. Overall, it’s exquisitely soft and pleasant. “If you’re not failing every now and again, it’s a sign you’re not doing anything very innovative.” Woody Allen"},
new Product{Id=16,Brand="Ron del Barrilito",
Name="Ron del Barrilito Five Stars Reserva Especial Rum 750ml",
Price=0.43,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Ron-del-Barrilito-Five-Stars-Reserva-Especial-Rum-750ml-1-800x800.jpg",
Description="An extremely-limited, one of a kind blend of aged rums in “Oloroso” white oak casks for up to 35 years, handmade with the same craftsmanship and tradition that has prevailed in this Puerto Rican brand since 1880."},
new Product{Id=17,Brand="John Walker",
Name="John Walker King George V Limited Edition Scotch Whiskey 750ml",
Price=0.43,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/12/John-Walker-King-George-V-Limited-Edition-Scotch-Whiskey-750ml-800x800.jpg",
Description="John Walker King George V Limited Edition Scotch Whiskey 750ml"},
new Product{Id=18,Brand="Highland Park 25",
Name="Highland Park 25 Year 2019 Release Scotch Whiskey 750ml",
Price=0.457,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Highland-Park-25-Year-2019-Release-Scotch-Whiskey-750ml-1-800x800.jpg",
Description="Created from fewer than 20 hand-selected sherry seasoned European oak casks, ex-bourbon casks and refill casks, Master Whisky Maker, Gordon Motion very selectively drew from the small treasure of casks suited to produce this rare harmony."},
new Product{Id=19,Brand="99",
Name="99 Peach VSOP Brandy 12/50ml",
Price=0.495,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/99-Peach-VSOP-1.jpg",
Description="That’s Very Special Old Pale. If you’re not in the know, it’s the designation for superior brandy."},
new Product{Id=20,Brand="Paul Masson",
Name="Paul Masson VS Brandy 750ml",
Price=0.4,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Paul-Masson-VS-Brandy-750ml-1.jpg",
Description="A Smooth Sophisticated Brandy Crafted In The European Tradition. Aged In Oak Barrels. Paul Masson VS Is An Award Winning Favorite With A Rich Amber Glow, And Slightly Sweet Taste Profile Featuring Notes Of Caramel And Vanilla."},
new Product{Id=21,Brand="Bertoux",
Name="Bertoux Brandy 750ml",
Price=0.42,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Bertoux-Brandy-750ml-1.jpg",
Description="BERTOUX Brandy is an elegant blend of pot‑distilled California Brandies, aged from three to seven years in French and American oak. The brandy showcases vibrancy, elegance, and dimensionality, with signature layers of flavor, enduring length and finish that elevates and brings new energy to the storied Sidecar"},
new Product{Id=22,Brand="Cava De Oro",
Name="Cava De Oro Anejo Tequila 750ml",
Price=0.38,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/cavadeoroanejotequila750ml.jpg",
Description="Cava de Oro Tequila Añejo has a rich amber / golden tone, a body of medium velvety weight and a generous mezcal of aromas of honey, nutmeg, black pepper, caramel and toasted oak. The aromatic compounds are very well recreated on the palate, along with the flavors of vanilla, red plums and cinnamon that emerge during the prolonged finish."},

new Product{Id=23,Brand="Don Julio",
Name="Don Julio 70 Anejo Cristalino Tequila 750ml",
Price=0.4,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/Don-Julio-70-Anejo-Claro-Tequila-1.jpg",
Description="Don Julio 70® Añejo Claro Tequila is the culmination of 70 years of knowledge, expertise and innovation that brings the smoothness of a Blanco tequila and the complexity of an Añejo tequila together for a totally unique tequila experience. Don Julio 70® Añejo Claro Tequila is aged eighteen months in American white-oak barrels and then carefully filtered to bring out its crisp agave flavor." },

new Product{Id=24,Brand="E Cuarenta",
Name="E Cuarenta Blanco Tequila | E-40 Tequila",
Price=0.4,
ImageLink="https://uptownspirits.com/wp-content/uploads/2021/10/E-Cuarenta-Blanco-Tequila-E-40-Tequila-Bottle-1.jpg",
Description="E. Cuarenta Reposado is aged for 2 months in used, American oak barrels.The reposado is light amber in color and delivers hints of vanilla and caramel in concert with cooked 100 % blue agave flavors"},

new Product
{
    Id = 25,
    Brand = "Van Gogh",
    Name = "Van Gogh Espresso Vodka 750ml",
    Price = 0.37,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Van-Gogh-Espresso-Vodka-750ml-1-400x400.jpg",
    Description = "”Our Van Gogh Espresso vodka is created with nothing but the best Colombian beans, giving this premium vodka a bittersweet coffee taste. With just a hint of citrus and a silky cocoa finish, Van Gogh Espresso is the perfect blank canvas for any coffee-inspired creation.”"
},
new Product
{
    Id = 26,
    Brand = "Hiram Walker",
    Name = "Hiram Walker Peppermint Schnapps Liqueur 750ml",
    Price = 0.3,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Hiram-Walker-Peppermint-Schnapps-Liqueur-750ml-1-800x800.jpg",
    Description = "An oil-of-mint distillation process gives Hiram Walker® Peppermint Schnapps its sweet and refreshing minty taste. It is Crystal clear and available 60 and 90 proof versions."
},
new Product
{
    Id = 27,
    Brand = "Mr Black",
    Name = "Mr Black Cold Brew Coffee Liqueur 750ml",
    Price = 0.23,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Mr-Black-Cold-Brew-Coffee-Liqueur-750ml-1-400x400.jpg",
    Description = "THE WORLD’S BEST COFFEE LIQUEUR"
},
new Product
{
    Id = 28,
    Brand = "Campari",
    Name = "Campari Liqueur 750ml",
    Price = 0.26,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Campari-Liqueur-1-400x400.jpg",
    Description = "Campari Liqueur is an alcoholic spirit obtained from the infusion of bitter herbs, aromatic plants and fruit in alcohol and water. Many have tried to guess the number of ingredients: some say there are 20 or 60, but others list the ingredients at 80. To this day, alcohol and water are the only known ingredients of its special and secret recipe. Its vibrant red colour, intense aroma and distinctive bitter taste make it extremely versatile, and the perfect base for some of the most famous cocktails around the world."
},
new Product
{
    Id = 29,
    Brand = "Disaronno",
    Name = "Disaronno Velvet Liqueur 750ml",
    Price = 0.18,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Disaronno-Velvet-Liqueur-750ml-1-400x400.jpg",
    Description = "An iconic shape and an elegant total white look for a creamy, velvety liqueur with a unique taste: here comes Disaronno Velvet, the big news for summer 2022!"
},
new Product
{
    Id = 30,
    Brand = "Bumbu",
    Name = "Bumbu Creme Liqueur 750ml",
    Price = 0.16,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Bumbu-Creme-Liqueur-750ml-1-400x400.jpg",
    Description = "Bumbu Crème is a perfect blend of Bumbu Rum, select spices, and rich, decadent, real dairy cream. It’s an irresistible creation that is perfect chill straight, on the rocks, or in a cocktail. Bumbu Crème shares the same heritage that has made Bumbu the world’s favorite craft rum maker."
},
new Product
{
    Id = 31,
    Brand = "Boosie Juice",
    Name = "Boosie Juice Watermelon Vodka | Lil’ Boosie Vodka",
    Price = 0.44,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Boosie-Juice-Watermelon-Vodka-Lil-Boosie-Vodka-1-400x400.jpg",
    Description = "Boosie Juice Watermelon Vodka is 6x distilled and includes only all natural flavors for enhanced smoothness and fresh taste. Enjoy Boosie Juice Watermelon on ice, mixed with cranberry juice or sip it straight."
},
new Product
{
    Id = 32,
    Brand = "Wild Roots",
    Name = "Wild Roots Peach Infused Vodka",
    Price = 0.38,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Wild-Roots-Peach-Infused-Vodka-1-400x400.jpg",
    Description = "Infused with over a pound of real fruit, this infusion exudes the aroma and taste of a fresh, juicy, ripe peach. No artificial sweeteners, flavors or colors."
},
new Product
{
    Id = 33,
    Brand = "Smirnoff",
    Name = "Smirnoff Spicy Tamarind Vodka 750ml",
    Price = 0.39,
    ImageLink = "https://uptownspirits.com/wp-content/uploads/2021/10/Smirnoff-Spicy-Tamarind-Vodka-750ml-1-400x400.jpg",
    Description = "Naturally sweet and spicy taste experiences that will awaken your taste buds for adventurous bold nights with your friends."
}
 };

        }


        Product IProductRepository.GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        IEnumerable<Product> IProductRepository.GetProducts(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }


    }
}
