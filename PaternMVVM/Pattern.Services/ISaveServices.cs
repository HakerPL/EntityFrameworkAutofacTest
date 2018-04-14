using Autofac;
using Pattern.Data;
using Pattern.Data.Factories;
using Pattern.Data.Repositories;
using Pattern.Entities;

namespace Pattern.Services
{
    public interface ISaveServices
    {
        void Save(Number przelicz);
    }

    // TODO: Czy to w jednej klasie wrzucamy z ISaveServices. Skąd wziąć dcContext
    public class SaveServices : ISaveServices
    {

        private readonly IPatternRepository _repository;

        public SaveServices()
        {
            _repository = Di.DiContainer.Container.Resolve<IPatternRepository>();
        }

        public void Save(Number number)
        {
            Number numberEnity = new Number
            {
                Number1 = number.Number1,
                Number2 = number.Number1
            };

            _repository.Save(numberEnity);
        }
    }
}
