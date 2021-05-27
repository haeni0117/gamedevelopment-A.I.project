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
    private static int N=0;
    
  


    //기본텍스트
    private static string text_1="서랍장을 샅샅이 뒤졌지만, \n스페어 키가 보이지 않는다.\n혹시나 하는 마음에 \n서랍장 뒤편과 아래도 살펴봤지만, \n결과는 마찬가지다. ";
    private static string text_2="하지만 이대로 주저앉아\n있을 수는 없다.\n번호 패드로라도 \n안방을 탈출해야 한다.";
    private static string text_3="안방에 드라이버로 \n쓸 만한 것이 있으려나?";

    //안방조사하기
    private static string 옷장text = "옷장에는 평소에 자주 입는 \n옷들이 걸려 있다.";
    private static string 수납대text = "침대 머리맡에 있는 수납대이다. \n읽을거리들과 잡동사니를 정리해두었다.";
    private static string 쓰레기통text = "자동으로 뚜껑이 열리는 \n철제 쓰레기통이다. \n쓰레기통까지 뒤지고 싶진 않지만 \n구겨진 메모지가 눈에 띈다";
    private static string 가방걸이text = "자주 쓰는 가방과 모자를\n걸어 놓았다. 집을 나서기 전에\n바로 가져갈 수 있어서 편리하다.";
    

    //scenario!
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);

    static IEnumerator coroutine3 = Typing0(옷장text);
    static IEnumerator coroutine4 = Typing0(수납대text);
    static IEnumerator coroutine5 = Typing0(쓰레기통text);
    static IEnumerator coroutine6 = Typing0(가방걸이text);

    





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

    static IEnumerator Typing0(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        
        
        //message=text_1;
        for (int i = 0; i < message.Length; i++) 
        { 
            typingText.text = message.Substring(0, i + 1); 
            yield return new WaitForSeconds(0.05f);

            if(N==1002||N==2002||N==3002||N==4002){
                N++;
                Debug.Log("coroutine is stopped N="+N);
                yield break; 
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면?
           
        }
            Debug.Log("user didn't skip the text+num"+num);
    } 
    //각각의 오브젝트들에 대한 설명
    public static void 옷장설명(){
        GameObject 옷장= GameObject.Find("옷장");
        Text 옷장t = GameObject.Find("옷장_text").GetComponent<Text>();
        옷장t.text = "● 옷장";
        N=1000;
    }

    public static void 수납대설명(){
        GameObject 옷장= GameObject.Find("수납대");
        Text 수납대t = GameObject.Find("수납대_text").GetComponent<Text>();
        수납대t.text = "● 수납대";
        N=2000;
    }

    public static void 쓰레기통설명(){
        GameObject 옷장= GameObject.Find("쓰레기통");
        Text 수납대t = GameObject.Find("쓰레기통_text").GetComponent<Text>();
        수납대t.text = "● 쓰레기통";
         N=3000;
        
    }

    public static void 가방걸이설명(){
        GameObject 옷장= GameObject.Find("가방걸이");
        Text 수납대t = GameObject.Find("가방걸이_text").GetComponent<Text>();
        수납대t.text = "● 가방걸이";
        N=4000;
    }
    //=====================================================================
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1; 
    }

    void Start()//텍스트비어있는 상태, interactable = false
    {
         //gamaobjects
        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");


        //buttons
        Button 수납대b = 수납대.GetComponent<Button>();
        Button 쓰레기통b = 쓰레기통.GetComponent<Button>();
        Button 가방걸이b = 가방걸이.GetComponent<Button>();
        Button 안방조사b = 안방조사.GetComponent<Button>();
        Button 옷장b = 옷장.GetComponent<Button>();

        //emptytext
        Text 옷장t = GameObject.Find("옷장_text").GetComponent<Text>();
        Text 수납대t = GameObject.Find("수납대_text").GetComponent<Text>();
        Text 쓰레기통t = GameObject.Find("쓰레기통_text").GetComponent<Text>();
        Text 가방걸이t = GameObject.Find("가방걸이_text").GetComponent<Text>();
        Text 안방조사t =GameObject.Find("안방조사_text").GetComponent<Text>();

        옷장t.text = "";
        수납대t.text = "";
        쓰레기통t.text = "";
        가방걸이t.text = "";
        안방조사t.text = "";

        //interatable 
        수납대b.interactable = false;
        쓰레기통b.interactable = false;
        가방걸이b.interactable = false;
        안방조사b.interactable = false;
        옷장b.interactable = false;




        //allocation gameobjects' component
        //main text 출력 오브젝트
        Text typingText = GameObject.Find("general text").GetComponent<Text>();

        //스킵버튼
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_2_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.

        //skip_text
        Text 스킵_text = GameObject.Find("skipButton").GetComponent<Text>();
        Debug.Log("dwhy"); 
        Debug.Log("coroutin is started! #2-3 "); 
        StartCoroutine(coroutine);
    }
    public void 안방조사활성화(){//<안방조사하기>버튼이 생긴다
        

        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");

        Debug.Log("안방조사활성화");

        Text 옷장t = GameObject.Find("옷장_text").GetComponent<Text>();
        Text 수납대t = GameObject.Find("수납대_text").GetComponent<Text>();
        Text 쓰레기통t = GameObject.Find("쓰레기통_text").GetComponent<Text>();
        Text 가방걸이t = GameObject.Find("가방걸이_text").GetComponent<Text>();
        Text 안방조사t =GameObject.Find("안방조사_text").GetComponent<Text>();

        Button 수납대b = 수납대.GetComponent<Button>();
        Button 쓰레기통b = 쓰레기통.GetComponent<Button>();
        Button 가방걸이b = 가방걸이.GetComponent<Button>();
        Button 안방조사b = 안방조사.GetComponent<Button>();
        Button 옷장b = 옷장.GetComponent<Button>();

        

        //text
        // 옷장t.text = "◎ 옷장";
        // 수납대t.text = "◎ 수납장";
        // 쓰레기통t.text = "◎ 쓰레기통";
        // 가방걸이t.text = "◎ 가방걸이";
        안방조사t.text = "▷ 안방조사하기";


        // 옷장.SetActive(false);
        // 수납대.SetActive(false);
        // 쓰레기통.SetActive(false);
        // 가방걸이.SetActive(false);
        // 안방조사.SetActive(false);

        //interatable 
        수납대b.interactable = false;
        쓰레기통b.interactable = false;
        가방걸이b.interactable = false;
        안방조사b.interactable = true;
        옷장b.interactable = false;

       
        안방조사b.onClick.AddListener(text_2_3.안방조사하기);
    }
    
    
    public static void 안방조사하기(){//<안방조사하기> 이후 선택지가 나온다.
        
        GameObject 옷장= GameObject.Find("옷장");
        GameObject 수납대= GameObject.Find("수납대");
        GameObject 쓰레기통= GameObject.Find("쓰레기통");
        GameObject 가방걸이= GameObject.Find("가방걸이");
        GameObject fadeout= GameObject.Find("fadeout");
        GameObject 안방조사= GameObject.Find("안방조사");
        Button 옷장b = 옷장.GetComponent<Button>();
        옷장b.onClick.AddListener(옷장설명);
        Button 수납대b = 수납대.GetComponent<Button>();
        수납대b.onClick.AddListener(수납대설명);
        Button 쓰레기통b = 쓰레기통.GetComponent<Button>();
        쓰레기통b.onClick.AddListener(쓰레기통설명);
        Button 가방걸이b = 가방걸이.GetComponent<Button>();
        가방걸이b.onClick.AddListener(가방걸이설명);
        Button 안방조사b = 안방조사.GetComponent<Button>();
        
        
        수납대b.interactable = true;
        쓰레기통b.interactable = true;
        가방걸이b.interactable = true;
        옷장b.interactable = true;
        

        Text 옷장t = GameObject.Find("옷장_text").GetComponent<Text>();
        Text 수납대t = GameObject.Find("수납대_text").GetComponent<Text>();
        Text 쓰레기통t = GameObject.Find("쓰레기통_text").GetComponent<Text>();
        Text 가방걸이t = GameObject.Find("가방걸이_text").GetComponent<Text>();
        Text 안방조사t =GameObject.Find("안방조사_text").GetComponent<Text>();
        //reasons : those objects were inactivated!
        
        // 옷장.SetActive(true);
        // 수납대.SetActive(true);
        // 쓰레기통.SetActive(true);
        // 가방걸이.SetActive(true);

        옷장t.text = "◎ 옷장";
        수납대t.text = "◎ 수납장";
        쓰레기통t.text = "◎ 쓰레기통";
        가방걸이t.text = "◎ 가방걸이";
        안방조사t.text = "▶ 안방조사하기";

    }

    // Update is called once per frame
    void Update(){

        if(num==0){
            StartCoroutine(coroutine);
        }
        // GameObject skipButton= GameObject.Find("skipButton");
        // Button skipButtonb = skipButton.GetComponent<Button>();
        // skipButtonb.onClick.AddListener(스킵버튼누르기);

        //Debug.Log(num);
        if(num==2){
            num++;
            Debug.Log("coroutine1 is started!  num"+num);
            StartCoroutine(coroutine1); 
            
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            num++;
            Debug.Log("coroutine2 is started!  num"+num);
            StartCoroutine(coroutine2);
            
            Invoke("안방조사활성화",1.0f);
        }
        //옷장설명코루틴함수 N=1000일때 활성화/ N=1001
        if(N==1000){
            N++;
            Debug.Log("옷장설명");
            StartCoroutine(coroutine3);
            
        }
        //수납대설명코루틴함수 N=2000일때 활성화 / N=2001
        if(N==2000){
            N++;
            Debug.Log("수납대설명");
            StartCoroutine(coroutine4);
           
        }
        //쓰레기통설명코루틴함수 N=3000일때 활성화 / N=3001
        if(N==3000){
            N++;
            Debug.Log("쓰레기통설명");
            StartCoroutine(coroutine5);
        }
        //가방걸이설명코루틴함수 N=4000일때 활성화 / N=4001
        if(N==4000){
            N++;
            Debug.Log("가방걸이설명");
            StartCoroutine(coroutine6);
        }
        
        // if(num==32){
        //     Debug.Log("coroutine6 is started+num"+num);
        //     StartCoroutine(coroutine6);
        //     fadeout.SetActive(true);
            
            

            
        // }
       

    }


}