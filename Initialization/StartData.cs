using System;
using System.Collections.Generic;
using System.Globalization;
using VeterinaryClinic.Entities;
using VeterinaryClinic.Entities.Enums;

namespace VeterinaryClinic.Initialization
{
    public static class StartData
    {
        public static List<Pet> StartPets { get; } = new List<Pet>
        {
            new Pet
            {
                Name = "Dwalin",
                Type = PetTypes.Cat,
                RegistrationDate = new DateTime(2020, 11, 1),
                Owner = new PetOwner
                {
                    Name = "(Capitan) Jack Sparrow",
                    PhoneNumber = "+380123456789"
                }
            },
            new Pet
            {
                Name = "Balin",
                Type = PetTypes.Dog,
                RegistrationDate = new DateTime(2020, 11, 2),
                Owner = new PetOwner
                {
                    Name = "Marty Stu",
                    PhoneNumber = "+380234567891"
                }
            },
            new Pet
            {
                Name = "Kili",
                Type = PetTypes.Bird,
                RegistrationDate = new DateTime(2020, 11, 2),
                Owner = new PetOwner
                {
                    Name = "Anonymous",
                    PhoneNumber = "+380345678912"
                }
            },
            new Pet
            {
                Name = "Fili",
                Type = PetTypes.Bird,
                RegistrationDate = new DateTime(2020, 11, 3),
                Owner = new PetOwner
                {
                    Name = "Mary Sue",
                    PhoneNumber = "+380456789123"
                }
            },
            new Pet
            {
                Name = "Dori",
                Type = PetTypes.Dog,
                RegistrationDate = new DateTime(2020, 11, 5),
                Owner = new PetOwner
                {
                    Name = "Harry Potter",
                    PhoneNumber = "+380567891234"
                }
            },
            new Pet
            {
                Name = "Nori",
                Type = PetTypes.Cat,
                RegistrationDate = new DateTime(2020, 11, 7),
                Owner = new PetOwner
                {
                    Name = "Leroy Jenkins",
                    PhoneNumber = "+380678912345"
                }
            },
            new Pet
            {
                Name = "Ori",
                Type = PetTypes.Bird,
                RegistrationDate = new DateTime(2020, 11, 8),
                Owner = new PetOwner
                {
                    Name = "Ben Kenobi",
                    PhoneNumber = "+380789123456"
                }
            },
            new Pet
            {
                Name = "Oin",
                Type = PetTypes.Dog,
                RegistrationDate = new DateTime(2020, 11, 8),
                Owner = new PetOwner
                {
                    Name = "Somebody",
                    PhoneNumber = "+380891234567"
                }
            },
            new Pet
            {
                Name = "Gloin",
                Type = PetTypes.Dog,
                RegistrationDate = new DateTime(2020, 11, 9),
                Owner = new PetOwner
                {
                    Name = "Tom Sawyer",
                    PhoneNumber = "+380912345678"
                }
            },
            new Pet
            {
                Name = "Bifur",
                Type = PetTypes.Cat,
                RegistrationDate = new DateTime(2020, 11, 12),
                Owner = new PetOwner
                {
                    Name = "Sam Fisher",
                    PhoneNumber = "+380987654321"
                }
            },
            new Pet
            {
                Name = "Bofur",
                Type = PetTypes.Bird,
                RegistrationDate = new DateTime(2020, 11, 12),
                Owner = new PetOwner
                {
                    Name = "Hitman",
                    PhoneNumber = "+380876543219"
                }
            },
            new Pet
            {
                Name = "Bombur",
                Type = PetTypes.Cat,
                RegistrationDate = new DateTime(2020, 11, 12),
                Owner = new PetOwner
                {
                    Name = "Jack Daniels",
                    PhoneNumber = "+380765432198"
                }
            },
            new Pet
            {
                Name = "Thorin",
                Type = PetTypes.Dog,
                RegistrationDate = new DateTime(2020, 11, 14),
                Owner = new PetOwner
                {
                    Name = "Bilbo Baggins",
                    PhoneNumber = "+380654321987"
                }
            },
        };
    }
}
