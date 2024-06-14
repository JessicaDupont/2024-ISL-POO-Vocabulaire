using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_ISL_POO_View.Presenters.Layout
{
    internal class TestsPanelPresenter : PresenterBase
    {
        public TestsPanelPresenter() : base()
        {
            
        }

        public string TestsTitle => _lang.TestsGroupBox;
        public string NbWordsTitle => _lang.NumbreOfWordsForTestLabel;
        public string RunButton => _lang.TestButton;
    }
}
