using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Database : MonoBehaviour
{
    List<User> LIUser = new List<User>();
    void generateUser() 
    {
        string name;
        string pw;

        Hash128 hash = Hash128.Parse("Stefanos");
        name = hash.ToString();
        hash = Hash128.Parse("testhashing1234!*");
        pw = hash.ToString();
        LIUser.Add(new User(name, pw,null,null,null,null,null));
    }
    public List<User> GetList()
    {
        generateUser();
        return LIUser;
    }
}

class User
{
    string username;
    string password;
    string nickname;
    string address;
    string age;
    string contract_fee;

    Schedule workschedule;

    public User(string username, string password, string nickname, string address, string age, string contract_fee, Schedule workschedule)
    {
        this.username = username;
        this.password = password;
        this.nickname = nickname;
        this.address = address;
        this.age = age;
        this.contract_fee = contract_fee;
        this.workschedule = workschedule;
    }

    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public string Nickname { get => nickname; set => nickname = value; }
    public string Address { get => address; set => address = value; }
    public string Age { get => age; set => age = value; }
    public string Contract_fee { get => contract_fee; set => contract_fee = value; }
    internal Schedule Workschedule { get => workschedule; set => workschedule = value; }
}

class Schedule
{
    List<Workday> plan;
}

class Workday
{
    workdays workdays;
    DateTime start;
    DateTime end;
    float time;
}


enum workdays
{
    monday, tuesday, wednesday, thursday, friday, saturday, sunday
}


