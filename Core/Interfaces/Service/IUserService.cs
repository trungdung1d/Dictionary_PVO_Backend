﻿using Core.Models.DTO;
using Core.Models.Param;
using Core.Models.ServerObject;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    /// <summary>
    /// Service xử lý dữ liệu user
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Thay đổi mật khẩu
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        Task<IServiceResult> UpdatePassword(string oldPassword, string newPassword);

        /// <summary>
        /// Lấy các thông tin cá nhân của người dùng
        /// </summary>
        /// <returns></returns>
        Task<IServiceResult> GetUserInfo();

        /// <summary>
        /// Cập nhật các thông tin cá nhân của người dùng
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<IServiceResult> UpdateUserInfo(UpdateUserInfoParam param);
    }
}
