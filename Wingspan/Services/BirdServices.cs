using System.Collections.Generic;
using Wingspan.DB;
using Wingspan.Model;

namespace Wingspan.Services;

public class BirdServices : IBirdServices
{
    private readonly IBirdsDB _db;

    public BirdServices(IBirdsDB localDb)
    {
        _db = localDb;
    }

    public List<Bird> GetAllBirds()
    {
        return _db.GetBirds();
    }
}
