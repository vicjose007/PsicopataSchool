using System;
using System.Collections.Generic;
using System.Text;

namespace NotasWorkshop.Core.BaseModel.BaseDto
{
    public interface IBaseDto
    {
        int? Id { get; set; }
        bool Deleted { get; set; }
    }
}
