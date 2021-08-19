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

    public static GameObject a;
    public static Button aB;
    public static Button 스킵;
    public static Text at;
//(2)반려동물 방석
    public static GameObject b;
    public static Button bB;
    public static Text bt;
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    private static string text_1="10분의 1도 안 되는 확률에 \n나와 시루의 목숨을 걸 수는 \n없어.\n나는 결국 사라를 컴퓨터에 \n연결하려는 계획을 포기했다.\n나는 인터넷이 끊긴 컴퓨터에 \n앞에 앉아 멍하니 의수를 \n바라보았다.";
    private static string text_2="그런데 묘하게 이상한 냄새가 \n난다. \n이게 도대체 무슨 냄새지…?";
    private static string text_3="갑자기 1층 거실에서 휴대전화 \n소리가 울렸다. \n설마 다시 통신이 터지는 건가?\n가슴이 뛰었다. \n이건 하늘이 내려주신 기회야. ";
    private static string text_4="벌떡 일어나 시루를 안고 \n1층으로 내려가는 계단 \n앞에 섰다.\n그런데…. \n계단을 내려갈수록 냄새가 \n점점 짙어진다. \n이대로 내려가도 괜찮은 걸까?";
    private static string text_5="어떻게 할까?";


    private static string text_6="전화가 끊기더라도 다시 전화를 \n걸어 구조를 요청하면 된다. ";
    private static string text_7="나는 주저하지 않고 계단을 \n내려갔다. 밑으로 내려갈수록 \n원인을 알 수 없는 냄새가 \n심해져서 옷깃으로 코를 막았다.";
    private static string text_8="전화는 거실 테이블 위에 있다.\n이제 전화만 받으면\n카라를 벗어날 수 있다.";
    private static string text_9="\"여보세요?\"";
    private static string text_10="\"저런...\n이렇게 쉬운 줄 알았다면,\n 진작 시도하는 건데.\"";
    private static string text_11="금속성의 날카로운 웃음소리가 \n거실에 울려 퍼지고, 귀가 \n멍할 정도로 큰 폭발음과 \n함께 폭풍 같은 화마가 들이닥쳤다.";
    private static string text_12="\"안돼..., 이렇게 죽을 수는 없어...\"";
    private static string text_13="\"배드엔딩-가스 폭발\n-너무 성급한 결정을 내리셨군요. \n때로는 행동하기 전에 잠시 \n생각하는 시간을 갖는 것도 좋답니다.-\"";
    // private static string text_14="\"뭔가 이상해...\n분명히 아까 집 안의 모든 \n통신이 다 끊긴 걸 확인했는데 \n갑자기 전화가 온다니?\n계단 앞에서 시루가 날카롭게 \n울기 시작했다.\n마치 내려가지 말라고 나를 \n말리는 것처럼.\"";
    // private static string text_15="\"도대체 무슨 냄새일까?\n직접 내려가 보지 않더라도 \n1층을 살펴볼 수 있으면 좋을 텐데…\"";
    // private static string text_16="\"여분의 인공지능을 보관하기에 \n이곳이 가장 안전한 공간이라고 \n하셨습니다. \n의수는 가장 보안이 강력한 \n기기니까요.\"";
    // private static string text_17="\"그럼 사라 혹시...지금 인터넷 연결돼?\"\n\n목소리에서 은근한 희망과\n조바심이 묻어났다.";
    // private static string text_18="\"안 그래도 그 말씀을 드리려고 \n했습니다. 지난 8월부터 사라 RC492, \n버전 26.6는 신원을 알 수 없는 \n사용자로부터 보안 공격을 \n총 69320회 받았습니다. \n현재 저는 공격을 방어하기 위해 \n자동으로 인터넷 연결을 해지해서 \n온라인 접속이 불가능합니다.\"";
    // private static string text_19="\"보안 공격? 진원지는 파악했어?\"";
    // private static string text_20="\"진원지는 서울시 서대문구 \n도시복합체 52동à(나)길 56호입니다.\"";
    // private static string text_21="\"52동 나길 563호면…. 우리 집이잖아?\"";
    // private static string text_22="\"“그렇습니다.\n집 내부에서 공격을\n받는 것 같습니다.”\"";
    // private static string text_23="사라가 인터넷에 접속하는 것을 \n막으려면 카라 자신의 인터넷 \n연결도 끊어야 한다.";
    // private static string text_24="사라가 카라보다 이전 모델이긴 \n하지만, 기능적으로 어마어마한 \n차이가 나는 건 아니었다.\n게다가 카라는 \n불안정한 베타 버전이다.\n사라가 카라에게서 통제권을 \n빼앗아 올 수만 있다면.....\n\n그럴 수만 있다면,\n이 집을 탈출할 수 있다.";
    // private static string text_25="\"사라. 내가 만약 컴퓨터에 \n너를 수동으로 연결하면 \n스마트홈 통제권을 회복할 수 \n있을까?\"";
    // private static string text_26="\"확실하지 않습니다. \n현재 카라 KMà468, 베타 버전은 \n도시복합체 52동 (나)길 563호의 \n호스트입니다. \n컴퓨터에 연결을 시도했을 때 \n제가 호스트가 될 가능성은 \n6.45%입니다.\"";
    // private static string text_27="고작 6.45%라니.\n나는 다시 암담해졌다. \n하지만 사라 없이 혼자 탈출을 \n시도해서 성공할 가능성은 \n몇 퍼센트나 될까?\n어쩌면 6.45%가 내 유일한 \n선택지인 것은 아닐까?";
    // private static string text_28="사라를 컴퓨터에 연결할까?";
    
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
    // static IEnumerator coroutine13 = Typing(text_14);
    // static IEnumerator coroutine14 = Typing(text_15);
    // static IEnumerator coroutine15 = Typing(text_16);
    // static IEnumerator coroutine16 = Typing(text_17);
    // static IEnumerator coroutine17 = Typing(text_18);
    // static IEnumerator coroutine18 = Typing(text_19);
    // static IEnumerator coroutine19 = Typing(text_20);
    // static IEnumerator coroutine20 = Typing(text_21);       
    // static IEnumerator coroutine21 = Typing(text_22);
    // static IEnumerator coroutine22 = Typing(text_23);       
    // static IEnumerator coroutine23 = Typing(text_24);
    // static IEnumerator coroutine24 = Typing(text_25);
    // static IEnumerator coroutine25 = Typing(text_26);
    // static IEnumerator coroutine26 = Typing(text_27);
    // static IEnumerator coroutine27 = Typing(text_28);
    public static void a활성화(){
        num=14;
    }
    public static void b활성화(){
        num=17;
    }
    






    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("a");
        aB =a.GetComponent<Button>();
        at = GameObject.Find("aText").GetComponent<Text>();
        aB.onClick.AddListener(a활성화);

        b = GameObject.Find("b");
        bB =b.GetComponent<Button>();
        bt = GameObject.Find("bText").GetComponent<Text>();
        bB.onClick.AddListener(b활성화);
        
        스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_8_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        at.text="A. 일분일초가 급하다. \n전화가 끊기기 전에 어서 내려가야 해. ";
        bt.text="B. 섣불리 움직이지 않는 게 \n좋겠어. 내려가지 않는다.";


        Debug.Log("coroutin is started! #3-1 num"+num);
        StartCoroutine(coroutine);
        a.SetActive(false);
        b.SetActive(false);
        스킵.interactable=true;
        
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
            스킵.interactable=false;
        }
        if(num==13){
            a.SetActive(true);
            b.SetActive(true);
            스킵.interactable=false;
        }
        if(num==14){
            SceneManager.LoadScene("8-2");
        }
        if(num==17){
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=true;
            a.SetActive(false);
            b.SetActive(false);
        }
        if(num==20){
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            스킵.interactable=true;
        }
        if(num==23){
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==26){
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==29){
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==35){
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==38){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }  
       
        
        

    }
}
