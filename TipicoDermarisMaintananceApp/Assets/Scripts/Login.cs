using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Security.Cryptography;

public class Login : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Text Username;
    [SerializeField] Text Password;
    [SerializeField] Text Errornotify;
    Database database = new Database();
    User LoginUser = new User("", "", null,null,null,null,null);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void LoginConfirmBtn()
    {
        string tmpUsername = Username.text;
        string tmpPassword = Password.text;

        if (string.IsNullOrWhiteSpace(tmpUsername) || string.IsNullOrWhiteSpace(tmpPassword))
        {
            Errornotify.gameObject.SetActive(true);
           
        }
        else
        {
            Errornotify.gameObject.SetActive(false);
            CheckLoginData(tmpUsername,tmpUsername);
            print("nej");
        }
           
    }

    void CheckLoginData(string tmpName, string tmpPW)
    {

        List<User> dbUser = database.GetList();

        
        LoginUser.Username = tmpName;
        LoginUser.Password = tmpPW;
        Hash128 hashname = Hash128.Parse(Username.text);
        tmpName = hashname.ToString();
        Hash128 hashpw = Hash128.Parse(Password.text);
        tmpPW = hashpw.ToString();

        foreach (var item in dbUser)
        {
            print(tmpName + "  input " + tmpPW);

            if(tmpName == item.Username && tmpPW == item.Password)
            {
                Panel.SetActive(false);
                print("test");
            }
        }
        
    }
    
}
