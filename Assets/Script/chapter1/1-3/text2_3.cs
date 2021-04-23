using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text2_3 : MonoBehaviour
{
    int count = 0;
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
    // Start is called before the first frame update
    void Start()
    {
        m_Speed = 0.05f; 
        m_Message="어떤 사람은 차가운 파란색을 보면\n심해가 떠올라 무섭다고 하지만,\n나는 늘 차가운 파란색만이 주는\n고립감이 좋았다.\n그곳에서만큼은\n어떤 불행도, 절망도\n나를 따라오지 못할 것 같았다."; 
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    
    }
    void text2_1(){
        m_Speed = 0.05f; 
        m_Message= "디자이너는 공사가 끝날 때까지\n화장실에 파란색 도기 타일을 쓰면 \n겨울에는 발이 시려서 \n화장실에는 얼씬도 하고 싶지 \n않을 거라고 악담을 퍼부었지만,\n나는 한 번도 화장실을 \n파란색 타일로 꾸민 것을\n후회하지 않았다.";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }

    void text2_2(){
        m_Speed = 0.05f; 
        m_Message= "나는 거울의 투명도를\n50%로 낮추고\n뿌연 안개 속을 걷듯\n불투명한 거울을 바라보며\n칫솔을 꺼내 들었다.\n“그런데 카라,\n아까 내 생일 축하를\n깜빡할 뻔했다는 건\n무슨 소리야?”";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            count++;
            Debug.Log(count);
            if(count==1){
                text2_1();
            }
            if(count==2){
                text2_2();
            }
            if(count==3){
                SceneManager.LoadScene("1-4");
            }
         }
    }
}