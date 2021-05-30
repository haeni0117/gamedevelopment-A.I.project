using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1 : MonoBehaviour
{
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정 
    public static Text typingText; 
    public static GameObject fadeout;

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
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    public static void 어디서부터찾아볼까(){
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text="▷ 어디부터 찾아볼까?";
        어디서부터B.interactable=true;

    }

    //어디서부터찾아볼까 클릭 후 이벤트
    public static void 어디서부터찾아볼까선택지활성화(){
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text="▶ 어디부터 찾아볼까?";
        어디서부터B.interactable=false;

        Debug.Log("구급상자 탐색장소 목록 보여주기");
         //안방
        GameObject 안방 = GameObject.Find("안방");
        Button 안방B =안방.GetComponent<Button>();
        Text 안방t = GameObject.Find("안방Text").GetComponent<Text>();
        안방t.text="◎ 안방에 들어간다.";
        안방B.interactable=true;
        안방B.onClick.AddListener(text6_1.안방으로이동);

        //작업실
        GameObject 작업실 = GameObject.Find("작업실");
        Button 작업실B =작업실.GetComponent<Button>();
        Text 작업실t = GameObject.Find("작업실Text").GetComponent<Text>();
        작업실t.text="◎ 작업실에 들어간다.";
        작업실B.interactable=true;
        작업실B.onClick.AddListener(text6_1.작업실로이동);

        //거실
        GameObject 거실 = GameObject.Find("거실");
        Button 거실B =거실.GetComponent<Button>();
        Text 거실t = GameObject.Find("거실Text").GetComponent<Text>();
        거실t.text="◎ 거실에 들어간다.";
        거실B.interactable=true;
        거실B.onClick.AddListener(text6_1.거실로이동);

        //게스트룸
        GameObject 게스트룸 = GameObject.Find("게스트룸");
        Button 게스트룸B =게스트룸.GetComponent<Button>();
        Text 게스트룸t = GameObject.Find("게스트룸Text").GetComponent<Text>();
        게스트룸t.text="◎ 게스트룸에 들어간다.";
        게스트룸B.interactable=true;
        게스트룸B.onClick.AddListener(text6_1.게스트룸으로이동);



    }

    //안방으로 씬이동
    public static void 안방으로이동(){
        Debug.Log("안방으로 이동");
        SceneManager.LoadScene("6-1-1");
    }
    //작업실로 씬이동
    public static void 작업실로이동(){
        Debug.Log("작업실로 이동");
        SceneManager.LoadScene("6-1-2");
    }
    //안방으로 씬이동
    public static void 거실로이동(){
        Debug.Log("거실로 이동");
        SceneManager.LoadScene("6-1-3");
    }
    //안방으로 씬이동
    public static void 게스트룸으로이동(){
        Debug.Log("게스트룸으로 이동");
        SceneManager.LoadScene("6-1-4");
    }


    private static string text_1="다시 카라를 소리쳐 불렀지만, \n답이 없었다.\n차라리 화라도 냈다면 \n덜 불안했을까?";
    private static string text_2="카라 앞에서 내 목숨은 \n플라스틱 장난감에 쌀알을 넣고 \n흔드는 것만큼이나 가벼웠다. ";
    private static string text_3="나를 죽이기 위해 \n카라는 난방 시스템을 \n완전히 끊어 버리거나\n바닥 온도를 걸어 다닐 수 없을 만큼 \n높일 수 있었다.";
    private static string text_4="아니면 그냥, \n외부와의 연결을 끊은 채 \n굶어 죽을 때까지 \n내버려 둘 수도 있다.";
    private static string text_5="어차피 2주쯤 연락이 없다고 해도 \n나를 찾는 사람은 \n아무도 없을 테니까. \n하지만 다행히 카라와 연락이 끊긴 지 \n꽤 오랜 시간이 지난 후에도 \n1층 거실은 밝았고, \n바닥은 뜨겁지 않았다.";
    private static string text_6="나는 그저\n차갑고 어두운 이곳에\n또다시,\n혼자,\n갇힌 것이다.";
    private static string text_7="'야-옹'";
    private static string text_8="나도 모르게 힘을 너무 세게 줬는지\n시루가 품을 빠져나왔다.\n시루는 고작 허리에서 바닥으로 \n점프하는데도 착지할 때 \n비틀거렸다.\n회색빛 대리석에 \n고양이 발바닥 모양의 \n핏자국이 선명하게 찍혔다";
    private static string text_9="'약속했잖아, 지켜주겠다고.'";
    private static string text_10="나는 두려움을 삼키고 \n다시 몸을 일으켰다. \n약속을 지키기 위해.";
    private static string text_11="자꾸만 도망가는 시루를 \n겨우 붙잡고 \n피가 흐르는 뒷다리를 살폈다.\n왼쪽 뒤 발바닥에 \n베인 상처가 뚜렷했다. \n아마 나무에서 미끄러지면서 \n거친 껍질에 상처가 난 것 같다. ";
    private static string text_12="어서 구급상자를 찾아야 해.";
    
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


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene 5-1 is started");
    //skipButton -> definition
       Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       StartCoroutine(coroutine);

        //다음물엄 : 어디서부터찾아볼까?(구급상자탐색)
        GameObject 어디서부터 = GameObject.Find("어디서부터");
        Button 어디서부터B =어디서부터.GetComponent<Button>();
        Text 어디서부터t = GameObject.Find("어디서부터Text").GetComponent<Text>();
        어디서부터t.text=" ";
        어디서부터B.interactable=false;
        어디서부터B.onClick.AddListener(text6_1.어디서부터찾아볼까선택지활성화);

        //안방
        GameObject 안방 = GameObject.Find("안방");
        Button 안방B =안방.GetComponent<Button>();
        Text 안방t = GameObject.Find("안방Text").GetComponent<Text>();
        안방t.text=" ";
        안방B.interactable=false;
        안방B.onClick.AddListener(text6_1.안방으로이동);

        //작업실
        GameObject 작업실 = GameObject.Find("작업실");
        Button 작업실B =작업실.GetComponent<Button>();
        Text 작업실t = GameObject.Find("작업실Text").GetComponent<Text>();
        작업실t.text=" ";
        작업실B.interactable=false;
        작업실B.onClick.AddListener(text6_1.작업실로이동);

        //거실
        GameObject 거실 = GameObject.Find("거실");
        Button 거실B =거실.GetComponent<Button>();
        Text 거실t = GameObject.Find("거실Text").GetComponent<Text>();
        거실t.text=" ";
        거실B.interactable=false;
        거실B.onClick.AddListener(text6_1.거실로이동);

        //게스트룸
        GameObject 게스트룸 = GameObject.Find("게스트룸");
        Button 게스트룸B =게스트룸.GetComponent<Button>();
        Text 게스트룸t = GameObject.Find("게스트룸Text").GetComponent<Text>();
        게스트룸t.text=" ";
        게스트룸B.interactable=false;
        게스트룸B.onClick.AddListener(text6_1.게스트룸으로이동);


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
            어디서부터찾아볼까();
            Debug.Log("어디서부터 찾아볼까 클릭");
            num++;
        }

    }
}
