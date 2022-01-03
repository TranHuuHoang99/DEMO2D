using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Font : AAnimationManager{
    public override void Tween()
    {
        LeanTween.moveY(this.gameObject, 9.2f + transform.parent.position.y, 2f).setEaseOutBounce();
    }
}
