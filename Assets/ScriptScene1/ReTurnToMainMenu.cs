using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ReTurnToMainMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void ReturnScene0(){
        SceneManager.LoadScene(0);
    }
    
    //buttong animation
    public void OnPointerEnter(PointerEventData eventData){
        LeanTween.scale(this.gameObject, Vector3.one * 1.25f, 0f);
    }
    public void OnPointerExit(PointerEventData eventData){
        LeanTween.scale(this.gameObject, Vector3.one, 0f);
    }
}
