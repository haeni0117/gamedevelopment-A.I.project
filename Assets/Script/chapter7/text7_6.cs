using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//7.5 #5 사라와 대화

public class text7_6 : MonoBehaviour
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
    private static string text_1="'사라......'";
    private static string text_2="사라의 목소리를 들으니\n사라를 처음 만났을 때가\n떠오른다. ";
    private static string text_3="사라를 처음 만난 날 \n나는 고작 7살이었다. \n나는 태어날 때부터 인공지능과 \n함께한 ‘I’ 세대지만,\n사라, 더 정확히 말하면 \n사라 1.0에겐 \n어린 내가 보기에도 \n기존의 인공지능과는 다른 \n특별함이 있었다. ";
    private static string text_4="대학에서 인공지능을 \n연구했던 아빠는 \n사라가 인류의 미래를 책임질 \n핵심 기술이라고 굳게 믿었다.\n엄마는 집 안에 가족이 아닌 \n‘생각하는 존재’가 \n들어온다는 걸 꺼렸지만, \n나와 오빠는 이미 사라에게 \n완전히 매료된 뒤였다.";
    private static string text_5="아니, 사라는 \n매혹될 수밖에 없는 \n세이렌이었다. \n사라는 단순히 학습된 프로그램을 \n수행하는 기계가 아닌,\n사람처럼 우선순위를 설정하고, \n하위 프로그램에게 \n명령을 내리고, \n인간과 어색하지 \n않게 대화를 나눌 수 있는,\n최초의 인공지능이었다.";
    private static string text_6="나는 그저\n차갑고 어두운 이곳에\n또다시,\n혼자,\n갇힌 것이다.";
    private static string text_7="나는 초등학교 때부터 \n사라와 함께 \n숙제를 했고, \n대학교에 입학한 뒤에는 \n과제를 했으며,\n자이나 사에 취직한 뒤에도 \n업무를 함께 했다.";
    private static string text_8="사라는 내 부모님이자 친구였고, \n심리 상담사이자 주치의였다.";
    private static string text_9="사라는, 내 유년의 전부였다.";
    private static string text_10="그런데 그랬던 사라가 어쩌다.....";
    private static string text_11="\"의수에 있는 거지?\"";
    private static string text_12="\"맥락을 이해하지 못했습니다.\n제가 왜 의수에 있는지 물으시는 건가요?\"";
    private static string text_13="\"그래…. \n네가 어쩌다 그곳에 들어가게 \n된 건지 도무지 모르겠어. \n기억이…, 기억이 전혀 안나.\"";
    private static string text_14="\"작년 6월 카라 베타 버전이 \n출시되고 저를 의수에 \n보관하셨습니다.\"";
    private static string text_15="\"근데 왜 하필이면 의수에......\"";
    private static string text_16="\"여분의 인공지능을 보관하기에 \n이곳이 가장 안전한 공간이라고 \n하셨습니다. \n의수는 가장 보안이 강력한 \n기기니까요.\"";
    private static string text_17="\"그럼 사라 혹시...지금 인터넷 연결돼?\"\n\n목소리에서 은근한 희망과\n조바심이 묻어났다.";
    private static string text_18="\"안 그래도 그 말씀을 드리려고 \n했습니다. 지난 8월부터 사라 RC492, \n버전 26.6는 신원을 알 수 없는 \n사용자로부터 보안 공격을 \n총 69320회 받았습니다. \n현재 저는 공격을 방어하기 위해 \n자동으로 인터넷 연결을 해지해서 \n온라인 접속이 불가능합니다.\"";
    private static string text_19="\"보안 공격? 진원지는 파악했어?\"";
    private static string text_20="\"진원지는 서울시 서대문구 \n도시복합체 52동à(나)길 56호입니다.\"";
    private static string text_21="\"52동 나길 563호면…. 우리 집이잖아?\"";
    private static string text_22="\"“그렇습니다.\n집 내부에서 공격을\n받는 것 같습니다.”\"";
    private static string text_23="사라가 인터넷에 접속하는 것을 \n막으려면 카라 자신의 인터넷 \n연결도 끊어야 한다.";
    private static string text_24="사라가 카라보다 이전 모델이긴 \n하지만, 기능적으로 어마어마한 \n차이가 나는 건 아니었다.\n게다가 카라는 \n불안정한 베타 버전이다.\n사라가 카라에게서 통제권을 \n빼앗아 올 수만 있다면.....\n\n그럴 수만 있다면,\n이 집을 탈출할 수 있다.";
    private static string text_25="\"사라. 내가 만약 컴퓨터에 \n너를 수동으로 연결하면 \n스마트홈 통제권을 회복할 수 \n있을까?\"";
    private static string text_26="\"확실하지 않습니다. \n현재 카라 KMà468, 베타 버전은 \n도시복합체 52동 (나)길 563호의 \n호스트입니다. \n컴퓨터에 연결을 시도했을 때 \n제가 호스트가 될 가능성은 \n6.45%입니다.\"";
    private static string text_27="고작 6.45%라니.\n나는 다시 암담해졌다. \n하지만 사라 없이 혼자 탈출을 \n시도해서 성공할 가능성은 \n몇 퍼센트나 될까?\n어쩌면 6.45%가 내 유일한 \n선택지인 것은 아닐까?";
    private static string text_28="사라를 컴퓨터에 연결할까?";
    
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
    public static void a활성화(){
        num=80;
    }
    public static void b활성화(){
        num=81;
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
        스킵.onClick.AddListener(text7_6.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        at.text="a. 네";
        bt.text="b. 아니요";


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
        if(num==32){
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==35){
            StartCoroutine(coroutine13);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==38){
            StartCoroutine(coroutine14);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==41){
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==44){
            StartCoroutine(coroutine16);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==47){
            StartCoroutine(coroutine17);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==50){
            StartCoroutine(coroutine18);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==53){
            StartCoroutine(coroutine19);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==56){
            StartCoroutine(coroutine20);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==59){
            StartCoroutine(coroutine21);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==62){
            StartCoroutine(coroutine22);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==65){
            StartCoroutine(coroutine23);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        } 
        if(num==68){
            StartCoroutine(coroutine24);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==71){
            StartCoroutine(coroutine25);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==74){
            StartCoroutine(coroutine26);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==77){
            StartCoroutine(coroutine27);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==79){
            a.SetActive(true);
            b.SetActive(true);
        }
        if(num==80){//yes
            
        }
        if(num==81){
            SceneManager.LoadScene("8-1");
        }

    }
}
