using DiceWars.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using static DiceWars.Models.Player.Enums;

namespace DiceWars.Models
{
    public abstract class APlayer : ABase
    {
        public APlayer(int playerNumber, PlayerType playerType) : base()
        {
            Number = playerNumber;
            Type = playerType;
            Color = ColorProvider.GetColor(playerNumber);
            TileProvider.IsSelectedChanged += TileSelectionChanged;
        }

        private void TileSelectionChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged(nameof(Tiles));
            NotifyPropertyChanged(nameof(DiceCount));
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

        private PlayerType type;
        public PlayerType Type
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

        private Brush color;
        public Brush Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != color)
                {
                    color = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public List<Tile> Tiles
        {
            get
            {
                return TileProvider.Tiles.Where(x => x.Owner == this).ToList();
            }
        }

        public int DiceCount
        {
            get
            {
                return Tiles.Sum(x => x.Dices.Count);
            }
        }

        public string Name
        {
            get
            {
                if (Type == PlayerType.Human)
                    return $"{Enum.GetName<PlayerType>(Type)}({Number})";
                else
                    return $"{Enum.GetName<AiType>((this as AAi).AiType)}({Number})";
            }
        }

        public abstract void Play();
    }
}
