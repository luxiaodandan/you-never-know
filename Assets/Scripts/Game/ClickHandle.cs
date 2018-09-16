﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Util;
using Config;
using Game;

public class ClickHandle : MonoBehaviour
{

    public void Start()
    {
        SceneInfo sceneInfo = DataManager.Get<SceneInfo>("sceneInfo");
        Button continueBtn = GameObject.Find("ContinueButton").GetComponent<Button>();
        if(sceneInfo == null){
            Debug.Log("First Enter Game");
            continueBtn.interactable = false;
        } else {
            continueBtn.interactable = true;
        }
        // initial scene info
        //SceneInfo sceneInfo = new SceneInfo
        //{
        //    SceneId = 1,
        //    SceneName = "GameStart"
        //};

        //UserInfo player = new UserInfo
        //{
        //    Satisfy = 50,
        //    Money = 2000,
        //    GirlSatisf = 50,
        //    Progress = sceneInfo
        //};

        //DataManager.Save("userInfo", player);
    }

    public void StartClick()
    {
        Debug.Log("Click Start Button.");
        SceneManager.LoadScene("Introduction");
    }

    public void ContinueClick()
    {
        SceneInfo historyScene = DataManager.Get<SceneInfo>("sceneInfo"); 
        if(historyScene != null) {
            Debug.Log("History Scene Name: " + historyScene.SceneName);
            SceneManager.LoadScene(historyScene.SceneName);
        }
    }
}