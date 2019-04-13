using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Console : MonoBehaviour
{
    /// <summary>
    /// LaunchConsole
    /// </summary>
    /// <param name="command">Command</param>
    /// <param name="arg">Option argument</param>
    /// <returns>result</returns>
    static public string LaunchConsole(string command, string arg)
    {
        System.Diagnostics.Process pro = new System.Diagnostics.Process();

        pro.StartInfo.FileName = command;
        pro.StartInfo.Arguments = arg;
        pro.StartInfo.CreateNoWindow = true;
        pro.StartInfo.UseShellExecute = false;
        pro.StartInfo.RedirectStandardOutput = true;
        pro.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("Shift_JIS");
        pro.Start();

        var result = pro.StandardOutput.ReadToEnd();

        Debug.Log(result);

        return result;
    }

    /// <summary>
    /// LaunchConsole
    /// </summary>
    /// <param name="command">Command</param>
    /// <param name="arg">Option argument</param>
    /// /// <param name="encoding">Encoding</param>
    /// <returns>result</returns>
    static public string LaunchConsole(string command, string arg, Encoding encoding)
    {
        System.Diagnostics.Process pro = new System.Diagnostics.Process();

        pro.StartInfo.FileName = command;
        pro.StartInfo.Arguments = arg;
        pro.StartInfo.CreateNoWindow = true;
        pro.StartInfo.UseShellExecute = false;
        pro.StartInfo.RedirectStandardOutput = true;
        pro.StartInfo.StandardOutputEncoding = encoding;
        pro.Start();

        var result = pro.StandardOutput.ReadToEnd();

        Debug.Log(result);

        return result;
    }
}
