using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.FlyWeight;
internal class TreeFactory
{
    private Dictionary<string, TreeFlyweight> _treePool = new Dictionary<string, TreeFlyweight>();

    public TreeFlyweight GetFlyweight(string species, string texture, string model)
    {
        string key = species + texture + model;
        if (!_treePool.ContainsKey(key))
        {
            _treePool[key] = new TreeFlyweight { Species = species, Texture = texture, Model = model };
        }
        return _treePool[key];
    }
}
