using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//#1-2 부재중전화

public class text_1_3: MonoBehaviour
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

    //basic component
    public static int num = 0;
    public static GameObject button_;
    public static int cnt = 0; //st atic 변수로 수정
    public static Text typingText;
    public static GameObject fadeout;


    //skip button
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num++;
    }
    //choice1activation






    //text수정완
    private static string text_1="어떤 사람은 차가운 파란색을 보면 \n심해가 떠올라 무섭다고 하지만, \n나는 늘 차가운 파란색만이 주는 \n고립감이 좋았다. \n그곳에서만큼은 \n어떤 불행도, 절망도 \n나를 따라오지 못할 것 같았다.";
    private static string text_2="디자이너는 공사가 끝날 때까지 \n화장실에 파란색 도기 타일을 쓰면 \n겨울에는 발이 시려서 \n화장실에는 얼씬도 하고 싶지 \n않을 거라고,\n나는 한 번도 화장실을 \n파란색 타일로 꾸민 것을 \n후회하지 않았다.";
    private static string text_3="나는 거울의 투명도를 \n50%로 낮추고 \n뿌연 안개 속을 걷듯 \n불투명한 거울을 바라보며 \n칫솔을 꺼내 들었다.";
    private static string text_4="\"그런데 카라, \n아까 내 생일 축하를 \n깜빡할 뻔했다는 건 \n무슨 소리야?\"";

    static IEnumerator coroutine =  Typing(text_1);
    static IEnumerator coroutine1 = Typing(text_2);
    static IEnumerator coroutine2 = Typing(text_3);
    static IEnumerator coroutine3 = Typing(text_4);




    // Start is called before the first frame update
    void Start()
    {
        Button 스킵 = GameObject.Find("skipButton").GetComponent<Button>();
        스킵.onClick.AddListener(text_1_3.스킵버튼클릭);//adlistner로 불러오려면 static void여야 한다.
        Debug.Log("scene1 is started "+num);
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
            StartCoroutine(coroutine2);
            num++;

        }
        if(num==8){
            StartCoroutine(coroutine3);
            num++;

        }
        if(num==11){
          SceneManager.LoadScene("1-4");
        }

}}
