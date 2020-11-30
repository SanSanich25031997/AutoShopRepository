using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Categories
{
    public interface ICategoryFactory
    {
        Category Create(int id, string name, string description);
    }
}
