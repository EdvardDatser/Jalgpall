﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    public class Game
    {
        public Team HomeTeam { get; } //Команда местных
        public Team AwayTeam { get; } // Команда приезжих
        public Stadium Stadium { get; } //Стадион
        public Ball Ball { get; private set; } // Мяч
        // Конструктор 
        public Game(Team homeTeam, Team awayTeam, Stadium stadium) // Создание обьекта Game, 
        {
            HomeTeam = homeTeam;
            homeTeam.Game = this; // присваивание значений
            AwayTeam = awayTeam;
            awayTeam.Game = this;
            Stadium = stadium;
        }

        public void Start() // Начало игры, мяч по центру, поле делиться по пополам по вертикале 
        {
            Ball = new Ball(Stadium.Width / 2, Stadium.Height / 2, this);
            HomeTeam.StartGame(Stadium.Width / 2, Stadium.Height);
            AwayTeam.StartGame(Stadium.Width / 2, Stadium.Height);
        }
        private (double, double) GetPositionForAwayTeam(double x, double y) // Определение координат для команды гостей
        {
            return (Stadium.Width - x, Stadium.Height - y);
        }

        public (double, double) GetPositionForTeam(Team team, double x, double y) // Определение команд. Распределение команд
        {
            return team == HomeTeam ? (x, y) : GetPositionForAwayTeam(x, y);
        }

        public (double, double) GetBallPositionForTeam(Team team) //
        {
            return GetPositionForTeam(team, Ball.X, Ball.Y);
        }

        public void SetBallSpeedForTeam(Team team, double vx, double vy)
        {
            if (team == HomeTeam)
            {
                Ball.SetSpeed(vx, vy);
            }
            else
            {
                Ball.SetSpeed(-vx, -vy);
            }
        }

        public void Move()// Двигаемся, просто двигаемся
        {
            HomeTeam.Move();
            AwayTeam.Move();
            Ball.Move();
        }
    }
}
