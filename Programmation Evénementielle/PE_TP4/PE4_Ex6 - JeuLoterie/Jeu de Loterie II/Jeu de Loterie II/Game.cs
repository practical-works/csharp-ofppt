using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JeuLoterie
{
    //========================================================================================
    // ● title
    //========================================================================================
    class Game
    {
        //========================================================================================
        // ● Attributs et Propriétés
        //========================================================================================
        private string player;
        private double wealth, bet;
        private int number;
        private int hits, wins, losses;
        private int score, singles, doubles, triples;
        private string result;
        TimeSpan time;
        private static int count = 0;
        //-----------------------------------------------------------------------------------------
        public string Player { get { return player; } set { player = value; } }
        public double Wealth { get { return wealth; } set { wealth = value; } }
        public double Bet { get { return bet; } set { bet = value; } }
        public int Number { get { return number; } set { number = value; } }
        public int Hits { get { return hits; } set { hits = value; } }
        public int Wins { get { return wins; } set { wins = value; } }
        public int Losses { get { return losses; } set { losses = value; } }
        public int Score { get { return score; } set { score = value; } }
        public int Singles { get { return singles; } set { singles = value; } }
        public int Doubles { get { return doubles; } set { doubles = value; } }
        public int Triples { get { return triples; } set { triples = value; } }
        public string Result { get { return result; } set { result = value; } }
        public TimeSpan Time { get { return time; } set { time = value; } }
        public static int Count { get { return count; } set { count = value; } }
        //========================================================================================
        // ● Constructeurs
        //========================================================================================
        public Game()
        {
            count++;
            this.player = "Joueur " + count;
            this.wealth = 300;
            this.bet = 100;
            this.number = 1;
            this.hits = 3;
            this.wins = this.losses = 0;
            this.score = this.singles = this.doubles = this.triples = 0;
            this.result = "Aucun";
            this.time = TimeSpan.Zero;
        }
        public Game(string player, double wealth, double bet, int number, int hits, int wins, int losses, 
            int score, int singles, int doubles, int triples, string result, TimeSpan time)
        {
            count++;
            this.player = player;
            this.wealth = wealth;
            this.bet = bet;
            this.number = number;
            this.hits = hits;
            this.wins = wins;
            this.losses = losses;
            this.score = score;
            this.singles = singles;
            this.doubles = doubles;
            this.triples = triples;
            this.result = result;
            this.time = time;
        }
        //========================================================================================
        // ● Méthodes
        //========================================================================================
    }
}
