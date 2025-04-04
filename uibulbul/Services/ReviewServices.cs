using uibulbul.Data;
using uibulbul.Models;

namespace uibulbul.Services
{
    public class ReviewServices
    {
        private readonly ApplicationDbContext _context;

        public ReviewServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Review> GetAllReviews()
        {
            return _context.Reviews.ToList();
        }

        public void AddNewReview(Review review)
        {
            Review newReview = new()
            {
                Id = review.Id,
                Rating = review.Rating,
                CarId = review.CarId,
                Text = review.Text,
                Author = review.Author,
                Date = review.Date
            };
            _context.Reviews.Add(newReview);
            _context.SaveChanges();
        }
        

        public void AddSampleReviews()
        {
            _context.Reviews.AddRange(
                new Review { Rating = 1.0f, CarId = 301, Text = "Ma chi diaulu de màchina est custa? Unu trumbullu chi no andat mancu a fùrriu! Est mellus a andare a peis chi cun custa cosa. Un disastru!", Author = "Bachisio 'Bàciu' Sanna (casteddaio)", Date = new DateOnly(2025, 03, 05) },
                new Review { Rating = 1.5f, CarId = 302, Text = "Mamma mia, ite fregadura! Paga' tantos dinari pro una cosa chi si istratàllat in duos dies? Andaisì a ধান! Mai prus!", Author = "Maria 'Mariedda' Piras (nuorese)", Date = new DateOnly(2025, 02, 15) },
                new Review { Rating = 2.0f, CarId = 303, Text = "Unu caddos de màchina! Su motore fae unu strepitu chi paret unu trattore, e is frenos no tenent gana de traballare. Chi est su tontu chi at fatu custa porcheria?", Author = "Gavino 'Gavineddu' Melis (sassarese)", Date = new DateOnly(2025, 01, 10) },
                new Review { Rating = 1.0f, CarId = 301, Text = "Ite birgogna! Una màchina chi dat prus problemas de su miu babbu candu est imbriagu. E is bentidores? Tottu mariolos! Mi sento unu minchione!", Author = "Francesca 'Frantzisca' Serra (oristanese)", Date = new DateOnly(2024, 12, 01) },
                new Review { Rating = 2.5f, CarId = 304, Text = "Mah, ite podo narrere? Unu schifìu! Plastica chi paret paperi, rifinituras fatas a casu e unu odore a intro chi ti benit a bòmire. Mai bida una cosa tale.", Author = "Salvatore 'Tore' Lai (ogliastrino)", Date = new DateOnly(2024, 10, 25) },
                new Review { Rating = 1.0f, CarId = 302, Text = "Andaisì a traballare, pigriosos! Apo ispendidu tantos dinari pro custa munnezza chi mi lassat a peis ogni tres pro duas. Sian maladittos!", Author = "Giulia 'Giulietta' Cossu (sulcitana)", Date = new DateOnly(2025, 03, 23) },
                new Review { Rating = 1.5f, CarId = 305, Text = "Una sola manna! Me l'aiant presentada comente oro coladu e imbetzes est prumbu. No la cussìgio a nemos, nemancu a su peus inimigu!", Author = "Michele 'Micheli' Carta (barbaricino)", Date = new DateOnly(2025, 03, 15) },
                new Review { Rating = 2.0f, CarId = 303, Text = "Ma ite mi so' comporadu? Un'incubu a battoro rodas! Ogni orta chi l'allùo timo chi iscoppiet. Che zente disonesta!", Author = "Angela 'Angheledda' Deiana (goceanina)", Date = new DateOnly(2025, 02, 05) },
                new Review { Rating = 1.0f, CarId = 304, Text = "Si podìa dare zero isteddos, lu faghìa immoi! Un furto legalizadu. Mi sento pigadu in giru dae custa zente. Ite cosa brutta!", Author = "Pietro 'Pedru' Pisu (campidanese)", Date = new DateOnly(2024, 12, 12) },
                new Review { Rating = 2.5f, CarId = 305, Text = "Naro solu una cosa: MAI PRUS! Un'esperienza dae dismentigare. Sa màchina est unu disastru e s'assistèntzia est ancora peus. Andade a un'àtera parte, crededemi!", Author = "Eleonora 'Nora' Meloni (planargese)", Date = new DateOnly(2024, 12, 08) }

                );
            _context.SaveChanges();
        }
    }
}
