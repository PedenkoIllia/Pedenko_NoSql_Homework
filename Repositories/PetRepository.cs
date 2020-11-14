using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using VeterinaryClinic.Entities;

namespace VeterinaryClinic.Repositories
{
    class PetRepository : BaseRepository<Pet>
    {
        public PetRepository(IMongoDatabase database) : base(database)
        {
            var RegistrationDateIndexDefinition = Builders<Pet>.IndexKeys.Ascending(p => p.RegistrationDate);

            collection.Indexes.CreateMany(new CreateIndexModel<Pet>[]
            {
                new CreateIndexModel<Pet>(Builders<Pet>.IndexKeys.Descending(pet => pet.RegistrationDate)),
                new CreateIndexModel<Pet>("{Type:1}")
            });
        }

        public long Count() => collection.EstimatedDocumentCount();

        public IEnumerable<Pet> Search(int pageNumber, int pageSize)
        {
            return collection
                    .Find(pet => true)
                    .Sort(Builders<Pet>.Sort.Descending(pet => pet.RegistrationDate))
                    .Skip(pageNumber * pageSize)
                    .Limit(pageSize)
                    .ToList();
        }

        public IEnumerable<ReportData> GetReportData()
        {
            return collection
                    .Aggregate(new AggregateOptions { AllowDiskUse = true })
                    .Group(p => p.Type, group => new ReportData { Type = group.Key, Count = group.Count() })
                    .Sort(Builders<ReportData>.Sort.Ascending(g => g.Count))
                    .ToList();
        }
    }
}
