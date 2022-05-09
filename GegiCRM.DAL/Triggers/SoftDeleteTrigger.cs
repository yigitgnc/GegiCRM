using EntityFrameworkCore.Triggered;
using GegiCRM.DAL.Concrete;
using GegiCRM.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.DAL.Triggers
{
    public class SoftDeleteTrigger : IBeforeSaveTrigger<IBaseEntity<int>>
    {
        readonly Context _dbContext;
        public SoftDeleteTrigger(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task BeforeSave(ITriggerContext<IBaseEntity<int>> context, CancellationToken cancellationToken)
        {
            if (context.ChangeType == ChangeType.Deleted)
            {
                var entry = _dbContext.Entry(context.Entity);
                context.Entity.IsDeleted = true;
                entry.State = EntityState.Modified;
            }

            await Task.CompletedTask;
        }
    }
}
