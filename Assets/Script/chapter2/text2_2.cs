using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text2_2 : MonoBehaviour
{
    public GameObject button_; //fadeout 용도

    //서랍장 조사 => 층별로 버튼 클릭 가능하게 구성
    public GameObject first_drawer;
    public GameObject second_drawer;
    public GameObject third_drawer;

    public int cnt = 0;
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
    public Text generaltext;
    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }
    public void narr(){
        Debug.Log("narration_start");
        m_Speed = 0.05f; 
        m_Message="모던한 방 분위기와는 \n어울리지 않는 서랍장이다. \n마음에 들지 않았지만, \n부모님이 골라주신 거라 \n어쩔 수 없이 \n침대 바로 옆에 뒀다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        Invoke("buttoninteractable",5);
    }
    // private void buttonactivating(){
    //     first_drawer.SetActive(true);
    //     second_drawer.SetActive(true);
    //     third_drawer.SetActive(true);
    // }
    public void buttoninteractable(){
        first_drawer.GetComponent<Button>().interactable=true;
        second_drawer.GetComponent<Button>().interactable=true;
        third_drawer.GetComponent<Button>().interactable=true;
    }

    //the first_floor of drawer investigation
    public void first(){
        m_Speed = 0.05f; 
        m_Message="사용하는 서랍이라고는 \n믿을 수 없을 정도로 \n텅 비어있다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        first_drawer.GetComponent<Button>().interactable = true;
        second_drawer.GetComponent<Button>().interactable=false;
        third_drawer.GetComponent<Button>().interactable=false;
        Invoke("buttoninteractable",3);
    }
    //the second_floor of drawer investigation
    public void second(){
        m_Speed = 0.05f; 
        m_Message="사용하는 서랍이라고는 \n믿을 수 없을 정도로 \n텅 비어있다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        first_drawer.GetComponent<Button>().interactable=false;
        second_drawer.GetComponent<Button>().interactable=false;
        third_drawer.GetComponent<Button>().interactable=false;
        Invoke("buttoninteractable",3);
    }
    //the third_floor of drawer investigation
    public void third(){
        m_Speed = 0.05f; 
        m_Message="이 집으로 이사 올 때 \n안전을 위해서 사 둔 호신용품이다. \n다행히 아직 사용할 일이 없어서 \n서랍장에 넣어 두고 잊고 있었다"; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        first_drawer.GetComponent<Button>().interactable=false;
        second_drawer.GetComponent<Button>().interactable=false;
        third_drawer.GetComponent<Button>().interactable=false;
        Invoke("buttoninteractable",3);
    }

    // Start is called before the first frame update
    void Start()
    {
        first_drawer.GetComponent<Button>().interactable=false;
        second_drawer.GetComponent<Button>().interactable=false;
        third_drawer.GetComponent<Button>().interactable=false;
        narr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
