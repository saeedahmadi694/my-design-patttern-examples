using DesignPattern.sample.Patterns.Decorator.Abilities;

namespace DesignPattern.sample.Patterns.FlyWeight;

public class FlyweightUsage
{
    public void Run()
    {
        TreeFactory treeFactory = new();

        Tree tree1 = new Tree(treeFactory.GetFlyweight("Pine", "pine_texture", "pine_model"));
        tree1.Plant(10, 20, 5, 10, 100);

        Tree tree2 = new Tree(treeFactory.GetFlyweight("Oak", "oak_texture", "oak_model"));
        tree2.Plant(15, 30, 6, 15, 90);

        Tree tree3 = new Tree(treeFactory.GetFlyweight("Pine", "pine_texture", "pine_model"));
        tree3.Plant(25, 40, 5, 20, 85);

        tree1.Draw();
        tree2.Draw();
        tree3.Draw();
    }
}
