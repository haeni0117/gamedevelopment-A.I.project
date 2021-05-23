using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text_2_3 : MonoBehaviour
{
    public static int cnt = 0; //st atic 변수로 수정 
    //public static Text typingText; 
    public static string message;
    public float m_Speed;
    private static int num=0;
    // private static GameObject 옷장;
    // private static GameObject 수납대;
    // private static GameObject 쓰레기통;
    // private static GameObject 가방걸이;
    // private static GameObject fadeout;//fadeout
    // private static GameObject 안방조사;
       



    private static string text_1="서랍장을 샅샅이 뒤졌지만,\n스페어 키가 보이지 않는다.\n혹시나 하는 마음에 \n서랍장 뒤편과 아래도 살펴봤지만, \n결과는 마찬가지다. ";
    private static string text_2 ="하지만 이대로 주저앉아 \n있을 수는 없다.\n번호 패드로라도 \n안방을 탈출해야 한다.";
    private static string text_3 = "안방에 드라이버로 \n쓸 만한 것이 있으려나? ";
    // private static string text_4 = "한참을 고민했지만, \n중앙 통제 시스템의 위치도,\n사용 설명서의 위치도 \n생각나지 않는다.\n누군가 기억을 \n깨끗하게 지워버린 것 같다.\n10년이 넘도록 \n스마트홈 인공지능에 \n익숙해진 탓이겠지.";
    // private static string text_5 = "카라를 복구하려면 \n일단은 이 우중충한 안방을 \n어서 벗어나야 한다.";
    // private static string text_6 = "\"철컥, 철컥\"\n\n예상과는 달리,\n거실로 나가는 문은 잠겨 있다.";
    // private static string text_7 ="안방은 가장 보안이 \n삼엄한 공간이기 때문에 \n전자동 문이 고장 났을 경우 \n수동으로 빠져나갈 수 있도록 \n스페어 키를 서랍장에 넣어 놨다.\n번호 패드를 쓰는 방법도 있지만….\n그러려면 나사를 먼저 풀어야 한다.\n우선 서랍장을 조사해 봐야겠다.";
    
    //scenario!
    static IEnumerator coroutine = Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    // static IEnumerator coroutine3 = Typing(text_4);
    // static IEnumerator coroutine4 = Typing(text_5);
    // static IEnumerator coroutine5 = Typing(text_6);
    // static IEnumerator coroutine6 = Typing(text_7);





    static IEnumerator Typing(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        
        
        //message=text_1;
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(0.05f);

            if(num%3==1){
                num++;
                Debug.Log("coroutine is stopped+num"+num);
                yield break; //코루틴종료
                //여기서 그냥 끊고, update에서 다음 시나리오 출력해주기
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면?
           
            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);
            //button_skip.onClick.AddListener(StopCoroutine(coroutine));
                // button_skip = transform.Find("skipButton").GetComponent<Button>() ;
                // button_skip.onClick.AddListener(StopCoroutine("Typing",text_1)) ;
                // Debug.Log("buttonisclicked");
            //     StopCoroutine("Typing");
            // }
            // else continue;
        
    } 


    
    public static void coroutine_stop(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
        
    }
    void Awake(){
        //description) original name = just gameobject || b+original name = gameobject with button component
        //allocating gameobjects
        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");

        옷장.SetActive(false);
        수납대.SetActive(false);
        쓰레기통.SetActive(false);
        가방걸이.SetActive(false);
        안방조사.SetActive(false);

        Debug.Log("SetActive(false)"); 

        


        //allocation gameobjects' component
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_2_3.coroutine_stop);//adlistner로 불러오려면 static void여야 한다.
        //base.image = GameObject.Find("skipButton").GetComponent<Image>();
        Text 스킵_text = GameObject.Find("skipButton").GetComponent<Text>();


        
        Button 수납대b = 수납대.GetComponent<Button>();
        Button 쓰레기통b = 쓰레기통.GetComponent<Button>();
        Button 가방걸이b = 가방걸이.GetComponent<Button>();
        Button 안방조사b = 안방조사.GetComponent<Button>();
        Button 옷장b = 옷장.GetComponent<Button>();
        
        
        //still inactivated
        //Button fadeout_ = GameObject.Find("fadeoutButton").GetComponent<Button>();
        //fadeout_.onClick.AddListener(base.fadeoutstart);

        Debug.Log(옷장); 

    }
    void Start()
    {
        //inactivating options
        // GameObect 옷장.SetActive(false);
        // 수납대.SetActive(false);
        // 쓰레기통.SetActive(false);
        // 가방걸이.SetActive(false);
        // 안방조사.SetActive(false);
        // Debug.Log("SetActive(false)"); 


        Debug.Log("coroutin is started! #2-3 "); 
        StartCoroutine(coroutine);
    }
    public void 안방조사활성화(){
        //계속 가르쳐 줘야함
        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");
        안방조사.SetActive(true);
    }
    public void 테스트(){
        Debug.Log("test case button is clicked");
    }
    public void 안방조사하기(){
        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");
        옷장.SetActive(true);
        수납대.SetActive(true);
        쓰레기통.SetActive(true);
        가방걸이.SetActive(true);
    }

    // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            Debug.Log("coroutine1 is started!  num"+num);
            StartCoroutine(coroutine1); 
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Invoke("안방조사활성화",3.0f);
        }
        // if(num==8){
        //     Debug.Log("coroutine3 is started!  num"+num);
        //     StartCoroutine(coroutine3);
        //     num++;
        // }
        // if(num==11){
        //     StartCoroutine(coroutine4);
        //     Debug.Log("coroutine3 is started!  num"+num);
        //     num++;
        // }
        // if(num==14){
        //     Debug.Log("<theonlychoice>버튼활성화  num"+num);
        //     theonlychoice.SetActive(true);//activate button
        // }
        
        // if(num==32){
        //     Debug.Log("coroutine6 is started+num"+num);
        //     StartCoroutine(coroutine6);
        //     fadeout.SetActive(true);
            
            

            
        // }
       

    }


}