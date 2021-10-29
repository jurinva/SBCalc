using System;

namespace SBCalc
{
  class SBCalcMain
  {
    public static void Main()
    {
      string txtSBK = "";
      string txtCPUID = "";

      // Console.Clear();

      Console.WriteLine("Enter your CPUID: ");
      txtCPUID = Console.ReadLine();

      if ((txtCPUID != null) && (txtCPUID.Length >= 15) && (txtCPUID.Length <= 16))
      {
          string SBKCodeResult = "";
          int l_sbkResult = SBKLibrary.GetEncoder(txtCPUID, ref SBKCodeResult);
          Console.WriteLine(txtCPUID);
          if (SBKCodeResult != null && SBKCodeResult != "")
          {
              char[] rmChar = { '\\', '0' };
              txtSBK = SBKCodeResult.Remove((SBKCodeResult.Length - 1), 1);
              Console.WriteLine(txtSBK);
          }
      }
      else
          Console.WriteLine("Please, check your CPUID.", "CPUID Error");
    }
  }
}
