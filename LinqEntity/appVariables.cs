using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqEntity.Entity;

namespace LinqEntity
{

    static class Globals
    {
        private static agentModel dbContext = null;

        /// <summary>
        /// Возвращает экземпляр модели (контекста)
        /// </summary>
        /// <returns>Модель</returns>
        public static agentModel getDbContext()
        {
            dbContext = dbContext ?? new agentModel();
            return dbContext;
        }
    }

}
