// Decompiled with JetBrains decompiler
// Type: States.Properties.Resources
// Assembly: States, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C74381C-CBF5-4AC0-8AA2-5CE9B24B8599
// Assembly location: C:\Users\ltrya\Documents\GitHub\States.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace States.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (States.Properties.Resources.resourceMan == null)
          States.Properties.Resources.resourceMan = new ResourceManager("States.Properties.Resources", typeof (States.Properties.Resources).Assembly);
        return States.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return States.Properties.Resources.resourceCulture;
      }
      set
      {
        States.Properties.Resources.resourceCulture = value;
      }
    }

    internal Resources()
    {
    }
  }
}
