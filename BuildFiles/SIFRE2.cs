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
    public partial class SIFRE2 : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button14;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private bool m_Initialized_SIFRE2;
        
        public SIFRE2() {
            this.InitializeComponent();
            this.m_Button14.Click += new System.EventHandler(this.m_Button14_Action_Click);
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button14 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button14);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Button14 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // SIFRE2
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(107)))), ((int)(((byte)(183))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 100;
            this.m_Picture.Left = 168;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "SIFRE2";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "log in (1)";
            this.m_Picture.Top = 114;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 94;
            // 
            // m_Button14
            // 
            this.m_Button14.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button14.BlinkDynamicsValue = false;
            this.m_Button14.Bold = true;
            this.m_Button14.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button14.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button14.DelayMouseInputPeriod = 0;
            this.m_Button14.EnabledDynamicsValue = true;
            this.m_Button14.FontSizePixels = 20;
            this.m_Button14.ForceTransparency = true;
            this.m_Button14.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button14.Height = 60;
            this.m_Button14.ImageHorizontalAlignment = "Left";
            this.m_Button14.ImageMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(4D, 4D, 4D, 4D);
            this.m_Button14.ImageStretch = true;
            this.m_Button14.IndicatorMargin = null;
            this.m_Button14.Left = 13;
            this.m_Button14.Name = "m_Button14";
            this.m_Button14.RequiresTransparency = true;
            this.m_Button14.ScreenOwnerName = "SIFRE2";
            this.m_Button14.StyleName = "Glossy";
            this.m_Button14.SymbolHeight = 50;
            this.m_Button14.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button14.SymbolName = "log in";
            this.m_Button14.SymbolWidth = 50;
            this.m_Button14.TextHeight = 24;
            this.m_Button14.TextMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(47D, 2D, 2D, 2D);
            this.m_Button14.TextValue = 0D;
            this.m_Button14.TextWidth = 319;
            this.m_Button14.Top = 40;
            this.m_Button14.Value = 0D;
            this.m_Button14.VisibleDynamicsValue = true;
            this.m_Button14.VisualPropertiesHashCode = 398040145;
            this.m_Button14.Width = 370;
            // 
            // m_Button
            // 
            this.m_Button.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.Bold = true;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button.DelayMouseInputPeriod = 0;
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontSizePixels = 20;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button.Height = 60;
            this.m_Button.ImageHorizontalAlignment = "Left";
            this.m_Button.ImageMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(4D, 4D, 4D, 4D);
            this.m_Button.ImageStretch = true;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 78;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "SIFRE2";
            this.m_Button.StyleName = "Glossy";
            this.m_Button.SymbolHeight = 50;
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button.SymbolName = "home";
            this.m_Button.SymbolWidth = 50;
            this.m_Button.TextHeight = 24;
            this.m_Button.TextMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(47D, 2D, 2D, 2D);
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 199;
            this.m_Button.Top = 134;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = -790725411;
            this.m_Button.Width = 250;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.IsCacheable = false;
            this.Location = new System.Drawing.Point(200, 120);
            this.ModalScreen = true;
            this.Name = "SIFRE2";
            this.PopupScreen = true;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "Default";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_SIFRE2 = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Button, SecurityGroups.Group_03);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Button, VisibilityModes.Hidden);
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
            if (!m_Initialized_SIFRE2) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Button14);
            this.DrawingPrimitives.Add(this.m_Button);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
        }
        
        private void m_Button14_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button14", "Click", "Login", "Security", "");
            Neo.ApplicationFramework.Generated.Globals.Security.Login();
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Show Screen", "AYARLAR", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.AYARLAR.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(SIFRE2));
            this.m_Button14.Text = resources.GetText("SIFRE2.Button14.Text", "TEKNİK SERVİS GİRİŞ");
            this.m_Button.Text = resources.GetText("SIFRE2.Button.Text", "AYARLAR");
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
            if (!m_Initialized_SIFRE2) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
        }
    }
}