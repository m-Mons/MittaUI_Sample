using System;
using R3;
using UnityEngine.UI;

namespace MittaUI.Runtime.Extension
{
    public static class SliderExtensions
    {
        public static IDisposable SetOnValueChangedDestination(this Slider self, Action<float> onValueChanged)
        {
            return self.onValueChanged
                .AsObservable()
                .Subscribe(onValueChanged.Invoke)
                .AddTo(self);
        }
    }
}