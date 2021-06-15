using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMoveFeedback : MonoBehaviour
{
    RectTransform rectTransform;
    [SerializeField] float duration = 0.1f, moveAmount = 25f;
    Vector3 initialPos, targetPos;
    bool moving;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        initialPos = rectTransform.localPosition;
        targetPos = initialPos + new Vector3(moveAmount,0,0);
    }
    public IEnumerator MoveAnimation()
    {
        moving = true;
        for (float i = 0; i < duration; i += Time.deltaTime)
        {
            rectTransform.localPosition = Vector3.Lerp(initialPos, targetPos, i / duration);
            yield return null;
        }
        rectTransform.localPosition = targetPos;
        for (float i = 0; i < duration; i += Time.deltaTime)
        {
            rectTransform.localPosition = Vector3.Lerp(targetPos, initialPos, i / duration);
            yield return null;
        }
        rectTransform.localPosition = initialPos;
        moving = false;
    }

    public void Feedback()
    {
        if (!moving)
        {
            StartCoroutine(MoveAnimation());
        }
    }
}
