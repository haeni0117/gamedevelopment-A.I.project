using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_3_1_1 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;
    //scenechange
    
     public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}
    public static void scenechange(){
        SceneManager.LoadScene("6-3-1");
    }

	// 투명 -> 불투명
	IEnumerator CoFadeIn(float fadeOutTime, System.Action nextEvent = null){
        GameObject srr = GameObject.Find("fadeout");
		Image sr = srr.GetComponent<Image>();
		Color tempColor = sr.color;
		while(tempColor.a < 1f){
			tempColor.a += Time.deltaTime / fadeOutTime;
			sr.color = tempColor;

			if(tempColor.a >= 1f) tempColor.a = 1f;

			yield return null;
		}

		sr.color = tempColor;
		if(nextEvent != null) nextEvent();
	}

	// 불투명 -> 투명
	IEnumerator CoFadeOut(float fadeOutTime, System.Action nextEvent = null){
		GameObject srr = GameObject.Find("fadeout");
		Image sr = srr.GetComponent<Image>();
		Color tempColor = sr.color;
		while(tempColor.a > 0f){
			tempColor.a -= Time.deltaTime / fadeOutTime;
			sr.color = tempColor;

			if(tempColor.a <= 0f) tempColor.a = 0f;

			yield return null;
		}
		sr.color = tempColor;
		if(nextEvent != null) nextEvent();
	}
    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    //choice1 선택
    public static void choice1(){
        SceneManager.LoadScene("6-3-1-1");

    }
    //fade in -> fade out 연결
    public void fadeout1(){
        FadeOut(1.0f);
    }

    //choice2 선택
    public static void choice2(){
        num=17;
          GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text="▷ 침착하게 생각한다.";
        choice1B.interactable=false;
        
        //choice 2 : B. 카라를 부른다.
        GameObject choice2 = GameObject.Find("choice2");
        Button choice2B =choice2.GetComponent<Button>();
        Text choice2t = GameObject.Find("choice2Text").GetComponent<Text>();
        choice2t.text="▶ 카라를 부른다.";
        choice2B.interactable=false;
        
    }

    public static void 선택지활성화(){
        //choice 1&2 showing

        //choice 1 : A. 침착하게 생각한다
        GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text="▷ 침착하게 생각한다.";
        choice1B.interactable=true;
        choice1B.onClick.AddListener(text6_3_1.choice1);

        //choice 2 : B. 카라를 부른다.
        GameObject choice2 = GameObject.Find("choice2");
        Button choice2B =choice2.GetComponent<Button>();
        Text choice2t = GameObject.Find("choice2Text").GetComponent<Text>();
        choice2t.text="▷ 카라를 부른다.";
        choice2B.interactable=true;
        choice2B.onClick.AddListener(text6_3_1.choice2);
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
    //스킵버튼
   
    
    //string -> narration
    private static string text_1="침착하게 생각한다.";
    private static string text_2="“침착해야 해. \n생각.....생각을 해보자. \n분명 여기를 탈출할 \n방법이 있을 거야.\"";
    private static string text_3="다행히 반신욕용 덮개라 \n팔만 겨우 빠져나갈 정도의 \n틈이 있었다.\n의수를 쓴다면 덮개를 \n뜯어낼 수 있을지도 모른다.";
    private static string text_4="하지만 정말 \n그 방법밖에 없는 걸까…?";
    //fadeinandout
    private static string text_5="심호흡하면서 \n마음을 가다듬었다. \n분명 지금 상황을 해결할\n방법이 있을 것이다.";
    //a. 의수를 사용한다.
    private static string text_6="물이 빠르게 차오른다. \n여기서 더 시간을 끌었다가는 \n살아남기 힘들 것이다. ";
    private static string text_7="물이 코끝을 간지럽히고 \n숨을 들이마실 때마다 \n물이 들어와서 코가 찡했다. ";
    private static string text_8="더는 시간을 지체할 수 없었다. \n나는 욕조 덮개 틈 사이로 \n의수를 밀어 넣고 힘을 줬다. \n처음에는 꼼짝하지 않던 \n덮개 끝부분이 조금씩 들썩이다가 \n완전히 벌어졌다";
    private static string text_9="덮개가 들리자마자 \n틈 사이로 몸을 빼냈다. ";
    private static string text_10="머리카락까지 적신 물이 \n욕조 덮개 틈 사이로 넘쳐흘렀다. \n힘을 너무 세게 준 탓인지 \n손바닥과 손가락이 이어지는 \n부분이 약간 휘었다.\n감각이 둔해지고 손목이 저릿했다.";
    private static string text_11="의수를 쥐었다 펴니 \n오랫동안 기름칠을 하지 않은 \n기계처럼 손가락 마디마디가 \n부자연스러웠다.";
    private static string text_12="제대로 움직이지 않는 의수의 \n손가락 관절 부분을 매만지는데 \n다시 의수에서 소리가 들렸다";
    private static string text_13="\"괜찮...? 제 목소리.... 들...요?\"";
    private static string text_14="이건 분명 카라의 목소리인데....\n카라가 갑자기 이렇게 친절하게\n말을 걸 리가 없다.\n그것도 의수를 통해서. \n도대체 누구지?";
    // b. 숨을 참고 버틴다
    private static string text_15="화장실에 누군가 갇혔을 \n때를 고려해 일정 시간 이상 \n인간의 생체 반응이 \n확인되지 않으면 \n화장실 문과 욕조 덮개가 \n열리게 되어있다.";
    private static string text_16="물이 코끝을 간지럽히고 \n숨을 들이마실 때마다 \n물이 들어와서 코가 찡했다.\n이대로 죽을지도 모른다는 \n공포가 온몸을 휩쓸었다.";
    private static string text_17="하지만 이제는 운명의 신에 \n목숨을 맡기는 수밖에. \n나는 물이 얼굴을 완전히 \n덮어버리기 전에 마지막으로 \n숨을 크게 들이쉬었다.";
    private static string text_18="얼마만큼의 시간이 지났을까? \n이제는 정말 버티기 어렵다고 \n생각할 즈음 욕조 덮개가 \n저절로 열렸다.";
    private static string text_19="나는 물속에서 빠져나와 \n차가운 타일 바닥 위에 엎어져서 \n숨을 골랐다.";
    private static string text_20="욕조에서 빠져나오니 또다시\n의수에서 파란 불빛이 번쩍였다.";
    private static string text_21="\"괜찮...? 제 목소리.... 들...요?\"";
    private static string text_22="설마 이건...사라의 목소리인가?";
    private static string text_23="다행히 반신욕용 덮개라 \n팔만 겨우 빠져나갈 정도의 \n틈이 있었다.\n의수를 쓴다면 덮개를 \n뜯어낼 수 있을지도 모른다.";
    private static string text_24="하지만 정말 \n그 방법밖에 없는 걸까…?";
    private static string text_25="심호흡하면서 \n마음을 가다듬었다. \n분명 지금 상황을 해결할\n방법이 있을 것이다.";

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

    //awake()
    void Awake(){
        FadeOut(1.0f);
        Debug.Log("fadein : awake function");
        //fadein
    }

    // Start is called before the first frame update
    void Start()
    {
        //(1)choice1
        GameObject choice1 = GameObject.Find("choice1");
        Button choice1B =choice1.GetComponent<Button>();
        Text choice1t = GameObject.Find("choice1Text").GetComponent<Text>();
        choice1t.text="";
        choice1B.interactable=false;
        choice1B.onClick.AddListener(text6_3_1.choice1);

        //(2)choice 2 : B. 카라를 부른다.
        GameObject choice2 = GameObject.Find("choice2");
        Button choice2B =choice2.GetComponent<Button>();
        Text choice2t = GameObject.Find("choice2Text").GetComponent<Text>();
        choice2t.text="";
        choice2B.interactable=false;
        choice2B.onClick.AddListener(text6_3_1.choice2);
        
   
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_3_1_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);


    }

    // Update is called once per frame
    void Update()
    {
        if(num==2){
            StartCoroutine(coroutine1);
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
            // FadeOut(1.0f);
            // Invoke("fadeout1",1.1f);
            
        }
        if(num==11){
            StartCoroutine(coroutine4);//"text: 이제 어떡하지?"
            Debug.Log("coroutine is started!  num"+num);
            num++;
            //narration
        }
        if(num==14){
            선택지활성화();//choice1&choice2
            num++;//activate button
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.interactable=false;//선택지 선택 중에는 스킵 액션비활성화 
        }
        if(num==17){
            Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
            스킵.interactable=true;//선택지 선택 중에는 스킵 액션비활성화 
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;

        }
        if(num==20){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==23){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
         if(num==26){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==29){
            FadeIn(1.0f);
            //ending -> no scenechange!
        }
        
    }
}