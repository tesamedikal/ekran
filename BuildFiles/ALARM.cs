//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated {
    using Neo.ApplicationFramework.Controls.Controls;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    using Neo.ApplicationFramework.Tools.Security;
    using Neo.ApplicationFramework.Tools.Actions;
    using Neo.ApplicationFramework.Common.MultiLanguage;
    
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class ALARM : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Alarm.AlarmViewer m_AlarmViewer;
        
        private Neo.ApplicationFramework.Controls.Controls.SymbolViewboxCF m_SymbolViewbox2;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private bool m_Initialized_ALARM;
        
        public ALARM() {
            this.InitializeComponent();
            this.m_SymbolViewbox2.MouseUp += new System.EventHandler(this.m_SymbolViewbox2_Action_PreviewMouseUp);
            this.ApplyLanguageInitialize();
        }
        
        public Neo.ApplicationFramework.Controls.Script.AlarmViewerCFAdapter AlarmViewer {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AlarmViewerCFAdapter>(this.m_AlarmViewer);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter SymbolViewbox2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_SymbolViewbox2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Controls.Logic.AlarmEventFilter alarmeventfilter1 = new Neo.ApplicationFramework.Controls.Logic.AlarmEventFilter();
            Neo.ApplicationFramework.Controls.Logic.AlarmEventFilterGroup alarmeventfiltergroup1 = new Neo.ApplicationFramework.Controls.Logic.AlarmEventFilterGroup();
            Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo alarmcolumninfo1 = new Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo();
            Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo alarmcolumninfo2 = new Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo();
            Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo alarmcolumninfo3 = new Neo.ApplicationFramework.Controls.Logic.AlarmColumnInfo();
            this.m_AlarmViewer = new Neo.ApplicationFramework.Controls.Alarm.AlarmViewer();
            this.m_SymbolViewbox2 = new Neo.ApplicationFramework.Controls.Controls.SymbolViewboxCF();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            ((System.ComponentModel.ISupportInitialize)(this.m_AlarmViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // ALARM
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_AlarmViewer
            // 
            alarmeventfiltergroup1.Enabled = true;
            alarmeventfiltergroup1.Name = "Default";
            alarmeventfiltergroup1.ShowAcknowlegedAlarms = true;
            alarmeventfiltergroup1.ShowActiveAlarms = true;
            alarmeventfiltergroup1.ShowInactiveAlarms = true;
            alarmeventfiltergroup1.ShowNormalAlarms = true;
            alarmeventfilter1.Groups.Add(alarmeventfiltergroup1);
            alarmeventfilter1.MaximumAlarmRows = 100;
            this.m_AlarmViewer.AlarmEventFilter = alarmeventfilter1;
            this.m_AlarmViewer.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.ButtonBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.ButtonHeight = 30;
            this.m_AlarmViewer.ButtonPosition = System.Windows.Forms.AnchorStyles.Top;
            this.m_AlarmViewer.ButtonWidth = 130;
            this.m_AlarmViewer.ColumnHeaderBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(146)))), ((int)(((byte)(214))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.EnabledDynamicsValue = true;
            this.m_AlarmViewer.FilterButtonIsVisible = false;
            this.m_AlarmViewer.FontFamily = "Tahoma";
            this.m_AlarmViewer.FontSizePixels = 18;
            this.m_AlarmViewer.Foreground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.GridBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(183)))), ((int)(((byte)(205))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.Input = false;
            this.m_AlarmViewer.Location = new System.Drawing.Point(3, 16);
            this.m_AlarmViewer.Name = "m_AlarmViewer";
            this.m_AlarmViewer.PauseButtonIsVisible = false;
            this.m_AlarmViewer.ScreenOwnerName = "ALARM";
            this.m_AlarmViewer.SelectedBorderColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AlarmViewer.Size = new System.Drawing.Size(783, 369);
            this.m_AlarmViewer.SummaryRowVisible = false;
            this.m_AlarmViewer.TabIndex = 2147483647;
            alarmcolumninfo1.ColumnWidth = 80D;
            alarmcolumninfo1.HeaderName = "State";
            alarmcolumninfo1.MappingName = "DisplayState";
            alarmcolumninfo2.ColumnWidth = 150D;
            alarmcolumninfo2.HeaderName = "Active Time";
            alarmcolumninfo2.MappingName = "ActiveTime";
            alarmcolumninfo3.ColumnWidth = 570D;
            alarmcolumninfo3.HeaderName = "Text";
            alarmcolumninfo3.MappingName = "DisplayText";
            this.m_AlarmViewer.VisibleColumns = new Neo.ApplicationFramework.Interfaces.IColumnInfo[] {
                    ((Neo.ApplicationFramework.Interfaces.IColumnInfo)(alarmcolumninfo1)),
                    ((Neo.ApplicationFramework.Interfaces.IColumnInfo)(alarmcolumninfo2)),
                    ((Neo.ApplicationFramework.Interfaces.IColumnInfo)(alarmcolumninfo3))};
            this.m_AlarmViewer.VisibleDynamicsValue = true;
            // 
            // m_SymbolViewbox2
            // 
            this.m_SymbolViewbox2.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.White, System.Drawing.Color.White, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_SymbolViewbox2.BlinkDynamicsValue = false;
            this.m_SymbolViewbox2.DelayMouseInputPeriod = 0;
            this.m_SymbolViewbox2.EnabledDynamicsValue = true;
            this.m_SymbolViewbox2.ForceTransparency = false;
            this.m_SymbolViewbox2.Height = 70;
            this.m_SymbolViewbox2.IndicatorMargin = null;
            this.m_SymbolViewbox2.Left = 716;
            this.m_SymbolViewbox2.Name = "m_SymbolViewbox2";
            this.m_SymbolViewbox2.RequiresTransparency = false;
            this.m_SymbolViewbox2.ScreenOwnerName = "ALARM";
            this.m_SymbolViewbox2.Top = 405;
            this.m_SymbolViewbox2.Value = 0D;
            this.m_SymbolViewbox2.VisibleDynamicsValue = true;
            this.m_SymbolViewbox2.Width = 70;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 70;
            this.m_Picture1.Left = 15;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "ALARM";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "12312313121";
            this.m_Picture1.Top = 393;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 216;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "ALARM";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_ALARM = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
        }
        
        protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData() {
            System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
            instanceList.Add(this.CreateInstanceData_Default());
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
            aliasInstances.Instances = instanceList.ToArray();
            return aliasInstances;
        }
        
        private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default() {
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
            aliasinstancecf1.Name = "Default";
            aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
            return aliasinstancecf1;
        }
        
        protected override void BindAliases() {
        }
        
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControlsAndPrimitives() {
            if (!m_Initialized_ALARM) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            this.Controls.Add(this.m_AlarmViewer);
            ((System.ComponentModel.ISupportInitialize)(this.m_AlarmViewer)).EndInit();
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_SymbolViewbox2);
            this.DrawingPrimitives.Add(this.m_Picture1);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
        }
        
        private void m_SymbolViewbox2_Action_PreviewMouseUp(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_SymbolViewbox2", "MouseUp", "Show Screen", "MENU", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.MENU.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(ALARM));
            this.ApplyResourcesOnForm();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected override void ApplyLanguage() {
            if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated) {
                return;
            }
            this.ApplyLanguageInternal();
            base.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ApplyLanguageInitialize() {
            if (!m_Initialized_ALARM) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("IsBlinkEnabled", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.MANUEL"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.BoolDynamicsConverterCF.TrueValueOne);
            this.m_Picture1.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
        }
    }
}
