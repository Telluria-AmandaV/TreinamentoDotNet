using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppEntVC.Data;
using AppEntVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppEntVC.Controllers
{
    public class CadSimplesController : Controller
    {
        private readonly StoreDataContext _context;

        public CadSimplesController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("v1/apptestewin")]
        [HttpGet]
        public IEnumerable<CadSimples> Get()
        {
            return _context.CadSimples.AsNoTracking().ToList();
        }

        [Route("v1/apptestewin{id}")]
        [HttpGet]
        public CadSimples Get(string cpf)
        {
            return _context.CadSimples.AsNoTracking().Where(x => x.CPF == cpf).FirstOrDefault();
        }

        [Route("v1/apptestewin")]
        [HttpPost]
        public CadSimples Post([FromBody] CadSimples cadsimples)
        {
            _context.CadSimples.Add(cadsimples);
            _context.SaveChanges();

            return cadsimples;
        }

        [Route("v1/apptestewin")]
        [HttpPut]
        public CadSimples Put([FromBody] CadSimples cadsimples)
        {
            _context.Entry<CadSimples>(cadsimples).State = EntityState.Modified;
            _context.SaveChanges();

            return cadsimples;
        }

        [Route("v1/apptestewin")]
        [HttpDelete]
        public CadSimples Delete([FromBody] CadSimples cadsimples)
        {
            _context.CadSimples.Remove(cadsimples);
            _context.SaveChanges();

            return cadsimples;
        }
    }
}