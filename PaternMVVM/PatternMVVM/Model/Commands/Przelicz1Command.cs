using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.ViewModel;

namespace Pattern.Model.Commands
{
    class Pattern1Command : ICommand
    {
        PatternViewModel _viewModel;
        public Pattern1Command(PatternViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Execute(object sender)
        {
            _viewModel.Liczba1 = _viewModel.Liczba2 / 2;
        }
    }
}
