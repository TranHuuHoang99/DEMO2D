using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : Hover
{
    [SerializeField] private List<GameObject> allFonts;
    [SerializeField] private List<GameObject> allButtons;

    private void Start(){
        FontAnimation();
        ButtonAnimation();
    }

    //attach animation font to fonts
    private void FontAnimation(){
        foreach(var allFont in allFonts){
            var font = allFont.GetComponent<IAnimation>();
            if(font != null){
                font.Tween();
            }
        }
    }

    //attach hover animation to buttons
    private void ButtonAnimation(){
        foreach(var allButton in allButtons){
            allButton.AddComponent<Hover>();
        }
    }
}
