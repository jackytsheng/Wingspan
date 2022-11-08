using System.Collections.Generic;
using Wingspan.Model;

namespace Wingspan.DB;
public class LocalBirdsDb : IBirdsDB
{
    private readonly List<Bird> _birds;

    public LocalBirdsDb(List<Bird> birds)
    {
        _birds = birds;
    }

    public List<Bird> GetBirds()
    {
        return _birds;
    }
}
