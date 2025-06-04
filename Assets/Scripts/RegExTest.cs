using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class RegExTest : MonoBehaviour
{

    public static bool IsValidEmail(string input)
    {
        return Regex.IsMatch(input, @"^[\w.-]+@[\w.-]+\.\w{2,}$");
    }
    public static bool IsNumeric(string input)
    {
        return Regex.IsMatch(input, @"^\d+$");
    }

    public static bool IsValidUsername(string input)
    {
        return Regex.IsMatch(input, @"^[a-zA-Z0-9]{3,15}$");
    }

    public static bool IsHexColor(string input)
    {
        return Regex.IsMatch(input, @"^#([A-Fa-f0-9]{6})$");
    }

    public static bool ContainsUnityWord(string input)
    {
        return Regex.IsMatch(input, @"\bUnity\b", RegexOptions.IgnoreCase);
    }
}

