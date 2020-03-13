using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    [SerializeField] float shake;
    public void Shake()
    {
        StartCoroutine(StartShake());
        print("SHAKE");
    }
    IEnumerator StartShake()
    {
        for (int i = 0; i < 5; i++)
        {
            transform.position -= transform.right*shake/100;
            yield return new WaitForEndOfFrame();
        }
        for (int i = 0; i < 10; i++)
        {
            transform.position += transform.right * shake / 100;
            yield return new WaitForEndOfFrame();
        }
        for (int i = 0; i < 5; i++)
        {
            transform.position -= transform.right * shake / 100;
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
}
