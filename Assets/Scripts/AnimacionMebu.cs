using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMebu : MonoBehaviour
{
    
    [SerializeField] Animator animator;

    public void Playaaaanimation(string nombre)
    {
        animator.Play(nombre);
    }

}
