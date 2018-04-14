using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.ViewModel;


namespace Pattern.Model.Commands 
{
    class Pattern2Command : ICommand
    {
        PatternViewModel _viewModel;
        public Pattern2Command(PatternViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Execute(object sender)
        {
            _viewModel.Liczba2 = 2 * _viewModel.Liczba1;
        }
    }
}
