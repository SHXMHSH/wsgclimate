using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wsgclimate.Models;
using wsgclimate.Repository;

namespace wsgclimate.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRepository<RoomModel> _rep;
        public RoomController()
        {
            _rep = new Repository<RoomModel>();
        }
        // GET: RoomController
        public ActionResult Index()
        {
            return View(_rep.GetAll());
        }
        [HttpPost]
        public RedirectToActionResult Edit(RoomModel model)
        {
            _rep.Edit(model);
            return RedirectToAction(nameof(Index));

        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Update(int id)
        {
            var model = _rep.Single(id);
            if (model == null) RedirectToAction(nameof(Index));
            return View(_rep.Single(id));
        }
        [HttpPost]
        public RedirectToActionResult Delete (int id)
        {
            return RedirectToAction(nameof(Index));
        }

    }
}
