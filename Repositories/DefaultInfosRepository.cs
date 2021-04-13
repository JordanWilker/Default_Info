using System.Collections.Generic;
using System.Data;
using Dapper;
using RPG_GAME.Models;

namespace RPG_GAME.Repositories
{
   public class DefaultInfosRepository
   {
      private readonly IDbConnection _db;

      public DefaultInfosRepository(IDbConnection db)
      {
         _db = db;
      }

      internal IEnumerable<DefaultInfo> GetAll()
      {
         string sql = "SELECT * FROM defaultinfo;";
         return _db.Query<DefaultInfo>(sql);
      }

      internal DefaultInfo GetById(int id)
      {
         string sql = "SELECT * FROM defaultinfo WHERE id = @id;";
         return _db.QueryFirstOrDefault<DefaultInfo>(sql, new { id });
      }

      internal DefaultInfo Create(DefaultInfo newDefaultInfo)
      {
         string sql = @"
         INSERT INTO defaultinfo
         (name, amount)
         VALUES
         (@name, @amount);";
         int id = _db.ExecuteScalar<int>(sql, newDefaultInfo);
         newDefaultInfo.Id = id;
         return newDefaultInfo;
      }

      internal DefaultInfo Edit(DefaultInfo data)
      {
         string sql = @"
         UPDATE defaultinfo
         SET
            name = @name,
            amount = @amount,
         WHERE id = @id;
         SELECT * FROM defaultinfo WHERE id = @id;";
         DefaultInfo returnDefaultInfo = _db.QueryFirstOrDefault<DefaultInfo>(sql, data);
         return returnDefaultInfo;
      }

      internal void Delete(int id)
      {
         string sql = "DELETE FROM defaultinfo WHERE Id = @id LIMIT 1";
         _db.Execute(sql, new { id });
      }
   }
}