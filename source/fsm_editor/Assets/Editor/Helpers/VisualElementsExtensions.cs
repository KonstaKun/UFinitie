using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class VisualElementsExtensions
{
    public static TVisualElement AddTo<TVisualElement>(this TVisualElement self, VisualElement parent)
        where TVisualElement : VisualElement
    {
        parent.Add(self);
        return self;
    }
}
