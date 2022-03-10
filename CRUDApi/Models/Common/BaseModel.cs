using CRUDApi.Enums;
using System;

namespace CRUDApi.Models.Common
{
    public class BaseModel
    {
        public long Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime EditedDate { get; set; }

        public long UpdatedBy { get; set; }

        public ItemState State { get; set; } = ItemState.Created;


        public void Update(long userId)
        {
            EditedDate = DateTime.Now;
            UpdatedBy = userId;
            State = ItemState.Updated;
        }

        public void Delete(long userId)
        {
            EditedDate = DateTime.Now;
            State = ItemState.Deleted;
            UpdatedBy = userId;
        }
    }
}
