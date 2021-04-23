using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _text : MonoBehaviour
{
    bool isButton = false;
    public GameObject btn;
    
    public void numup(){
        num++;
        Debug.Log(num);
    }
    int test;

    int num=1000;
    bool my_coroutine_is_running = false;
    void buttonactivation(){
        if(my_coroutine_is_running==false){
            btn.SetActive(true);
            Debug.Log("버튼활성화");}
               //btn.SetActive(true);
        //     Debug.Log("button on");
        //     }
        // if(my_coroutine_is_running==true){
        //     btn.SetActive(false);
        //     Debug.Log("button off");
        
        else{
            btn.SetActive(false);
            Debug.Log("버튼비활성화");}
    }


    //코루틴함수는 그냥 동시에 시행되는 수 그래서 0이랑 8이 함께 디버깅된 것
    // public void OnGUI()
    // {
    //     if (!isClicked)
    //     {
    //         if(isClicked==false&&GUI.Button(new Rect(10, 10, 150, 100), "START"))
    //         {
    //             isClicked = true;
    //             num++;
    //             Debug.Log(num);
    //         }
    //     }
    //     else
    //     {
    //         GUI.Label(new Rect(10, 10, 100, 20), "Hello");
    //     }
    // }
    public GameObject choice1;
    public GameObject choice2;

    //==================================
    public void text1_(){ 
        test = 99;
        my_coroutine_is_running=true;
        choice1.SetActive(false);
        choice2.SetActive(false);
        m_Speed = 0.1f; 
        m_Message="그 말씀만 벌써 3번째입니다.\n씻으시는 동안 잠을 깰 수 있도록 \n커피를 한 잔 타 드리겠습니다.\n지금 일어나지 않으시면\n어제 설정해 두셨던\n‘강제 기상’ 모드를\n작동하는 수밖에 없습니다.";
        generaltext.text=m_Message;
        StartCoroutine(typingText(m_TypingText, m_Message, m_Speed));
        test= 8;
        //my_coroutine_is_running=false;
        //ebug.Log("coroutine : "+my_coroutine_is_running);  
    }
    //==================================
    public Text text1;
    public Text text2;
    public Text generaltext;
    int count = 0;
    public Text m_TypingText; 
    public string m_Message;
    public float m_Speed;

    void isBTN(){
        if(isButton==true){
            btn.SetActive(true);
            Debug.Log("on");
        }
        else{
            btn.SetActive(false);
            Debug.Log("off");
        }
    }

    // void coroutine_(){
    //     if(my_coroutine_is_running==true){
    //         isButton=false;
    //     }
    //     else{isButton=true;
    //     }
    // }
    
   
    // Start is called before the first frame update
    void Start()
    {
        buttonactivation();
        btn.SetActive(false);
        //imbtn = GameObject.transform.Find("Button").GetComponent<Button>();
    
       
        generaltext.text="OO님, 일어나실 시간입니다.";
        text1.text="5분만 더……. ";
        text2.text ="지금 몇 시야, 카라?";
    }

    //coroutine function
    
    IEnumerator typingText(Text typingText, string message, float speed) 
    {   
        int test2 = 3;
        //test = "2";
        for (int i = 0; i < message.Length; i++){
            //test = "3";
            
            typingText.text = message.Substring(0, i + 1); 
            test = 4;
            int text2 = 5;
            //Debug.Log(text2);
            yield return new WaitForSeconds(speed);
            //my_coroutine_is_running = ; 
            test = 5;
            my_coroutine_is_running=true;
            //test = "6";
            // Debug.Log(my_coroutine_is_running);
        } 
        Debug.Log("2");
        test = 7;
        btn.SetActive(false);
        //my_coroutine_is_running=false;
        
    


    }
    
    

    // Update is called once per frame
    void Update(){
        
        //isBTN();
        //Debug.Log(my_coroutine_is_running);
        //buttonactivation();
        //Debug.Log("coroutine : "+my_coroutine_is_running);
        Debug.Log(test);
        
       
        
        
      

        if(num==1001){
            text1_();
        }
            // if(count==2){
            //     text2_();
            //     }
            // if(count==3){
            //     text3_();
            // }
            // if(count==4){
            //     SceneManager.LoadScene("1-2");
            // }
    }
     
    
        
        
 
    void text2_(){
        m_Speed = 0.1f; 
        m_Message= "그래……. 이제 일어나야지.\n둔기로 뒤통수를 맞은 것처럼\n 머리가 욱신거린다.\n어제 회식에서 그렇게 술을 \n많이 마신 것 같지도 않은데, \n집에 들어온 기억이 전혀 없다. \n스무 살 때 겪었던 \n숙취를 다시 겪는 기분이네.";
        generaltext.text=m_Message;
        //StartCoroutine(larger());
        //StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
    }

     void text3_(){
        m_Speed = 0.1f; 
        m_Message= "스무 살 때와 차이가 있다면 \n더는 퀴퀴하고 좁은 기숙사 방에서 \n밤새 토사물을 치우느라 \n화난 룸메이트를 \n마주하지 않아도 된다는 것? \n항상 혼자 살기에는 \n집이 너무 넓다고 불평을 해왔지만, \n인공지능이 설정한 최적 온도와 습도는 \n언제나 상쾌하고, \n퀸사이즈 침대 위에 놓인 \n새하얀 침구는 오늘따라 더 눈부시다." ;
        generaltext.text=m_Message;
        //StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
        
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
