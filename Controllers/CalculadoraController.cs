using PSP_Trabajo.Models;
using System;
using System.Web.Mvc;

namespace PSP_Trabajo.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            Calculadora calculadora = new Calculadora();
            double noSePudo = 0;
            ViewBag.Ms = "Ingrese 2 números";
            if (double.TryParse(Request.Form["numeroA"], out noSePudo) && double.TryParse(Request.Form["numeroB"], out noSePudo))
            {
                calculadora.NumeroA = Convert.ToDouble(Request.Form["numeroA"]);
                calculadora.NumeroB = Convert.ToDouble(Request.Form["numeroB"]);
                
                if (calculadora.CalcularValor().Equals(0))
                {
                    ViewBag.Ms = "No se encontró una acción para esta condición";
                }
                else
                {
                    ViewData["respuesta"] = calculadora.CalcularValor();
                }
            }
            return View();
        }
    }
}