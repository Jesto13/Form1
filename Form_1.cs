using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Form_1 : MonoBehaviour
{
    public Text _zayavnik;
    public Text _odynoki;
    public Text _prizvDytyny;
    public Text _imyaDytyny;
    public Text _pobatDytyny;
    public Text _datanarDytyny;
    public Text _seryatanomersvpronarDytyny;
    public Text _kymvydanosvpronarDytyny;
    public Text _nomeractzap;
    public Text _dataactzap;
    public Text _prizvMaty;
    public Text _imyaMaty;
    public Text _pobatMaty;
    public Text _datanarMaty;
    public Text _phoneMaty;
    public Text _postalindexMaty;
    public Text _oblMaty;
    public Text _rayonMaty;
    public Text _naspunktMaty;
    public Text _vulMaty;
    public Text _nomerbudMaty;
    public Text _nomercorpMaty;
    public Text _nomerkvMaty;
    public Text _passporttypeMaty;

    [SerializeField]
    // "form action" on inspect form
    private string LinkOnForms = "https://docs.google.com/forms/d/e/1FAIpQLSdfhza8L4J-cATRoLWigajpbVY7ODzMOB7huew8-LCci8-Gzg/viewform?usp=sf_link/formResponse";

    public void Send()
    {
            StartCoroutine(Post());
    }

    IEnumerator Post()
    {
        WWWForm form = new WWWForm();

        //Оберіть заявника:
        form.AddField("entry.1590567683", _zayavnik.text);
        //Одинокий Батько/Мати
        form.AddField("entry.1189733810", _odynoki.text);
        //Відомості про дитину
        //Прізвище:
        form.AddField("entry.521945452", _prizvDytyny.text);
        //Ім'я:
        form.AddField("entry.555882429", _imyaDytyny.text);
        //По батькові:
        form.AddField("entry.971610079", _pobatDytyny.text);
        //Дата народження:
        form.AddField("entry.1172236652", _datanarDytyny.text);
        //Серія та № свідоцтва про народження:
        form.AddField("entry.694421736", _seryatanomersvpronarDytyny.text);
        //Ким видано:
        form.AddField("entry.1100011491", _kymvydanosvpronarDytyny.text);
        //Номер актового запису:
        form.AddField("entry.1054669001", _nomeractzap.text);
        //Дата актового запису:
        form.AddField("entry.2102140203", _dataactzap.text);
        //Відомості про матір:
        //Прізвище:
        form.AddField("entry.119393056", _prizvMaty.text);
        //Ім'я:
        form.AddField("entry.1180440441", _imyaMaty.text);
        //По батькові :
        form.AddField("entry.935550710", _pobatMaty.text);
        //Дата народження:
        form.AddField("entry.940966112", _datanarMaty.text);
        //Контактний телефон:
        form.AddField("entry.606524153", _phoneMaty.text);
        //Адреса реєстрації
        //Поштовий індекс:
        form.AddField("entry.395578255", _postalindexMaty.text);
        //Область/м.Київ/м.Севастополь:
        form.AddField("entry.1532589028", _oblMaty.text);
        //Район/Місто/Район міста:
        form.AddField("entry.244721964", _rayonMaty.text);
        //Населений пункт/Район міста:
        form.AddField("entry.393514263", _naspunktMaty.text);
        //Вулиця:
        form.AddField("entry.610247008", _vulMaty.text);
        //Номер будинку:
        form.AddField("entry.1227863651", _nomerbudMaty.text);
        //Номер корпусу:
        form.AddField("entry.1921883645", _nomercorpMaty.text);
        //Номер квартири:
        form.AddField("entry.120870518", _nomerkvMaty.text);
        //Тип паспорту 
        form.AddField("entry.68925646", _passporttypeMaty.text);

        byte[] rawData = form.data;

        WWW www = new WWW(LinkOnForms, rawData);
        yield return www;

        if (String.IsNullOrEmpty(www.error))
        { // succes

            Debug.Log("Success");
        }
        else
        { // fail
            Debug.Log("Epic fail");
        }
    }
}
