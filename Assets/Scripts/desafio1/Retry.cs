﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    
    public void repetirFase() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
       
    }
}
