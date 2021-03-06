﻿using System;
using System.Collections.ObjectModel;
using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Story : TreeBase
    {
        #region Champs
        /// <summary>
        /// ID de la story
        /// </summary>
        private int _ID;

        /// <summary>
        /// Description de la story
        /// </summary>
        private string _description;

        /// <summary>
        /// Tag "Not safe for work"
        /// </summary>
        private bool _nsfw;

        /// <summary>
        /// Tag PEGI
        /// </summary>
        private string _pegi;

        /// <summary>
        /// Chemin d'accés de l'image associé à la story
        /// </summary>
        private string _imagePath;

        /// <summary>
        /// Pseudo de l'auteur
        /// </summary>
        private string _author;

        /// <summary>
        /// Date de création de la story
        /// </summary>
        private DateTime _creationDate;

        /// <summary>
        /// Version de la story
        /// </summary>
        private int _version;
        #endregion

        #region Constructeur
        public Story() {
            this._name = "New story";
            this._uc = new StoryControl();
            this._collectionUC = new PathCollectionControl();
        }
        #endregion

        #region Accesseurs
        /// <summary>
        /// Tag "Not safe for work"
        /// </summary>
        public bool NSFW
        {
            get
            {
                return _nsfw;
            }
            set
            {
                this._nsfw = value;
                OnPropertyChanged("NSFW");
            }
        }

        /// <summary>
        /// Chemin d'accés de l'image associé à la story
        /// </summary>
        public string PEGI
        {
            get
            {
                return _pegi;
            }
            set
            {
                this._pegi = value;
                OnPropertyChanged("PEGI");
            }
        }

        /// <summary>
        /// Chemin d'accés de l'image associé à la story
        /// </summary>
        public string ImagePathStory
        {
            get
            {
                return _imagePath;
            }
            set
            {
                this._imagePath = value;
                OnPropertyChanged("ImagePathStory");
            }
        }

        /// <summary>
        /// Pseudo de l'auteur
        /// </summary>
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                this._author = value;
                OnPropertyChanged("Author");
            }
        }

        /// <summary>
        /// Description de la story
        /// </summary>
        public string DescriptionStory
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
                OnPropertyChanged("DescriptionStory");
            }
        }
        
        protected override void AddChild()
        {
            Path child = new Path();
            this._childrens.Add(child);

            child.IsSelected = true;
            IsExpanded = true;
        }

        #endregion
    }
}
