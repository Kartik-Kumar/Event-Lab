﻿using Events.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Events.Web.Controllers
{
    public class BaseController : Controller
    {
        // GET: BaseController
        
            protected ApplicationDbContext db = new ApplicationDbContext();

        public bool IsAdmin()
        {
            var currentUserId = this.User.Identity.GetUserId();
            var IsAdmin = (currentUserId != null && this.User.IsInRole("Administrator"));
            return IsAdmin;
        }
    }
}