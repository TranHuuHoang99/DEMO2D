using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderFont : AAnimationManager
{
    public override void Tween()
    {
        LeanTween.moveY(this.gameObject, -1.71f + transform.parent.position.y, 2f);
    }
}
