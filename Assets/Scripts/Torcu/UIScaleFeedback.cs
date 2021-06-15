using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScaleFeedback : MonoBehaviour
{
    RectTransform rectTransform;
    float duration = 0.1f;
    [SerializeField] float scaleAmount = 0.05f;
    bool moving;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public IEnumerator ScaleAnimation()
    {
        moving = true;
        Vector3 target = Vector3.one - new Vector3(scaleAmount, scaleAmount, scaleAmount);
        for (float i = 0; i< duration; i += Time.deltaTime)
        {
            rectTransform.localScale = Vector3.Lerp(Vector3.one, target, i / duration);
            yield return null;
        }
        rectTransform.localScale = target;
        for (float i = 0; i < duration; i += Time.deltaTime)
        {
            rectTransform.localScale = Vector3.Lerp(target, Vector3.one, i / duration);
            yield return null;
        }
        rectTransform.localScale = Vector3.one;
        moving = false;
    }

    public void Feedback()
    {
        if (!moving)
        {
            StartCoroutine(ScaleAnimation());
        }
    }
}
