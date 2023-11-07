﻿using Microsoft.AspNetCore.Mvc;
using STIMULUS_V2.Server.Services.Interfaces;
using STIMULUS_V2.Shared.Models.Entities;

namespace STIMULUS_V2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichierSourceController : Controller
    {
        private readonly IModelService<FichierSource, int> fichierSourceService;

        public FichierSourceController(IModelService<FichierSource, int> fichierSourceService)
        {
            this.fichierSourceService = fichierSourceService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] FichierSource fichierSource)
        {
            var response = await fichierSourceService.Create(fichierSource);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await fichierSourceService.Delete(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await fichierSourceService.Get(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/All")]
        public async Task<IActionResult> GetAll()
        {
            var response = await fichierSourceService.GetAll();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("Fetch/FromParent/{id}")]
        public async Task<IActionResult> GetFromParentId(int id)
        {
            var response = await fichierSourceService.GetFromParentId(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] FichierSource fichierSource)
        {
            var response = await fichierSourceService.Update(id, fichierSource);
            return StatusCode(response.StatusCode, response);
        }
    }
}