using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using MvcForums.Models;

namespace MvcForums
{
    public class AdminRoleProvider : RoleProvider
    {
        MvcForumsEntities _repository;
        public AdminRoleProvider()
        {
            _repository = new MvcForumsEntities();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            User user = _repository.User.Single(dbUser => dbUser.UserName == username);

            if (user != null)
            {
                return user.Role1.role1 == roleName;
            }
            else
                return false;
        }
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }
        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        //This needs to be refactored
        public override string[] GetRolesForUser(string username)
        {
            User user = _repository.User.Single(dbUser => dbUser.UserName == username);
            string[] roles = new string[1];
            roles[0] = user.Role1.role1;
            return roles;
        }
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();

        }
        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();

        }
    }
}
