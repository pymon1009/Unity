using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class AsyncTest : MonoBehaviour
{
    [SerializeField] Button m_button;
    [SerializeField] Text m_text1;
    [SerializeField] Text m_text2;
    public void Btn_AsyncTest()
    {
        run();
    }
    async void run()
    {
        /*        var task_ = Task.Run(() => waitAsync(3));

                int sum = await task_;*/

        var task1 = Task.Run(() => waitAsync1(3));
        var task2 = Task.Run(() => waitAsync2(5));

        int sum1 = await task1;
        int sum2 = await task2;

        m_text1.text = sum1.ToString();
        m_text2.text = sum2.ToString();
        m_button.enabled = true;
    }
    int waitAsync1(int time)
    {
        int result = 0;

        for(int i = 0; i < time; i++)
        {
            Debug.Log("testAsunc1 result : " + result.ToString());
            result += i;
            Thread.Sleep(1000);
            //m_text1.text = result.ToString();
        }

        return result;
    }

    int waitAsync2(int time)
    {
        int result = 0;

        for (int i = 0; i < time; i++)
        {
            Debug.Log("testAsunc2 result : " + result.ToString());
            result += i;
            Thread.Sleep(2000);
            //m_text2.text = result.ToString();
        }

        return result;
    }
}
