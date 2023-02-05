using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum effectType
{
    typewriter=0,

}


public class TypingWord : MonoBehaviour
{
    [SerializeField] private TMP_Text m_text;
    [SerializeField] private float speed = 0.1f;
    private void Awake()
    {
        gameObject.TryGetComponent<TMP_Text>(out m_text);
    }
    private void Start()
    {
        StartCoroutine(TypeWriter());
    }

    private IEnumerator TypeWriter()
    {
        m_text.ForceMeshUpdate();
        TMP_TextInfo textInfo = m_text.textInfo;
        int total = textInfo.characterCount;
        bool complete = false;
        int current = 0;
        while (!complete)
        {
            if(current > total)
            {
                current = total;
                yield return new WaitForSecondsRealtime(1);
                complete = true;
            }
            m_text.maxVisibleCharacters = current;
            current++;
            yield return new WaitForSecondsRealtime(0.1f);
        }
        yield return null;
    }
}
