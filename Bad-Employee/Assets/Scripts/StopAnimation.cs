using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour {

    //public AnimationClip anim;

    public void StopAnimationn()
    {
        GetComponent<Animator>().enabled = false;
    }
}
