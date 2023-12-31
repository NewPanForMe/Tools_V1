﻿using Microsoft.AspNetCore.Mvc;
using System;
using Ys.Tools.Exception;
using Ys.Tools.Models;

namespace Ys.Tools.Controllers;

public class BaseController : BaseAuthController
{
    public override CurrentUser CurrentUser
    {
        get
        {

            if (base.CurrentUser.Code == null)
            {
                throw new MessageException("获取用户失败");
            }
            return base.CurrentUser;
        }
    }
}