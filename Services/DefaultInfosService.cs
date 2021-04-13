using System;
using System.Collections.Generic;
using RPG_GAME.Models;
using RPG_GAME.Repositories;

namespace RPG_GAME.Services
{
   public class DefaultInfosService
   {
      private readonly DefaultInfosRepository _repo;

      public DefaultInfosService(DefaultInfosRepository repo)
      {
         _repo = repo;
      }

      internal IEnumerable<DefaultInfo> GetAll()
      {
         return _repo.GetAll();
      }

      internal DefaultInfo GetById(int id)
      {
         DefaultInfo data = _repo.GetById(id);
         if (data == null)
         {
            throw new Exception("Invalid Id");
         }
         return data;
      }

      internal DefaultInfo Create(DefaultInfo newDefaultInfo)
      {
         return _repo.Create(newDefaultInfo);
      }

      internal DefaultInfo Edit(DefaultInfo updated)
      {
         DefaultInfo data = GetById(updated.Id);

         data.Name = updated.Name != null ? updated.Name : data.Name;
         data.Amount = updated.Amount != null ? updated.Amount : data.Amount;

         return _repo.Edit(data);
      }

      internal String Delete(int id)
      {
         // NOTE: Why do we declare data? We don't use it...
         DefaultInfo data = GetById(id);
         _repo.Delete(id);
         return "delorted";
      }
   }
}