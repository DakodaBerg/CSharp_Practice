using ApiDBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            await CreateContact();
            await GetAllContacts();
        }

        private async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:44379/api/contacts");

            List<ContactModel> contacts;
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };
                string responseText = await response.Content.ReadAsStringAsync();
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText, options);
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel()
            {
                FirstName = "Megan",
                LastName = "Hill"
            };
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "blahbah" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "3492023" });

            var _client = _httpClientFactory.CreateClient();
            var response = await _client.PostAsync("https://localhost:44379/api/contacts", new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json"));
        }
    }
}
