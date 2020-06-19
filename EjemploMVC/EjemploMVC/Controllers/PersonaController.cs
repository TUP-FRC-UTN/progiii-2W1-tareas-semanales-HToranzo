using EjemploMVC.AccesoDatos;
using EjemploMVC.Models;
using EjemploMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploMVC.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        public ActionResult AltaPersona()
        {
            List<SexoItemVM> listaSexos = AD_Personas.ObtenerListaSexo();

            List<SelectListItem> items = listaSexos.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.nombre,
                    Value = d.idSexo.ToString(),
                    Selected = false
                };
            });

            ViewBag.items = items;

            return View();
        }

        [HttpPost]
        public ActionResult AltaPersona(Persona model)
        {
            
            
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.InsertarNuevaPersona(model);
                if (resultado)
                {
                   return RedirectToAction("ListadoPersonas", "Persona");
                } 
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult ListadoPersonas()
        {
            List<Persona> lista = AD_Personas.ObtenerListaPersona();
            return View(lista);
        }

        public ActionResult DatosPersona(int idPersona)
        {
            List<SexoItemVM> listaSexos = AD_Personas.ObtenerListaSexo();

            List<SelectListItem> itemsCombo = listaSexos.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.nombre,
                    Value = d.idSexo.ToString(),
                    Selected = false
                };
            });

            Persona resultado = AD_Personas.ObtenerPersona(idPersona);

            foreach (var item in itemsCombo)
            {
                if (item.Value.Equals(resultado.IdSexo.ToString())) ;
                {
                    item.Selected = true;
                    break;
                }

            }
            return View(resultado);
        }
        [HttpPost]
        public ActionResult DatosPersona(Persona model)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.ActualizarPersona(model);
                if (resultado)
                {
                    return RedirectToAction("ListadoPersonas", "Persona");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

        public ActionResult EliminarPersona(int idPersona)
        {
            Persona resultado = AD_Personas.ObtenerPersona(idPersona);

            return View(resultado);
        }

        [HttpPost]
        public ActionResult EliminarPersona(Persona model)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.EliminarPersona(model);
                if (resultado)
                {
                    return RedirectToAction("ListadoPersona", "Persona");
                }
                else
                {
                    return View(model);
                }
            }
            return View();
        }

	}
}