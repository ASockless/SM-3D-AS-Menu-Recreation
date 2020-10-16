using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoi : MonoBehaviour
{
    Animator CoverAnimator;
    // Start is called before the first frame update
    void Start()
    {
        CoverAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartAnimations()
    {
        CoverAnimator.SetBool("IsHover", true);
    }

    public void StopAnimations()
    {

        CoverAnimator.SetBool("IsHover", false);
    }
}
