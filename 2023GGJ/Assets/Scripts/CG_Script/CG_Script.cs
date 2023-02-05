using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CG_Script : MonoBehaviour
{
    /*[SerializeField] private VideoPlayer VideoPlayer;
    [SerializeField] private RawImage rawImage;*/


    /*private double time;
    private double currentTime;*/
    [SerializeField] private float totalTime;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator LoadNextScene()
    {
        /*VideoPlayer.SetDirectAudioVolume(0, 1);
        VideoPlayer.Play();
        rawImage.gameObject.SetActive(true);*/
        yield return new WaitForSeconds(totalTime);
        SceneManager.LoadScene("Dark scene1");
    }

}
