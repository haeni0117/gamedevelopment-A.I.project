using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_3_1 : MonoBehaviour
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
    private static string text_1="\"으악\"";
    private static string text_2="갑자기 차가운 물이 느껴져서 \n눈을 번쩍 떴다. \n빠른 속도로 욕조에 \n물이 차오르고 있었다.\n허둥거리며 몸을 일으키려 했지만, \n두꺼운 벽에 뒤통수를 부딪쳤다.";
    private static string text_3="손을 뻗어 겨우 벽을 만져보니 \n우둘투둘한 문양의 \n욕조 덮개가 느껴졌다.\n반신욕을 할 때 사용하는 \n욕조 덮개였다.";
    private static string text_4="욕조 밖에서 시루의 \n당황한 울음소리가 들렸다.";
    //text click : 이제 어떡하지?
    private static string text_5="이제 어떡하지?";
    //click choice
    //카라를 부른다(choice2 text)
    private static string text_6="좁은 욕조에 갇혀 죽기만을 \n기다릴 수는 없다. \n가능성이 적다는 건 알고 있지만, \n카라를 부르는 것 말고는 \n방법이 없어.";
    private static string text_7="\"카라! 꺼내줘! \n물이 차오르고 있어! \n카라! 제발.....\"";
    private static string text_8="물이 점점 더 차오른다. \n이제 정말 숨을 쉬기가 버거웠다.\n카라를 부를수록 더 많은 양의 \n물이 목과 코를 침범했다. \n나는 마지막 숨을 토해내면서 \n카라의 이름을 불렀지만, \n카라는 역시 대답이 없다.";
    private static string text_9="\"카라.....!\"";
    //bad ending!
    private static string text_10="배드 엔딩 – 맹목적 신뢰 \n\"과도한 믿음은 \n죽음을 초래하기도 하죠.\"";
    
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
       스킵.onClick.AddListener(text6_3_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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