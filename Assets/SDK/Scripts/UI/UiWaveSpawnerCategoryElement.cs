using System.Collections.Generic;
using UnityEngine;

namespace ThunderRoad
{
    public class UiWaveSpawnerCategoryElement : MonoBehaviour
    {

        [SerializeField] private new UIText name;
        [SerializeField] private UiWaveSpawnerWaveElement waveElement;
        public void SetCategory(UIWaveSpawner waveSpawner, string category, List<CatalogData> wavesData)
        {
        }

    }
}