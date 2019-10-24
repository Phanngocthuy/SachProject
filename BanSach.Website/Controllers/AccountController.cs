using BanSach.Model;
using BanSach.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanSach.Website.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private readonly IAccount_Service service;
        public AccountController()
        {
            service = new Account_Service();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account model)
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}