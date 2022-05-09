using NotasWorkshop.Core.BaseModel.BaseDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotasWorkshop.Core.BaseModel.BaseEntityDto
{
    public interface IBaseEntityDto : IBaseDto
    {
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}
