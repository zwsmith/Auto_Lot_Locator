using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicalApp;

namespace VehUI.Controllers
{
    [Authorize]
    public class VehicInfoesController : Controller
    {
        private readonly VehDataBSModel _context;

        public VehicInfoesController(VehDataBSModel context)
        {
            _context = context;
        }

        // GET: VehicInfoes
        public async Task<IActionResult> Index()
        {
            return View(VehFactory.GetVehicInfos());
            //return View(await _context.VehicInfos.ToListAsync());
        }

        // GET: VehicInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicInfo = await _context.VehicInfos
                .SingleOrDefaultAsync(m => m.Cselect == id);
            if (vehicInfo == null)
            {
                return NotFound();
            }

            return View(vehicInfo);
        }

        // GET: VehicInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehCategs,TypeC,Make,Model,Color,Cselect,CusName,Budget")] VehicInfo vehicInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicInfo);
        }

        // GET: VehicInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicInfo = await _context.VehicInfos.SingleOrDefaultAsync(m => m.Cselect == id);
            if (vehicInfo == null)
            {
                return NotFound();
            }
            return View(vehicInfo);
        }

        // POST: VehicInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VehCategs,TypeC,Make,Model,Color,Cselect,CusName,Budget")] VehicInfo vehicInfo)
        {
            if (id != vehicInfo.Cselect)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicInfoExists(vehicInfo.Cselect))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehicInfo);
        }

        // GET: VehicInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicInfo = await _context.VehicInfos
                .SingleOrDefaultAsync(m => m.Cselect == id);
            if (vehicInfo == null)
            {
                return NotFound();
            }

            return View(vehicInfo);
        }

        // POST: VehicInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vehicInfo = await _context.VehicInfos.SingleOrDefaultAsync(m => m.Cselect == id);
            _context.VehicInfos.Remove(vehicInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicInfoExists(string id)
        {
            return _context.VehicInfos.Any(e => e.Cselect == id);
        }
    }
}
