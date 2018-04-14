using System;
using System.Collections.Generic;
using Autofac;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pattern.ViewModel;

namespace Pattern
{
    public partial class NumbersForm : Form
    {
        private PatternViewModel _viewModel;
        public NumbersForm()
        {
            InitializeComponent();
            _viewModel = new PatternViewModel();
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;

            textBox1.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Liczba1), false, DataSourceUpdateMode.OnPropertyChanged);
            nudLiczba1.DataBindings.Add("Value", _viewModel, nameof(_viewModel.Liczba1), false, DataSourceUpdateMode.OnPropertyChanged);
            doubleInput1.DataBindings.Add("Value", _viewModel, nameof(_viewModel.Liczba1), false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Liczba2), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _viewModel.SaveCommand.Execute(this);
        }


        private bool isPropertyChanging = false;
        private void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (isPropertyChanging)
                return;
            else
                isPropertyChanging = true;

            try
            {
                switch (e.PropertyName)
                {
                    case nameof(_viewModel.Liczba1):
                        _viewModel.Pattern2Command.Execute(this);
                        break;
                    case nameof(_viewModel.Liczba2):
                        _viewModel.Pattern1Command.Execute(this);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                isPropertyChanging = false;
            }
        }

    }
}