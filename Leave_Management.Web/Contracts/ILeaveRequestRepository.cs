using Leave_Management.Web.Data;
using Leave_Management.Web.Models;

namespace Leave_Management.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM request);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<LeaveRequestVM> GetLeaveRequestAsync(int? id);

        Task<List<LeaveRequestVM>> GetAllAsync(string employeeId);

        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task CancelLeaveRequest(int leaveRequestId);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
    }
}
