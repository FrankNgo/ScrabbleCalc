using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RPS.Models
{
  public class Game
  {
    private string _player1;
    public int _results = 0;

    public Game (string player1)
    {
      _player1 = player1.ToLower();
    }

    public string GetPlayer1()
    {
      return _player1;
    }
    public void SetPlayer1(string player1)
    {
       _player1 = player1;
    }
    public int GetResult()
    {
      return _results;
    }

    public char[] SplitWord()
    {
      return _player1.ToCharArray();
    }

    public void GetWinner(string player1)
    {
      char [] _player1 = SplitWord();
      for(int i = 0; i < _player1.Length; i++)
      {
        if(_player1[i] =='a' || _player1[i] =='e'|| _player1[i] =='i' ||  _player1[i] =='o' || _player1[i] =='u'|| _player1[i] =='l' || _player1[i] =='n' || _player1[i] =='r'|| _player1[i] =='s' || _player1[i] =='t')
        {
          _results += 1;
        }
        else if(_player1[i] =='g' || _player1[i] =='d')
        {
          _results += 2;
        }
        else if(_player1[i] =='b' || _player1[i] =='c'|| _player1[i] =='m' ||  _player1[i] =='p')
        {
          _results += 3;
        }
        else if(_player1[i] =='f' || _player1[i] =='h'|| _player1[i] =='v' || _player1[i] =='w' || _player1[i] =='y')
        {
          _results += 4;
        }
        else if(_player1[i] =='k')
        {
          _results += 5;
        }
        else if(_player1[i] =='j' || _player1[i] =='x')
        {
          _results += 8;
        }
        else if(_player1[i] =='q' || _player1[i] =='z')
        {
          _results += 10;
        }
          else
        {
          _results += 0;
        }
      }
    }
  }
}
