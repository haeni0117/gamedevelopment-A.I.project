using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _text1_2 : MonoBehaviour
{
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public GameObject choice3_1;//화장실과 연결되는 선택지
    public GameObject general;

    public Text text1;
    public Text text2;
    public Text text3;//화장실과 연결되는 선택지 -> 보류

    public Text generaltext;
    int count = 0;
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;
   
    
    
    void Start()
    {
        generaltext.text="드디어 일어나셨군요.\n주무시는 동안, 어머니께 \n전화가 왔습니다.\n지금 확인하시겠습니까?\"";
        text1.text="그래 고마워";
        text2.text ="이 시간에? 엄마가? 무슨 일로?";
    }

    IEnumerator Typing(Text typingText, string message, float speed) 
    { 
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(speed); 
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            count++;
            Debug.Log(count);
            if(count==2){
                text2_2();
                }
            if(count==3){
                text3_2();
            }
            if(count==4){
                text4_2();
            }
            if(count==5){
                generaltext.text="";
                newchoice();
            }
            if(count==7){
                SceneManager.LoadScene("1-3");
                general.SetActive(false);
            }
        
            
    }
    }
        
        
    
    public void text1_2(){
        Debug.Log("clicked");
        choice1.SetActive(false);
        choice1.SetActive(false);
        m_Speed = 0.1f; 
        m_Message="<부재중 기록 확인>\n“왜 오늘 같은 날\n전화를 안 받니?\n설마 평일인데 7시 넘어서까지\n자는 건 아니겠지?\n\n\n추모식이 4시부터\n시립묘지에서 열리니까\n오늘은 연차를 내든지 해서\n꼭 오도록 해라.\"";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    // Start is called before the first frame update   
        }
    public void toiletonechoice(){
        Debug.Log("toilet");
        
        choice3_1.SetActive(false);
        m_Speed = 0.1f;
        general.SetActive(true); 
        m_Message="화장실 문을 여는 순간,\n전 세계에서 가장 많은 사람이\n불렀을 노래와 함께\n카라의 쾌활한 목소리가\n집 안 곳곳에서 흘러나왔다.\n“아 참, 중요한 걸\n깜빡할 뻔했네요.\n주인님의 32번째 생일을\n진심으로 축하드립니다.\"";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        }
    

        

    void text2_2(){
        m_Speed = 0.05f; 
        m_Message= "옷은 검은 색으로 \n깔끔하게 입고 오고,\n어떻게 떠난 아이인데…….\n양심이 있으면\n네가 저번처럼 늦지는 않겠지. \n\n연희 숙모랑 연준 삼촌도\n온다고 했으니,\n엄마 창피하게 하지 마라.\n그러니까…….\n이만 끊는다.\n이따 보자.”";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }

    void text3_2(){
        m_Speed = 0.1f; 
        m_Message= "\"괜찮으십니까?\"\n멍하니 음성이 끊긴 전화기만\n바라보다 카라의 말에\n정신이 들었다.";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }
   
    void text4_2(){
        m_Speed = 0.1f; 
        m_Message= "오늘마저 늦으면\n부모님은 두 번 다시 나를\n보고 싶어 하지 않으실 것이다.\n갑작스럽게 반차라도 내려면\n지각만은 피해야 했으므로\n나는 급히 침대에서 내려와\n화장실로 향했다.";
        generaltext.text=m_Message;
        StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }
    void newchoice(){
        choice3.SetActive(true);
        general.SetActive(false);

        
    }
        //if(count==3){
           // m_Speed = 0.1f; 
            //m_Message= "\n스무 살 때와 차이가 있다면 \n더는 퀴퀴하고 좁은 기숙사 방에서 \n밤새 토사물을 치우느라 \n화난 룸메이트를 \n마주하지 않아도 된다는 것? \n항상 혼자 살기에는 \n집이 너무 넓다고 불평을 해왔지만, \n인공지능이 설정한 최적 온도와 습도는 \n언제나 상쾌하고, \n퀸사이즈 침대 위에 놓인 \n새하얀 침구는 오늘따라 더 눈부시다."; 
           // generaltext.text=m_Message;
           // StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
          //  }
   //void textnumber(){
        
    //    }
    //}    
       

    
    
}
