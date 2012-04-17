using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SharedWorkspaceLinks 
	/// SupportByVersion Office, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SharedWorkspaceLinks : _IMsoDispObj ,IEnumerable<NetOffice.OfficeApi.SharedWorkspaceLink>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SharedWorkspaceLinks);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceLinks(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceLinks(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceLinks(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceLinks() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SharedWorkspaceLinks(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Office", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.SharedWorkspaceLink this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceLink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SharedWorkspaceLink.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceLink;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public bool ItemCountExceeded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemCountExceeded", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="uRL">string URL</param>
		/// <param name="description">optional object Description</param>
		/// <param name="notes">optional object Notes</param>
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceLink Add(string uRL, object description, object notes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(uRL, description, notes);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceLink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceLink.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceLink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="uRL">string URL</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceLink Add(string uRL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(uRL);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceLink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceLink.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceLink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 11, 12, 14
		/// </summary>
		/// <param name="uRL">string URL</param>
		/// <param name="description">optional object Description</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 11,12,14)]
		public NetOffice.OfficeApi.SharedWorkspaceLink Add(string uRL, object description)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(uRL, description);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.SharedWorkspaceLink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.SharedWorkspaceLink.LateBindingApiWrapperType) as NetOffice.OfficeApi.SharedWorkspaceLink;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.OfficeApi.SharedWorkspaceLink> Member
        
        /// <summary>
		/// SupportByVersionAttribute Office, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
       public IEnumerator<NetOffice.OfficeApi.SharedWorkspaceLink> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OfficeApi.SharedWorkspaceLink item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Office, 11,12,14
		/// </summary>
		[SupportByVersionAttribute("Office", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}