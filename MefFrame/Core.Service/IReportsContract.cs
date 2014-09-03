//------------------------------------------------------------------------------
// <copyright file="ReportsConfiguration.generated.cs">
//        生成时间：2014-09-02 13:50
// </copyright>
//------------------------------------------------------------------------------
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Component.Data;

namespace Core.Service
{
    /// <summary>
    /// ——Reports
    /// </summary>    
    public interface IReportsContract
    {
       
        //查询数据集
        IQueryable<Reports> Reportss { get; }
        //添加
        int Insert(Reports entity);
        //删除
        int Delete(Expression<Func<Reports, bool>> predicate);
        //修改
        int Update(Expression<Func<Reports, bool>> predicate1, Expression<Func<Reports, Reports>> predicate2);
       
    }
}
