using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_2 : MonoBehaviour
{// Start is called before the first frame update
    public static int num = 2;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    
    public static GameObject fadeout;

    //조사할 오브젝트
    public static GameObject bed;
    public static GameObject answer_a;
    public static GameObject answer_b;

    public static Button bed_b;
    public static Button answer_a_b;
    public static Button answer_b_b;

    public static Text bed_t;
    public static Text answer_a_t;
    public static Text answer_b_t;
    public static Text typingText;

    public static Button 스킵;

    private static string text_1="구급상자를 발견하고\n안도의 한숨을 쉬었다.\n\n\n\"우리 시루 착하지?\"";
    private static string text_2="시루를 치료한다.";
    private static string text_3="시루의 발에 붕대를 \n단단히 감아주었다. \n병원에 가서 확실하게 \n치료를 받아야겠지만 \n지금은 이게 최선이다.";
    private static string text_4="{ 구급 상자 삭제 }";
    private static string text_5="시루는 치료를 마치자마자 \n침대에 똬리를 틀고 누워 \n꼼짝도 하지 않았다.\n피를 많이 흘린데다 \n베란다에 갇히기까지 해서 \n굉장히 지쳤을 것이다.";
    private static string text_6="시루, 이제 좀 쉬어.\n사료를 찾으러\n부엌으로 돌아가려는데\n아까 베개에서 봤던\n물체가 눈에 밟혔다.";
    private static string text_7="텅 빈 게스트룸 베개 위에\n놓인 물건이라니,\n도대체 뭐였을까?";
    private static string text_8="베개 사이에 \n인형 발 같은 것이 있다. \n난 어렸을 때부터 \n인형을 좋아하지 않았다.\n특히 바비인형처럼 \n사람을 본뜬 인형은 더더욱.\n도대체 왜 이런 게 \n여기 있는 거지?";
    private static string text_9="조심스럽게 베개 틈 사이에 낀 \n인형 발을 꺼냈다. \n어린아이가 들고 다닐 만한 \n우주비행사 모양의 인형이다. ";
    private static string text_10="겉면의 천은 다 낡고 헤졌지만, \n방금 빤 것처럼 깨끗했다. \n머리와 몸체를 잇는 부분을 \n기운 흔적이 있다.\n서툰 바느질 솜씨 탓에 \n실 사이로 듬성듬성 솜이 보였다. \n누군가 인형을 굉장히 소중하게 \n여긴 것이 분명하다.\n인형의 모습이 \n어딘가 굉장히 익숙한데….";
    private static string text_11="...아, 난 이 인형을 알아. \n이건 분명....";
    private static string text_12="오빠의 장례식 관 위에 \n올려두었던 애착 인형이다.";
    private static string text_13="애써 묻어 두었던 기억들이\n파도처럼 나를 덮쳤다.";
    private static string text_14="오빠는 늘 우주비행사가 \n되고 싶어 했다.\n광활한 우주에서 \n주먹 크기로 줄어든 \n지구를 바라보고 싶다고 했다.\n그리고 오빠가 우주비행사 \n꿈을 꿀 때면 \n늘 그 곁엔 ‘아로’가 있었다.";
    private static string text_15="친구나 엄마가 나이에 맞지 않게 \n인형을 끌어안고 잔다고 \n핀잔을 줄 때도,\n오빠는 개의치 않았다.";
    private static string text_16="‘아로’를 바라보며\n진짜 우주에 데려가겠다고\n약속했으니까.\n그리고 오빠는 충분히\n그 꿈을 이룰 수 있는\n사람이었다.";
    private static string text_17="살아 있었다면.\n나만 아니었다면.\n내가 순간의 호기심에\n돌발행동을 하지 않았다면.";
    private static string text_18="애써 묻어뒀던 기억이 \n악착같이 고개를 들었다";
    private static string text_19="'안전벨트.....'";
    private static string text_20="숨이 막히고 머리가 어지럽다. \n텅 빈 이 공간은 너무 넓고, \n나는 너무 초라하고 작았다.";
    private static string text_21="좁은 공간으로,\n가야만,\n해....";
    private static string text_22="제발....";
    private static string text_23="여기선,\n버틸 수가,\n없어....";
    private static string text_24="어디로 가야 하지?";
    private static string text_25="거실은 너무 넓어....\n전혀 안정을 찾을 수 없어.";
    private static string text_26="나는 본능적으로 \n좁은 공간을 찾아\n화장실로 뛰어 들어갔다.";




    static IEnumerator coroutine1 =  Typing(text_1);
    static IEnumerator coroutine2 =  Typing(text_2);
    static IEnumerator coroutine3 =  Typing(text_3);
    static IEnumerator coroutine4 =  Typing(text_4);
    static IEnumerator coroutine5 =  Typing(text_5);
    static IEnumerator coroutine6 =  Typing(text_6);
    static IEnumerator coroutine7 =  Typing(text_7);
    static IEnumerator coroutine8 =  Typing(text_8);
    static IEnumerator coroutine9 =  Typing(text_9);
    static IEnumerator coroutine10 =  Typing(text_10);
    static IEnumerator coroutine11 =  Typing(text_11);
    static IEnumerator coroutine12 =  Typing(text_12);
    static IEnumerator coroutine13 =  Typing(text_13);
    static IEnumerator coroutine14 =  Typing(text_14);
    static IEnumerator coroutine15 =  Typing(text_15);
    static IEnumerator coroutine16 =  Typing(text_16);
    static IEnumerator coroutine17 =  Typing(text_17);
    static IEnumerator coroutine18 =  Typing(text_18);
    static IEnumerator coroutine19 =  Typing(text_19);
    static IEnumerator coroutine20 =  Typing(text_20);
    static IEnumerator coroutine21 =  Typing(text_21);
    static IEnumerator coroutine22 =  Typing(text_22);
    static IEnumerator coroutine23 =  Typing(text_23);
    static IEnumerator coroutine24 =  Typing(text_24);
    static IEnumerator coroutine25 =  Typing(text_25);
    static IEnumerator coroutine26 =  Typing(text_26);
    // static IEnumerator coroutine27 =  Typing(text_27);

    
   

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;

    }
    public static void re(){
        num=41;
    }
    // public void activate(){
        
    //     sofa_b.interactable=true;
    //     table_b.interactable=true;
    //     speaker_b.interactable=true;
    //     decoration_b.interactable=true;
    //     walldeco_b.interactable=true;
    //     tv_b.interactable=true;
    //     another_b.interactable=true;

    //     sofa_t.text="(1) 소파";
    //     table_t.text="(2) 탁자";
    //     speaker_t.text="(3) 스피커";
    //     decoration_t.text="(4) 장식장";
    //     walldeco_t.text="(5) 벽면 화분 장식";
    //     tv_t.text="(6) TV";
    //     another_t.text="(7) 다른 장소로 가본다.";
        
        
        
    // }
    // public void inactivate(){
        
    //     sofa_b.interactable=false;
    //     table_b.interactable=false;
    //     speaker_b.interactable=false;
    //     decoration_b.interactable=false;
    //     walldeco_b.interactable=false;
    //     tv_b.interactable=false;
    //     another_b.interactable=false;

    //     sofa_t.text=" ";
    //     table_t.text=" ";
    //     speaker_t.text=" ";
    //     decoration_t.text=" ";
    //     walldeco_t.text=" ";
    //     tv_t.text=" ";
    //     another_t.text=" ";}

    // public void click_sofa(){
    //     스킵.interactable=false;
    //     num=2;
    // }
    // public void click_table(){
    //     스킵.interactable=false;
    //     num=5;
    // }
    // public void click_speaker(){
    //     스킵.interactable=false;
    //     num=8;
    // }
    // public void click_decoration(){
    //     num=11;
    //     스킵.interactable=false;
    // }
    // public void click_walldeco(){
    //     스킵.interactable=false;
    //     num=14;
    // }
    // public void click_tv(){
    //     스킵.interactable=false;
    //     num=17;
    // }
    // public void click_another(){
    //     스킵.interactable=false;
    //     num=20;
        
    // }
    

    // public void choiceAB_activate(){
    //     achoice_b.interactable=true;
    //     bchoice_b.interactable=true;
    //     achoice_t.text="A. 다른 곳을 둘러본다.";
    //     bchoice_t.text="B. 아니다. 더 찾아보자.";

    // }
    // public void click_achoice(){
    //     SceneManager.LoadScene("6-1");
    // }
    // public void click_bchoice(){
    //     achoice_b.interactable=false;
    //     bchoice_b.interactable=false;
    //     achoice_t.text=" ";
    //     bchoice_t.text=" ";
    //     activate();
    //     typingText.text=" ";
    // }
    public void click_answer_a(){
        num=74;
    }
    public void click_answer_b(){
        num=77;
    }
    public void nextscene(){
        SceneManager.LoadScene("6-3");
    }
    // public void click_question(){
    //     num=
    //     Invoke("activate_answers",1f);
    // }
    public void activate_answers(){
        answer_a_b.interactable=true;
        answer_a_t.text="A. 거실로 간다.";
        answer_b_b.interactable=true;
        answer_b_t.text="B. 게스트룸 화장실로 간다.";


    }
    public void click_bed(){
        num=23;
    }
    public void activate_bed(){
        bed_b.interactable=true;
        bed_t.text="(1) 침대";
    }

    static IEnumerator Typing(string message)
    {
        typingText = GameObject.Find("general text").GetComponent<Text>();
        Debug.Log(typingText);
        Debug.Log(message);

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


  void Awake(){
    bed=GameObject.Find("bed");
    bed_b=GameObject.Find("bed").GetComponent<Button>();
    bed_t=GameObject.Find("bedtext").GetComponent<Text>();
    bed_b.interactable=false;
    bed_t.text=" "; 
    answer_a_b=GameObject.Find("answer_a").GetComponent<Button>();
    answer_a_t=GameObject.Find("answer_atext").GetComponent<Text>();
    answer_b_b=GameObject.Find("answer_b").GetComponent<Button>();
    answer_b_t=GameObject.Find("answer_btext").GetComponent<Text>();

  }
    // Start is called before the first frame update
   void Start()
    {
        스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text6_2.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        스킵.interactable=false;
        bed_b.onClick.AddListener(click_bed);
        bed_b.interactable=false;
        bed_t.text=" "; 
        answer_a_t.text=" ";
        answer_b_t.text=" ";

    Debug.Log("coroutin is started! #6-2 num : "+num);
        
        

    }

//     // Update is called once per frame
    void Update(){

        Debug.Log(num);
        if(num==2){
            스킵.interactable=true;
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
        }
        if(num==5){
            스킵.interactable=true;
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
        }
        if(num==8){
            스킵.interactable=true;
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
            //closet text 출력시작 
            
        }
        if(num==11){
            스킵.interactable=true;
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==14){
            스킵.interactable=true;
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==17){
            스킵.interactable=true;
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
        }
        if(num==20){
            //(5)organizer
            스킵.interactable=false;
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("activate_bed",2f);
        }
        if(num==23){
            스킵.interactable=true;
            StartCoroutine(coroutine8);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==26){
            스킵.interactable=true;
            StartCoroutine(coroutine9);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==29){
            스킵.interactable=true;
            StartCoroutine(coroutine10);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==32){
            스킵.interactable=true;
            StartCoroutine(coroutine11);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==35){
            스킵.interactable=true;
            StartCoroutine(coroutine12);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==38){
            스킵.interactable=true;
            StartCoroutine(coroutine13);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==41){
            스킵.interactable=true;
            StartCoroutine(coroutine14);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            
        }
        if(num==44){
            스킵.interactable=true;
            StartCoroutine(coroutine15);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("re",2f);
        }
        if(num==47){
            스킵.interactable=true;
            StartCoroutine(coroutine16);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            
        }
        if(num==50){
            스킵.interactable=true;
            StartCoroutine(coroutine17);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==53){
            스킵.interactable=true;
            StartCoroutine(coroutine18);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==56){
            스킵.interactable=true;
            StartCoroutine(coroutine19);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==59){
            스킵.interactable=true;
            StartCoroutine(coroutine20);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==62){
            스킵.interactable=true;
            StartCoroutine(coroutine21);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==65){
            스킵.interactable=true;
            StartCoroutine(coroutine22);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==68){
            스킵.interactable=true;
            StartCoroutine(coroutine23);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==71){
            스킵.interactable=true;
            StartCoroutine(coroutine24);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("activate_answers",1f);
        }
        if(num==74){
            스킵.interactable=true;
            StartCoroutine(coroutine25);
            Debug.Log("coroutine is started!  num"+num);
            num++;
        }
        if(num==77){
            스킵.interactable=true;
            StartCoroutine(coroutine26);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("nextscene",2f);
            
        }
        
        // if(num==32){
        //     스킵.interactable=false;
        //     inactivate();
        //     StartCoroutine(coroutine11);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        //     Invoke("activate",1.8f);
        // }
        // if(num==35){
        //     스킵.interactable=false;
        //     inactivate();
        //     StartCoroutine(coroutine12);
        //     Debug.Log("coroutine is started!  num"+num);
        //     num++;//activate button
        //     Invoke("activate",1.8f);
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
        //     SceneManager.LoadScene("4-2");
        //     num++;//activate button
        // }


    }
}
