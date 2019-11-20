using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        CoroutineWithData cd = new CoroutineWithData(this, "http://localhost/jmpf/map/php/webservice/player.load.all.php");
        yield return cd.Coroutine;

       var N = SimpleJSON.JSON.Parse(cd.result+"");
        Debug.Log(N);

        if (N==null) {
            Debug.Log("");
            yield return null;
        }

        if (N[0]["uid"] == null) {  print("NULL");yield return null; }
       Debug.Log("uid " + N[0]["uid"]);  //  'success' or 'fail'
  
    }
     
    // Update is called once per frame
    IEnumerator players()
    {
        CoroutineWithData cd = new CoroutineWithData(this, "http://localhost/jmpf/map/php/webservice/player.load.all.php");
        yield return cd.Coroutine;
      //  Debug.Log("result is " + cd.result);  //  'success' or 'fail'
        var N = SimpleJSON.JSON.Parse(cd.result + "");
  
    }


     
}
