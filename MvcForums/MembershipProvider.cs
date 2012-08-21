using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Text;
using MvcForums.Models;

namespace MvcForums
{
    public class UserMemberProvider : MembershipProvider
    {
        #region Unimplemented MembershipProvider Methods

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

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            throw new NotImplementedException();
        }
      

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { throw new NotImplementedException(); }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresUniqueEmail
        {
            get { throw new NotImplementedException(); }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }
        
        #endregion

       // IUserRepository _repository;

        public UserMemberProvider() 
        {
        }

        /*public AdminMemberProvider(IUserRepository repository) : base()
        {
            _repository = repository ?? UserRepositoryFactory.GetRepository();
        }*/

        public User User
        {
            get;
            private set;
        }
        public User CreateUser(string userName ,string password, string email)
        {
            using (MvcForumsEntities forumEntities = new MvcForumsEntities())
            {
                //Checking if a user with the given name exists..if not create, otherwise return null
                if(forumEntities.User.Where(user => user.UserName == userName).Count() == 0)
                {
                    User newUser = new User(){UserName = userName, Password = password, EmailAddress=email, CreateDate=DateTime.Now};
                    forumEntities.AddToUser(newUser);
                    try
                    {
                        forumEntities.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    return newUser; 
                }
                else
                    return null;

            }
        }
        public override bool ValidateUser(string username, string password)
        {
            if(string.IsNullOrEmpty(password.Trim())) return false;
            
            string hash = EncryptPassword(password);
   
            MvcForumsEntities forumEntities = new MvcForumsEntities();
            User user = forumEntities.User.Single(dbUser => dbUser.UserName == username);
            if (user == null) return false;

            if (user.Password == password)
            {
                User = user;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Procuses an MD5 hash string of the password
        /// </summary>
        /// <param name="password">password to hash</param>
        /// <returns>MD5 Hash string</returns>
        protected string EncryptPassword(string password)
        {
            //we use codepage 1252 because that is what sql server uses
            byte[] pwdBytes = Encoding.GetEncoding(1252).GetBytes(password);
            byte[] hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(pwdBytes);
            return Encoding.GetEncoding(1252).GetString(hashBytes);
        }

    }
}
