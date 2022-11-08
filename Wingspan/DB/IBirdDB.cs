using System.Collections.Generic;
using Wingspan.Model;

namespace Wingspan.DB;

public interface IBirdDB
{
    public List<Bird> GetBirds();
}
