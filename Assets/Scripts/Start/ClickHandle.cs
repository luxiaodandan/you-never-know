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
        // initial scene info
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 1,
            SceneName = "GameStart"
        };

        UserInfo player = new UserInfo
        {
            Satisfy = 50,
            Money = 2000,
            GirlSatisf = 50,
            Progress = sceneInfo
        };

        //DataManager.Save("userInfo", player);
    }

    public void StartClick()
    {
        //Debug.Log(DataManager.Get<UserInfo>("userInfo"));
        SceneManager.LoadScene("Introduction");
    }
}