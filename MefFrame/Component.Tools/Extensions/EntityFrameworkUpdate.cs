using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Component.Tools.Extensions
{
    public static class EntityFrameworkUpdate
    {
        #region 上下文修改方法
        public static void Update<TEntity>(this DbContext dbContext,
            Expression<Func<TEntity, object>> propertyExpression, params TEntity[] entities) where TEntity : class
        {
            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");
            if (entities == null) throw new ArgumentNullException("entities");
            ReadOnlyCollection<MemberInfo> memberInfos = ((dynamic)propertyExpression.Body).Members;
            foreach (TEntity entity in entities)
            {
                try
                {
                    DbEntityEntry<TEntity> entry = dbContext.Entry(entity);
                    dbContext.Configuration.ValidateOnSaveEnabled = false;
                    entry.State = EntityState.Unchanged;
                    foreach (var memberInfo in memberInfos)
                    {
                        entry.Property(memberInfo.Name).IsModified = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion 

    }
}
