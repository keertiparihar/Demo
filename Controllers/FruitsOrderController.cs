using AdminProject.Models;
using AdminProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminProject.Controllers
{
    public class FruitsOrderController : Controller
    {
        // GET: FruitsOrder
        public ActionResult Index()
        {
            FruitsOrderRepository oFruitsOrderRepository = new FruitsOrderRepository();
            FruitsOrderModel oFruitsOrderModel = new FruitsOrderModel();
            //FruitsDropdownModel oFruitsModel = new FruitsDropdownModel();

            
            List<FruitsDropdownModel> listOrder = oFruitsOrderRepository.GetAllFruitsName();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var v in listOrder)
            {
                list.Add(new SelectListItem { Text = v.FruitsName, Value = v.FruitsId.ToString() });
            }
            ViewBag.Fruits = list;
            return View();
        }
        [HttpPost]
        public ActionResult SaveFruitsOrder(FruitsOrderModel oFruitsOrderModel)
        {
            try
            {
               
                if(ModelState.IsValid)
                {
                    FruitsOrderRepository oFruitsOrderRepository = new FruitsOrderRepository();
                    if(oFruitsOrderModel.Id==0)
                    {
                        if(oFruitsOrderRepository.AddFruitsOrder(oFruitsOrderModel))
                        {
                            ViewBag.Message = "Fruits Order details added successfully";
                        }
                    }
                    else
                    {

                    }

                }
                return RedirectToAction("Success");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index");
            }

            
           
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}