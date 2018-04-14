using Pattern.ViewModel;
using Pattern.Entities;
using Pattern.Services;
using Autofac;

namespace Pattern.Model.Commands
{
    class SaveCommand : ICommand
    {
        ISaveServices _przeliczServices ;

        PatternViewModel _viewModel;
        public SaveCommand(PatternViewModel viewModel)
        {
            _viewModel = viewModel;
            _przeliczServices = Di.DiContainer.Container.Resolve<ISaveServices>();
        }

        public void Execute(object sender)
        {
            //uzycie mappera
            _przeliczServices.Save(new Number
            {
                Number1 = _viewModel.Liczba1,
                Number2 = _viewModel.Liczba2
            });
        }
    }
}
