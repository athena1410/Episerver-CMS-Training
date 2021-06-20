using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

namespace AlloyTraining.Business.SelectionFactories
{
    public class ThemeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem
            {
                Value = "OrangeTheme", Text = "Orange"
            };

            yield return new SelectItem
            {
                Value = "PurpleTheme", Text = "Purple"
            };

            yield return new SelectItem
            {
                Value = "GreenTheme", Text = "Green"
            };
        }
    }
}