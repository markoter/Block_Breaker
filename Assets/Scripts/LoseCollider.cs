﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{
    
    public void LoadGameOverScene()
    {
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        SceneManager.LoadScene(lastSceneIndex);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadGameOverScene();
    }
}
