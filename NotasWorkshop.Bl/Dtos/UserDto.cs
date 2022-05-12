using NotasWorkshop.Core.BaseModel.BaseEntityDto;

namespace NotasWorkshop.Bl.Dtos
{
    public class UserDto : BaseEntityDto
    {

        public string? Name { get; set; }

        public string? Password { get; set; }
    }
}
