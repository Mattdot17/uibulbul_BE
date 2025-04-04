using uibulbul.Data;
using uibulbul.Models;

namespace uibulbul.Services
{
    public class CurrencyServices
    {
        private readonly ApplicationDbContext _context;


        public CurrencyServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Currency> GetAllCurrencies()
        {
            return _context.Currencies.ToList();
        }

        public void AddNewCurrency(Currency currency)
        {
            Currency newCurrency = new()
            {
                Id = currency.Id,
                Name = currency.Name,
                Value = currency.Value,
                CurrencyCode = currency.CurrencyCode
            };
            _context.Currencies.Add(newCurrency);
            _context.SaveChanges();
        }

        public void AddSampleCurrencies()
        {
            _context.Currencies.AddRange(

                new Currency { CurrencyCode = "USD", Name = "American Dollar", Value = 1.2f },
                new Currency { CurrencyCode = "EUR", Name = "Euro", Value = 0.92f },
                new Currency { CurrencyCode = "GBP", Name = "British Pound", Value = 0.80f },
                new Currency { CurrencyCode = "JPY", Name = "Japanese Yen", Value = 151.00f },
                new Currency { CurrencyCode = "CAD", Name = "Canadian Dollar", Value = 1.36f },
                new Currency { CurrencyCode = "AUD", Name = "Australian Dollar", Value = 1.53f },
                new Currency { CurrencyCode = "CHF", Name = "Swiss Franc", Value = 0.90f },
                new Currency { CurrencyCode = "CNY", Name = "Chinese Yuan", Value = 7.25f },
                new Currency { CurrencyCode = "SEK", Name = "Swedish Krona", Value = 10.70f },
                new Currency { CurrencyCode = "NZD", Name = "New Zealand Dollar", Value = 1.65f }

            );
            _context.SaveChanges();

            
        }
    }
}
