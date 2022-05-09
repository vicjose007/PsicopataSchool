using System;
using System.Collections.Generic;
using System.Text;

namespace NotasWorkshop.Core.BaseModel.BaseDto
{
    public class BaseDto : IBaseDto
    {
        public virtual int? Id { get; set; }
        public virtual bool Deleted { get; set; }
    }
}
