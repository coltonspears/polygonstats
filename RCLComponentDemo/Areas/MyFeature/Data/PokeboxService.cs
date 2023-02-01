using Pokebox;
using Pokebox.Models;

namespace RCLComponentDemo.Areas.MyFeature.Data;

public interface IPokeboxService
{
    List<PokeboxEntry> GetPokeboxEntries();
}

public class PokeboxService : IPokeboxService
{
    private readonly PokeboxContext? _dbContext = null;

    public PokeboxService(PokeboxContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<PokeboxEntry> GetPokeboxEntries()
    {
        return  _dbContext.PokeboxEntries.ToList();
    }

}
