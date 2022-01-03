using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSizeScale : MonoBehaviour
{
    public void Resize(){
        LeanTween.scale(this.gameObject, Vector3.one, 0f);
    }
}
