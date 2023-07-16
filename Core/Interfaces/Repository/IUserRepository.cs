using Core.Models.DTO;
using Core.Models.Entity;
using System;
using System.Threading.Tasks;

namespace Core.Interfaces.Repository
{

    public interface IUserRepository: IBaseRepository<user>
    {
        /// <summary>
        /// Khởi tạo dữ liệu khi tài khoản được kích hoạt
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<bool> CreateActivatedAccountData(string userId);
    }
}
