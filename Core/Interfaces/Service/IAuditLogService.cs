using Core.Models.DTO;
using Core.Models.Param;
using Core.Models.ServerObject;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    /// <summary>
    /// Service xử lý dữ liệu log
    /// </summary>
    public interface IAuditLogService
    {
        /// <summary>
        /// Lấy lịch sử truy cập của người dùng
        /// </summary>
        /// <param name="searchFilter"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="dateForm"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        Task<IServiceResult> GetLogs(string searchFilter, int? pageIndex, int? pageSize, string dateForm, string dateTo);

        /// <summary>
        /// Lưu lịch sử truy cập của người dùng
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<IServiceResult> SaveLog(AuditLog param);
    }
}
