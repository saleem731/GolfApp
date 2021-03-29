using GolfApp.Models;
using GolfApp.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GolfApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GolfClubsController : ControllerBase
    {
        public IGolfClubDAL _dal;
        public GolfClubsController(IGolfClubDAL dal)
        {
            _dal = dal;
        }

        [HttpGet]
        public List<GolfClub> Get()
        {
            return _dal.Get();
        }

        // GET api/<GolfClubs>/5
        [HttpGet("{id}")]
        public GolfClub Get(int id)
        {
            return _dal.GetByID(id);
        }

        // POST api/<GolfClubs>
        [HttpPost]
        public void Post([FromBody] GolfClub golfClub)
        {
            try
            {
                _dal.Insert(golfClub);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Put([FromBody] GolfClub golfClub)
        {
            try
            {
                _dal.Update(golfClub);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // DELETE api/<GolfClubs>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            try
            {
                _dal.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
