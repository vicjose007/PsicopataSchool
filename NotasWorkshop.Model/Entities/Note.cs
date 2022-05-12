using NotasWorkshop.Core.BaseModel.BaseEntity;

namespace NotasWorkshop.Model.Entities
{
    public class Note : BaseEntity
    {
        public string? Title{ get; set; }
        public string? Description{ get; set; }
        public DateTime DateTime { get; set; }
    }
}
