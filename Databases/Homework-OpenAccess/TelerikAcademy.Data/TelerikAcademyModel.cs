﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using TelerikAcademy.Data;

namespace TelerikAcademy.Data	
{
	public partial class TelerikAcademyModels : OpenAccessContext, ITelerikAcademyModelsUnitOfWork
	{
		private static string connectionStringName = @"TelerikAcademyConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("TelerikAcademyModel.rlinq");
		
		public TelerikAcademyModels()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public TelerikAcademyModels(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public TelerikAcademyModels(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public TelerikAcademyModels(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public TelerikAcademyModels(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<User> Users 
		{
			get
			{
				return this.GetAll<User>();
			}
		}
		
		public IQueryable<Town> Towns 
		{
			get
			{
				return this.GetAll<Town>();
			}
		}
		
		public IQueryable<Project> Projects 
		{
			get
			{
				return this.GetAll<Project>();
			}
		}
		
		public IQueryable<Group> Groups 
		{
			get
			{
				return this.GetAll<Group>();
			}
		}
		
		public IQueryable<Employee> Employees 
		{
			get
			{
				return this.GetAll<Employee>();
			}
		}
		
		public IQueryable<Department> Departments 
		{
			get
			{
				return this.GetAll<Department>();
			}
		}
		
		public IQueryable<Address> Addresses 
		{
			get
			{
				return this.GetAll<Address>();
			}
		}
		
		public IQueryable<OpenAccessDemoEntity> OpenAccessDemoEntities 
		{
			get
			{
				return this.GetAll<OpenAccessDemoEntity>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			return backend;
		}
	}
	
	public interface ITelerikAcademyModelsUnitOfWork : IUnitOfWork
	{
		IQueryable<User> Users
		{
			get;
		}
		IQueryable<Town> Towns
		{
			get;
		}
		IQueryable<Project> Projects
		{
			get;
		}
		IQueryable<Group> Groups
		{
			get;
		}
		IQueryable<Employee> Employees
		{
			get;
		}
		IQueryable<Department> Departments
		{
			get;
		}
		IQueryable<Address> Addresses
		{
			get;
		}
		IQueryable<OpenAccessDemoEntity> OpenAccessDemoEntities
		{
			get;
		}
	}
}
#pragma warning restore 1591