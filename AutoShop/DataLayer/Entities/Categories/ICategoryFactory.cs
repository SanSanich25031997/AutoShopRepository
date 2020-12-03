using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Categories
{
    public interface ICategoryFactory
    {
        Category Create(string name, string description);
    }
}
