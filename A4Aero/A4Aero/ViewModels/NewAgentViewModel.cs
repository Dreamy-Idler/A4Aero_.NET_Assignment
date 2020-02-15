using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A4Aero.Models;

namespace A4Aero.ViewModels
{
    public class NewAgentViewModel
    {
        public IEnumerable<AgentList> Agent_Lists { get; set; }
        public AgentList Lists { get; set; }
    }
}