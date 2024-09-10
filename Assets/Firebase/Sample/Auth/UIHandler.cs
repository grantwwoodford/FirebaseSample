using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase;
using UnityEngine;

public class FirebaseManager : MonoBehaviour
{
    private static FirebaseManager _instance;

    public static FirebaseManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private FirebaseApp _app;
    
    private void Start()
    {
        CreateFirebaseApp();
    }

    private void CreateFirebaseApp()
    {
        // _app = Firebase.FirebaseApp.DefaultInstance;
        if (_app == null)
        {
            Firebase.FirebaseApp.Create();
        }
        
        // Initialize your database reference here
        _app = Firebase.FirebaseApp.DefaultInstance;

        Debug.Log("FIREBASE INIT FINISHED");
        
        Debug.Log("Firebase initialized successfully");
    }
}