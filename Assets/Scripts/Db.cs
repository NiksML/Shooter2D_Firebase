using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;

public class Db : MonoBehaviour
{
    DatabaseReference dbRef;
    
    void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SaveData(string str)
    {
        dbRef.Child("users").SetValueAsync(str);
    }

}
