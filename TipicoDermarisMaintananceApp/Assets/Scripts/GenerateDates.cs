using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateDates : MonoBehaviour
{
    [SerializeField] GameObject PrefabItem;
    SetTimeDate setTimeAndDate;
    private void Start()
    {
        for (int i = 0; i < 32; i++)
        {
            SetDates(i.ToString(), "xx:xx - XX:XX",1.10f*i);
        }
        

    }

    void SetDates(string date, string time, float offset)
    {
        GameObject prefab = Instantiate(PrefabItem, this.gameObject.transform );
        prefab.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y -offset, this.gameObject.transform.position.z);
        setTimeAndDate = prefab.GetComponent<SetTimeDate>();
        setTimeAndDate.SetTimeAndDate(date, time);
    }
}
