using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Inspector_ActivateEventHandler();
	public delegate void Inspector_DeactivateEventHandler();
	public delegate void Inspector_CloseEventHandler();
	public delegate void Inspector_BeforeMaximizeEventHandler(ref bool Cancel);
	public delegate void Inspector_BeforeMinimizeEventHandler(ref bool Cancel);
	public delegate void Inspector_BeforeMoveEventHandler(ref bool Cancel);
	public delegate void Inspector_BeforeSizeEventHandler(ref bool Cancel);
	public delegate void Inspector_PageChangeEventHandler(ref string ActivePageName);
	public delegate void Inspector_AttachmentSelectionChangeEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Inspector 
	/// SupportByVersion Outlook, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Inspector : _Inspector,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		InspectorEvents_SinkHelper _inspectorEvents_SinkHelper;
		InspectorEvents_10_SinkHelper _inspectorEvents_10_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Inspector);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public Inspector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Inspector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Inspector(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Inspector 
        /// </summary>		
		public Inspector():base("Outlook.Inspector")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of Inspector
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public Inspector(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14
		/// </summary>
		private event Inspector_ActivateEventHandler _ActivateEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14)]
		public event Inspector_ActivateEventHandler ActivateEvent
		{
			add
			{
				CreateEventBridge();
				_ActivateEvent += value;
			}
			remove
			{
				_ActivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14
		/// </summary>
		private event Inspector_DeactivateEventHandler _DeactivateEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14)]
		public event Inspector_DeactivateEventHandler DeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_DeactivateEvent += value;
			}
			remove
			{
				_DeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 9,10,11,12,14
		/// </summary>
		private event Inspector_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByVersion Outlook 9 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 9,10,11,12,14)]
		public event Inspector_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Inspector_BeforeMaximizeEventHandler _BeforeMaximizeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Inspector_BeforeMaximizeEventHandler BeforeMaximizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMaximizeEvent += value;
			}
			remove
			{
				_BeforeMaximizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Inspector_BeforeMinimizeEventHandler _BeforeMinimizeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Inspector_BeforeMinimizeEventHandler BeforeMinimizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMinimizeEvent += value;
			}
			remove
			{
				_BeforeMinimizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Inspector_BeforeMoveEventHandler _BeforeMoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Inspector_BeforeMoveEventHandler BeforeMoveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeMoveEvent += value;
			}
			remove
			{
				_BeforeMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14
		/// </summary>
		private event Inspector_BeforeSizeEventHandler _BeforeSizeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14
		/// </summary>
		[SupportByVersion("Outlook", 10,11,12,14)]
		public event Inspector_BeforeSizeEventHandler BeforeSizeEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeSizeEvent += value;
			}
			remove
			{
				_BeforeSizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 12,14
		/// </summary>
		private event Inspector_PageChangeEventHandler _PageChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 12 14
		/// </summary>
		[SupportByVersion("Outlook", 12,14)]
		public event Inspector_PageChangeEventHandler PageChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PageChangeEvent += value;
			}
			remove
			{
				_PageChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 14
		/// </summary>
		private event Inspector_AttachmentSelectionChangeEventHandler _AttachmentSelectionChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 14
		/// </summary>
		[SupportByVersion("Outlook", 14)]
		public event Inspector_AttachmentSelectionChangeEventHandler AttachmentSelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentSelectionChangeEvent += value;
			}
			remove
			{
				_AttachmentSelectionChangeEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, InspectorEvents_SinkHelper.Id,InspectorEvents_10_SinkHelper.Id);


			if(InspectorEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_inspectorEvents_SinkHelper = new InspectorEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(InspectorEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_inspectorEvents_10_SinkHelper = new InspectorEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _inspectorEvents_SinkHelper)
			{
				_inspectorEvents_SinkHelper.Dispose();
				_inspectorEvents_SinkHelper = null;
			}
			if( null != _inspectorEvents_10_SinkHelper)
			{
				_inspectorEvents_10_SinkHelper.Dispose();
				_inspectorEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}