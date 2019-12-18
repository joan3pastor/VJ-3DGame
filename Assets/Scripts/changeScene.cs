using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public int IndexScene;

    public void ChangeScene() {
        Application.LoadLevel(IndexScene);
    }

}
