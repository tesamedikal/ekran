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
    public partial class O2_AKIS_GIRAFIGI : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Trend.TrendViewerCF m_TrendViewer;
        
        private Neo.ApplicationFramework.Controls.Controls.RectangleCF m_Rectangle;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private bool m_Initialized_O2_AKIS_GIRAFIGI;
        
        public O2_AKIS_GIRAFIGI() {
            this.InitializeComponent();
            this.m_Picture.MouseDown += new System.EventHandler(this.m_Picture_Action_MouseDown);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        public Neo.ApplicationFramework.Controls.Script.TrendCFAdapterBase TrendViewer {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TrendCFAdapterBase>(this.m_TrendViewer);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter Rectangle {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter>(this.m_Rectangle);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Controls.Trend.CurveCF curvecf1 = new Neo.ApplicationFramework.Controls.Trend.CurveCF();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_TrendViewer = new Neo.ApplicationFramework.Controls.Trend.TrendViewerCF();
            this.m_Rectangle = new Neo.ApplicationFramework.Controls.Controls.RectangleCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_TrendViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // O2_AKIS_GIRAFIGI
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 60;
            this.m_Picture.Left = 603;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "O2_AKIS_GIRAFIGI";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "12312313121";
            this.m_Picture.Top = 418;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 154;
            // 
            // m_TrendViewer
            // 
            this.m_TrendViewer.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_TrendViewer.BlinkDynamicsValue = false;
            curvecf1.BlinkDynamicsValue = false;
            curvecf1.Color = System.Drawing.Color.Red;
            curvecf1.DataSourceName = "Tags.AKIS_DEGERI";
            curvecf1.DelayMouseInputPeriod = 0;
            curvecf1.DisplayName = "Curve";
            curvecf1.EnabledDynamicsValue = true;
            curvecf1.Height = 307;
            curvecf1.ScreenOwnerName = null;
            curvecf1.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.Red, System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            curvecf1.VisibleDynamicsValue = true;
            curvecf1.Width = 624;
            this.m_TrendViewer.Curves.Add(curvecf1);
            this.m_TrendViewer.DelayMouseInputPeriod = 0;
            this.m_TrendViewer.EnabledDynamicsValue = true;
            this.m_TrendViewer.FontSizePixels = 11;
            this.m_TrendViewer.ForceTransparency = false;
            this.m_TrendViewer.Foreground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_TrendViewer.GridLineColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_TrendViewer.Height = 402;
            this.m_TrendViewer.IndicatorMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(72.346666666666664D, 28.541999999999973D, 72.346666666666692D, 66.48599999999999D);
            this.m_TrendViewer.Left = 15;
            this.m_TrendViewer.Name = "m_TrendViewer";
            this.m_TrendViewer.RequiresTransparency = false;
            this.m_TrendViewer.ScaleColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_TrendViewer.ScreenOwnerName = "O2_AKIS_GIRAFIGI";
            this.m_TrendViewer.TimeOffset = System.TimeSpan.Parse("00:00:00");
            this.m_TrendViewer.TimeRange = System.TimeSpan.Parse("00:04:00");
            this.m_TrendViewer.TimeScaleMajorTickCount = 1;
            this.m_TrendViewer.TimeScaleMaximum = 39083.5D;
            this.m_TrendViewer.TimeScaleMinimum = 39083.49722222222D;
            this.m_TrendViewer.TimeTextScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(72.346666666666664D, 344.514D, 72.346666666666692D, 0D);
            this.m_TrendViewer.Top = 9;
            this.m_TrendViewer.Value = 0D;
            this.m_TrendViewer.ValueMajorScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(52.346666666666671D, 28.541999999999973D, 706.65333333333331D, 66.48599999999999D);
            this.m_TrendViewer.ValueMajorScaleMaxMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(706.65333333333331D, 28.541999999999973D, 52.346666666666692D, 66.48599999999999D);
            this.m_TrendViewer.ValueMinorScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(54.846666666666671D, 28.541999999999973D, 709.15333333333331D, 66.48599999999999D);
            this.m_TrendViewer.ValueMinorScaleMaxMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(709.15333333333331D, 28.541999999999973D, 54.846666666666692D, 66.48599999999999D);
            this.m_TrendViewer.ValueScaleMajorTickCount = 26;
            this.m_TrendViewer.ValueScaleMaximum = 2500D;
            this.m_TrendViewer.ValueScaleMinimum = 9.8D;
            this.m_TrendViewer.ValueScaleMinorTickCount = 4;
            this.m_TrendViewer.ValueTextScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(15D, 28.541999999999973D, 720.65333333333331D, 66.48599999999999D);
            this.m_TrendViewer.ValueTextScaleMaxMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(720.65333333333331D, 28.541999999999973D, 15D, 66.48599999999999D);
            this.m_TrendViewer.VisibleDynamicsValue = true;
            this.m_TrendViewer.Width = 769;
            // 
            // m_Rectangle
            // 
            this.m_Rectangle.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF();
            this.m_Rectangle.BlinkDynamicsValue = false;
            this.m_Rectangle.DelayMouseInputPeriod = 0;
            this.m_Rectangle.EnabledDynamicsValue = true;
            this.m_Rectangle.Fill = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle.Height = 15;
            this.m_Rectangle.Left = 48;
            this.m_Rectangle.Name = "m_Rectangle";
            this.m_Rectangle.ScreenOwnerName = "O2_AKIS_GIRAFIGI";
            this.m_Rectangle.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle.Top = 431;
            this.m_Rectangle.VisibleDynamicsValue = true;
            this.m_Rectangle.Width = 15;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 12;
            this.m_Text.Height = 21;
            this.m_Text.Left = 71;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "O2_AKIS_GIRAFIGI";
            this.m_Text.Top = 428;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 77;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "O2_AKIS_GIRAFIGI";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_O2_AKIS_GIRAFIGI = true;
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
            if (!m_Initialized_O2_AKIS_GIRAFIGI) {
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
            this.DrawingPrimitives.Add(this.m_TrendViewer);
            this.DrawingPrimitives.Add(this.m_Rectangle);
            this.DrawingPrimitives.Add(this.m_Text);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_TrendViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
        }
        
        private void m_Picture_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture", "MouseDown", "Show Screen", "MENU", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.MENU.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(O2_AKIS_GIRAFIGI));
            this.m_Text.Text = resources.GetText("O2_AKIS_GIRAFIGI.Text.Text", "OKSİJEN AKIŞ");
            this.m_TrendViewer.Curves[0].DisplayName = resources.GetText("O2_AKIS_GIRAFIGI.TrendViewer.Curves[0].DisplayName", "Curve");
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
            if (!m_Initialized_O2_AKIS_GIRAFIGI) {
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