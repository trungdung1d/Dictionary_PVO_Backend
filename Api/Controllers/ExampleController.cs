﻿using Core.Constants;
using Core.Enums;
using Core.Interfaces.Service;
using Core.Models.DTO;
using Core.Models.Param;
using Core.Models.ServerObject;
using Core.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Api.Controllers
{
    /// <summary>
    /// Lớp controller cung cấp api liên quan đến example
    /// </summary>
    public class ExampleController : BaseApiController
    {
        #region Fields
        private readonly IExampleService _service;
        #endregion

        #region Constructors

        public ExampleController(IHustServiceCollection serviceCollection, IExampleService service) : base(serviceCollection)
        {
            _service = service;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Thực hiện thêm 1 example
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        [HttpPost("add_example")]
        public async Task<IServiceResult> AddExample([FromBody] Example example)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.AddExample(example);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }

        /// <summary>
        /// Thực hiện cập nhật example
        /// </summary>
        /// <param name="concept"></param>
        /// <returns></returns>
        [HttpPut("update_example")]
        public async Task<IServiceResult> UpdateExample([FromBody] Example example)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.UpdateExample(example);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }

        /// <summary>
        /// Thực hiện xóa example
        /// </summary>
        /// <param name="exampleId"></param>
        /// <returns></returns>
        [HttpDelete("delete_example")]
        public async Task<IServiceResult> DeleteExample([FromQuery] Guid exampleId)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.DeleteExample(exampleId);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }

        /// <summary>
        /// Lấy dữ liệu example
        /// </summary>
        /// <param name="conceptId"></param>
        /// <returns></returns>
        [HttpGet("get_example")]
        public async Task<IServiceResult> GetExample([FromQuery] Guid exampleId)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.GetExample(exampleId);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }

        /// <summary>
        /// Tìm kiếm example
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [HttpPost("search_example")]
        public async Task<IServiceResult> SearchExample([FromBody] SearchExampleParam param)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.SearchExample(param);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }


        #endregion
    }
}
