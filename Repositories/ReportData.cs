using VeterinaryClinic.Entities.Enums;

namespace VeterinaryClinic.Repositories
{
    public class ReportData
    {
        public PetTypes Type { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Type of animal: {Type}, quantity: {Count}";
        }
    }
}