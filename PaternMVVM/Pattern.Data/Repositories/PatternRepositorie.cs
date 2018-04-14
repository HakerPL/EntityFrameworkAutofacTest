using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Autofac;
using Pattern.Data.Factories;
using Pattern.Entities;

namespace Pattern.Data.Repositories
{    
    public class PatternRepositorie : IPatternRepository
    {
        private readonly ApplicationDbContext _dbContext;

        // przekazujemy w coonect parametry do bazy danych
        public PatternRepositorie()
        {
            var factory = Pattern.Di.DiContainer.Container.Resolve<IDbContextFactory>();            
            _dbContext = factory.CreateContext();
        }
        
        public Number Get(int id)
        {
            //List<Numbers> numbers = _dbContext.Numbers.ToList();
            Number number = _dbContext.Numbers.FirstOrDefault(a => a.Id == id);
            return number;
            //throw new NotImplementedException();
        }

        public bool Save(Number numbers)
        {   
            // TODO: Jak ustawiać czy dana operacja jest poprawką czy edycją. Na podstaie id=0 ??
            //_dbContext.Entry(numbers).State = EntityState.Modified; //Ustawiamy informację dla Entity Framework, że rekord został zmodyfikowany
            _dbContext.Numbers.Add(numbers);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Remove(Number number)
        {
            //Numbers przelicz = db.Numbers.FirstOrDefault(a => a.Id == id); //Wyciągamy pierwszy napotkany album o tytule "Kill'em All"
            if (number != null) //Sprawdzamy, czy album istnieje
            {
                _dbContext.Numbers.Remove(number); //Usuwamy z tabeli Albums wiersz
                _dbContext.SaveChanges(); //Zapisujemy zmiany.
            }
            return true;
        }
    }
}
