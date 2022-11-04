using AutoMapper;
using Avtobus1BLL.DTOs;
using Avtobus1BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace Avtobus1.Controllers
{
    public class UrlController : Controller
    {
        private readonly IUrlService _urlService;

        public UrlController(IUrlService urlService)
        {
            _urlService = urlService;
        }
        public async Task<IActionResult> Index()
        {
            var allLinks =await _urlService.Get();
            return View(allLinks);
        }
        public IActionResult Create()
        {
            return View(new CreateUrlDTO());
        }
        [HttpPost]
        public IActionResult Create(CreateUrlDTO createUrlDTO)
        {
            if (createUrlDTO == null)
            {
                throw new ArgumentNullException(nameof(createUrlDTO));
            }         
            
            _urlService.Create(createUrlDTO);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            var url = _urlService.GetItem(id);
            if(url == null)
            {
                return NotFound();
            }
            return View(url.Result);
        }
        [HttpPost]
        public IActionResult Edit(CreateUrlDTO createUrlDTO)
        {
            if(createUrlDTO == null)
            {
                throw new ArgumentOutOfRangeException(nameof(createUrlDTO));
            }
            if (!ModelState.IsValid)
            {
                return View(createUrlDTO);
            }
            _urlService.Edit(createUrlDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var deletingUrl = _urlService.GetItem(id);
            if(deletingUrl == null)
            {
                return NotFound();
            }
            return View(deletingUrl.Result);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _urlService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Redirect(int id)
        {
            var url = _urlService.GetItem(id);
            _urlService.Increment(id);
            
            return Redirect(url.Result.LongUrl);
        }
    }
}
