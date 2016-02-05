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

namespace DAL.Entity
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class silkspanEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new silkspanEntities object using the connection string found in the 'silkspanEntities' section of the application configuration file.
        /// </summary>
        public silkspanEntities() : base("name=silkspanEntities", "silkspanEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new silkspanEntities object.
        /// </summary>
        public silkspanEntities(string connectionString) : base(connectionString, "silkspanEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new silkspanEntities object.
        /// </summary>
        public silkspanEntities(EntityConnection connection) : base(connection, "silkspanEntities")
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
        public ObjectSet<TEST_SYSTEM> TEST_SYSTEM
        {
            get
            {
                if ((_TEST_SYSTEM == null))
                {
                    _TEST_SYSTEM = base.CreateObjectSet<TEST_SYSTEM>("TEST_SYSTEM");
                }
                return _TEST_SYSTEM;
            }
        }
        private ObjectSet<TEST_SYSTEM> _TEST_SYSTEM;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TEST_SYSTEM EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTEST_SYSTEM(TEST_SYSTEM tEST_SYSTEM)
        {
            base.AddObject("TEST_SYSTEM", tEST_SYSTEM);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="silkspanModel", Name="TEST_SYSTEM")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TEST_SYSTEM : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TEST_SYSTEM object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static TEST_SYSTEM CreateTEST_SYSTEM(global::System.Int32 id)
        {
            TEST_SYSTEM tEST_SYSTEM = new TEST_SYSTEM();
            tEST_SYSTEM.ID = id;
            return tEST_SYSTEM;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EMAIL
        {
            get
            {
                return _EMAIL;
            }
            set
            {
                OnEMAILChanging(value);
                ReportPropertyChanging("EMAIL");
                _EMAIL = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EMAIL");
                OnEMAILChanged();
            }
        }
        private global::System.String _EMAIL;
        partial void OnEMAILChanging(global::System.String value);
        partial void OnEMAILChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SYSTEM_NAME
        {
            get
            {
                return _SYSTEM_NAME;
            }
            set
            {
                OnSYSTEM_NAMEChanging(value);
                ReportPropertyChanging("SYSTEM_NAME");
                _SYSTEM_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SYSTEM_NAME");
                OnSYSTEM_NAMEChanged();
            }
        }
        private global::System.String _SYSTEM_NAME;
        partial void OnSYSTEM_NAMEChanging(global::System.String value);
        partial void OnSYSTEM_NAMEChanged();

        #endregion
    
    }

    #endregion
    
}
