using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


//moving animation
public abstract class AAnimationManager : MonoBehaviour,IAnimation
{
    public virtual void Tween(){
        LeanTween.moveY(this.gameObject, 9.2f + transform.parent.position.y, 0f);
    }
    
}


//animation on pointer enter
public class Hover : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler{
    public void OnPointerEnter(PointerEventData eventData){
        LeanTween.scale(this.gameObject, Vector3.one * 1.25f, 0f);
    }
    public void OnPointerExit(PointerEventData eventData){
        LeanTween.scale(this.gameObject, Vector3.one, 0f);
    }
}


