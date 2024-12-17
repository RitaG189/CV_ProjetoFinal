using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class AnalyticsManager : MonoBehaviour
{
    private async void Start()
    {
        // Initialize Unity Gaming Services
        await UnityServices.InitializeAsync();

    }
}