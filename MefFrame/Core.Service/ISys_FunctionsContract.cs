//------------------------------------------------------------------------------
// <copyright file="Sys_FunctionsConfiguration.generated.cs">
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
    /// ——Sys_Functions
    /// </summary>    
    public interface ISys_FunctionsContract
    {
       
        //查询数据集
        IQueryable<Sys_Functions> Sys_Functionss { get; }
        //添加
        int Insert(Sys_Functions entity);
        //删除
        int Delete(Expression<Func<Sys_Functions, bool>> predicate);
        //修改
        int Update(Expression<Func<Sys_Functions, bool>> predicate1, Expression<Func<Sys_Functions, Sys_Functions>> predicate2);
       
    }
}
