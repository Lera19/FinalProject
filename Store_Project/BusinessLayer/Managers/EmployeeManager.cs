using BusinessLayer.Interfaces;
using DAL.Model;
using DAL.Utils;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class EmployeeManager : UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store) { }

        public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options, IOwinContext context)
        {
            StoreContext db = context.Get<StoreContext>();
            EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));

            return manager;
        }
    }
}
