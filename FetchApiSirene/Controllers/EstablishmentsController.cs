using FetchApiSirene.BusinessLogic.Services;
using FetchApiSirene.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FetchApiSirene.Controllers
{
    public class EstablishmentsController : Controller
    {
        // GET: EstablishmentsController
        private readonly IEstablishmentInterface _establishmentInterface;
        public EstablishmentsController(IEstablishmentInterface establishmentInterface)
        {
            IestablishmentInterface = establishmentInterface;
        }

        // POST: EstablishmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet("{Establishment}}")]
        public async ActionResult Task<IActionResult> GetSchoolsByEstablishment(string Establishment )
        {
            var filter= Builders<Establishments>.Filter.Eq(c => c.Denomination);
            var school = await _IEstablishmentInterface.GetAsync(filter);
            if (school != null)
            {
                return NotFound();
            }
            return Ok(school);
        }

        // POST: EstablishmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEstablishments(Establishments establishments)
        {
            await _IEstablishmentInterface.CreateAsync(establishments);
            return View();
        }
    }
}
