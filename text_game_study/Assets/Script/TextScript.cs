using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text ScriptTxt;

    string[] reading = new string[4] {"2021-02-03", "haneul", "haha", " "};
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; reading[i] != " " || i == reading.Length ; i++){
            ScriptTxt.text += reading[i];
            ScriptTxt.text += "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
