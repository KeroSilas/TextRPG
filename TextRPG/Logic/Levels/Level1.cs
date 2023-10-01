﻿using TextRPG.Logic.Abstract;
using TextRPG.Model;
using TextRPG.Model.Abstract;
using TextRPG.Model.Enemies;

namespace TextRPG.Logic.Levels;

public class Level1 : Level
{
    public override void Start(ref PlayableCharacter player)
    {
        Character enemy = new Slime(player);
        InitiateBattle(ref player, ref enemy);
        
        enemy = new Goblin(player);
        InitiateBattle(ref player, ref enemy);
        
        enemy = new KingSlime(player);
        InitiateBattle(ref player, ref enemy);
        
        enemy = new Dragon(player);
        InitiateBattle(ref player, ref enemy);
    }
}