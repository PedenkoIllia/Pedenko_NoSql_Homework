using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text;
using VeterinaryClinic.Entities.Enums;
using VeterinaryClinic.Entities.Interfaces;

namespace VeterinaryClinic.Entities
{
    public class Pet : IEntity
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public PetTypes Type { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegistrationDate { get; set; }

        public PetOwner Owner { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append("Name: ").Append(Name).Append(", type: ").Append(Type).Append(Environment.NewLine)
                .Append("Owner: ").Append(Owner.Name).Append(", phone number: ").Append(Owner.PhoneNumber)
                .Append(Environment.NewLine).Append("Registration date: ")
                .Append(RegistrationDate.ToString("dd.MM.yyyy"));

            return sb.ToString();
        }
    }
}
