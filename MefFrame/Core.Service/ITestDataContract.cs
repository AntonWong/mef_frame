//------------------------------------------------------------------------------
// <copyright file="TestDataConfiguration.generated.cs">
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
    /// ——TestData
    /// </summary>    
    public interface ITestDataContract
    {
       
        //查询数据集
        IQueryable<TestData> TestDatas { get; }
        //添加
        int Insert(TestData entity);
        //删除
        int Delete(Expression<Func<TestData, bool>> predicate);
        //修改
        int Update(Expression<Func<TestData, bool>> predicate1, Expression<Func<TestData, TestData>> predicate2);
       
    }
}
