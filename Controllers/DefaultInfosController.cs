using System;
using Microsoft.AspNetCore.Mvc;
using RPG_GAME.Models;

namespace RPG_GAME.Services
{
   [ApiController]
   [Route("api/[controller]")]
   public class DefaultInfosController : ControllerBase
   {
      private readonly DefaultInfosService _service;
      public DefaultInfosController(DefaultInfosService service)
      {
         _service = service;
      }

      [HttpGet]
      public ActionResult<DefaultInfo> Get()
      {
         try
         {
            return Ok(_service.GetAll());
         }
         catch (Exception e)
         {
            return BadRequest(e.Message);
         }
      }

      [HttpGet("{id}")]
      public ActionResult<DefaultInfo> GetAll(int id)
      {
         try
         {
            return Ok(_service.GetById(id));
         }
         catch (Exception e)
         {
            return BadRequest(e.Message);
         }
      }

      [HttpPost]
      public ActionResult<DefaultInfo> Create([FromBody] DefaultInfo newDefaultInfo)
      {
         try
         {
            return Ok(_service.Create(newDefaultInfo));
         }
         catch (Exception e)
         {
            return BadRequest(e.Message);
         }
      }

      [HttpPut("{id}")]
      public ActionResult<DefaultInfo> EditDefaultInfo([FromBody] DefaultInfo updated, int id)
      {
         try
         {
            updated.Id = id;
            return Ok(_service.Edit(updated));
         }
         catch (Exception e)
         {
            return BadRequest(e.Message);
         }
      }

      [HttpDelete("{id}")]
      public ActionResult<DefaultInfo> Delete(int id)
      {
         try
         {
            return Ok(_service.Delete(id));
         }
         catch (Exception e)
         {
            return BadRequest(e.Message);
         }
      }
   }
}