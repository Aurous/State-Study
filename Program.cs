// Decompiled with JetBrains decompiler
// Type: States.Program
// Assembly: States, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C74381C-CBF5-4AC0-8AA2-5CE9B24B8599
// Assembly location: C:\Users\ltrya\Documents\GitHub\States.exe

using System;
using System.Windows.Forms;

namespace States
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
