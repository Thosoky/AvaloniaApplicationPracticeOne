
using AvaloniaApplicationPracticeOne.Models;

namespace AvaloniaApplicationPracticeOne;

public class Service
{
    // переменная хранит экземпляр контекста
    private static Rcis31Context? _db;
    
    // метод, если экземпляр еще не создан, создает и возвращает его
    // если экземпляр создан, возвращает его
    public static Rcis31Context GetDbContext()
    {
        if (_db == null)
        {
            _db = new Rcis31Context();
        }
        return _db;
    }
}