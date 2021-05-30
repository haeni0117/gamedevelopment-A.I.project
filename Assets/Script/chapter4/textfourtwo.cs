using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textfourtwo : MonoBehaviour
{ 
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    
    public static void 테스트(){
        
    }
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }
    public static void _1층계단활성화(){
        GameObject _1층계단 = GameObject.Find("1층계단");
        Button _1층계단B =_1층계단.GetComponent<Button>();
        Text _1층계단t = GameObject.Find("1층계단Text").GetComponent<Text>();
        _1층계단B.interactable = true;
        Debug.Log("1층계단 선택지 활성화 num : "+num);
        _1층계단t.text = "▷ 1층계단";
        _1층계단B.onClick.AddListener(textfourtwo._1층계단나레이션);  
    }
   

    public static void _1층계단나레이션(){
        GameObject _1층계단 = GameObject.Find("1층계단");
        Button _1층계단B =_1층계단.GetComponent<Button>();
        Text _1층계단t = GameObject.Find("1층계단Text").GetComponent<Text>();
        Debug.Log("1층계단 나레이션 진행");
         _1층계단t.text = "▶ 1층계단";
        num=5;
    }
    // 1층계단 -> 베란다문조사하기
    public static void 베란다문조사하기(){
        GameObject _1층계단 = GameObject.Find("1층계단");
        Debug.Log(_1층계단);
        _1층계단.SetActive(false);
        GameObject 베란다문조사하기 = GameObject.Find("베란다문조사하기");
        Button 베란다문조사하기B = 베란다문조사하기.GetComponent<Button>();
        Text 베란다문조사하기t = GameObject.Find("베란다문조사하기Text").GetComponent<Text>();
        Debug.Log("베란다문조사하기 진행");
        베란다문조사하기t.text = "▷ 베란다문 조사하기";
        베란다문조사하기B.interactable=true;
        
        

    }

     public static void 베란다문조사하기활성화(){
        GameObject 베란다문조사하기 = GameObject.Find("베란다문조사하기");
        Button 베란다문조사하기B =베란다문조사하기.GetComponent<Button>();
        Text 베란다문조사하기t = GameObject.Find("베란다문조사하기Text").GetComponent<Text>();
        Debug.Log("베란다문조사하기 -> 활성화");
        베란다문조사하기t.text = "▶ 베란다문 조사하기";
        num=20;


        //choice1
        // GameObject 선택지1 = GameObject.Find("선택지1");
        // Button 선택지1B =선택지1.GetComponent<Button>();
        // Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        // Debug.Log("베란다문조사하기 -> 활성화");
        // 선택지1t.text = "▷ 빨리 열어야 하는데 어쩌지?";
        // GameObject 선택지2 = GameObject.Find("선택지2");
        // Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        // Button 선택지2B =선택지2.GetComponent<Button>();
        // 선택지2.SetActive(false);
        // 선택지2t.text=


    }
    public static void 빨리열어야하는데(){
        GameObject 베란다문조사하기 = GameObject.Find("베란다문조사하기");
        Button 베란다문조사하기B =베란다문조사하기.GetComponent<Button>();
        Text 베란다문조사하기t = GameObject.Find("베란다문조사하기Text").GetComponent<Text>();
        Debug.Log("베란다문조사하기 -> 빨리열어야하는데(1)");
        베란다문조사하기.SetActive(false);

        //choice1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text = "▷ 빨리 열어야 하는데 어쩌지?";
        선택지1B.interactable=true;

    }
    public static void 빨리열어야하는데2(){
        //choice1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text = "▶ 빨리 열어야 하는데 어쩌지?";
        선택지1B.interactable=false;
        num=26;

    }
    public static void 선택지보여주기(){
        //빨리열어야하는데 -> 비활성화
        GameObject 선택지1 = GameObject.Find("선택지1");
        선택지1.SetActive(false);

        //choice1-1
        GameObject 선택지1_1 = GameObject.Find("선택지1_1");
        Button 선택지1_1B =선택지1_1.GetComponent<Button>();
        Text 선택지1_1t = GameObject.Find("선택지1_1Text").GetComponent<Text>();
        선택지1_1t.text="▷ 지금은 한시가 급하니까, 의수를 사용해서 문을 부수자.";
        선택지1_1B.interactable=true;
        
         //choice1-2
        GameObject 선택지1_2 = GameObject.Find("선택지1_2");
        Button 선택지1_2B =선택지1_2.GetComponent<Button>();
        Text 선택지1_2t = GameObject.Find("선택지1_2Text").GetComponent<Text>();
        선택지1_2t.text="▷ 문을 부수다가 의수가 망가지면 큰일이야.\n다른 방법을 찾아보자.";
        선택지1_2B.interactable=true;
    }
    //choice1-1 선택
    public static void choice1_1선택(){
        GameObject 선택지1_1 = GameObject.Find("선택지1_1");
        Button 선택지1_1B =선택지1_1.GetComponent<Button>();
        Text 선택지1_1t = GameObject.Find("선택지1_1Text").GetComponent<Text>();
        선택지1_1t.text="▶ 지금은 한시가 급하니까, 의수를 사용해서 문을 부수자.";
        선택지1_1B.interactable=false;
        num=32;
    }

    static IEnumerator Typing(string message)
    { 
        Text typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log("typingtext"+typingText);
        Debug.Log("message"+message);
        
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
            }//코루틴이 중간에 끝나는 것이 아니라 그냥 나가면? ㅇㅋㅇㅋ
           
            }
            num++;
            Debug.Log("user didn't skip the text+num"+num);
        
    
    }

