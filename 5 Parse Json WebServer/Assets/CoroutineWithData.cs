using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoroutineWithData

{
    public Coroutine Coroutine { get; private set; }
    public object result;
    private IEnumerator target;
    public CoroutineWithData(MonoBehaviour owner, string url)
    {

        this.target = retrieve(url);
        this.Coroutine = owner.StartCoroutine(Run());
       
    }


    
    private IEnumerator Run()
    {
        while (target.MoveNext())
        {
            result = target.Current;
            yield return result;
        }
    }


 
    private IEnumerator retrieve(string url)
    {
        //todo data
        WWWForm form = new WWWForm();
        form.AddField("gid", "1");
        WWW www = new WWW(url,form);
        yield return www;
        if (System.String.IsNullOrEmpty(www.error))
        {

               yield return www.text;
            // var N = SimpleJSON.JSON.Parse(www.text + "");
        }
        else
        {
            yield return null;
        }
    }
}