using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BlogDB.Core;

using The_Intern_MVC.Models;

namespace The_Intern_MVC.Controllers
{
    public class AccountController : ControllerBase
    {

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}