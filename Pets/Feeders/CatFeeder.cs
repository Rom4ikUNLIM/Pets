using Pets.Feeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets.Pets
{
    public class CatFeeder : PetFeeder
    {
        public int maxFoodAmountCat { get; } = 200;
    }
}
