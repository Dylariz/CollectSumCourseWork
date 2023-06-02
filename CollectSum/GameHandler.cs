using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectSum
{
    public class GameHandler
    {
        public Player LeftPlayer { get; }
        public Player RightPlayer { get; }
        public bool IsLeftTurn { get; private set; }
        public int CurrentRound { get; private set; }
        public int MaxScore { get; }

        private int _countOfRounds;
        private Random _gameRandom;
        private int[] _defaultNumbersPool;
        private List<int> _numbersPool;

        public GameHandler(uint countOfRounds, uint countOfEqualNumbersInPool, uint maxScore)
        {
            LeftPlayer = new Player("Left Player");
            RightPlayer = new Player("Right Player");
            _gameRandom = new Random();

            _countOfRounds = (int)countOfRounds;
            MaxScore = (int)maxScore;
            CurrentRound = 0;

            _defaultNumbersPool = new int[10 * countOfEqualNumbersInPool];
            
            int currentNumber = 2;
            for (uint i = 0; i < _defaultNumbersPool.Length; i += countOfEqualNumbersInPool)
            {
                for (int j = 0; j < countOfEqualNumbersInPool; j++)
                {
                    _defaultNumbersPool[i + j] = currentNumber;
                }
                currentNumber++;
            }

            FillNumbersPool();
            
            IsLeftTurn = _gameRandom.Next(2) != 0;
        }
        
        /// <returns>false — игра кончилась</returns>
        public bool AddNumberToPlayer()
        {
            int number = _numbersPool.First();
            _numbersPool.Remove(number);

            if (IsLeftTurn)
            {
                LeftPlayer.AddNumber(number);

                if (LeftPlayer.RoundScore > MaxScore)
                {
                    // Следующий раунд
                    LeftPlayer.NextRound(true);
                    RightPlayer.NextRound(false);
                    FillNumbersPool();
                    
                    // Конец игры
                    if (_countOfRounds == ++CurrentRound)
                    {
                        CurrentRound--;
                        return false;
                    }
                }
            }
            else
            {
                RightPlayer.AddNumber(number);

                if (RightPlayer.RoundScore > MaxScore)
                {
                    // Следующий раунд
                    LeftPlayer.NextRound(false);
                    RightPlayer.NextRound(true);
                    FillNumbersPool();
                    
                    // Конец игры
                    if (_countOfRounds == ++CurrentRound)
                    {
                        CurrentRound--;
                        return false;
                    }
                }
            }
            
            // Смена хода
            if (!LeftPlayer.IsPassed && !RightPlayer.IsPassed)
            {
                IsLeftTurn = !IsLeftTurn;
            }
            return true;
        }
        
        /// <returns>false — игра кончилась</returns>
        public bool PassPlayer()
        {
            if (IsLeftTurn)
            {
                LeftPlayer.Pass();
            }
            else
            {
                RightPlayer.Pass();
            }
            
            if (LeftPlayer.IsPassed && RightPlayer.IsPassed) // Оба пропустили
            {
                // Следующий раунд
                LeftPlayer.NextRound(false);
                RightPlayer.NextRound(false);
                FillNumbersPool();
                
                // Конец игры
                if (_countOfRounds == ++CurrentRound)
                {
                    CurrentRound--;
                    return false;
                }
            }
            else // Один игрок пропустил
            {
                IsLeftTurn = !IsLeftTurn;
            }

            return true;
        }

        private void FillNumbersPool()
        {
            _numbersPool = _defaultNumbersPool.ToList();
            
            // Рандомное перемешивание _numbersPool
            for (int i = _numbersPool.Count - 1; i >= 1; i--)
            {
                int j = _gameRandom.Next(i + 1);
                (_numbersPool[i], _numbersPool[j]) = (_numbersPool[j], _numbersPool[i]);
            }
        }
    }
}