﻿//-----------------------------------------------------------------------
// <copyright file= "IUserRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/10/30 11:51:09
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Sample.Domain.AggregateModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Repositories.Contacts
{
    public interface IUserRepository
    {
        #region Services

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="account">账户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        Task<AppUser> GetAppUserInfo(string account, string password);

        #endregion Services
    }
}