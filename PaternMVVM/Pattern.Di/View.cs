using Autofac;

namespace Pattern.Di
{
    class View
    {
        private readonly IOutput _output;

        public View(IContainer container)
        {
            _output = container.Resolve<IOutput>();
        }

        public void Show()
        {
            _output.Write();
        }
    }
}
