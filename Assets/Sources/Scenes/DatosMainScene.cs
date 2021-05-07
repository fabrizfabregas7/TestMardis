using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosMainScene : MonoBehaviour
{
    // Start is called before the first frame update
    
     public static string inputPlaca;
     public static string inputFecha;
     public static string inputHora;
    public void ReadPlaca(string a)
    {
        inputPlaca = a;
        Debug.Log(inputPlaca);
    }
    public void ReadFecha(string b)
    {
        inputFecha = b;
        Debug.Log(inputFecha);
    }
    public void ReadHora(string c)
    {
        inputHora = c;
        Debug.Log(inputHora);
    }
}
