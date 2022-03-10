using CRUDApi.Enums;
using System;

namespace CRUDApi.Models.Common
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime EditedDate { get; set; }

        public long UpdatedBy { get; set; }

        public ItemState State { get; set; }


        public void Update(long userId)
        {
            EditedDate = DateTime.Now;
        }
    }
}
