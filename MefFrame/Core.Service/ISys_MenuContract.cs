//------------------------------------------------------------------------------
// <copyright file="Sys_MenuConfiguration.generated.cs">
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
    /// ——Sys_Menu
    /// </summary>    
    public interface ISys_MenuContract
    {
       
        //查询数据集
        IQueryable<Sys_Menu> Sys_Menus { get; }
        //添加
        int Insert(Sys_Menu entity);
        //删除
        int Delete(Expression<Func<Sys_Menu, bool>> predicate);
        //修改
        int Update(Expression<Func<Sys_Menu, bool>> predicate1, Expression<Func<Sys_Menu, Sys_Menu>> predicate2);
       
    }
}
