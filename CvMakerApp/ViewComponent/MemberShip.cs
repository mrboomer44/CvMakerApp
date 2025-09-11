﻿using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class MemberShip : ViewComponent
    {
        private readonly Context _context;

        public MemberShip(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Memberships.OrderByDescending(x => x.MembershipId).ToList();
            return View(degerler);

        }
    }
}