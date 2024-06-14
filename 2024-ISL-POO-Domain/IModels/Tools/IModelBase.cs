using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_Domain.IModels
{
    public interface IModelBase
    {
        int Id { get; set; }
        bool DataCompleted { get; set; }
    }
}
