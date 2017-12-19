//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	using Neo.ApplicationFramework.Tools.Alarm;
	
	
	public partial class AlarmServer : Neo.ApplicationFramework.Tools.Alarm.AlarmServer
	{
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmGroup m_Default;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem0;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem1;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem2;
		
		public AlarmServer()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmGroup Default
		{
			get
			{
				return this.m_Default;
			}
			set
			{
				this.m_Default = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem0
		{
			get
			{
				return this.m_Default_AlarmItem0;
			}
			set
			{
				this.m_Default_AlarmItem0 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem1
		{
			get
			{
				return this.m_Default_AlarmItem1;
			}
			set
			{
				this.m_Default_AlarmItem1 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem2
		{
			get
			{
				return this.m_Default_AlarmItem2;
			}
			set
			{
				this.m_Default_AlarmItem2 = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
			this.Default_AlarmItem2.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.ALARM_3"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem1.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.ALARM_SAFLIK_DUSTU"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem0.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.ALARM_CALISMA_SAATI"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
		}
		
		private void InitializeObjectCreations()
		{
			this.Default = new Neo.ApplicationFramework.Tools.Alarm.AlarmGroup();
			this.Default_AlarmItem0 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem1 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem2 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem2)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem2)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.Default.AcknowledgeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
			this.Default.AcknowledgeForeColor = System.Drawing.Color.Black;
			this.Default.ActiveBackColor = System.Drawing.Color.White;
			this.Default.ActiveForeColor = System.Drawing.Color.Black;
			this.Default_AlarmItem0.AcknowledgeRequired = true;
			this.Default_AlarmItem0.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem0.Contacts = null;
			this.Default_AlarmItem0.DefaultText = "LUTFEN YETKİLİ SERVİS İLE İRTİBATA GEÇİNİZ";
			this.Default_AlarmItem0.DisplayName = "AlarmItem0";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString dynamicstring1 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			dynamicstring1.Text = "LUTFEN YETKİLİ SERVİS İLE İRTİBATA GEÇİNİZ";
			this.Default_AlarmItem0.DynamicString = dynamicstring1;
			this.Default_AlarmItem0.EnableDistribution = false;
			this.Default_AlarmItem0.GroupId = new System.Guid("8fcf519d-1afe-44c3-9509-bd1ad9e7d849");
			this.Default_AlarmItem0.GroupName = "Default";
			this.Default_AlarmItem0.History = true;
			this.Default_AlarmItem0.IsDigitalValue = false;
			this.Default_AlarmItem0.Name = "Default_AlarmItem0";
			this.Default_AlarmItem0.OutputDevices = null;
			this.Default_AlarmItem0.RepeatCount = false;
			this.Default_AlarmItem0.TriggerValue = 1;
			this.Default_AlarmItem1.AcknowledgeRequired = true;
			this.Default_AlarmItem1.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem1.Contacts = null;
			this.Default_AlarmItem1.DefaultText = "SAFLIK  ORANI DÜŞÜK";
			this.Default_AlarmItem1.DisplayName = "AlarmItem1";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString dynamicstring2 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			dynamicstring2.Text = "SAFLIK  ORANI DÜŞÜK";
			this.Default_AlarmItem1.DynamicString = dynamicstring2;
			this.Default_AlarmItem1.EnableDistribution = false;
			this.Default_AlarmItem1.GroupId = new System.Guid("8fcf519d-1afe-44c3-9509-bd1ad9e7d849");
			this.Default_AlarmItem1.GroupName = "Default";
			this.Default_AlarmItem1.History = true;
			this.Default_AlarmItem1.IsDigitalValue = false;
			this.Default_AlarmItem1.Name = "Default_AlarmItem1";
			this.Default_AlarmItem1.OutputDevices = null;
			this.Default_AlarmItem1.RepeatCount = false;
			this.Default_AlarmItem1.TriggerValue = 1;
			this.Default_AlarmItem2.AcknowledgeRequired = true;
			this.Default_AlarmItem2.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem2.Contacts = null;
			this.Default_AlarmItem2.DefaultText = "";
			this.Default_AlarmItem2.DisplayName = "AlarmItem2";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString dynamicstring3 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			dynamicstring3.Text = "";
			this.Default_AlarmItem2.DynamicString = dynamicstring3;
			this.Default_AlarmItem2.EnableDistribution = false;
			this.Default_AlarmItem2.GroupId = new System.Guid("8fcf519d-1afe-44c3-9509-bd1ad9e7d849");
			this.Default_AlarmItem2.GroupName = "Default";
			this.Default_AlarmItem2.History = true;
			this.Default_AlarmItem2.IsDigitalValue = false;
			this.Default_AlarmItem2.Name = "Default_AlarmItem2";
			this.Default_AlarmItem2.OutputDevices = null;
			this.Default_AlarmItem2.RepeatCount = false;
			this.Default_AlarmItem2.TriggerValue = 1;
			this.Default.AlarmItems.Add(this.Default_AlarmItem0);
			this.Default.AlarmItems.Add(this.Default_AlarmItem1);
			this.Default.AlarmItems.Add(this.Default_AlarmItem2);
			this.Default.EnableDistribution = false;
			this.Default.InactiveBackColor = System.Drawing.Color.White;
			this.Default.InactiveForeColor = System.Drawing.Color.Black;
			this.Default.Name = "Default";
			this.Default.NormalBackColor = System.Drawing.Color.White;
			this.Default.NormalForeColor = System.Drawing.Color.Black;
			this.AlarmGroups.Add(this.Default);
			this.MaxNumberOfAlarms = 1000;
			this.StorageEvent.AcknowledgeTime = null;
			this.StorageEvent.ActiveTime = null;
			this.StorageEvent.AlarmGroupName = "";
			this.StorageEvent.AlarmGroupText = "";
			this.StorageEvent.AlarmItemId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.StorageEvent.Count = 0;
			this.StorageEvent.DisplayText = "";
			this.StorageEvent.EnableDistribution = false;
			this.StorageEvent.ForceToList = false;
			this.StorageEvent.History = false;
			this.StorageEvent.InActiveTime = null;
			this.StorageEvent.NormalTime = null;
			this.StorageEvent.RepeatCount = false;
			this.StorageEvent.State = Neo.ApplicationFramework.Interfaces.AlarmState.Normal;
			this.StorageEvent.TableName = "AlarmServer";
			this.StorageEvent.Text = "";
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(AlarmServer));
			this.m_Default.Text = resources.GetText("AlarmServer.Default.Text", "Default");
			this.m_Default_AlarmItem0.StaticText = resources.GetText("AlarmServer.Default_AlarmItem0.StaticText", "LUTFEN YETKİLİ SERVİS İLE İRTİBATA GEÇİNİZ");
			this.m_Default_AlarmItem1.StaticText = resources.GetText("AlarmServer.Default_AlarmItem1.StaticText", "SAFLIK  ORANI DÜŞÜK");
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
