﻿using STIMULUS_V2.Client.Services.Interfaces;
using STIMULUS_V2.Shared.Models.DTOs;
using STIMULUS_V2.Shared.Models.Entities;
using System.Net.Http.Json;

namespace STIMULUS_V2.Client.Services
{
    public class GroupeService : IModelService<Groupe, int>
    {
        private readonly HttpClient _httpClient;

        public GroupeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<APIResponse<Groupe>> Create(Groupe item)
        {
            var result = await _httpClient.PostAsJsonAsync<Groupe>("api/Groupe/Create", item);
            return await result.Content.ReadFromJsonAsync<APIResponse<Groupe>>();
        }

        public async Task<APIResponse<bool>> Delete(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/Groupe/Delete/{id}");
            return await result.Content.ReadFromJsonAsync<APIResponse<bool>>();
        }

        public async Task<APIResponse<Groupe>> Get(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<APIResponse<Groupe>>($"api/Groupe/Fetch/{id}");
            return result;
        }

        public async Task<APIResponse<IEnumerable<Groupe>>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<APIResponse<IEnumerable<Groupe>>>("api/Groupe/Fetch/All");
            return result;
        }

        public Task<APIResponse<IEnumerable<Groupe>>> GetFromParentId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResponse<Groupe>> Update(int id, Groupe item)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Groupe/Update/{id}", item);
            return await result.Content.ReadFromJsonAsync<APIResponse<Groupe>>();
        }
    }
}