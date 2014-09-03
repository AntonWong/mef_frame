//------------------------------------------------------------------------------
// <copyright file="TestDataConfiguration.generated.cs">
//        生成时间：2014-09-02 13:50
// </copyright>
//------------------------------------------------------------------------------
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Service;
using Site.Models;

namespace Site.Service
{
    /// <summary>
    /// ——TestData核心业务契约
    /// </summary>    
    public interface ITestDataSiteContract:ITestDataContract
    {
        List<MenuView> Menus();

        int DeleteMenu(int id);

        int AddMenu(MenuView model);
    }
}
