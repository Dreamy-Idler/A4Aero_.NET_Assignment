using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A4Aero.Models;
using A4Aero.ViewModels;

namespace A4Aero.Controllers
{
    public class AgentController : Controller
    {
        private ApplicationDbContext _context;

        public AgentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var markupPlanTypes = _context.Agent_List.ToList();
            var viewModel = new NewAgentViewModel
            {
                Agent_Lists = markupPlanTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(AgentList list)
        {
            if (list.Id == 0)
                _context.Agent_List.Add(list);
            else
            {
                var agentListInDb = _context.Agent_List.Single(c => c.Id == list.Id);
                agentListInDb.CODE = list.CODE;
                agentListInDb.NAME = list.NAME;
                agentListInDb.MARKUP_PLAN = list.MARKUP_PLAN;
                agentListInDb.MOBILE = list.MOBILE;
                agentListInDb.EMAIL = list.EMAIL;
            }
            _context.Agent_List.Add(list);
            _context.SaveChanges();
            return RedirectToAction("Index", "Agent");
        }

        public ViewResult Index()
        {
            var lists = _context.Agent_List;
            return View(lists);
        }

        public ActionResult Details(int id)
        {
            var lists = _context.Agent_List.SingleOrDefault(c => c.Id == id);
            return View(lists);
        }

        public ActionResult Edit(int id)
        {
            var agentList = _context.Agent_List.SingleOrDefault(c => c.Id == id);

            var viewModel = new NewAgentViewModel 
            { 
                Lists = agentList

            };
            return View("Save", viewModel);
        }
    }
}