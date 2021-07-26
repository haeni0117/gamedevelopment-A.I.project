using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text6_1_4 : MonoBehaviour
{// Start is called before the first frame update
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //static 변수로 수정
    public static bool bed_inspection = false;
    public static bool emergencypox_inspection = false;
    public static GameObject fadeout;
    //조사할 오브젝트
    public static GameObject bed;
    public static GameObject closet;
    public static GameObject restroom;
    public static GameObject makeup;
    public static GameObject drawer;
    

    public static Button bed_b;
    public static Button closet_b;
    public static Button restroom_b;
    public static Button makeup_b;
    public static Button drawer_b;
    // public static Button achoice_b;
    // public static Button bchoice_b;
    public static Button 스킵;

    public static Text bed_t;
    public static Text closet_t;
    public static Text restroom_t;
    public static Text makeup_t;
    public static Text drawer_t;
    // public static Text achoice_t;
    // public static Text bchoice_t;
    public static Text typingText;

    
    private static string text_1="침대를 오랫동안 사용하지 않아 \n먼지가 소복이 쌓였다.\n베개 틈 사이에 \n뭔가 있지만, 너무 작아서 \n확실히 구급상자는 아니다.\n사람 발처럼 \n생긴 것 같기도 하고....";
    private static string text_2="일단은 어서 \n구급상자를 찾아보자.";//구급상자찾은 경우 -> 밑줄친 문장은 뺴고 출력
    private static string text_3="옷장 안에는 옷걸이만 \n몇 개 걸려 있고 텅 비었다. \n이 집에 나 이외에 \n사람이 올 일이 없으니 \n당연한 일이지만, \n폐가를 뒤지는 기분이 들어 \n꺼림칙하다. ";
    private static string text_4="화장실에 들어가기 전에\n게스트룸을 좀 더 조사해 보자.";
    private static string text_5="화장대 위에는 아무것도 없다. \n서랍에는 뭐가 있으려나?";
    private static string text_6="놀랍게도 게스트룸 서랍장에서 \n구급상자를 발견했다! \n어쩌다가 이렇게 중요한 물품이 \n게스트룸 서랍장에 있는 거지?\n\n{구급상자를 얻었다}";
    private static string text_7="계속 시선이 \n침대로 향한다.";
   

    static IEnumerator coroutine1 =  Typing(text_1);
    static IEnumerator coroutine2 =  Typing(text_2);
    static IEnumerator coroutine3 =  Typing(text_3);
    static IEnumerator coroutine4 =  Typing(text_4);
    static IEnumerator coroutine5 =  Typing(text_5);
    static IEnumerator coroutine6 =  Typing(text_6);
    static IEnumerator coroutine7 =  Typing(text_7);

    
   

    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;

    }
    public void activate(){
        
        bed_b.interactable=true;
        closet_b.interactable=true;
        restroom_b.interactable=true;
        makeup_b.interactable=true;
        drawer_b.interactable=false;
        

        bed_t.text="(1) 침대";
        closet_t.text="(2) 옷장";
        restroom_t.text="(3) 게스트룸 화장실";
        makeup_t.text="(4) 화장대";
        // drawer_t.text=" "
        // another_t.text=" "       
    }
    public void inactivate(){
        
        bed_b.interactable=false;
        closet_b.interactable=false;
        restroom_b.interactable=false;
        makeup_b.interactable=false;
        drawer_b.interactable=false;
        

        bed_t.text=" ";
        closet_t.text=" ";
        restroom_t.text=" ";
        makeup_t.text=" ";
        drawer_t.text=" ";}

    public void click_bed(){
        스킵.interactable=false;
        if(bed_inspection==true){스킵.interactable=true;}
        
        else{num=2;스킵.interactable=false;}
    }
    public void click_closet(){
        스킵.interactable=false;
        num=8;
    }
    public void click_restroom(){
        스킵.interactable=false;
        num=11;
    }
    public void click_makeup(){
        num=14;
        스킵.interactable=false;
        Invoke("makeup_drawer_is_exposured",1.8f);
    
    }
    public void makeup_drawer_is_exposured(){
        drawer_b.interactable=true;
        drawer_t.text="(4)-1 화장대 서랍장";
    }
    

    public void click_drawer(){
        if(bed_inspection==true)
            {num=17;
             Invoke("click_drawer2",4f);
            //침대 조사 완료 후 구급상자를 얻으면 바로 다음으로 진행한다.
        }
        else{num=20;}
    }

    public void click_drawer2(){
        SceneManager.LoadScene("6-2");
        
    }
    

    // public void choiceAB_activate(){
    //     achoice_b.interactable=true;
    //     bchoice_b.interactable=true;
    //     achoice_t.text="A. 다른 곳을 둘러본다.";
    //     bchoice_t.text="B. 아니다. 더 찾아보자.";

    // }

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
    //button
    bed_b=GameObject.Find("bed").GetComponent<Button>();
    closet_b=GameObject.Find("closet").GetComponent<Button>();
    restroom_b=GameObject.Find("restroom").GetComponent<Button>();
    makeup_b=GameObject.Find("makeup").GetComponent<Button>();
    drawer_b=GameObject.Find("drawer").GetComponent<Button>();
    
    

    bed_t=GameObject.Find("bedtext").GetComponent<Text>();
    closet_t=GameObject.Find("closettext").GetComponent<Text>();
    restroom_t=GameObject.Find("restroomtext").GetComponent<Text>();
    makeup_t=GameObject.Find("makeuptext").GetComponent<Text>();
    drawer_t=GameObject.Find("drawertext").GetComponent<Text>();
    
    typingText=GameObject.Find("general text").GetComponent<Text>();


    //onclick -> function
    bed_b.onClick.AddListener(click_bed);
    closet_b.onClick.AddListener(click_closet);
    restroom_b.onClick.AddListener(click_restroom);
    makeup_b.onClick.AddListener(click_makeup);
    drawer_b.onClick.AddListener(click_drawer);
    

  }
    // Start is called before the first frame update
   void Start()
    {
       스킵 = GameObject.Find("skipButton").GetComponent<Button>();
       스킵.onClick.AddListener(text6_1_4.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
       스킵.interactable=false;

        bed_b.interactable=true;
        closet_b.interactable=true;
        restroom_b.interactable=true;
        makeup_b.interactable=true;
        drawer_b.interactable=false;

        
        bed_t.text="(1) 침대";
        closet_t.text="(2) 옷장";
        restroom_t.text="(3) 게스트룸 화장실";
        makeup_t.text="(4) 화장대";
        drawer_t.text=" ";
        Debug.Log("coroutin is started! #6-1-4-> 게스트룸 조사 num"+num);
        
        

    }

//     // Update is called once per frame
    void Update(){

        Debug.Log(num);
        if(num==2){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine1);
            num++;
            Invoke("activate",6f);
        }
        if(num==5){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine2);
            num++;
            Invoke("activate",1.6f);
            
        }
        if(num==8){
            스킵.interactable=false;
            inactivate();
            Debug.Log("coroutine is started!  num"+num);
            StartCoroutine(coroutine3);
            num++;
            Invoke("activate",5f);
            //closet text 출력시작 
            
        }
        //게스트룸화장실
        if(num==11){
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine4);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("activate",3f);
            
            
        }
        if(num==14){
            //(4)화장대조사
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine5);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            
        }
        
        if(num==17){
            //(4)sidetable
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine6);
            Debug.Log("coroutine is started!  num"+num);
            num++;//activate button
            drawer_b.interactable=true;
            
        }
        if(num==20){
            //(5)organizer
            스킵.interactable=false;
            inactivate();
            StartCoroutine(coroutine7);
            Debug.Log("coroutine is started!  num"+num);
            num++;
            Invoke("activate",1f);
        }
        
        
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
