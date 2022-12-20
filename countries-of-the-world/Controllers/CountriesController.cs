using CountriesOfTheWorld.Data;
using CountriesOfTheWorld.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountriesOfTheWorld.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountriesController : ControllerBase {
        private readonly ApiContext _context;

        public CountriesController(ApiContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryById() {
            
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCountries() {
            
            return Ok();
        }

        //PUT: api/Countries/UpdateCountry/Thailand
        [HttpPut("{countryname}")]
        public async Task<IActionResult> UpdateCountry() {
            
            return Ok();
        }

        //POST: api/Countries/AddNewCountry
        [HttpPost]
        public async Task<ActionResult<CountryInfo>> AddNewCountry() {
            return Ok();
        }

        //DELETE: api/Countries/DeleteCountry/999
        [HttpDelete("{rowId}")]
        public async Task<IActionResult> DeleteCountry() {
            
            return Ok();
        }
    }
}
