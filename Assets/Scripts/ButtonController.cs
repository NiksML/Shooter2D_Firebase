using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public InputField input;
    private Db db;
    void Start()
    {
        db = GetComponent<Db>();
    }

    
    public void ClickButton()
    {
        db.SaveData(input.text);
    }
}
