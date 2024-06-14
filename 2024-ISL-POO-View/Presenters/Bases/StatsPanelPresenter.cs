using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Presenters.Bases
{
    internal class StatsPanelPresenter : PresenterBase
    {
        public StatsPanelPresenter() : base()
        {
            
        }

        public string StatsTitle => _lang.StatsLabel;
    }
}
