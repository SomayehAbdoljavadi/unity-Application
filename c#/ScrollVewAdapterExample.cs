using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;

public class ScrollVewAdapterExample : MonoBehaviour {
    public Texture2D[] availableIcon;
    public RectTransform perfab;
    public Text CountText;
    public ScrollRect scrollview;
    public RectTransform content;

    // Use this for initialization
    void Start() {

    }
    
    public void UpdateItem()
    {
        int newCount;
        int.TryParse(CountText.text, out newCount);
        StartCoroutine(FetchItemModelsFromServer(newCount, results => OnReceivedNewModels(results)));
    }
    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }
    void OnReceivedNewModels(ExampleItemModel[] models)
    {

    }

    
    IEnumerable FetchItemModelsFromServer(int count, Action<ExampleItemModel[]> onDone)
    {
        yield return new WaitForSeconds(2f);

        var results = new ExampleItemModel[count];
        for(int i=0; i<count; ++i)
        {
            results[i] = new ExampleItemModel();
            results[i].title = "Item " + i;
            results[i].iconIndex = UnityEngine.Random.Range(0, availableIcon.Length);
            results[i].icon2Index = UnityEngine.Random.Range(0, availableIcon.Length);
            results[i].icon3Index = UnityEngine.Random.Range(0, availableIcon.Length);
        }

        onDone(results);
    }

    public class ExampleItemModel
    {
        public string title;
        public int iconIndex, icon2Index, icon3Index;
    }
}
