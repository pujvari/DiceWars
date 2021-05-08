using System;
using System.Collections.Generic;
using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public class Tile : ABase
    {
        public Tile(int tileNumber, TileType type = TileType.UnPlayable) : base()
        {
            Number = tileNumber;
            Dices = new List<Dice>();
        }

        private List<Dice> dices;
        public List<Dice> Dices
        {
            get
            {
                return dices;
            }
            set
            {
                if (value != dices)
                {
                    dices = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private APlayer owner;
        public APlayer Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (value != owner)
                {
                    owner = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value != number)
                {
                    number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private TileType type;
        public TileType Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value != type)
                {
                    type = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public bool isSelected;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                if (value != isSelected)
                {
                    isSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime selectedDate;
        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                if (value != selectedDate)
                {
                    selectedDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Row
        {
            get
            {
                return Number / 10;
            }
        }

        public int Column
        {
            get
            {
                return Number % 10;
            }
        }

        public void War(Tile defender)
        {
            int attackerValue = 0;
            Dices.ForEach(x => attackerValue += x.Roll());

            int defenderValue = 0;
            defender.Dices.ForEach(x => defenderValue += x.Roll());

            if (attackerValue > defenderValue)
            {
                defender.Owner = Owner;
                defender.Dices = Dices;
                defender.Dices.RemoveAt(1);
            }

            Dices = new List<Dice>() { new Dice() };
            IsSelected = false;
            defender.IsSelected = false;
        }

        public bool NextTo(Tile tile)
        {
            if (Row == tile.Row + 1 && Column == tile.Column)
                return true;
            if (Row == tile.Row - 1 && Column == tile.Column)
                return true;
            if (Column == tile.Column + 1 && Row == tile.Row)
                return true;
            if (Column == tile.Column - 1 && Row == tile.Row)
                return true;
            return false;
        }
    }
}
