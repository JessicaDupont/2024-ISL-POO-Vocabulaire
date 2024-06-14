﻿using _2024_ISL_POO_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_Domain.IModels
{
    public interface IWord : IModelBase
    {
        int Id { get; set; }
        string Name { get; set; }
        GrammaticalGroup Group { get; set; }
        ILanguage Language { get; set; }
        List<ISerie> Series();
        List<IWord> Traduction();
    }
}
