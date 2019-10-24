using BanSach.Model;
using BanSach.Service;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanSach.Website.Areas.Admin.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopic_Service topic_Service;
        public TopicController()
        {
            topic_Service = new Topic_Service();
        }
        public ActionResult Index(Topic model)
        {
            ViewBag.Topic = model;
            IPagedList<Topic> data = topic_Service.PagedListNonAjax(model);
            return View(data);
        }
    }
}