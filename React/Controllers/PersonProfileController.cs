﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        public List<Profile> Get()
        {
            return ProfileDataBase.Profiles;
        }


        [HttpGet("{id}")]
        public Profile Get(int id)
        {
            return ProfileDataBase.Profiles.Single(x => x.Id == id);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var victim = ProfileDataBase.Profiles.Single(x => x.Id == id);
            return ProfileDataBase.Profiles.Remove(victim);
        }
        [HttpPost]
        public bool Post([FromBody] Profile profile)
        {
            ProfileDataBase.Profiles.Add(profile);
            return true;
        }
    }
}
