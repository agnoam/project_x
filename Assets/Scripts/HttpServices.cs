using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HttpServices {

    private const string serverURL = "http://example.server.com";
    
    
    // TODO: Add Google ads to win coins

    // Making http requests to checkout about coins
    public static async void exampleHttpPostReq() {
        string stringifiedJson = "{}";

        // Making async POST http request by unity package
        UnityWebRequest req = UnityWebRequest.Post($"{serverURL}/postExample", stringifiedJson);
        UnityWebRequestAsyncOperation operation = req.SendWebRequest();
        operation.completed += (AsyncOperation op) => {
            // Runs when the request done
        };
    }

    public static void exampleHttpGetReq() {
        // Making the POST http request by unity package
        UnityWebRequest req = UnityWebRequest.Get($"{serverURL}/getExample");
        UnityWebRequestAsyncOperation operation = req.SendWebRequest();
        operation.completed += (AsyncOperation op) => {
            // Runs when the request done
        };
    }
}
