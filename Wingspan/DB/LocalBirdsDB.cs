using System.Collections.Generic;
using Wingspan.Model;

namespace Wingspan.DB;
public class LocalBirdsDb : IBirdsDB
{
    public List<Bird> GetBirds()
    {
        return new()
        {
            new()
            {
                CommonName = "Bird",
                ScientificName = "Bird",
                GameSet = "core",
                AbilityColor = "white",
                AbilityDescription = "hello",
            }
        };
    }
}
