using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//7.5 #5 사라와 대화

public class text_8_1 : MonoBehaviour
{
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

    
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    private static string text_1="10분의 1도 안 되는 확률에 \n나와 시루의 목숨을 걸 수는 없어.";
    private static string text_2="나는 결국 사라를 컴퓨터에 \n연결하려는 계획을 포기했다.\n나는 인터넷이 끊긴 컴퓨터에 \n앞에 앉아 멍하니 의수를 \n바라보았다.";
    private static string text_3="그런데 묘하게 이상한 냄새가 난다.\n이게 도대체 무슨 냄새지…?";
    private static string text_4="갑자기 1층 거실에서 \n휴대전화 소리가 울렸다. \n설마 다시 통신이 터지는 건가?\n가슴이 뛰었다. \n이건 하늘이 내려주신 기회야.";
    private static string text_5="벌떡 일어나 시루를 안고\n1층으로 내려가는 계단 \n앞에 섰다.\n그런데…. \n계단을 내려갈수록 냄새가 \n점점 짙어진다. \n이대로 내려가도 괜찮은 걸까?";


    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);       
    static IEnumerator coroutine3 = Typing(text_4);
    static IEnumerator coroutine4 = Typing(text_5);
    
    public static void 어떻게할까(){
        GameObject 어떻게할까 = GameObject.Find("어떻게할까");
        Button 어떻게할까B =어떻게할까.GetComponent<Button>();
        Text 어떻게할까t = GameObject.Find("어떻게할까Text").GetComponent<Text>();
        어떻게할까t.text="▷ 어떻게 할까?";
        어떻게할까B.interactable=true;
    }

    public static void 선택지1이동(){
        Debug.Log("A 전화가 끊기기 전에 내려간다 선택(ending)");
        SceneManager.LoadScene("8-1-1");
    }
    public static void 선택지2이동(){
        Debug.Log("B 신중한판단");
        SceneManager.LoadScene("8-1-2");
    }


    public static void 어떻게할까활성화(){
        GameObject 어떻게할까 = GameObject.Find("어떻게할까");
        Button 어떻게할까B =어떻게할까.GetComponent<Button>();
        Text 어떻게할까t = GameObject.Find("어떻게할까Text").GetComponent<Text>();
        어떻게할까t.text="▶ 어떻게 할까?";
        어떻게할까B.interactable=false;

        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B = 선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text="▷ 일분일초가 급하다.\n    전화가 끊기기 전에 어서 내려가야 해.";
        선택지1B.interactable=true;

        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B = 선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text="▷ 섣불리 움직이지 않는 게 좋겠어. \n    내려가지 않는다.";
        선택지2B.interactable=true;
    }




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.

        //Q 어떻게할까?
        GameObject 어떻게할까 = GameObject.Find("어떻게할까");
        Button 어떻게할까B =어떻게할까.GetComponent<Button>();
        Text 어떻게할까t = GameObject.Find("어떻게할까Text").GetComponent<Text>();
        어떻게할까t.text=" ";
        어떻게할까B.interactable=false;
        어떻게할까B.onClick.AddListener(text_8_1.어떻게할까활성화);

        //선택지1
        GameObject 선택지1 = GameObject.Find("선택지1");
        Button 선택지1B = 선택지1.GetComponent<Button>();
        Text 선택지1t = GameObject.Find("선택지1Text").GetComponent<Text>();
        선택지1t.text=" ";
        선택지1B.interactable=false;
        선택지1B.onClick.AddListener(text_8_1.선택지1이동);

        //선택지2
        GameObject 선택지2 = GameObject.Find("선택지2");
        Button 선택지2B = 선택지2.GetComponent<Button>();
        Text 선택지2t = GameObject.Find("선택지2Text").GetComponent<Text>();
        선택지2t.text=" ";
        선택지2B.interactable=false;
        선택지2B.onClick.AddListener(text_8_1.선택지2이동);



        Debug.Log("coroutin is started! #3-1 num"+num);
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
            Debug.Log("어떻게 할까 ()");
            어떻게할까();
            num++;
        }
       

    }
}
