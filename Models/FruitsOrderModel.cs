using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminProject.Models
{
    public class FruitsOrderModel
    {
        public int Id { get; set; }
        public int FruitsId { get; set; }

        public List<FruitsDropdownModel> fruits { get; set; }
        public string OrderBy { get; set; }
        public string Mobile { get; set; }
        public string Quantity { get; set; }
    }
}