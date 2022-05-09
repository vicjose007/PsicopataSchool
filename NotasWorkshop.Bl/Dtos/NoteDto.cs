using NotasWorkshop.Core.BaseModel.BaseEntityDto;

namespace NotasWorkshop.Bl.Dtos
{
    public class NoteDto : BaseEntityDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
