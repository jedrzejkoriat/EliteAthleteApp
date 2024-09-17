﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingPlanApp.Web.Constants;
using TrainingPlanApp.Web.Contracts;
using TrainingPlanApp.Web.Data;
using TrainingPlanApp.Web.Models;
using TrainingPlanApp.Web.Repositories;

namespace TrainingPlanApp.Web.Controllers
{
    public class DietsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IDietRepository dietRepository;
		private readonly IMapper mapper;

        public DietsController(ApplicationDbContext context, IDietRepository dietRepository, IMealRepository mealRepository, IMapper mapper)
        {
            this.context = context;
            this.dietRepository = dietRepository;
			this.mapper = mapper;
        }

        // GET: Diets
        public async Task<IActionResult> Index()
        {
            var dietsVM = mapper.Map<List<DietIndexVM>>(await dietRepository.GetAllAsync());     
            return View(dietsVM);
        }

        // GET: Diets/Details
        public async Task<IActionResult> Details(int? id)
		{
			var diet = (await dietRepository.GetAsync(id));
			if (diet == null)
            {
                return NotFound();
			}
			var dietVM = mapper.Map<DietIndexVM>(diet);
            return View(dietVM);
		}

		// GET: Diets/Create
		public IActionResult Create(string? userId)
		{
			var model = new DietCreateVM
			{
				UserId = userId
			};
			return View(model);
		}

        // POST: Diets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DietCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await dietRepository.CreateDiet(model);
                    return RedirectToAction(nameof(Index), new { id = model.UserId });
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occurred. Please try again later");
            }
            return View(model);
        }

        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> ChangeStatus(int id, bool status, string userId)
        {
            await dietRepository.ChangeDietStatus(id, status);
            return RedirectToAction(nameof(Index));
        }      
        
        // GET: Diets/ManageIngredients
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> ManageMeals(int? id, bool redirectToAdmin)
        {
            var dietManageMealsVM = await dietRepository.GetDietManageMealsVM(id, redirectToAdmin);
            return View(dietManageMealsVM);
        }

        // POST: Diets/ManageIngredients
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> ManageMeals(DietManageMealsVM dietManageMealsVM, int index)
        {
            return View(await dietRepository.AddMealToDiet(dietManageMealsVM, index));
        }

        // GET: Diets/Edit
        public async Task<IActionResult> Edit(int? id, bool redirectToAdmin)
        {
            if (id == null)
            {
                return NotFound();
            }
            var diet = await context.Diets.FindAsync(id);
            if (diet == null)
            {
                return NotFound();
            }
            var dietCreateVM = mapper.Map<DietCreateVM>(diet);
            dietCreateVM.RedirectToAdmin = redirectToAdmin;
            return View(dietCreateVM);
        }

        // POST: Diets/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DietCreateVM dietCreateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await dietRepository.EditDiet(dietCreateVM);
                    return RedirectToAction(nameof(Index));
                    /*return RedirectToAction(nameof(Index), new { id = model.UserId });*/
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error has occurred. Please try again later");
            }

            return View(dietCreateVM);
		}

		// POST: Diets/ManageMeals/RemoveMeal
		[HttpPost, ActionName("RemoveMeal")]
		[ValidateAntiForgeryToken]
		[Authorize(Roles = Roles.Administrator)]
		public async Task<IActionResult> RemoveMeal(int dietId, int index)
		{
			await dietRepository.RemoveMealFromDiet(dietId, index);
			return RedirectToAction(nameof(ManageMeals), new { id = dietId });
		}

		// POST: Diets/Delete
		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await dietRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
