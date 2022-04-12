using System.Diagnostics;

string strCmdText;
strCmdText = "tasklist";
System.Diagnostics.Process.Start("CMD.exe", strCmdText);
string strCmdText1;
string userInput = Console.ReadLine();
strCmdText1 = "taskkill " + userInput;
System.Diagnostics.Process.Start("CMD.exe", strCmdText);