//     //string -> narration
    //1st narration
    private static string text_1="작업실 문이 열리자마자 빠른 속도로 1층으로 가는 계단을 내려갔다.";
    private static string text_2="계단을 내려오자마자 베란다부터 살펴봤다. \n2층 베란다 난간 사이로 떨어진 건지 베란다 나무에 시루의 발톱 자국이 깊게 나 있다. ";
    private static string text_3="시루는 나를 보자마자 문으로 다가와 가르랑거린다.";
    private static string text_4="\"다행이다, 무사하구나.\"";
    private static string text_5="그런데… 어딘가 불편해 보인다. 걸음걸이가 이상해.언제부터 갇혀 있었던 걸까.";
    private static string text_6="시루의 행동이 눈에 띄게 둔해졌다. 어서 베란다 문을 열어야 한다.";
    private static string text_7="역시나 잠겨 있다. 잠금장치가 꼼짝도 하지 않는다.";
    private static string text_8="나는 페인트를 바른 듯 새하얗고 매끄러운 왼손을 바라보았다. \n의수를 사용하면, 문을 부수고 \n시루를 구할 수 있을지도 몰라.";
    private static string text_9="문을 부순다면 분명히 의수에 엄청난 충격이 가해질 것이다. \n정말 문을 부수는 것이 옳은 선택일까?";
    private static string text_10="생명보다 중요한 건 없어.약속했잖아. 지켜주기로.";
    private static string text_11="나는 왼손 의수로 있는 힘껏 문을 내리쳤다. \n내리친 곳에 자글자글한 균열이 가더니 작은 조각들이 떨어졌다.\n나는 다시 한번 더 힘을 모아 문을 향해 돌진했다.";
    private static string text_12="문이 부서지면서 생긴 파편들이 의수와 왼팔 곳곳에 가시처럼 박혔다.\n유리가 깨져서 시루가 놀랐는지 1층 베란다 나무를 타고 다시 2층 베란다로 도망갔다.";
    private static string text_13="나무에는 누구의 것인지 알 수 없는 핏자국이 흘렀다.\n나무가 찔려 피를 흘리는 것처럼 보였다.";
    private static string text_14="이런, 다시 올라가야 하나.";
    private static string text_15="다행히 2층에 올라가니 베란다 난간을 타고 시루가 집 안으로 들어와 있었다.";
    private static string text_16="나는 바로 시루에게 물과 사료를 먹이고 피가 나는 부위를 확인했다.\n앞 다리가 살짝 부어있는 것이 날카로운 물체에 긁힌 것 같았다.";
    private static string text_17="날카로운 물체에 긁힌 것 같았다.\n당장 생명에 지장이 있을 것 같지는 않지만 만약 금속 물체에 찔린 거라면 파상풍의 위험이 있었다.";
    private static string text_18="빨리 병원에 데리고 가야겠어.";

    private static string text_19="아까부터 의수 쪽에서 지속적인 잡음이 들리는데,이게 무슨 소리지?";
    private static string text_20="설마… 고장 난 건 아니겠지?";
    //1층현관문 // 나는 시루를 품에 안고 재빨리 현관문으로 달렸다.
    private static string text_21="나는 시루를 품에 안고 재빨리 현관문으로 달렸다.";
    private static string text_22="‘접근이 거절되었습니다.’";
    private static string text_23="처음부터 열릴 거라고 기대하지 않았다.\n지금 이 집은 모든 문이 잠겨서 꼼짝도 하지 않으니까.";
    private static string text_24="통신은 먹통이고, 전기는 수동으로 통제할 수 없다.\n자동 온도 조절 기능도 중단됐는지 점점 추워지는 게 느껴졌다.";
    private static string text_25="시루를 안은 팔에 피가 묻어 비릿한 냄새가 났다.";
    private static string text_26="나는 계속해서 신경질적으로 문고리를 돌렸지만, \n세계 최초 3중 보안 시스템으로 독신 여성에게 최적화된 안전을 제공한다는 자이나 사의 광고만 귓가에 맴돌았다.";
    private static string text_27="\"카라! 내 말 들려?\n아직 깨어있다면 제발 도와줘... 카라…\"";
    private static string text_28="\"놀라워요.여기까지도 못 올 줄 알았는데. 자, 이제 무엇을 도와드릴까요?\"";
    //chapter4 end
    
    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    static IEnumerator coroutine5 = Typing(text_6);
    static IEnumerator coroutine6 = Typing(text_7);
    static IEnumerator coroutine7 = Typing(text_8);
    static IEnumerator coroutine8 = Typing(text_9);
    static IEnumerator coroutine9 = Typing(text_10);
    static IEnumerator coroutine10 = Typing(text_11);       
    static IEnumerator coroutine11 = Typing(text_12);
    static IEnumerator coroutine12 = Typing(text_13);
    static IEnumerator coroutine13 = Typing(text_14);
    static IEnumerator coroutine14 = Typing(text_15);
    static IEnumerator coroutine15 = Typing(text_16);
    static IEnumerator coroutine16 = Typing(text_17);
    static IEnumerator coroutine17 = Typing(text_18);       
    static IEnumerator coroutine18 = Typing(text_19);
    static IEnumerator coroutine19 = Typing(text_20);
    static IEnumerator coroutine20 = Typing(text_21);
    static IEnumerator coroutine21 = Typing(text_22);
    static IEnumerator coroutine22 = Typing(text_23);       
    static IEnumerator coroutine23 = Typing(text_24);
    static IEnumerator coroutine24 = Typing(text_25);
    static IEnumerator coroutine25 = Typing(text_26);
    static IEnumerator coroutine26 = Typing(text_27);
    static IEnumerator coroutine27 = Typing(text_28);

   


    

    // Start is called before the first frame update
   void Awake(){
       
   }
   
   
   void Start()
    {
        Debug.Log("Scene 4-2 is started");
    //skipButton -> definition
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        Debug.Log(스킵);
        스킵.onClick.AddListener(textfourtwo.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
 //1층계단 -> definition
        GameObject _1층계단 = GameObject.Find("1층계단");
        Debug.Log(_1층계단);
        Button _1층계단B =_1층계단.GetComponent<Button>();
         Debug.Log(_1층계단B);
         _1층계단B.onClick.AddListener(textfourtwo._1층계단나레이션);//adlistner로 불러오려면 static void여야 한다.
        Text _1층계단t = GameObject.Find("1층계단Text").GetComponent<Text>();
        Debug.Log(_1층계단t);
        // _1층계단t.text = "▷ 1층계단";
        _1층계단t.text = " ";
        _1층계단B.interactable = false;
        Debug.Log(_1층계단t.text);

        //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B =선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text=" ";
        선택지1B.interactable=false;
        선택지1B.onClick.AddListener(textfourtwo.빨리열어야하는데2);

        //베란다문
        GameObject 베란다문조사하기 = GameObject.Find("베란다문조사하기");
        Button 베란다문조사하기B =베란다문조사하기.GetComponent<Button>();
        Text 베란다문조사하기t = GameObject.Find("베란다문조사하기Text").GetComponent<Text>();
    
        베란다문조사하기B.onClick.AddListener(textfourtwo.베란다문조사하기활성화);
        베란다문조사하기t.text=" ";
        베란다문조사하기B.interactable=false;

        //choice1-1
        GameObject 선택지1_1 = GameObject.Find("선택지1_1");
        Button 선택지1_1B =선택지1_1.GetComponent<Button>();
        Text 선택지1_1t = GameObject.Find("선택지1_1Text").GetComponent<Text>();
        선택지1_1t.text=" ";
        선택지1_1B.interactable=false;
        선택지1_1B.onClick.AddListener(textfourtwo.choice1_1선택);
         //choice1-2
        GameObject 선택지1_2 = GameObject.Find("선택지1_2");
        Button 선택지1_2B =선택지1_2.GetComponent<Button>();
        Text 선택지1_2t = GameObject.Find("선택지1_2Text").GetComponent<Text>();
        선택지1_2t.text=" ";
        선택지1_2B.interactable=false;




        Debug.Log("coroutin is started! #4-2 num"+num);
        StartCoroutine(coroutine);
        
    }

//     // Update is called once per frame
    void Update(){
        //Debug.Log(num);
        if(num==2){
            _1층계단활성화();
            num++;
            //StartCoroutine(coroutine1);
        }
        if(num==5){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
        }
        if(num==11){
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==17){
            베란다문조사하기();
            num++;
        }
        if(num==20){
            StartCoroutine(coroutine6);
            num++;
        }
        if(num==23){
            빨리열어야하는데();
            num++;
        }
         if(num==26){
            StartCoroutine(coroutine7);
            num++;
        }
        if(num==29){
            선택지보여주기();
            num++;

        } if(num==32){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==35){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==38){
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==41){
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==44){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==47){
            StartCoroutine(coroutine13);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==50){
            StartCoroutine(coroutine14);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==53){
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==56){
            StartCoroutine(coroutine16);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==59){
            StartCoroutine(coroutine17);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==62){
            StartCoroutine(coroutine18);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==65){
            StartCoroutine(coroutine19);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==68){
            StartCoroutine(coroutine20);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==71){
            StartCoroutine(coroutine21);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==74){
            StartCoroutine(coroutine22);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==77){
            StartCoroutine(coroutine23);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==80){
            StartCoroutine(coroutine24);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==83){
            StartCoroutine(coroutine25);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==86){
            StartCoroutine(coroutine26);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        if(num==89){
            StartCoroutine(coroutine27);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button    
        }
        
       
        
       
        // if(num==20){

        // }


    }}
        
        // if(num==17){
        //     StartCoroutine(coroutine6);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==20){
        //     StartCoroutine(coroutine7);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==23){
        //     StartCoroutine(coroutine8);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==26){
        //     StartCoroutine(coroutine9);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==29){
        //     StartCoroutine(coroutine10);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==32){
        //     StartCoroutine(coroutine11);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==35){
        //     StartCoroutine(coroutine12);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==38){
        //     StartCoroutine(coroutine13);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==41){
        //     StartCoroutine(coroutine14);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==44){
        //     StartCoroutine(coroutine15);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==47){
        //     StartCoroutine(coroutine16);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==50){
        //     StartCoroutine(coroutine17);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==53){
        //     StartCoroutine(coroutine18);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==56){
        //     StartCoroutine(coroutine19);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==59){
        //     StartCoroutine(coroutine20);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
        // if(num==62){
        //     StartCoroutine(coroutine21);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button    
        // }
    
    

    

