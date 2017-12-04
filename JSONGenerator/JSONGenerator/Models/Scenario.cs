using JSONGenerator.Controls;
using JSONGenerator.ViewModels;

namespace JSONGenerator.Models
{
    public class Scenario : TreeBase
    {
        #region Constructeur
        public Scenario()
        {
            this._name = "Scenarios";
            this._collectionUC = new StoryCollectionControl();
        }
        #endregion

        protected override void AddChild()
        {
            Story child = new Story();
            this._childrens.Add(child);

            child.IsSelected = true;
            IsExpanded = true;
        }
    }
}
