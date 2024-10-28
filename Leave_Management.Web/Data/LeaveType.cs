namespace Leave_Management.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
