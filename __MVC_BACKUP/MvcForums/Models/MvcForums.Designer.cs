﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MvcForums.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MvcForumsEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MvcForumsEntities object using the connection string found in the 'MvcForumsEntities' section of the application configuration file.
        /// </summary>
        public MvcForumsEntities() : base("name=MvcForumsEntities", "MvcForumsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcForumsEntities object.
        /// </summary>
        public MvcForumsEntities(string connectionString) : base(connectionString, "MvcForumsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcForumsEntities object.
        /// </summary>
        public MvcForumsEntities(EntityConnection connection) : base(connection, "MvcForumsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcForumsModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userID">Initial value of the UserID property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        public static User CreateUser(global::System.Int32 userID, global::System.String userName, global::System.String password, global::System.String emailAddress, global::System.DateTime createDate)
        {
            User user = new User();
            user.UserID = userID;
            user.UserName = userName;
            user.Password = password;
            user.EmailAddress = emailAddress;
            user.CreateDate = createDate;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                if (_UserID != value)
                {
                    OnUserIDChanging(value);
                    ReportPropertyChanging("UserID");
                    _UserID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserID");
                    OnUserIDChanged();
                }
            }
        }
        private global::System.Int32 _UserID;
        partial void OnUserIDChanging(global::System.Int32 value);
        partial void OnUserIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                if (_UserName != value)
                {
                    OnUserNameChanging(value);
                    ReportPropertyChanging("UserName");
                    _UserName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("UserName");
                    OnUserNameChanged();
                }
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                if (_Password != value)
                {
                    OnPasswordChanging(value);
                    ReportPropertyChanging("Password");
                    _Password = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Password");
                    OnPasswordChanged();
                }
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                if (_EmailAddress != value)
                {
                    OnEmailAddressChanging(value);
                    ReportPropertyChanging("EmailAddress");
                    _EmailAddress = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("EmailAddress");
                    OnEmailAddressChanged();
                }
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                if (_CreateDate != value)
                {
                    OnCreateDateChanging(value);
                    ReportPropertyChanging("CreateDate");
                    _CreateDate = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CreateDate");
                    OnCreateDateChanged();
                }
            }
        }
        private global::System.DateTime _CreateDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        #endregion
    
    }

    #endregion
    
}