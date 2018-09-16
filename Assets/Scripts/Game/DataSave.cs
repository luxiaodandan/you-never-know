using Game;
using Util;
using UnityEngine;

public class DataSave : MonoBehaviour {

    private void SaveScene(SceneInfo sceneInfo) {
        DataManager.Save("sceneInfo", sceneInfo);
    }

    public void SaveScene0()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 0,
            SceneName = "Introduction"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene1() {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 1,
            SceneName = "Scene1"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene2()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 2,
            SceneName = "Scene2"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene3()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 3,
            SceneName = "Scene3"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene4()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 4,
            SceneName = "Scene4"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene5()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 5,
            SceneName = "Scene5"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene6()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 6,
            SceneName = "Scene6"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene7()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 7,
            SceneName = "Scene7"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene8()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 8,
            SceneName = "Scene8"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene9()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 9,
            SceneName = "Scene9"
        };
        SaveScene(sceneInfo);
    }

    public void SaveScene10()
    {
        SceneInfo sceneInfo = new SceneInfo
        {
            SceneId = 10,
            SceneName = "Scene10"
        };
        SaveScene(sceneInfo);
    }
}
