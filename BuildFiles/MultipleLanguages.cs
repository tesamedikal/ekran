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
	
	
	public partial class MultipleLanguages : Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageServer
	{
		
		public MultipleLanguages()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
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
		}
		
		private void InitializeObjectCreations()
		{
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo languageinfo1 = new Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo();
			languageinfo1.Index = 1;
			languageinfo1.IsPublic = true;
			languageinfo1.KeyboardLayoutName = "US";
			languageinfo1.Name = "Turkish (Turkey)";
			languageinfo1.UseInRuntime = true;
			languageinfo1.WordWrapAdjust = false;
			this.Languages.Add(languageinfo1);
			Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo languageinfo2 = new Neo.ApplicationFramework.Tools.MultiLanguage.LanguageInfo();
			languageinfo2.Index = 2;
			languageinfo2.IsPublic = true;
			languageinfo2.KeyboardLayoutName = "US";
			languageinfo2.Name = "English (United Kingdom)";
			languageinfo2.UseInRuntime = true;
			languageinfo2.WordWrapAdjust = false;
			this.Languages.Add(languageinfo2);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(MultipleLanguages));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}