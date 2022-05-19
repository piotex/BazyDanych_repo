﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppServer.Contexts;
using WebAppServer.Models;
using WebAppServer.MoqModels;
using WebAppServer.SingletonsFlags;

namespace WebAppServer.Controllers.DbBasicControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private OracleDbContext _dataContext;
        public UsersController(OracleDbContext dbContext)
        {
            _dataContext = dbContext;
        }

        /// <summary>
        /// Rest Api Get method
        /// </summary>
        /// <returns>List of all Users</returns>
        [HttpGet]
        public List<Users> Get()
        {
            if (ApplicationVersion.IsTestVersion())
            {
                return MoqUsersList.GetInstance().GetMoqList();
            }
            return _dataContext.Users.ToList();
        }

        /// <summary>
        /// Rest Api Get method
        /// </summary>
        /// <returns>Users model that have matching id parameter</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            var inspection = await _dataContext.Users.FindAsync(id);
            if (inspection == null)
            {
                return NotFound();
            }
            return inspection;
        }

        /// <summary>
        /// Rest Api Post method, to insert Users into database 
        /// </summary>
        /// <returns>Inserted Users</returns>
        [HttpPost]
        public void Post(Users company)
        {
            if (ApplicationVersion.IsTestVersion())
            {
                MoqUsersList.GetInstance().PushToMoqList(company);
            }
            else
            {
                _dataContext.Users.Add(company);
                _dataContext.SaveChangesAsync();
            }
            //return CreatedAtAction("GetCompany", new { id = company.CompanyId }, company);
        }
    }
}
