using System.Collections;
using System.Collections.Generic;
using System.IO;
// using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class RestAPI : MonoBehaviour
{
    private string _url = "https://6425a4287ac292e3cf0680dd.mockapi.io/Players";
    public InputField _getData;
    public void GetData() => StartCoroutine(GetDataFromWeb());

    IEnumerator GetDataFromWeb()
    {
        using(UnityWebRequest request = UnityWebRequest.Get(_url))
        {
            yield return request.SendWebRequest();
            if(request.result == UnityWebRequest.Result.ConnectionError)
                Debug.Log(request.error);
            else
            {
                string json = request.downloadHandler.text;
                _getData.text = json;
            }
        }


    }
}
