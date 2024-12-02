namespace MediPlus_DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CraetedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
