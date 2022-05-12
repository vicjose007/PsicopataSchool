using NotasWorkshop.Core.BaseModel.Base;

namespace NotasWorkshop.Model.Entities
{
    public class User : Base
    {
        
        public string? Name { get; set; }

        public string? Password { get; set; }
    }

}