﻿using Microsoft.AspNetCore.Mvc;
using STIMULUS_V2.Server.Services.Interfaces;
using STIMULUS_V2.Shared.Models.Entities;

namespace STIMULUS_V2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenceController : Controller
    {
        private readonly IModelService<Reference, int> referenceService;

        public ReferenceController(IModelService<Reference, int> referenceService)
        {
            this.referenceService = referenceService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Reference reference)
        {
            var response = await referenceService.Create(reference);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await referenceService.Delete(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await referenceService.Get(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/All")]
        public async Task<IActionResult> GetAll()
        {
            var response = await referenceService.GetAll();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/FromParent/{id}")]
        public async Task<IActionResult> GetFromParentId(int id)
        {
            var response = await referenceService.GetFromParentId(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Reference reference)
        {
            var response = await referenceService.Update(id, reference);
            return StatusCode(response.StatusCode, response);
        }
    }
}