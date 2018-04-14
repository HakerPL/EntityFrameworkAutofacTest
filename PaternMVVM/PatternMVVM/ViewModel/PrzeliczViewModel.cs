using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Pattern.Model.Commands;
using Pattern.Data.Repositories;
using Pattern.Entities;
using Pattern.DTO;
using Pattern.Data;
using System.ComponentModel;

namespace Pattern.ViewModel
{
    class PatternViewModel: INotifyPropertyChanged
    {
        public IPatternRepository Repository;
        public PatternDto  PatternModel;
        public decimal Liczba1
        {
            get
            {
                return PatternModel.Liczba1;
            }
            set
            {
                if (PatternModel.Liczba1 != value)
                {
                    PatternModel.Liczba1 = value;
                    OnPropertyChanged(nameof(Liczba1));
                }
            }
        }

        public decimal Liczba2
        {
            get
            {
                return PatternModel.Liczba2;
            }
            set
            {
                PatternModel.Liczba2 = value;
                OnPropertyChanged(nameof(Liczba2));
            }
        }


        public PatternViewModel()
        {
            Repository = Di.DiContainer.Container.Resolve<IPatternRepository>();

            PatternModel = new PatternDto();
        }

        private ICommand _przelicz1Command;
        public ICommand Pattern1Command => _przelicz1Command ?? (_przelicz1Command = new Pattern1Command(this));

        private ICommand _przelicz2Command;
        public ICommand Pattern2Command => _przelicz2Command ?? (_przelicz2Command = new Pattern2Command(this));

        private ICommand _saveCommand;
        public ICommand SaveCommand => _saveCommand ?? (_saveCommand = new SaveCommand(this));


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
