using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstract;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;
using Traversal.EntityLayer.Concrete;
using Traversal.WebUI.Areas.Admin.Models;

namespace Traversal.WebUI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var announcements = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList());

            return View(announcements);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO announcementModel)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = announcementModel.Content,
                    Title = announcementModel.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }

            return View(announcementModel);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var announcement = _announcementService.TGetByID(id);

            _announcementService.TDelete(announcement);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var announcement = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.TGetByID(id));

            return View(announcement);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO announcementModel)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = announcementModel.AnnouncementID,
                    Title = announcementModel.Title,
                    Content = announcementModel.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }

            return View(announcementModel);
        }
    }
}