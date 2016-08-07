// Decompiled with JetBrains decompiler
// Type: States.Properties.Settings
// Assembly: States, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C74381C-CBF5-4AC0-8AA2-5CE9B24B8599
// Assembly location: C:\Users\ltrya\Documents\GitHub\States.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace States.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        return Settings.defaultInstance;
      }
    }
  }
}
