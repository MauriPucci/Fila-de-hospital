using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QueueManager : MonoBehaviour
{
    private List<KeyValuePair<string, int>> characterQueue;

    public TextMeshProUGUI displayText;

    private void Start()
    {
        characterQueue = new List<KeyValuePair<string, int>>();

        characterQueue.Add(new KeyValuePair<string, int>("Alice", 1));
        characterQueue.Add(new KeyValuePair<string, int>("Bob", 3));
        characterQueue.Add(new KeyValuePair<string, int>("Charlie", 2));
        characterQueue.Add(new KeyValuePair<string, int>("Diana", 5));
        characterQueue.Add(new KeyValuePair<string, int>("Eve", 4));
        characterQueue.Add(new KeyValuePair<string, int>("Frank", 6));
        characterQueue.Add(new KeyValuePair<string, int>("Grace", 7));
        characterQueue.Add(new KeyValuePair<string, int>("Hank", 8));
        characterQueue.Add(new KeyValuePair<string, int>("Ivy", 9));
        characterQueue.Add(new KeyValuePair<string, int>("Jack", 10));
        characterQueue.Add(new KeyValuePair<string, int>("Kevin", 11));
        characterQueue.Add(new KeyValuePair<string, int>("Luna", 12));
        characterQueue.Add(new KeyValuePair<string, int>("Mia", 13));
        characterQueue.Add(new KeyValuePair<string, int>("Nina", 14));
        characterQueue.Add(new KeyValuePair<string, int>("Oscar", 15));
        characterQueue.Add(new KeyValuePair<string, int>("Paul", 16));
        characterQueue.Add(new KeyValuePair<string, int>("Quinn", 17));
        characterQueue.Add(new KeyValuePair<string, int>("Rose", 18));
        characterQueue.Add(new KeyValuePair<string, int>("Sam", 19));
        characterQueue.Add(new KeyValuePair<string, int>("Tina", 20));

        characterQueue.Sort((x, y) => x.Value.CompareTo(y.Value));

        StartCoroutine(ShowNames());
    }

    private IEnumerator ShowNames()
    {
        while (characterQueue.Count > 0)
        {
            var nextCharacter = characterQueue[0];
            characterQueue.RemoveAt(0);
            displayText.text = "Next: " + nextCharacter.Key;

            yield return new WaitForSeconds(2);
        }

        displayText.text = "Queue is empty!";
    }

}

