using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Runner : MonoBehaviour
{
    [FormerlySerializedAs("_animator")]
    public Animator[] animators;

    private void Start()
    {
        StartCoroutine(RunnerProc());
    }

    IEnumerator RunnerProc()
    {
        yield return new WaitForSeconds(5);
        
        foreach (var a in animators)
        {
            a.SetBool("IsLoaded", true);
        }
    }
}