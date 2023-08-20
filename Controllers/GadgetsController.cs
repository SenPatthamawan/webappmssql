using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webappmssql.Data;
using webappmssql.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace webappmssql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GadgetsController : ControllerBase
    {
        private readonly MyWorldDBContext _myworldDBContext; //_myworldDBContext คือชื่อ object

        public GadgetsController(MyWorldDBContext myWorldDBContext)
        {
            _myworldDBContext = myWorldDBContext;
        }

        //การสร้าง Method Get All Gadgets()
        //https://localhost:5001/Gadgets/all
        [HttpGet]
        [Route("all")]
        public IActionResult GetAllGadgets()
        {
            var allGadgets = _myworldDBContext.Gadgets.ToList(); //auto json format
            return Ok(allGadgets);
        }

        //สร้าง Method Add Gadgets()
        //https://localhost:5001/Gadgets/add
        [HttpPost]
        [Route("add")]
        public IActionResult CreateGadget(Gadgets gadgets)
        {
            _myworldDBContext.Gadgets.Add(gadgets);
            _myworldDBContext.SaveChanges();
            return Ok(gadgets.Id);
        }

        //สร้าง Method Update Gadgets()
        //https://localhost:5001/Gadgets/update
        [HttpPut]
        [Route("update")]
        public IActionResult UpdateGadget(Gadgets gadgets)
        {
            _myworldDBContext.Update(gadgets);
            _myworldDBContext.SaveChanges();
            return NoContent();
        }

        //สร้าง Method Delete Gadgets()
        //https://localhost:5001/Gadgets/delete
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteGadget(int id)
        {
            var gadgetToDelete = _myworldDBContext.Gadgets.Where(_ => _.Id == id).FirstOrDefault();
            if (gadgetToDelete == null)
            {
                return NotFound();
            }
            _myworldDBContext.Gadgets.Remove(gadgetToDelete);
            _myworldDBContext.SaveChanges();
            return NoContent();

        }

    }
}