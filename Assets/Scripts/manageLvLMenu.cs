using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class manageLvLMenu : MonoBehaviour
     , IPointerClickHandler
     , IPointerEnterHandler
     , IPointerExitHandler
{

    public int levelSceneIndex;


    void Start()
    {
        Debug.Log("I WORK");
    }

    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
        Application.LoadLevel(levelSceneIndex);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Over");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Out");
    }

}
