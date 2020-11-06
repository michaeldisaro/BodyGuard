﻿using System.Threading.Tasks;
using Michaelsoft.BodyGuard.Client.Interfaces;
using Michaelsoft.BodyGuard.Client.Models;
using Michaelsoft.BodyGuard.Client.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Michaelsoft.BodyGuard.Client.Areas.User.Pages
{
    public class Update : PageModel
    {

        private readonly IBodyGuardUserApiService _userApiService;

        public Update(IBodyGuardUserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        [BindProperty]
        public UpdateForm UpdateForm { get; set; }

        public void OnGet()
        {
            UpdateForm = new UpdateForm
            {
                SuccessUrl = "/User/Update",
                FailureUrl = "/User/Update"
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Update failed.";
                return Page();
            }

            var response = await _userApiService.UpdateUser(UpdateForm.User);

            if (response.Success)
            {
                TempData["Message"] = "Update succeed!";
                return Redirect(UpdateForm.SuccessUrl ?? "/User/Update");
            }

            TempData["Message"] = "Update failed.";
            return Redirect(UpdateForm.FailureUrl ?? "/User/Update");
        }

    }
}