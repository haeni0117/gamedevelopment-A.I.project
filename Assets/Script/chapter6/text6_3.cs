using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class text6_3 : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeIn(fadeOutTime,nextEvent));
	}

	public void FadeOut(float fadeOutTime, System.Action nextEvent = null){
		StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
	}
    public static void scenechange(){
        SceneManager.LoadScene("6-3-1");
    }
    public static GameObject a;
    public static Button aB;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
//(3)의지
    public static GameObject c;
    public static Button cB;
    public static Button 스킵;
    public static Text ct;
//(4)iot쓰레기통
    public static GameObject d;
    public static Button dB;
    public static Text dt;
    public static bool a_inspection=false;
    public static bool b_inspection= false;


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


    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

     public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
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
    public static void a활성화(){
        num = 47;

    }
     public static void b활성화(){
        num=50;
    }

    private static string text_1="조심스럽게 베개 틈 사이에 낀 \n인형 발을 꺼냈다. \n어린아이가 들고 다닐 만한 \n우주비행사 모양의 인형이다. ";
    private static string text_2="겉면의 천은 다 낡고 헤졌지만, \n방금 빤 것처럼 깨끗했다. \n머리와 몸체를 잇는 부분을 \n기운 흔적이 있다.\n서툰 바느질 솜씨 탓에 \n실 사이로 듬성듬성 솜이 보였다. \n누군가 인형을 굉장히 소중하게 \n여긴 것이 분명하다.\n인형의 모습이 \n어딘가 굉장히 익숙한데....";
    private static string text_3="...아, 난 이 인형을 알아. \n이건 분명….";
    private static string text_4="오빠의 장례식 관 위에 \n올려두었던 애착 인형이다.";
    private static string text_5="애써 묻어 두었던 기억들이\n파도처럼 나를 덮쳤다."; //B선택지연결(변기로간다)
    //C선택지(욕조로 간다)
    private static string text_6="오빠는 늘 우주비행사가 \n되고 싶어 했다.\n광활한 우주에서 \n주먹 크기로 줄어든 \n지구를 바라보고 싶다고 했다.\n그리고 오빠가 우주비행사 \n꿈을 꿀 때면 \n늘 그 곁엔 ‘아로’가 있었다.."; //C선택지연결
    private static string text_7="친구나 엄마가 나이에 맞지 않게 \n인형을 끌어안고 잔다고\n핀잔을 줄 때도,\n오빠는 개의치 않았다.";
    private static string text_8="‘아로’를 바라보며 \n진짜 우주에 데려가겠다고 \n약속했으니까. \n그리고 오빠는 충분히 \n그 꿈을 이룰 수 있는 \n사람이었다.";//원래 반복
    private static string text_9="살아 있었다면.\n나만 아니었다면.\n내가 순간의 호기심에\n돌발행동을 하지 않았다면. ";
    private static string text_10="애써 묻어뒀던 기억이 \n악착같이 고개를 들었다.";
    private static string text_11="‘안전벨트....'";
    private static string text_12="숨이 막히고 머리가 어지럽다. \n텅 빈 이 공간은 너무 넓고, \n나는 너무 초라하고 작았다.";
    private static string text_13="좁은 공간으로,\n가야만,\n해....";
    private static string text_14="제발....";
    private static string text_15="여기선,\n버틸 수가,\n없어...";
    private static string text_16="어디로 가야 하지?";
    private static string text_17="거실은 너무 넓어....\n전혀 안정을 찾을 수 없어";
    private static string text_18="나는 본능적으로\n좁은 공간을 찾아\n화장실로 뛰어 들어갔다.";
    //coroutine function
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
    // Start is called before the first frame update
    void Awake(){
        
        Debug.Log("fadein : awake function");
         a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        aB.onClick.AddListener(a활성화);

        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bB.onClick.AddListener(b활성화);

        at.text="A.거실로 간다.";
        bt.text="B.게스트룸 화장실로 간다.";
        a.SetActive(false);
        b.SetActive(false);

        // c = GameObject.Find("c");
        // cB =c.GetComponent<Button>();
        // ct = GameObject.Find("cText").GetComponent<Text>();
        // cB.onClick.AddListener(c활성화);

        // d = GameObject.Find("d");
        // dB =d.GetComponent<Button>();
        // dt = GameObject.Find("dText").GetComponent<Text>();
        // dB.onClick.AddListener(d활성화);
        //fadein
    }
    void Start()
    {
        Debug.Log("Scene 6-3 is started");
        //오피스텔 화장실 .img
   
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
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
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==35){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==38){
            StartCoroutine(coroutine13);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==41){
            StartCoroutine(coroutine14);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==44){
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            스킵.interactable=false;
            num++;
        }
        if(num==46){
            a.SetActive(true);
            b.SetActive(true);
        }
        if(num==47){
            StartCoroutine(coroutine16);
            
        }
        if(num==49){
            a.SetActive(true);
            if(a_inspection==true){
                aB.interactable=false;
            }else aB.interactable=true;
            b.SetActive(true);
        }
        if(num==50){
            StartCoroutine(coroutine17);
            num++;
        }
        if(num==52){
            SceneManager.LoadScene("6-4");
        }
        


    }
}
