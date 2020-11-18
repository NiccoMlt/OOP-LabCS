// <copyright file="Program.cs" company="Unibo">
// Copyright (c) Unibo. All rights reserved.
// </copyright>

namespace Unibo.ISI.ProgramazioneAdOggetti.Esercitazioni
{
    using System;
    using System.Windows.Forms;

    static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
