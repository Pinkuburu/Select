using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Code : MonoBehaviour
{
    public Toggle Mode1;
    public Toggle Mode2;
    public Text Result;
    public float Acceleration;

    public float Timer;
    private float timer;


    //加速度相关的变量
    float old_y = 0.0f;
    float new_y = 0.0f;
    float result_y = 0.0f;


    // Use this for initialization
    void Start()
    {
        Result.text = "无";

        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        new_y = Input.acceleration.y;
        result_y = new_y - old_y;
        old_y = new_y;

        timer -= Time.deltaTime;

        if (Mode1.isOn)
        {
            if (Result.text == "正" && Result.text == "反")
            {
                Result.text = "无";
            }
            if (result_y > Acceleration&&timer<=0)
            {
                
                Handheld.Vibrate();//震动效果
                int ra1 = Random.Range(1, 100);
                Result.text = ra1.ToString();
                timer = Timer;

            }

        }
        else if (Mode2.isOn)
        {
            if (Result.text != "正" && Result.text != "反" && Result.text != "无")
            {
                Result.text = "无";
            }
            if (result_y > Acceleration && timer <= 0)
            {
                
                Handheld.Vibrate();//震动效果
                float ra1 = Random.Range(0, 2);

                Debug.Log(ra1);
                if (ra1 == 1)
                {
                    Result.text = "正";
                }
                if (ra1 == 0)

                {
                    Result.text = "反";
                }
                timer = Timer;
            }
        }
    }

}
