using Model;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class HospitalController : Controller
    {
        public HospitalRepository repository;

        public HospitalController()
        {
            repository = new HospitalRepository();
        }

        public ActionResult Index()
        {
            return View();

        }

        //JsonResult retorna um json para uma requisição
        public JsonResult Store(Hospital hospital)
        {
            repository.Inserir(hospital);
            //retorna no formato de json o objeto de hospital
            // que foi persistido no banco de dados.
            return Json(hospital);
        }

        public JsonResult ObterTodos()
        {
            List<Hospital> hospitais = repository.ObtertTodos("");
            return Json(hospitais);
        }
    }
}