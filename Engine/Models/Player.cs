﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotification
    {
        //add backing variables for each property in the Player class so that the setter can store the new value
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name 
        { get { return _name; } 
          set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            } 
        }

        public string CharacterClass 
        { get { return _characterClass; }
          set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            } 
        }

        public int HitPoints 
        { get { return _hitPoints; }
            set {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }

        public int ExperiencePoints
        { get { return _experiencePoints; } //Get the current value of the experience points
          set { 
                _experiencePoints = value;  //Set the new value of the experience points
                OnPropertyChanged(nameof(ExperiencePoints)); // Raise the PropertyChanged event
             } 
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }
        //automatically notifies the UI when objects are added to it, or removed from it
        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

    }
}
