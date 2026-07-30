using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Events;

public class EventsClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "EventsClass4";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"EventsClass4: {Count}";
    }
}
