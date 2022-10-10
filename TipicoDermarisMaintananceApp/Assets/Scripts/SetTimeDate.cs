using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimeDate : MonoBehaviour
{
    Text date;
    Text time;

    public void SetTimeAndDate(string tmpdate, string tmptime)
    {
        time = GameObject.Find("time").GetComponent<Text>();
        date = GameObject.Find("Date").GetComponent<Text>();

        date.text = tmpdate;
        time.text = tmptime;

        print(date.text);
        print(time.text);
    }
}
