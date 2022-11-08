using System.Collections.Generic;
using Wingspan.Model;

namespace Wingspan.DB;

public interface IBirdsDB
{
    public List<Bird> GetBirds();
}
