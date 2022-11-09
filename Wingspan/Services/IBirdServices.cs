using System.Collections.Generic;
using Wingspan.Model;

namespace Wingspan.Services;

public interface IBirdServices
{
    public List<Bird> GetAllBirds();
}
