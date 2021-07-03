using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text2_4 : MonoBehaviour
{
    private static int num=0;

    //스킵버튼
    public static void 스킵버튼클릭(){
        Debug.Log("skipbutton is clicked! num="+num);
        num+=1;
    }


    static IEnumerator Typing(string message)
    {
        Text typingText = GameObject.Find("general text").GetComponent<Text>();


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

    private static string text_1="찾을 만한 곳은 \n다 찾아본 것 같다. \n여전히 스페어 키는 보이지 않고, \n드라이버도 보이지 않는다. \n이제 어떻게 할까? ";
    private static string text_철제자="{철제 자를 사용했다.} \n자의 폭이 알아서 나사에 꼭 들어맞는다. \n나사가 모두 풀렸다.";




    static IEnumerator coroutine =  Typing(text_1);
    // static IEnumerator coroutine1 = Typing(text_2);
    // static IEnumerator coroutine2 = Typing(text_3);

    // static IEnumerator coroutine3 = Typing0(옷장text);
    // static IEnumerator coroutine4 = Typing0(수납대text);
    // static IEnumerator coroutine5 = Typing0(쓰레기통text);
    // static IEnumerator coroutine6 = Typing0(가방걸이text);
    // Start is called before the first frame update
    void Start()
    {
        Text typingText = GameObject.Find("general text").GetComponent<Text>();

        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
