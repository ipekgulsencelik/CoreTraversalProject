﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.ValidationRules;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);

                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetByID(id);

            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);

            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}