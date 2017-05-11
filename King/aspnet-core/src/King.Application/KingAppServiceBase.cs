﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using King.MultiTenancy;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using King.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace King
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class KingAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected KingAppServiceBase()
        {
            LocalizationSourceName = KingConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}