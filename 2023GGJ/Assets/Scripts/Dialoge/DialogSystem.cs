using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text textLabel;
    public Image talkImage;//说话的头像
    public TextAsset textFile;
    public int index;
    List<string> textList = new List<string>();
    public float textSpeed;
    bool textFinished;
    public Sprite face01, face02;

    void Awake()
    {
        GetTextFormFile(textFile);
    }
    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
        textFinished = true;
        StartCoroutine(SetTextUI());
    }
        // Update is called once per frame
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
            if (Input.GetKeyDown(KeyCode.E)&&textFinished)
        {
            //textLabel.text = textList[index];
            //index++;
            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        //将文本按行切割,变成数组
        var lineDate = file.text.Split('\n');
        //循环将数组中的字符添加到集合中
        foreach (var line in lineDate)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        switch (textList[index].Trim())
        {
            case "A:":
                talkImage.sprite = face01;
                index++;
                break;
            case "T:":
                talkImage.sprite = face02;
                index++;
                break;
        }
        for(int i = 0; i < textList[index].Length; i++)
        {
            textLabel.text += textList[index][i];
            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true;
        index++;
    }
}
