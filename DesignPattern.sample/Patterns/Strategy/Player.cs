using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.Strategy;

public class Player
{
    public IAttackStrategy _attackStrategy;
    public IDefenceStrategy _defenceStrategy;

    public Player(IDefenceStrategy defenceStrategy, IAttackStrategy attackStrategy)
    {
        _defenceStrategy = defenceStrategy;
        _attackStrategy = attackStrategy;
    }

    public void Attack()
    {
        _attackStrategy.Attack();
    }
    public void Defend()
    {
        _defenceStrategy.Defend();
    }
}
