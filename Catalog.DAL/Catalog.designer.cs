﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalog.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Catalog")]
	public partial class CatalogDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertFeedback(Feedback instance);
    partial void UpdateFeedback(Feedback instance);
    partial void DeleteFeedback(Feedback instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public CatalogDataContext() : 
				base(global::Catalog.DAL.Properties.Settings.Default.CatalogConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CatalogDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Feedback> Feedbacks
		{
			get
			{
				return this.GetTable<Feedback>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<int> _ParentId;
		
		private EntitySet<Category> _Categories;
		
		private EntitySet<Product> _Products;
		
		private EntityRef<Category> _Category1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnParentIdChanging(System.Nullable<int> value);
    partial void OnParentIdChanged();
    #endregion
		
		public Category()
		{
			this._Categories = new EntitySet<Category>(new Action<Category>(this.attach_Categories), new Action<Category>(this.detach_Categories));
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			this._Category1 = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(200)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentId", DbType="Int")]
		public System.Nullable<int> ParentId
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					if (this._Category1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentIdChanging(value);
					this.SendPropertyChanging();
					this._ParentId = value;
					this.SendPropertyChanged("ParentId");
					this.OnParentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Category", Storage="_Categories", ThisKey="Id", OtherKey="ParentId")]
		public EntitySet<Category> Categories
		{
			get
			{
				return this._Categories;
			}
			set
			{
				this._Categories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="Id", OtherKey="CategoryID")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Category", Storage="_Category1", ThisKey="ParentId", OtherKey="Id", IsForeignKey=true)]
		public Category Category1
		{
			get
			{
				return this._Category1.Entity;
			}
			set
			{
				Category previousValue = this._Category1.Entity;
				if (((previousValue != value) 
							|| (this._Category1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category1.Entity = null;
						previousValue.Categories.Remove(this);
					}
					this._Category1.Entity = value;
					if ((value != null))
					{
						value.Categories.Add(this);
						this._ParentId = value.Id;
					}
					else
					{
						this._ParentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Category1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = this;
		}
		
		private void detach_Categories(Category entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = null;
		}
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Feedbacks")]
	public partial class Feedback : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private byte _Vote;
		
		private System.DateTime _Date;
		
		private System.Nullable<int> _UserId;
		
		private string _Text;
		
		private int _ProductId;
		
		private EntityRef<Product> _Product;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnVoteChanging(byte value);
    partial void OnVoteChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    #endregion
		
		public Feedback()
		{
			this._Product = default(EntityRef<Product>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vote", DbType="TinyInt NOT NULL")]
		public byte Vote
		{
			get
			{
				return this._Vote;
			}
			set
			{
				if ((this._Vote != value))
				{
					this.OnVoteChanging(value);
					this.SendPropertyChanging();
					this._Vote = value;
					this.SendPropertyChanged("Vote");
					this.OnVoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Feedback", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Feedbacks.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Feedbacks.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Feedback", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Feedbacks.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Feedbacks.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _ShortDescription;
		
		private string _LongDescription;
		
		private int _CategoryID;
		
		private string _ImagePath;
		
		private EntitySet<Feedback> _Feedbacks;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnShortDescriptionChanging(string value);
    partial void OnShortDescriptionChanged();
    partial void OnLongDescriptionChanging(string value);
    partial void OnLongDescriptionChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnImagePathChanging(string value);
    partial void OnImagePathChanged();
    #endregion
		
		public Product()
		{
			this._Feedbacks = new EntitySet<Feedback>(new Action<Feedback>(this.attach_Feedbacks), new Action<Feedback>(this.detach_Feedbacks));
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortDescription", DbType="NVarChar(500)")]
		public string ShortDescription
		{
			get
			{
				return this._ShortDescription;
			}
			set
			{
				if ((this._ShortDescription != value))
				{
					this.OnShortDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ShortDescription = value;
					this.SendPropertyChanged("ShortDescription");
					this.OnShortDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LongDescription", DbType="NVarChar(MAX)")]
		public string LongDescription
		{
			get
			{
				return this._LongDescription;
			}
			set
			{
				if ((this._LongDescription != value))
				{
					this.OnLongDescriptionChanging(value);
					this.SendPropertyChanging();
					this._LongDescription = value;
					this.SendPropertyChanged("LongDescription");
					this.OnLongDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL")]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="NVarChar(1000)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this.OnImagePathChanging(value);
					this.SendPropertyChanging();
					this._ImagePath = value;
					this.SendPropertyChanged("ImagePath");
					this.OnImagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Feedback", Storage="_Feedbacks", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<Feedback> Feedbacks
		{
			get
			{
				return this._Feedbacks;
			}
			set
			{
				this._Feedbacks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category", ThisKey="CategoryID", OtherKey="Id", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._CategoryID = value.Id;
					}
					else
					{
						this._CategoryID = default(int);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Feedbacks(Feedback entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Feedbacks(Feedback entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _Password;
		
		private byte _Role;
		
		private EntitySet<Feedback> _Feedbacks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(byte value);
    partial void OnRoleChanged();
    #endregion
		
		public User()
		{
			this._Feedbacks = new EntitySet<Feedback>(new Action<Feedback>(this.attach_Feedbacks), new Action<Feedback>(this.detach_Feedbacks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="TinyInt NOT NULL")]
		public byte Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Feedback", Storage="_Feedbacks", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Feedback> Feedbacks
		{
			get
			{
				return this._Feedbacks;
			}
			set
			{
				this._Feedbacks.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Feedbacks(Feedback entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Feedbacks(Feedback entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
