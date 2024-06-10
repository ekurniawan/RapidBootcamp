﻿using Microsoft.AspNetCore.Mvc;
using RapidBootcamp.BackendAPI.DAL;
using RapidBootcamp.BackendAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RapidBootcamp.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoriesController(ICategory category)
        {
            _category = category;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var categories = _category.GetAll();
            return categories;
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            var category = _category.GetById(id);
            return category;
        }

        [HttpGet("ByName")]
        public IEnumerable<Category> GetByName(string name)
        {
            var categories = _category.GetByCategoryName(name);
            return categories;
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post(Category category)
        {
            try
            {
                var result = _category.Add(category);
                return CreatedAtAction(nameof(Get),
                    new { id = category.CategoryId }, category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
